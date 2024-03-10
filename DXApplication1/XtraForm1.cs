using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RandomNumberGenerator
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
        public Form2()
        {
            InitializeComponent();
            ShowResult();
        }
        public void ShowResult()
        {
            if (Form1.Numbers == 1)
            {
                Show_Label_1_1.Text = Form1.Random_1_1.ToString();
                Show_Label_2_1.Text = " ";
                Show_Label_3_1.Text = " ";
                Show_Label_4_1.Text = " ";
                Show_Label_5_1.Text = " ";
                Show_Label_1_2.Text = " ";
                Show_Label_2_2.Text = " ";
                Show_Label_3_2.Text = " ";
                Show_Label_4_2.Text = " ";
            }
            else if (Form1.Numbers == 2)
            {
                Show_Label_1_1.Text = " ";
                Show_Label_2_1.Text = " ";
                Show_Label_3_1.Text = " ";
                Show_Label_4_1.Text = " ";
                Show_Label_5_1.Text = " ";
                Show_Label_1_2.Text = Form1.Random_1_2.ToString();
                Show_Label_2_2.Text = Form1.Random_2_2.ToString();
                Show_Label_3_2.Text = " ";
                Show_Label_4_2.Text = " ";
            }
            else if (Form1.Numbers == 3)
            {
                Show_Label_1_1.Text = Form1.Random_1_1.ToString();
                Show_Label_2_1.Text = Form1.Random_2_1.ToString();
                Show_Label_3_1.Text = Form1.Random_3_1.ToString();
                Show_Label_4_1.Text = " ";
                Show_Label_5_1.Text = " ";
                Show_Label_1_2.Text = " ";
                Show_Label_2_2.Text = " ";
                Show_Label_3_2.Text = " ";
                Show_Label_4_2.Text = " ";
            }
            else if (Form1.Numbers == 4)
            {
                Show_Label_1_1.Text = " ";
                Show_Label_2_1.Text = " ";
                Show_Label_3_1.Text = " ";
                Show_Label_4_1.Text = " ";
                Show_Label_5_1.Text = " ";
                Show_Label_1_2.Text = Form1.Random_1_2.ToString();
                Show_Label_2_2.Text = Form1.Random_2_2.ToString();
                Show_Label_3_2.Text = Form1.Random_3_2.ToString();
                Show_Label_4_2.Text = Form1.Random_4_2.ToString();
            }
            else if (Form1.Numbers == 5)
            {
                Show_Label_1_1.Text = Form1.Random_1_1.ToString();
                Show_Label_2_1.Text = Form1.Random_2_1.ToString();
                Show_Label_3_1.Text = Form1.Random_3_1.ToString();
                Show_Label_4_1.Text = Form1.Random_4_1.ToString();
                Show_Label_5_1.Text = Form1.Random_5_1.ToString();
                Show_Label_1_2.Text = " ";
                Show_Label_2_2.Text = " ";
                Show_Label_3_2.Text = " ";
                Show_Label_4_2.Text = " ";
            }
        }

        private void Button_OK_Finish_Click(object sender, EventArgs e)
        {

            

        }

        private void White()
        {
            //添加白名单
            if (Form1.Numbers == 1)
            {
                Form1.sum = Form1.sum + 1;
                Form1.white[Form1.sum - 1] = Form1.Random_1_1;
            }
            else if (Form1.Numbers == 2)
            {
                Form1.sum = Form1.sum + 2;
                Form1.white[Form1.sum - 2] = Form1.Random_1_2;
                Form1.white[Form1.sum - 1] = Form1.Random_2_2;
            }
            else if (Form1.Numbers == 3)
            {
                Form1.sum = Form1.sum + 3;
                Form1.white[Form1.sum - 3] = Form1.Random_1_1;
                Form1.white[Form1.sum - 2] = Form1.Random_2_1;
                Form1.white[Form1.sum - 1] = Form1.Random_3_1;
            }
            else if (Form1.Numbers == 4)
            {
                Form1.sum = Form1.sum + 4;
                Form1.white[Form1.sum - 4] = Form1.Random_1_2;
                Form1.white[Form1.sum - 3] = Form1.Random_2_2;
                Form1.white[Form1.sum - 2] = Form1.Random_3_2;
                Form1.white[Form1.sum - 1] = Form1.Random_4_2;
            }
            else if (Form1.Numbers == 5)
            {
                Form1.sum = Form1.sum + 5;
                Form1.white[Form1.sum - 5] = Form1.Random_1_1;
                Form1.white[Form1.sum - 4] = Form1.Random_2_1;
                Form1.white[Form1.sum - 3] = Form1.Random_3_1;
                Form1.white[Form1.sum - 2] = Form1.Random_4_1;
                Form1.white[Form1.sum - 1] = Form1.Random_5_1;
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void White_Button_Click(object sender, EventArgs e)
        {

        }

        private void White_Button_Click_2(object sender, EventArgs e)
        {
           
        }

        private void White_Button_Click_1(object sender, EventArgs e)
        {
            White_Button.Enabled = false;
            White();
        }

        private void Button_OK_Finish_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
