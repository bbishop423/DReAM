﻿namespace DReAM
{
    partial class Compile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.close_btn = new System.Windows.Forms.Label();
            this.minimize_btn = new System.Windows.Forms.Label();
            this.window_lbl = new System.Windows.Forms.Label();
            this.input_btn = new System.Windows.Forms.Button();
            this.output_btn = new System.Windows.Forms.Button();
            this.compile_btn = new System.Windows.Forms.Button();
            this.input_txt = new System.Windows.Forms.TextBox();
            this.output_txt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(640, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(22, 24);
            this.close_btn.TabIndex = 3;
            this.close_btn.Text = "x";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // minimize_btn
            // 
            this.minimize_btn.AutoSize = true;
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize_btn.ForeColor = System.Drawing.Color.White;
            this.minimize_btn.Location = new System.Drawing.Point(612, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(22, 24);
            this.minimize_btn.TabIndex = 2;
            this.minimize_btn.Text = "-";
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // window_lbl
            // 
            this.window_lbl.Location = new System.Drawing.Point(12, 9);
            this.window_lbl.Name = "window_lbl";
            this.window_lbl.Size = new System.Drawing.Size(108, 29);
            this.window_lbl.TabIndex = 7;
            this.window_lbl.Text = "Compile";
            // 
            // input_btn
            // 
            this.input_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.input_btn.Location = new System.Drawing.Point(33, 96);
            this.input_btn.Name = "input_btn";
            this.input_btn.Size = new System.Drawing.Size(132, 61);
            this.input_btn.TabIndex = 8;
            this.input_btn.Text = "Open File";
            this.input_btn.UseVisualStyleBackColor = false;
            this.input_btn.Click += new System.EventHandler(this.input_btn_Click);
            // 
            // output_btn
            // 
            this.output_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.output_btn.Location = new System.Drawing.Point(33, 202);
            this.output_btn.Name = "output_btn";
            this.output_btn.Size = new System.Drawing.Size(132, 61);
            this.output_btn.TabIndex = 9;
            this.output_btn.Text = "Output File";
            this.output_btn.UseVisualStyleBackColor = false;
            this.output_btn.Click += new System.EventHandler(this.output_btn_Click);
            // 
            // compile_btn
            // 
            this.compile_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.compile_btn.Location = new System.Drawing.Point(268, 303);
            this.compile_btn.Name = "compile_btn";
            this.compile_btn.Size = new System.Drawing.Size(135, 49);
            this.compile_btn.TabIndex = 10;
            this.compile_btn.Text = "Compile";
            this.compile_btn.UseVisualStyleBackColor = false;
            this.compile_btn.Click += new System.EventHandler(this.compile_btn_Click);
            // 
            // input_txt
            // 
            this.input_txt.Location = new System.Drawing.Point(191, 111);
            this.input_txt.Name = "input_txt";
            this.input_txt.Size = new System.Drawing.Size(443, 32);
            this.input_txt.TabIndex = 11;
            // 
            // output_txt
            // 
            this.output_txt.Location = new System.Drawing.Point(191, 217);
            this.output_txt.Name = "output_txt";
            this.output_txt.Size = new System.Drawing.Size(443, 32);
            this.output_txt.TabIndex = 12;
            // 
            // Compile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(662, 375);
            this.Controls.Add(this.output_txt);
            this.Controls.Add(this.input_txt);
            this.Controls.Add(this.compile_btn);
            this.Controls.Add(this.output_btn);
            this.Controls.Add(this.input_btn);
            this.Controls.Add(this.window_lbl);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.minimize_btn);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Compile";
            this.Opacity = 0.9D;
            this.Text = "Compile";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Compile_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Compile_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Compile_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.Label minimize_btn;
        private System.Windows.Forms.Label window_lbl;
        private System.Windows.Forms.Button input_btn;
        private System.Windows.Forms.Button output_btn;
        private System.Windows.Forms.Button compile_btn;
        private System.Windows.Forms.TextBox input_txt;
        private System.Windows.Forms.TextBox output_txt;
    }
}