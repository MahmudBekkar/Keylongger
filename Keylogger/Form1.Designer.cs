using System;
using System.Drawing;
using System.Windows.Forms;

namespace Keylogger
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            SuspendLayout();

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            FormBorderStyle = FormBorderStyle.Sizable;
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = true;
            Text = "Form1";
            Load += Form1_Load;

            ResumeLayout(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}