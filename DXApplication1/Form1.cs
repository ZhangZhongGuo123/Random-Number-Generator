using DevExpress.XtraEditors;
using System;
using System.IO;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
            Home.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            Settings.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            WhiteList.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            his.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
        }
        private void tileBar_SelectedItemChanged2(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
            Settings.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            Home.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            WhiteList.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            his.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
        }
        private void tileBar_SelectedItemChanged3(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
            WhiteList.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            Home.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            Settings.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            his.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
        }
        private void tileBar_SelectedItemChanged4(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
            his.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            Home.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            Settings.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            WhiteList.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
        }

        private void HomePage_Click(object sender, EventArgs e)
        {

        }
        System.Random random = new System.Random();
        public static int Random_1_1;
        public static int Random_2_1;
        public static int Random_3_1;
        public static int Random_4_1;
        public static int Random_5_1;
        public static int Random_1_2;
        public static int Random_2_2;
        public static int Random_3_2;
        public static int Random_4_2;
        public static int MinNumber = 1;
        public static int MaxNumber = 55;
        public static int sum;
        public static int blacksum = 0;
        public static int[] white = new int[100];
        public static int[] blacknum = new int[100];
        public static int Numbers = 1;
        public static bool j = false;
        public static bool magic = false;
        public static bool readlist = false;
        public static bool i = false;
        public static bool writelist = false;
        public static int ms = 50;
        public void readtxt(bool flag)
        {
            if (flag)
            {
                string path = "LuckyList.txt";
                string[] a = File.ReadAllLines(path);
                for (int i = 0; i < a.Length; i++)
                {
                    if (int.Parse(a[i]) != 0 && a[i] != null)
                    {
                        blacksum++;
                    }
                    for (int j = 0; j < blacknum.Length; j++)
                    {
                        if (blacknum[j] == int.Parse(a[i]))
                        {
                            goto Failed;
                        }
                    }
                    blacknum[i] = int.Parse(a[i]);
                Failed:;
                }
                string path1 = "WhiteList.txt";
                string[] a1 = File.ReadAllLines(path1);
                for (int j = 0; j < a1.Length; j++)
                {
                    for (int i = 0; i < white.Length; i++)
                    {
                        if (int.Parse(a1[j]) == white[i])
                        {
                            goto Fail;
                        }
                    }
                    white[j] = int.Parse(a1[j]);
                    sum++;
                Fail:;
                }
                Read.Enabled = false;
            }
            else
            {

            }
        }
        public void lucky()
        {
            if (blacknum[0] != 0)
            {
                if (blacknum[blacksum - 1] >= MinNumber && blacknum[blacksum - 1] <= MaxNumber)
                {
                    if (blacknum[blacksum - 1] >= 1 && blacknum[blacksum - 1] <= 99)
                    {
                        if (Numbers == 1 || Numbers == 3 || Numbers == 5)
                        {
                            Random_1_1 = blacknum[blacksum - 1];
                            Label_1_1.Text = blacknum[blacksum - 1].ToString();
                            blacksum += 1;
                        }
                        else
                        {
                            Random_1_2 = blacknum[blacksum - 1];
                            Label_2_1.Text = blacknum[blacksum - 1].ToString();
                            blacksum += 1;
                        }
                    }

                }
            }

            else
            {
            }

        }
        public void Start()
        {
            //while (!i)
            //{
            if (Numbers == 1)
            {
                Label_2_1.Text = " ";
                Label_3_1.Text = " ";
                Label_4_1.Text = " ";
                Label_5_1.Text = " ";
                Label_1_2.Text = " ";
                Label_2_2.Text = " ";
                Label_3_2.Text = " ";
                Label_4_2.Text = " ";
            a1:
                Random_1_1 = random.Next(MinNumber, MaxNumber + 1);

                for (int R1 = 0; R1 < sum; R1++)
                {
                    if (Random_1_1 == white[R1])
                    {
                        goto a1;
                    }
                }
                string Random_1_1_String = Random_1_1.ToString();
                Label_1_1.Text = Random_1_1_String;
            }
            else if (Numbers == 2)
            {
                Label_1_1.Text = " ";
                Label_2_1.Text = " ";
                Label_3_1.Text = " ";
                Label_4_1.Text = " ";
                Label_5_1.Text = " ";
                Label_3_2.Text = " ";
                Label_4_2.Text = " ";
            aa:
                Random_1_2 = random.Next(MinNumber, MaxNumber + 1);
                for (int R2 = 0; R2 < sum; R2++)
                {
                    if (Random_1_2 == white[R2])
                    {
                        goto aa;
                    }
                }
                string Random_1_2_String = Random_1_2.ToString();
                Label_1_2.Text = Random_1_2_String;
            a2:
                Random_2_2 = random.Next(MinNumber, MaxNumber + 1);
                if (Random_2_2 == Random_1_2)
                {
                    goto a2;
                }
                for (int R2 = 0; R2 < sum; R2++)
                {
                    if (Random_2_2 == white[R2])
                    {
                        goto a2;
                    }
                }
                string Random_2_2_String = Random_2_2.ToString();
                Label_2_2.Text = Random_2_2_String;
            }
            else if (Numbers == 3)
            {
                Label_4_1.Text = " ";
                Label_5_1.Text = " ";
                Label_1_2.Text = " ";
                Label_2_2.Text = " ";
                Label_3_2.Text = " ";
                Label_4_2.Text = " ";
            a3:
                Random_1_1 = random.Next(MinNumber, MaxNumber + 1);
                for (int R2 = 0; R2 < sum; R2++)
                {
                    if (Random_1_1 == white[R2])
                    {
                        goto a3;
                    }
                }
                string Random_1_1_String = Random_1_1.ToString();
                Label_1_1.Text = Random_1_1_String;
            aa2:
                Random_2_1 = random.Next(MinNumber, MaxNumber + 1);
                if (Random_2_1 == Random_1_1)
                {
                    goto aa2;
                }
                for (int R2 = 0; R2 < sum; R2++)
                {
                    if (Random_2_1 == white[R2])
                    {
                        goto aa2;
                    }
                }
                string Random_2_1_String = Random_2_1.ToString();
                Label_2_1.Text = Random_2_1_String;
            a3a:
                Random_3_1 = random.Next(MinNumber, MaxNumber + 1);
                if (Random_3_1 == Random_1_1 || Random_3_1 == Random_2_1)
                {
                    goto a3a;
                }
                for (int R2 = 0; R2 < sum; R2++)
                {
                    if (Random_3_1 == white[R2])
                    {
                        goto a3a;
                    }
                }
                string Random_3_1_String = Random_3_1.ToString();
                Label_3_1.Text = Random_3_1_String;
            }
            else if (Numbers == 4)
            {
                Label_1_1.Text = " ";
                Label_2_1.Text = " ";
                Label_3_1.Text = " ";
                Label_4_1.Text = " ";
                Label_5_1.Text = " ";
            a4:
                Random_1_2 = random.Next(MinNumber, MaxNumber + 1);
                for (int R2 = 0; R2 < sum; R2++)
                {
                    if (Random_1_2 == white[R2])
                    {
                        goto a4;
                    }
                }
                string Random_1_2_String = Random_1_2.ToString();
                Label_1_2.Text = Random_1_2_String;
            aa4:
                Random_2_2 = random.Next(MinNumber, MaxNumber + 1);
                if (Random_2_2 == Random_1_2)
                {
                    goto aa4;
                }
                for (int R2 = 0; R2 < sum; R2++)
                {
                    if (Random_2_2 == white[R2])
                    {
                        goto aa4;
                    }
                }
                string Random_2_2_String = Random_2_2.ToString();
                Label_2_2.Text = Random_2_2_String;
            a4a:
                Random_3_2 = random.Next(MinNumber, MaxNumber + 1);
                if (Random_3_2 == Random_1_2 || Random_3_2 == Random_2_2)
                {
                    goto a4a;
                }
                for (int R2 = 0; R2 < sum; R2++)
                {
                    if (Random_3_2 == white[R2])
                    {
                        goto a4a;
                    }
                }
                string Random_3_2_String = Random_3_2.ToString();
                Label_3_2.Text = Random_3_2_String;
            a4b:
                Random_4_2 = random.Next(MinNumber, MaxNumber + 1);
                if (Random_4_2 == Random_1_2 || Random_4_2 == Random_2_2 || Random_4_2 == Random_3_2)
                {
                    goto a4b;
                }
                for (int R2 = 0; R2 < sum; R2++)
                {
                    if (Random_4_2 == white[R2])
                    {
                        goto a4b;
                    }
                }
                string Random_4_2_String = Random_4_2.ToString();
                Label_4_2.Text = Random_4_2_String;
            }
            else
            {
                Label_1_2.Text = " ";
                Label_2_2.Text = " ";
                Label_3_2.Text = " ";
                Label_4_2.Text = " ";
            a5:
                Random_1_1 = random.Next(MinNumber, MaxNumber + 1);
                for (int R2 = 0; R2 < sum; R2++)
                {
                    if (Random_1_1 == white[R2])
                    {
                        goto a5;
                    }
                }
                string Random_1_1_String = Random_1_1.ToString();
                Label_1_1.Text = Random_1_1_String;
            aa5:
                Random_2_1 = random.Next(MinNumber, MaxNumber + 1);
                if (Random_2_1 == Random_1_1)
                {
                    goto aa5;
                }
                for (int R2 = 0; R2 < sum; R2++)
                {
                    if (Random_2_1 == white[R2])
                    {
                        goto aa5;
                    }
                }
                string Random_2_1_String = Random_2_1.ToString();
                Label_2_1.Text = Random_2_1_String;
            a5a:
                Random_3_1 = random.Next(MinNumber, MaxNumber + 1);
                if (Random_3_1 == Random_1_1 || Random_3_1 == Random_2_1)
                {
                    goto a5a;
                }
                for (int R2 = 0; R2 < sum; R2++)
                {
                    if (Random_3_1 == white[R2])
                    {
                        goto a5a;
                    }
                }
                string Random_3_1_String = Random_3_1.ToString();
                Label_3_1.Text = Random_3_1_String;
            a5b:
                Random_4_1 = random.Next(MinNumber, MaxNumber + 1);
                if (Random_4_1 == Random_1_1 || Random_4_1 == Random_2_1 || Random_4_1 == Random_3_1)
                {
                    goto a5b;
                }
                for (int R2 = 0; R2 < sum; R2++)
                {
                    if (Random_4_1 == white[R2])
                    {
                        goto a5b;
                    }
                }
                string Random_4_1_String = Random_4_1.ToString();
                Label_4_1.Text = Random_4_1_String;
            a5c:
                Random_5_1 = random.Next(MinNumber, MaxNumber + 1);
                if (Random_5_1 == Random_1_1 || Random_5_1 == Random_2_1 || Random_5_1 == Random_3_1 || Random_5_1 == Random_4_1)
                {
                    goto a5c;
                }
                for (int R2 = 0; R2 < sum; R2++)
                {
                    if (Random_5_1 == white[R2])
                    {
                        goto a5c;
                    }
                }
                string Random_5_1_String = Random_5_1.ToString();
                Label_5_1.Text = Random_5_1_String;
            }
            //Thread.Sleep(100);
            //}


        }
        private void Button_ReStart_Click(object sender, EventArgs e)
        {
            Label_1_1.Text = " ";
            Label_2_1.Text = " ";
            Label_3_1.Text = " ";
            Label_4_1.Text = " ";
            Label_5_1.Text = " ";
            Label_1_2.Text = " ";
            Label_2_2.Text = " ";
            Label_3_2.Text = " ";
            Label_4_2.Text = " ";
        }
        private void Button_Start_Click(object sender, EventArgs e)
        {



        }
        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
                Application.DoEvents();
            }


        }
        private void Button_Stop_Click(object sender, EventArgs e)
        {

        }

        //private void Button_Settings_Click(object sender, EventArgs e)
        //{
        //    if (!magic)
        //    {
        //        Form4 form4 = new Form4();
        //        form4.Show();
        //    }
        //    else
        //    {

        //    }

        //}

        private void Button_ReStart_Click_1(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Text = Form1.Numbers.ToString();
            numericUpDown2.Text = Form1.MaxNumber.ToString();
            numericUpDown3.Text = Form1.MinNumber.ToString();
            numericUpDown4.Text = Form1.ms.ToString();

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            magic = true;
        }

        private void Common_Label_1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Start_Click_1(object sender, EventArgs e)
        {
            i = false;
            if (MaxNumber - MinNumber < sum + Numbers)
            {
                Form5 form5 = new Form5();
                form5.Show();
            }

            else
            {
                while (!i)
                {
                    Start();
                    Button_Start.Enabled = false;
                    Button_Stop.Enabled = true;
                    Button_ReStart.Enabled = false;
                    Button_Start.Visible = false;
                    Button_Stop.Visible = true;
                    Delay(ms);
                }
            }

        }

        private void Button_Stop_Click_1(object sender, EventArgs e)
        {
            i = true;
            lucky();
            Button_Stop.Enabled = false;
            Button_Start.Enabled = true;
            Button_ReStart.Enabled = true;
            Button_Stop.Visible = false;
            Button_Start.Visible = true;
            Refresh();
            history();
            Form2 form2 = new Form2();
            form2.Show();

        }
        private void history()
        {
            if (Numbers == 1)
            {
                File.AppendAllText("History.txt", "\r\n" + System.DateTime.Now.ToString("G") + "  " + Random_1_1.ToString());
            }
            else if (Numbers == 2)
            {
                File.AppendAllText("History.txt", "\r\n" + System.DateTime.Now.ToString("G") + "  " + Random_1_2.ToString());
                File.AppendAllText("History.txt", "\r\n" + System.DateTime.Now.ToString("G") + "  " + Random_2_2.ToString());

            }
            else if (Numbers == 3)
            {
                File.AppendAllText("History.txt", "\r\n" + System.DateTime.Now.ToString("G") + "  " + Random_1_1.ToString());
                File.AppendAllText("History.txt", "\r\n" + System.DateTime.Now.ToString("G") + "  " + Random_2_1.ToString());
                File.AppendAllText("History.txt", "\r\n" + System.DateTime.Now.ToString("G") + "  " + Random_3_1.ToString());
            }
            else if (Numbers == 4)
            {
                File.AppendAllText("History.txt", "\r\n" + System.DateTime.Now.ToString("G") + "  " + Random_1_2.ToString());
                File.AppendAllText("History.txt", "\r\n" + System.DateTime.Now.ToString("G") + "  " + Random_2_2.ToString());
                File.AppendAllText("History.txt", "\r\n" + System.DateTime.Now.ToString("G") + "  " + Random_3_2.ToString());
                File.AppendAllText("History.txt", "\r\n" + System.DateTime.Now.ToString("G") + "  " + Random_4_2.ToString());
            }
            else
            {
                File.AppendAllText("History.txt", "\r\n" + System.DateTime.Now.ToString("G") + "  " + Random_1_1.ToString());
                File.AppendAllText("History.txt", "\r\n" + System.DateTime.Now.ToString("G") + "  " + Random_2_1.ToString());
                File.AppendAllText("History.txt", "\r\n" + System.DateTime.Now.ToString("G") + "  " + Random_3_1.ToString());
                File.AppendAllText("History.txt", "\r\n" + System.DateTime.Now.ToString("G") + "  " + Random_4_1.ToString());
                File.AppendAllText("History.txt", "\r\n" + System.DateTime.Now.ToString("G") + "  " + Random_5_1.ToString());
            }
        }

        private void Button_ReStart_Click_2(object sender, EventArgs e)
        {
            Random_1_1 = 0;
            Random_2_1 = 0;
            Random_3_1 = 0;
            Random_4_1 = 0;
            Random_5_1 = 0;
            Random_1_2 = 0;
            Random_2_2 = 0;
            Random_3_2 = 0;
            Random_4_2 = 0;
            i = false;
            Label_1_1.Text = " ";
            Label_2_1.Text = " ";
            Label_3_1.Text = " ";
            Label_4_1.Text = " ";
            Label_5_1.Text = " ";
            Label_1_2.Text = " ";
            Label_2_2.Text = " ";
            Label_3_2.Text = " ";
            Label_4_2.Text = " ";
            white = new int[100];
            blacknum = new int[100];
            string line;
            int locate = 0;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("Default.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    if (locate == 0)
                    {
                        if (int.Parse(line) >= 1 && int.Parse(line) <= 98)
                        {
                            MinNumber = int.Parse(line);
                        }
                        else
                        {
                            MinNumber = 1;
                        }
                        locate++;
                    }
                    else if (locate == 1)
                    {
                        if ((int.Parse(line) >= 2 && int.Parse(line) <= 99))
                        {
                            MaxNumber = int.Parse(line);
                        }
                        else
                        {
                            MaxNumber = 55;
                        }
                        locate++;
                    }
                    else if (locate == 2)
                    {
                        if (int.Parse(line) >= 1 && int.Parse(line) <= 5)
                        {
                            Numbers = int.Parse(line);
                        }
                        else
                        {
                            Numbers = 1;
                        }
                        locate++;
                    }
                    else if (locate == 4)
                    {
                        if (int.Parse(line) == 1)
                        {
                            readlist = true;
                        }
                        else
                        {
                            readlist = false;
                        }
                    }
                    else if (locate == 3)
                    {
                        if (int.Parse(line) >= 1 && int.Parse(line) <= 1000)
                        {
                            ms = int.Parse(line);
                        }
                        else
                        {
                            ms = 50;
                        }
                        locate++;
                    }
                    else
                    {

                    }
                    //write the line to console window
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception)
            {

            }
            finally
            {

            }
            numericUpDown4.Value = ms;
            numericUpDown3.Value = MinNumber;
            numericUpDown1.Value = MaxNumber;
            numericUpDown2.Value = Numbers;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!magic)
            {
                Form6 form6 = new Form6();
                form6.Show();
            }
            else
            {
                lucky black = new lucky();
                black.Show();
                magic = false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Form1.Numbers = (int)numericUpDown2.Value;
            //Form1.MaxNumber = (int)numericUpDown1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Form1.MaxNumber = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Form1.Numbers = (int)numericUpDown2.Value;
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            Form1.ms = (int)numericUpDown4.Value;
        }

        private void WhiteListPage_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            magic = true;
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            string line;
            int locate = 0;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("Default.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    if (locate == 0)
                    {
                        if (int.Parse(line) >= 1 && int.Parse(line) <= 98)
                        {
                            MinNumber = int.Parse(line);
                        }
                        else
                        {
                            MinNumber = 1;
                        }
                        locate++;
                    }
                    else if (locate == 1)
                    {
                        if ((int.Parse(line) >= 2 && int.Parse(line) <= 99))
                        {
                            MaxNumber = int.Parse(line);
                        }
                        else
                        {
                            MaxNumber = 55;
                        }
                        locate++;
                    }
                    else if (locate == 2)
                    {
                        if (int.Parse(line) >= 1 && int.Parse(line) <= 5)
                        {
                            Numbers = int.Parse(line);
                        }
                        else
                        {
                            Numbers = 1;
                        }
                        locate++;
                    }
                    else if (locate == 4)
                    {
                        if (int.Parse(line) == 1)
                        {
                            readlist = true;
                        }
                        else
                        {
                            readlist = false;
                        }
                    }
                    else if (locate == 3)
                    {
                        if (int.Parse(line) >= 1 && int.Parse(line) <= 1000)
                        {
                            ms = int.Parse(line);
                        }
                        else
                        {
                            ms = 50;
                        }
                        locate++;
                    }
                    else
                    {

                    }
                    //write the line to console window
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception)
            {

            }
            finally
            {

            }
            readtxt(readlist);
            numericUpDown4.Value = ms;
            numericUpDown3.Value = MinNumber;
            numericUpDown1.Value = MaxNumber;
            numericUpDown2.Value = Numbers;
        }

        private void numericUpDown3_ValueChanged_1(object sender, EventArgs e)
        {
            Form1.MinNumber = (int)numericUpDown3.Value;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColumnHeader ch = new ColumnHeader();

            ch.Text = "序号";   //设置列标题

            ch.Width = 120;    //设置列宽度

            ch.TextAlign = HorizontalAlignment.Left;   //设置列的对齐方式

            this.listView1.Columns.Add(ch);    //将列头添加到ListView控件。
        }

        private void Write_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("LuckyList.txt"))
            {
                // 将数组中的每个元素写入文件中，每个元素占一行
                foreach (int element in blacknum)
                {
                    writer.WriteLine(element);
                }
            }
            using (StreamWriter writer = new StreamWriter("WhiteList.txt"))
            {
                // 将数组中的每个元素写入文件中，每个元素占一行
                foreach (int element1 in white)
                {
                    writer.WriteLine(element1);
                }
            }
        }

        private void Read_Click(object sender, EventArgs e)
        {
            string path = "LuckyList.txt";
            string[] a = File.ReadAllLines(path);
            for (int i = 0; i < a.Length; i++)
            {
                if (int.Parse(a[i]) != 0 && a[i] != null)
                {
                    blacksum++;
                }
                for (int j = 0; j < blacknum.Length; j++)
                {
                    if (blacknum[j] == int.Parse(a[i]))
                    {
                        goto Failed;
                    }
                }
                blacknum[i] = int.Parse(a[i]);
            Failed:;
            }
            string path1 = "WhiteList.txt";
            string[] a1 = File.ReadAllLines(path1);
            for (int j = 0; j < a1.Length; j++)
            {
                for (int i = 0; i < white.Length; i++)
                {
                    if (int.Parse(a1[j]) == white[i])
                    {
                        goto Fail;
                    }
                }
                white[j] = int.Parse(a1[j]);
                sum++;
            Fail:;
            }
            Read.Enabled = false;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "白名单值：\n";
            foreach (int i in white)
            {
                if (i != 0)
                {
                    richTextBox1.Text += i.ToString() + "\t" + "\n";
                }
            }
        }

        private void navigationPage7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            simpleButton2.Text = "Please Wait...";
            simpleButton2.Enabled = false;
            richTextBox2.Text = "日期                           数据";
            string line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("History.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    richTextBox2.Text += line + "\n";
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
                Delay(1000);
                simpleButton2.Enabled = true;
                simpleButton2.Text = "读取历史记录";
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                writelist = true;
            }
            else
            {

            }
            File.WriteAllText("Default.txt", string.Empty);
            WriteFile(MinNumber.ToString());
            WriteFile(MaxNumber.ToString());
            WriteFile(Numbers.ToString());
            WriteFile(ms.ToString());
            if (writelist)
            {
                WriteFile(1.ToString());
            }
            else
            {
                WriteFile(0.ToString());
            }
            writelist = false;
        }
        public static void WriteFile(String str)
        {
            StreamWriter sw = new StreamWriter("Default.txt", true, System.Text.Encoding.Default);
            sw.WriteLine(str);
            sw.Close();
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tileBar_Click(object sender, EventArgs e)
        {

        }

        private void navigationPage6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            simpleButton4.Text = "Please Wait...";
            simpleButton4.Enabled = false;
            richTextBox3.Text = "日期                           数据";
            string line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("History.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    richTextBox3.Text += line + "\n";
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
                Delay(1000);
                simpleButton4.Text = "读取历史记录";
                simpleButton4.Enabled = true;
            }
            catch (Exception)
            {

            }
            finally
            {

            }
        }
    }
}
