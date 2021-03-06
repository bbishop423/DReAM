﻿using System;
using System.Windows.Forms;

namespace DReAM
{
    public partial class Contact : Form
    {
        private bool drag = false;
        private int mousex = 0;
        private int mousey = 0;

        public Contact()
        {
            InitializeComponent();
        }

        private void Communicate_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                this.Top = Cursor.Position.Y - mousey;
                this.Left = Cursor.Position.X - mousex;
            }
        }

        private void Communicate_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - this.Left;
            mousey = Cursor.Position.Y - this.Top;
        }

        private void Communicate_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void website_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.juliar.org");
        }

        private void documentation_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.juliar.org/documentation");
        }

        private void twitter_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/juliarLang");
        }

        private void email_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:admin@juliar.org?subject=DReaM");
        }
    }
}
