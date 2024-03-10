﻿using System;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class lucky : DevExpress.XtraEditors.XtraForm
    {
        public lucky()
        {
            InitializeComponent();
        }

        private void Button_OK_3_Click(object sender, EventArgs e)
        {
            bool y = true;
            if (Convert.ToInt32(textBox1.Text) < Form1.MinNumber || Convert.ToInt32(textBox1.Text) > Form1.MaxNumber)
            {
                XtraForm4 form4 = new XtraForm4();
                form4.Show();
                Close();
            }
            else
            {
                for (int i = 0; i < Form1.blacksum; i++)
                {
                    if (textBox1.Text == Form1.blacknum[i].ToString())
                    {
                        y = false;
                        Form7 form7 = new Form7();
                        form7.Show();
                    }

                }
                if (y)
                {
                    Form1.blacksum = Form1.blacksum + 1;
                    int.TryParse(textBox1.Text, out Form1.blacknum[Form1.blacksum - 1]);
                    Close();
                }
            }
            


        }
        private void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void black_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}