﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.IO;
using DreamCompiler;
using System.Linq.Expressions;
using System.Reflection;


namespace DreamUnitTest
{
    
    [TestClass]
    public class CompilerUnitTest
    {
        [TestMethod]
        public void TestCommpile()
        {
            try
            {
                if (File.Exists(@"..\..\..\..\examples\test.jlr"))
                {

                    MemoryStream memoryStream = null;

                    using (var stream = new FileStream(@"..\..\..\..\examples\test.jlr", FileMode.Open))
                    {
                        var byteArray = new byte[stream.Length];
                        stream.Read(byteArray, 0, (int)stream.Length);
                        memoryStream = new MemoryStream(byteArray);
                        var compiler = new Compiler();
                        compiler.Go(memoryStream);

                    }
                }
                /*
                using (MemoryStream memStream = new MemoryStream((int) file.Length))
                {
                    memStream.Write(file, 0, file.Length);
                    var compiler = new Compiler();
                    compiler.Go(memStream);
                }
                */


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [TestMethod]
        public void TestExpressions()
        {
            string[,] gradeArray =
                {{"chemistry", "history", "mathematics"}, {"78", "61", "82"}};

            Expression arrayExpression = Expression.Constant(gradeArray);

            MethodCallExpression methodCall = Expression.ArrayIndex(arrayExpression, Expression.Constant(0), Expression.Constant(3));

            try
            {
                var theLambda = Expression.Lambda(methodCall).Compile().DynamicInvoke();
            }
            catch (Exception exception)
            {
                Trace.WriteLine(exception.Message);
                throw;
            }


            BinaryExpression binary = Expression.MakeBinary(
                ExpressionType.Subtract,
                Expression.Constant(54),
                Expression.Constant(14));

            BinaryExpression binary1 = Expression.MakeBinary(
                ExpressionType.Subtract,
                Expression.Constant(Convert.ToInt32("45")),
                Expression.Constant(14));

            Expression[] expressions = new Expression[]
            {
                methodCall,
                binary,
                binary1
            };

            BlockExpression block = Expression.Block(expressions);

            foreach (Expression ex in block.Expressions)
            {
                Trace.WriteLine(ex.ToString());
                Trace.WriteLine(ex.Reduce().ToString());

                Trace.WriteLine(Expression.Lambda(ex).Compile().DynamicInvoke());
            }

        }

        public static String foo( string s )
        {
            Trace.WriteLine("this is the foo method");
            return s;
        }
        

        [TestMethod]
        public void TestBlock()
        {
            ParameterExpression value = Expression.Parameter(typeof(int), "value");
            ParameterExpression result = Expression.Parameter(typeof(int), "result");


            Func<string, string> action = (s) =>
            {
                BlockExpression writeHelloBlockExpression = Expression.Block(
                    Expression.Call(null,
                        typeof(Trace).GetMethod("WriteLine", new Type[] {typeof(String)}) ??
                        throw new InvalidOperationException(),
                        Expression.Constant("0s")
                    ));

               return String.Empty;
            };
  
            /*
            

            Expression<Func<string, string>> exp = (s) => action(s);
          
            
            var methodCallExpression = Expression.Call(exp, action.Method, Expression.Parameter(typeof(string),"foo"));

            Expression callExpr = Expression.Call(
                Expression.Constant("sample string"), typeof(String).GetMethod("ToUpper", new Type[] { }));
            
            // Print out the expression.
            Trace.WriteLine(callExpr.ToString());

            // The following statement first creates an expression tree,
            // then compiles it, and then executes it.  
            Trace.WriteLine(Expression.Lambda<Func<String>>(callExpr).Compile()());
            */

            var actionType = action.GetType();


            LabelTarget label = Expression.Label(typeof(int));
            var lableExpression = Expression.Break(label, result);
            var greaterThanExpression = Expression.GreaterThan(value, Expression.Constant(1));
            var postDecrementExpression = Expression.PostDecrementAssign(value);
            var multiplyExpression = Expression.MultiplyAssign(result, postDecrementExpression);


            var callMethodExpression = Expression.Call(null,
                typeof(Trace).GetMethod("WriteLine", new Type[] { typeof(String) }) ?? throw new InvalidOperationException(),
                Expression.Constant("World!")
            );

            var tempBlock = Expression.Block(multiplyExpression, callMethodExpression);//, callWrite);
            var ifThanElseExpression = Expression.IfThenElse(greaterThanExpression, tempBlock, lableExpression);
            BlockExpression block = Expression.Block(
                new[] { result },
                Expression.Assign(result, Expression.Constant(1)),
                Expression.Loop(ifThanElseExpression, label)
            );

            int factorial = Expression.Lambda<Func<int, int>>(block, value).Compile()(5);
                

            if (factorial != 120)
            {
                throw new Exception("");
            }

            Console.WriteLine(factorial);
        }

        public static MethodInfo GetMethodInfo(Expression<Action> expression)
        {
            return GetMethodInfo((LambdaExpression)expression);
        }

        /// <summary>
        /// Given a lambda expression that calls a method, returns the method info.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        public static MethodInfo GetMethodInfo<T>(Expression<Action<T>> expression)
        {
            return GetMethodInfo((LambdaExpression)expression);
        }

        /// <summary>
        /// Given a lambda expression that calls a method, returns the method info.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        public static MethodInfo GetMethodInfo<T, TResult>(Expression<Func<T, TResult>> expression)
        {
            return GetMethodInfo((LambdaExpression)expression);
        }

        /// <summary>
        /// Given a lambda expression that calls a method, returns the method info.
        /// </summary>
        /// <param name="expression">The expression.</param>
        /// <returns></returns>
        public static MethodInfo GetMethodInfo(LambdaExpression expression)
        {
            MethodCallExpression outermostExpression = expression.Body as MethodCallExpression;

            if (outermostExpression == null)
            {
                throw new ArgumentException("Invalid Expression. Expression should consist of a Method call only.");
            }

            return outermostExpression.Method;
        }
    }
}
