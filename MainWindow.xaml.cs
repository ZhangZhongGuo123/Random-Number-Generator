using System.Windows;
using System.Windows.Controls;

namespace Randon_Number_Generator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int center = 400;
        public static int up = 50;
        public static int TitNum = 40;
        public static int NumNum = 40;
        public static int Numw = 100;
        public static int Numh = 60;
        public static int Numgap = 40;
        public static int Titleh = 50;
        public static int Titlew = 120;
        public static int length;
        public static int p1x = center - Titleh / 2 - length;
        public static int p2x = center - Numgap / 2 - Numh - length;
        public static int p3x = center + Numgap / 2 - length;
        public static int p4x = center - Numh * 3 / 2 - Numgap - length;
        public static int p5x = center + Numh / 2 + Numgap - length;
        public static int p6x = center - Numgap * 3 / 2 - Numh * 2 - length;
        public static int p7x = center + Numgap * 3 / 2 + Numh - length;
        public static int p8x = center - Numgap * 2 - Numh * 5 / 2 - length;
        public static int p9x = center + Numgap * 2 + Numh * 3 / 2 - length;
        public static int NumFy = up + Titleh + TitNum;
        public static int NumSy = NumFy + Numh + NumNum;
        public static int min;
        public static int max;
        public static int once;
        public static int[]? show;
        public static int[]? ol;
        public static int[] flist = Enumerable.Range(min, max - min + 1).ToArray();
        public static int[]? v;
        public static int[]? r;
        public static int[]? white;
        public static bool running = false;
        public static int delay = 1;
        public void LabelMargin(int label, int left, int top)
        {
            switch (label)
            {
                case 1:
                    Thickness thickness1 = new Thickness();
                    thickness1.Top = top;
                    thickness1.Left = left;
                    Num1.Margin = thickness1;
                    break;
                case 2:
                    Thickness thickness2 = new Thickness();
                    thickness2.Top = top;
                    thickness2.Left = left;
                    Num2.Margin = thickness2;
                    break;
                case 3:
                    Thickness thickness3 = new Thickness();
                    thickness3.Top = top;
                    thickness3.Left = left;
                    Num3.Margin = thickness3;
                    break;
                case 4:
                    Thickness thickness4 = new Thickness();
                    thickness4.Top = top;
                    thickness4.Left = left;
                    Num4.Margin = thickness4;
                    break;
                case 5:
                    Thickness thickness5 = new Thickness();
                    thickness5.Top = top;
                    thickness5.Left = left;
                    Num5.Margin = thickness5;
                    break;
                case 6:
                    Thickness thickness6 = new Thickness();
                    thickness6.Top = top;
                    thickness6.Left = left;
                    Num6.Margin = thickness6;
                    break;
                case 7:
                    Thickness thickness7 = new Thickness();
                    thickness7.Top = top;
                    thickness7.Left = left;
                    Num7.Margin = thickness7;
                    break;
                case 8:
                    Thickness thickness8 = new Thickness();
                    thickness8.Top = top;
                    thickness8.Left = left;
                    Num8.Margin = thickness8;
                    break;
                case 9:
                    Thickness thickness9 = new Thickness();
                    thickness9.Top = top;
                    thickness9.Left = left;
                    Num9.Margin = thickness9;
                    break;
                case 10:
                    Thickness thickness10 = new Thickness();
                    thickness10.Top = top;
                    thickness10.Left = left;
                    Num10.Margin = thickness10;
                    break;
            }
        }
        public void ChangeLabelPosition(int value)
        {
            switch (value)
            {
                case 1:
                    LabelMargin(1, p1x, NumFy);
                    break;
                case 2:
                    LabelMargin(1, p2x, NumFy);
                    LabelMargin(2, p3x, NumFy);
                    break;
                case 3:
                    LabelMargin(1, p4x, NumFy);
                    LabelMargin(2, p1x, NumFy);
                    LabelMargin(3, p5x, NumFy);
                    break;
                case 4:
                    LabelMargin(1, p6x, NumFy);
                    LabelMargin(2, p2x, NumFy);
                    LabelMargin(3, p3x, NumFy);
                    LabelMargin(4, p7x, NumFy);
                    break;
                case 5:
                    LabelMargin(1, p8x, NumFy);
                    LabelMargin(2, p4x, NumFy);
                    LabelMargin(3, p1x, NumFy);
                    LabelMargin(4, p5x, NumFy);
                    LabelMargin(5, p9x, NumFy);
                    break;
                case 6:
                    LabelMargin(1, p8x, NumFy);
                    LabelMargin(2, p4x, NumFy);
                    LabelMargin(3, p1x, NumFy);
                    LabelMargin(4, p5x, NumFy);
                    LabelMargin(5, p9x, NumFy);
                    LabelMargin(6, p1x, NumSy);
                    break;
                case 7:
                    LabelMargin(1, p8x, NumFy);
                    LabelMargin(2, p4x, NumFy);
                    LabelMargin(3, p1x, NumFy);
                    LabelMargin(4, p5x, NumFy);
                    LabelMargin(5, p9x, NumFy);
                    LabelMargin(6, p2x, NumSy);
                    LabelMargin(7, p3x, NumSy);
                    break;
                case 8:
                    LabelMargin(1, p8x, NumFy);
                    LabelMargin(2, p4x, NumFy);
                    LabelMargin(3, p1x, NumFy);
                    LabelMargin(4, p5x, NumFy);
                    LabelMargin(5, p9x, NumFy);
                    LabelMargin(6, p4x, NumSy);
                    LabelMargin(7, p1x, NumSy);
                    LabelMargin(8, p5x, NumSy);
                    break;
                case 9:
                    LabelMargin(1, p8x, NumFy);
                    LabelMargin(2, p4x, NumFy);
                    LabelMargin(3, p1x, NumFy);
                    LabelMargin(4, p5x, NumFy);
                    LabelMargin(5, p9x, NumFy);
                    LabelMargin(6, p6x, NumSy);
                    LabelMargin(7, p2x, NumSy);
                    LabelMargin(8, p3x, NumSy);
                    LabelMargin(9, p7x, NumSy);
                    break;
                case 10:
                    LabelMargin(1, p8x, NumFy);
                    LabelMargin(2, p4x, NumFy);
                    LabelMargin(3, p1x, NumFy);
                    LabelMargin(4, p5x, NumFy);
                    LabelMargin(5, p9x, NumFy);
                    LabelMargin(6, p8x, NumSy);
                    LabelMargin(7, p4x, NumSy);
                    LabelMargin(8, p1x, NumSy);
                    LabelMargin(9, p5x, NumSy);
                    LabelMargin(10, p9x, NumSy);
                    break;
            }
        }
        public MainWindow()
        {
            InitializeComponent();

        }
        private Random random = new Random();


        private async void Run(object sender, RoutedEventArgs e)
        {
            flist = Enumerable.Range(min, max - min + 1).ToArray();
            min = int.Parse(Minimum.Text);
            max = int.Parse(Maximum.Text);
            once = int.Parse(Once.Text);
            if (max < 10)
            {
                length = 0;
            }
            else if (max >= 10 && max < 100)
            {
                length = 10;
            }
            else if (max >= 100 && max < 1000)
            {
                length = 30;
            }
            else
            {
                length = 50;
            }
            Stop.IsEnabled = true;
            Start.IsEnabled = false;
            Stop.Visibility = Visibility.Visible;
            Start.Visibility = Visibility.Collapsed;
            Maximum.IsEnabled = false;
            Minimum.IsEnabled = false;
            Once.IsEnabled = false;
            ChangeLabelPosition(once);
            running = true;
            while (running)
            {
                Gennum(once);
                await Task.Delay(delay);
            }
        }

        private void End(object sender, RoutedEventArgs e)
        {
            Start.IsEnabled = true;
            Stop.IsEnabled = false;
            Maximum.IsEnabled = true;
            Minimum.IsEnabled = true;
            Once.IsEnabled = true;
            Start.Visibility = Visibility.Visible;
            Stop.Visibility = Visibility.Collapsed;
            running = false;
        }
        public void Gennum(int num)
        {
            if (flist != null)
            {
                switch (num)
                {
                    case 1:
                        // 检查数组是否为空或有效元素数量是否足够
                        if (flist != null && flist.Length > 0)
                        {
                            HashSet<int> uniqueNumbersSet = new HashSet<int>(flist);

                            // 将HashSet转换为List，方便随机抽取
                            List<int> uniqueNumbersList = uniqueNumbersSet.ToList();

                            // 确保有足够的元素进行随机抽取
                            if (uniqueNumbersList.Count >= 1)
                            {
                                // 创建一个新的列表来存放随机抽取的数字
                                List<int> selectedNumbers = new List<int>();

                                // 随机抽取1个不重复的数字
                                while (selectedNumbers.Count < 1)
                                {
                                    int randomIndex = random.Next(uniqueNumbersList.Count);
                                    int randomNumber = uniqueNumbersList[randomIndex];

                                    selectedNumbers.Add(randomNumber);
                                    uniqueNumbersList.RemoveAt(randomIndex);  // 移除已选中的数字，避免下次抽中
                                }

                                // 将抽取的数字分配给Label控件
                                int index = 0;
                                Label[] labels = { Num1 };  // 注意这里数组长度调整为1
                                foreach (var label in labels)
                                {
                                    if (index < selectedNumbers.Count)
                                    {
                                        label.Content = selectedNumbers[index].ToString();
                                        index++;
                                    }
                                    else
                                    {
                                        break;  // 如果selectedNumbers的数量不足1，退出循环
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        // 检查数组是否为空或有效元素数量是否足够
                        if (flist != null && flist.Length > 0)
                        {
                            HashSet<int> uniqueNumbersSet = new HashSet<int>(flist);

                            // 将HashSet转换为List，方便随机抽取
                            List<int> uniqueNumbersList = uniqueNumbersSet.ToList();

                            // 确保有足够的元素进行随机抽取
                            if (uniqueNumbersList.Count >= 2)
                            {
                                // 创建一个新的列表来存放随机抽取的数字
                                List<int> selectedNumbers = new List<int>();

                                // 随机抽取2个不重复的数字
                                while (selectedNumbers.Count < 2)
                                {
                                    int randomIndex = random.Next(uniqueNumbersList.Count);
                                    int randomNumber = uniqueNumbersList[randomIndex];

                                    selectedNumbers.Add(randomNumber);
                                    uniqueNumbersList.RemoveAt(randomIndex);  // 移除已选中的数字，避免下次抽中
                                }

                                // 将抽取的数字分配给Label控件
                                int index = 0;
                                Label[] labels = { Num1, Num2 };  // 注意这里数组长度调整为2
                                foreach (var label in labels)
                                {
                                    if (index < selectedNumbers.Count)
                                    {
                                        label.Content = selectedNumbers[index].ToString();
                                        index++;
                                    }
                                    else
                                    {
                                        break;  // 如果selectedNumbers的数量不足2，退出循环
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        // 检查数组是否为空或有效元素数量是否足够
                        if (flist != null && flist.Length > 0)
                        {
                            HashSet<int> uniqueNumbersSet = new HashSet<int>(flist);

                            // 将HashSet转换为List，方便随机抽取
                            List<int> uniqueNumbersList = uniqueNumbersSet.ToList();

                            // 确保有足够的元素进行随机抽取
                            if (uniqueNumbersList.Count >= 3)
                            {
                                // 创建一个新的列表来存放随机抽取的数字
                                List<int> selectedNumbers = new List<int>();

                                // 随机抽取3个不重复的数字
                                while (selectedNumbers.Count < 3)
                                {
                                    int randomIndex = random.Next(uniqueNumbersList.Count);
                                    int randomNumber = uniqueNumbersList[randomIndex];

                                    selectedNumbers.Add(randomNumber);
                                    uniqueNumbersList.RemoveAt(randomIndex);  // 移除已选中的数字，避免下次抽中
                                }

                                // 将抽取的数字分配给Label控件
                                int index = 0;
                                Label[] labels = { Num1, Num2, Num3 };  // 注意这里数组长度调整为3
                                foreach (var label in labels)
                                {
                                    if (index < selectedNumbers.Count)
                                    {
                                        label.Content = selectedNumbers[index].ToString();
                                        index++;
                                    }
                                    else
                                    {
                                        break;  // 如果selectedNumbers的数量不足3，退出循环
                                    }
                                }
                            }
                        }
                        break;
                    case 4:
                        // 检查数组是否为空或有效元素数量是否足够
                        if (flist != null && flist.Length > 0)
                        {
                            HashSet<int> uniqueNumbersSet = new HashSet<int>(flist);

                            // 将HashSet转换为List，方便随机抽取
                            List<int> uniqueNumbersList = uniqueNumbersSet.ToList();

                            // 确保有足够的元素进行随机抽取
                            if (uniqueNumbersList.Count >= 4)
                            {
                                // 创建一个新的列表来存放随机抽取的数字
                                List<int> selectedNumbers = new List<int>();

                                // 随机抽取4个不重复的数字
                                while (selectedNumbers.Count < 4)
                                {
                                    int randomIndex = random.Next(uniqueNumbersList.Count);
                                    int randomNumber = uniqueNumbersList[randomIndex];

                                    selectedNumbers.Add(randomNumber);
                                    uniqueNumbersList.RemoveAt(randomIndex);  // 移除已选中的数字，避免下次抽中
                                }

                                // 将抽取的数字分配给Label控件
                                int index = 0;
                                Label[] labels = { Num1, Num2, Num3, Num4 };  // 注意这里数组长度调整为4
                                foreach (var label in labels)
                                {
                                    if (index < selectedNumbers.Count)
                                    {
                                        label.Content = selectedNumbers[index].ToString();
                                        index++;
                                    }
                                    else
                                    {
                                        break;  // 如果selectedNumbers的数量不足4，退出循环
                                    }
                                }
                            }
                        }
                        break;
                    case 5:
                        // 检查数组是否为空或有效元素数量是否足够
                        if (flist != null && flist.Length > 0)
                        {
                            HashSet<int> uniqueNumbersSet = new HashSet<int>(flist);

                            // 将HashSet转换为List，方便随机抽取
                            List<int> uniqueNumbersList = uniqueNumbersSet.ToList();

                            // 确保有足够的元素进行随机抽取
                            if (uniqueNumbersList.Count >= 5)
                            {
                                // 创建一个新的列表来存放随机抽取的数字
                                List<int> selectedNumbers = new List<int>();

                                // 随机抽取5个不重复的数字
                                while (selectedNumbers.Count < 5)
                                {
                                    int randomIndex = random.Next(uniqueNumbersList.Count);
                                    int randomNumber = uniqueNumbersList[randomIndex];

                                    selectedNumbers.Add(randomNumber);
                                    uniqueNumbersList.RemoveAt(randomIndex);  // 移除已选中的数字，避免下次抽中
                                }

                                // 将抽取的数字分配给Label控件
                                int index = 0;
                                Label[] labels = { Num1, Num2, Num3, Num4, Num5 };  // 注意这里数组长度调整为5
                                foreach (var label in labels)
                                {
                                    if (index < selectedNumbers.Count)
                                    {
                                        label.Content = selectedNumbers[index].ToString();
                                        index++;
                                    }
                                    else
                                    {
                                        break;  // 如果selectedNumbers的数量不足5，退出循环
                                    }
                                }
                            }
                        }
                        break;
                    case 6:
                        // 检查数组是否为空或有效元素数量是否足够
                        if (flist != null && flist.Length > 0)
                        {
                            HashSet<int> uniqueNumbersSet = new HashSet<int>(flist);

                            // 将HashSet转换为List，方便随机抽取
                            List<int> uniqueNumbersList = uniqueNumbersSet.ToList();

                            // 确保有足够的元素进行随机抽取
                            if (uniqueNumbersList.Count >= 6)
                            {
                                // 创建一个新的列表来存放随机抽取的数字
                                List<int> selectedNumbers = new List<int>();

                                // 随机抽取6个不重复的数字
                                while (selectedNumbers.Count < 6)
                                {
                                    int randomIndex = random.Next(uniqueNumbersList.Count);
                                    int randomNumber = uniqueNumbersList[randomIndex];

                                    selectedNumbers.Add(randomNumber);
                                    uniqueNumbersList.RemoveAt(randomIndex);  // 移除已选中的数字，避免下次抽中
                                }

                                // 将抽取的数字分配给Label控件
                                int index = 0;
                                Label[] labels = { Num1, Num2, Num3, Num4, Num5, Num6 };  // 注意这里数组长度调整为2
                                foreach (var label in labels)
                                {
                                    if (index < selectedNumbers.Count)
                                    {
                                        label.Content = selectedNumbers[index].ToString();
                                        index++;
                                    }
                                    else
                                    {
                                        break;  // 如果selectedNumbers的数量不足6，退出循环
                                    }
                                }
                            }
                        }
                        break;
                    case 7:
                        // 检查数组是否为空或有效元素数量是否足够
                        if (flist != null && flist.Length > 0)
                        {
                            HashSet<int> uniqueNumbersSet = new HashSet<int>(flist);

                            // 将HashSet转换为List，方便随机抽取
                            List<int> uniqueNumbersList = uniqueNumbersSet.ToList();

                            // 确保有足够的元素进行随机抽取
                            if (uniqueNumbersList.Count >= 7)
                            {
                                // 创建一个新的列表来存放随机抽取的数字
                                List<int> selectedNumbers = new List<int>();

                                // 随机抽取7个不重复的数字
                                while (selectedNumbers.Count < 7)
                                {
                                    int randomIndex = random.Next(uniqueNumbersList.Count);
                                    int randomNumber = uniqueNumbersList[randomIndex];

                                    selectedNumbers.Add(randomNumber);
                                    uniqueNumbersList.RemoveAt(randomIndex);  // 移除已选中的数字，避免下次抽中
                                }

                                // 将抽取的数字分配给Label控件
                                int index = 0;
                                Label[] labels = { Num1, Num2, Num3, Num4, Num5, Num6, Num7 };  // 注意这里数组长度调整为7
                                foreach (var label in labels)
                                {
                                    if (index < selectedNumbers.Count)
                                    {
                                        label.Content = selectedNumbers[index].ToString();
                                        index++;
                                    }
                                    else
                                    {
                                        break;  // 如果selectedNumbers的数量不足7，退出循环
                                    }
                                }
                            }
                        }
                        break;
                    case 8:
                        // 检查数组是否为空或有效元素数量是否足够
                        if (MainWindow.flist != null && MainWindow.flist.Length > 0)
                        {
                            HashSet<int> uniqueNumbersSet = new HashSet<int>(MainWindow.flist);

                            // 将HashSet转换为List，方便随机抽取
                            List<int> uniqueNumbersList = uniqueNumbersSet.ToList();

                            // 确保有足够的元素进行随机抽取
                            if (uniqueNumbersList.Count >= 8)
                            {
                                // 创建一个新的列表来存放随机抽取的数字
                                List<int> selectedNumbers = new List<int>();

                                // 随机抽取8个不重复的数字
                                while (selectedNumbers.Count < 8)
                                {
                                    int randomIndex = random.Next(uniqueNumbersList.Count);
                                    int randomNumber = uniqueNumbersList[randomIndex];

                                    selectedNumbers.Add(randomNumber);
                                    uniqueNumbersList.RemoveAt(randomIndex);  // 移除已选中的数字，避免下次抽中
                                }

                                // 将抽取的数字分配给Label控件
                                int index = 0;
                                Label[] labels = { Num1, Num2, Num3, Num4, Num5, Num6, Num7, Num8 };  // 注意这里数组长度调整为8
                                foreach (var label in labels)
                                {
                                    if (index < selectedNumbers.Count)
                                    {
                                        label.Content = selectedNumbers[index].ToString();
                                        index++;
                                    }
                                    else
                                    {
                                        break;  // 如果selectedNumbers的数量不足8，退出循环
                                    }
                                }
                            }
                        }
                        break;
                    case 9:

                        // 检查数组是否为空或有效元素数量是否足够
                        if (MainWindow.flist != null && MainWindow.flist.Length > 0)
                        {
                            HashSet<int> uniqueNumbersSet = new HashSet<int>(MainWindow.flist);

                            // 将HashSet转换为List，方便随机抽取
                            List<int> uniqueNumbersList = uniqueNumbersSet.ToList();

                            // 确保有足够的元素进行随机抽取
                            if (uniqueNumbersList.Count >= 9)
                            {
                                // 创建一个新的列表来存放随机抽取的数字
                                List<int> selectedNumbers = new List<int>();

                                // 随机抽取9个不重复的数字
                                while (selectedNumbers.Count < 9)
                                {
                                    int randomIndex = random.Next(uniqueNumbersList.Count);
                                    int randomNumber = uniqueNumbersList[randomIndex];

                                    selectedNumbers.Add(randomNumber);
                                    uniqueNumbersList.RemoveAt(randomIndex);  // 移除已选中的数字，避免下次抽中
                                }

                                // 将抽取的数字分配给Label控件
                                int index = 0;
                                Label[] labels = { Num1, Num2, Num3, Num4, Num5, Num6, Num7, Num8, Num9 };  // 注意这里数组长度调整为9
                                foreach (var label in labels)
                                {
                                    if (index < selectedNumbers.Count)
                                    {
                                        label.Content = selectedNumbers[index].ToString();
                                        index++;
                                    }
                                    else
                                    {
                                        break;  // 如果selectedNumbers的数量不足9，退出循环
                                    }
                                }
                            }
                        }
                        break;
                    case 10:
                        // 检查数组是否为空或有效元素数量是否足够
                        if (MainWindow.flist != null && MainWindow.flist.Length > 0)
                        {
                            HashSet<int> uniqueNumbersSet = new HashSet<int>(MainWindow.flist);

                            // 将HashSet转换为List，方便随机抽取
                            List<int> uniqueNumbersList = uniqueNumbersSet.ToList();

                            // 确保有足够的元素进行随机抽取
                            if (uniqueNumbersList.Count >= 10)
                            {
                                // 创建一个新的列表来存放随机抽取的数字
                                List<int> selectedNumbers = new List<int>();

                                // 随机抽取10个不重复的数字
                                while (selectedNumbers.Count < 10)
                                {
                                    int randomIndex = random.Next(uniqueNumbersList.Count);
                                    int randomNumber = uniqueNumbersList[randomIndex];

                                    selectedNumbers.Add(randomNumber);
                                    uniqueNumbersList.RemoveAt(randomIndex);  // 移除已选中的数字，避免下次抽中
                                }

                                // 将抽取的数字分配给Label控件
                                int index = 0;
                                Label[] labels = { Num1, Num2, Num3, Num4, Num5, Num6, Num7, Num8, Num9, Num10 };  // 注意这里数组长度调整为10
                                foreach (var label in labels)
                                {
                                    if (index < selectedNumbers.Count)
                                    {
                                        label.Content = selectedNumbers[index].ToString();
                                        index++;
                                    }
                                    else
                                    {
                                        break;  // 如果selectedNumbers的数量不足10，退出循环
                                    }
                                }
                            }
                        }
                        break;
                }
            }
        }

        private void MinimumChange(object sender, TextChangedEventArgs e)
        {
            try
            {
                min = int.Parse(Minimum.Text);
            }
            finally
            {

            }

        }

        private void MaximumChange(object sender, TextChangedEventArgs e)
        {
            try
            {
                max = int.Parse(Maximum.Text);
            }
            catch
            {

            }
            finally
            {

            }
        }

        private void OnceChange(object sender, TextChangedEventArgs e)
        {
            try
            {
                once = int.Parse(Once.Text);
            }
            catch
            {

            }
            finally
            {

            }
        }
    }
}