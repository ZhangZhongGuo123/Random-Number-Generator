using System.Configuration;
using System.Diagnostics;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using Random_Number_Generator.ViewModels;
using Windows.Storage;
using Windows.Storage.Streams;
using Windows.UI.Core;

namespace Random_Number_Generator.Views;

public sealed partial class HomePage : Page
{
    public static int p1x = 290;
    public static int p2x = 190;
    public static int p3x = 90;
    public static int p4x = 0;
    public static int p5x = 100;
    public static int p6x = 200;
    public static int p7x = 300;
    public static int p1y = 25;
    public static int p2y = 150;
    public static int p3y = 275;
    public static int min;
    public static int max;
    public static int once;
    public static int mode;
    public static int resultindex;
    public static string? text;
    public static int MessageNum = 0;
    public static int[]? show;
    public static int[]? ol;
    public static int[]? flist;
    public static int[]? v;
    public static int[]? r;
    public static int[]? white;
    public static int[]? ranlist;
    public static int[]? whitelist;
    public static int[]? complexlist;
    public static int[]? possibilities;
    public static int[]? result;
    List<int> numbersList = new List<int>();
    public static bool running = false;
    public static int delay = 1;
    public static bool ifreadconfig = true;
    private FileHelper _fileHelper;
    public HomeViewModel ViewModel
    {
        get;
    }
    public static async Task WriteTextBlocksToCsv(List<TextBlock> textBlocks, string filePath, int min, int max, int once, int mode)
    {
        if (!File.Exists(filePath))
        {
            // 文件不存在，创建文件
            using (FileStream fs = File.Create(filePath))
            {
                // 文件已成功创建，此处可选择写入初始内容，或保持为空
            }
        }
        try
        {
            // 获取当前时间
            using (var writer = new StreamWriter(filePath, true))
            {
                int counter = 0;

                foreach (var text in textBlocks)
                {
                    if (counter >= once) break; // 达到指定数量后停止
                    // 获取当前时间
                    DateTime currentTime = DateTime.Now;
                    string line = $"{currentTime},{min},{max},{text.Text},{mode}";

                    // 写入CSV
                    await writer.WriteLineAsync(line);
                    counter++;
                }
            }
        }
        catch (Exception ex)
        {
            // 记录或处理异常，例如文件访问权限问题
            Debug.WriteLine($"Error writing to CSV: {ex.Message}");
        }
    }
    public static async Task WriteTextBlocksToCsvAsync(List<TextBlock> textBlocks, string filePath, int min, int max, int once)
    {
        StorageFolder folder = ApplicationData.Current.LocalFolder;
        StorageFile file = await folder.CreateFileAsync(filePath, CreationCollisionOption.OpenIfExists);

        // 检查文件是否存在，如果不存在则创建
        if (file == null)
        {
            file = await folder.CreateFileAsync(filePath, CreationCollisionOption.GenerateUniqueName);
        }

        try
        {
            int counter = 0;

            using (IRandomAccessStream stream = await file.OpenAsync(FileAccessMode.ReadWrite))
            {
                using (Stream fileStream = stream.AsStreamForWrite())
                {
                    // 移动到文件末尾
                    fileStream.Seek(0, SeekOrigin.End);

                    using (StreamWriter writer = new StreamWriter(fileStream, System.Text.Encoding.UTF8, bufferSize: 1024, leaveOpen: true))
                    {
                        foreach (var text in textBlocks)
                        {
                            if (counter >= once) break; // 达到指定数量后停止
                            // 获取当前时间
                            DateTime currentTime = DateTime.Now;
                            string line = $"{currentTime},{min},{max},{text.Text}";

                            // 写入CSV
                            await writer.WriteLineAsync(line);
                            counter++;
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // 记录或处理异常，例如文件访问权限问题
            Debug.WriteLine($"Error writing to CSV: {ex.Message}");
        }
    }
    public void LabelMargin(int x, int y, int Label)
    {
        Microsoft.UI.Xaml.Thickness thickness = new Microsoft.UI.Xaml.Thickness();
        thickness.Top = 0;
        switch (x)
        {
            case 1: thickness.Right = p1x; thickness.Left = 0; break;
            case 2: thickness.Right = p2x; thickness.Left = 0; break;
            case 3: thickness.Right = p3x; thickness.Left = 0; break;
            case 4: thickness.Left = p4x; thickness.Right = 0; break;
            case 5: thickness.Left = p5x; thickness.Right = 0; break;
            case 6: thickness.Left = p6x; thickness.Right = 0; break;
            case 7: thickness.Left = p7x; thickness.Right = 0; break;
            case 14: thickness.Left = p4x - 40; thickness.Right = 0; break;
            case 21: thickness.Right = p1x - 70; thickness.Left = 0; break;
            case 27: thickness.Left = p7x - 70; thickness.Right = 0; break;
        }
        switch (y)
        {
            case 1: thickness.Bottom = p1y; thickness.Top = 0; break;
            case 2: thickness.Bottom = p2y; thickness.Top = 0; break;
            case 3: thickness.Bottom = p3y; thickness.Top = 0; break;
        }
        switch (Label)
        {
            case 1: Num1.Margin = thickness; break;
            case 2: Num2.Margin = thickness; break;
            case 3: Num3.Margin = thickness; break;
            case 4: Num4.Margin = thickness; break;
            case 5: Num5.Margin = thickness; break;
            case 6: Num6.Margin = thickness; break;
            case 7: Num7.Margin = thickness; break;
            case 8: Num8.Margin = thickness; break;
            case 9: Num9.Margin = thickness; break;
            case 10: Num10.Margin = thickness; break;
            case 11: Num11.Margin = thickness; break;
            case 12: Num12.Margin = thickness; break;
        }
    }
    public void InitLabelMargin()
    {
        LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); LabelMargin(1, 3, 9); LabelMargin(3, 3, 10); LabelMargin(5, 3, 11); LabelMargin(7, 3, 12);
        Num1.Text = " ";
        Num2.Text = " ";
        Num3.Text = " ";
        Num4.Text = " ";
        Num5.Text = " ";
        Num6.Text = " ";
        Num7.Text = " ";
        Num8.Text = " ";
        Num9.Text = " ";
        Num10.Text = " ";
        Num11.Text = " ";
        Num12.Text = " ";
    }
    public void ChangeLabelPosition(int once)
    {
        InitLabelMargin();
        if (max < 100)
        {
            switch (once)
            {
                case 1: LabelMargin(14, 2, 1); Num1.FontSize = 70; break;
                case 2: LabelMargin(21, 2, 1); LabelMargin(27, 2, 2); Num1.FontSize = 70; Num2.FontSize = 70; break;
                case 3: LabelMargin(1, 2, 1); LabelMargin(4, 2, 2); LabelMargin(7, 2, 3); Num1.FontSize = 50; Num2.FontSize = 50; Num3.FontSize = 50; break;
                case 4: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); Num1.FontSize = 50; Num2.FontSize = 50; Num3.FontSize = 50; Num4.FontSize = 50; break;
                case 5: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(4, 1, 5); Num1.FontSize = 50; Num2.FontSize = 50; Num3.FontSize = 50; Num4.FontSize = 50; Num5.FontSize = 50; break;
                case 6: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(3, 1, 5); LabelMargin(5, 1, 6); Num1.FontSize = 50; Num2.FontSize = 50; Num3.FontSize = 50; Num4.FontSize = 50; Num5.FontSize = 50; Num6.FontSize = 50; break;
                case 7: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(4, 1, 6); LabelMargin(7, 1, 7); Num1.FontSize = 50; Num2.FontSize = 50; Num3.FontSize = 50; Num4.FontSize = 50; Num5.FontSize = 50; Num6.FontSize = 50; Num7.FontSize = 50; break;
                case 8: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); Num1.FontSize = 50; Num2.FontSize = 50; Num3.FontSize = 50; Num4.FontSize = 50; Num5.FontSize = 50; Num6.FontSize = 50; Num7.FontSize = 50; Num8.FontSize = 50; break;
                case 9: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); LabelMargin(4, 3, 9); break;
                case 10: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); LabelMargin(3, 3, 9); LabelMargin(5, 3, 10); break;
                case 11: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); LabelMargin(1, 3, 9); LabelMargin(4, 3, 10); LabelMargin(7, 3, 11); break;
                case 12: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); LabelMargin(1, 3, 9); LabelMargin(3, 3, 10); LabelMargin(5, 3, 11); LabelMargin(7, 3, 12); break;
            }
        }
        else if (max < 1000 && max >= 100)
        {
            switch (once)
            {
                case 1: LabelMargin(14, 2, 1); Num1.FontSize = 60; break;
                case 2: LabelMargin(21, 2, 1); LabelMargin(27, 2, 2); Num1.FontSize = 60; Num2.FontSize = 60; break;
                case 3: LabelMargin(1, 2, 1); LabelMargin(4, 2, 2); LabelMargin(7, 2, 3); Num1.FontSize = 40; Num2.FontSize = 40; Num3.FontSize = 40; break;
                case 4: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); Num1.FontSize = 40; Num2.FontSize = 40; Num3.FontSize = 40; Num4.FontSize = 40; break;
                case 5: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(4, 1, 5); Num1.FontSize = 40; Num2.FontSize = 40; Num3.FontSize = 40; Num4.FontSize = 40; Num5.FontSize = 40; break;
                case 6: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(3, 1, 5); LabelMargin(5, 1, 6); Num1.FontSize = 40; Num2.FontSize = 40; Num3.FontSize = 40; Num4.FontSize = 40; Num5.FontSize = 40; Num6.FontSize = 40; break;
                case 7: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(4, 1, 6); LabelMargin(7, 1, 7); Num1.FontSize = 40; Num2.FontSize = 40; Num3.FontSize = 40; Num4.FontSize = 40; Num5.FontSize = 40; Num6.FontSize = 40; Num7.FontSize = 40; break;
                case 8: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); Num1.FontSize = 40; Num2.FontSize = 40; Num3.FontSize = 40; Num4.FontSize = 40; Num5.FontSize = 40; Num6.FontSize = 40; Num7.FontSize = 40; Num8.FontSize = 40; break;
                case 9: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); LabelMargin(4, 3, 9); break;
                case 10: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); LabelMargin(3, 3, 9); LabelMargin(5, 3, 10); break;
                case 11: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); LabelMargin(1, 3, 9); LabelMargin(4, 3, 10); LabelMargin(7, 3, 11); break;
                case 12: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); LabelMargin(1, 3, 9); LabelMargin(3, 3, 10); LabelMargin(5, 3, 11); LabelMargin(7, 3, 12); break;
            }
        }
        else
        {
            switch (once)
            {
                case 1: LabelMargin(14, 2, 1); break;
                case 2: LabelMargin(21, 2, 1); LabelMargin(27, 2, 2); break;
                case 3: LabelMargin(1, 2, 1); LabelMargin(4, 2, 2); LabelMargin(7, 2, 3); break;
                case 4: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); break;
                case 5: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(4, 1, 5); break;
                case 6: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(3, 1, 5); LabelMargin(5, 1, 6); break;
                case 7: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(4, 1, 6); LabelMargin(7, 1, 7); break;
                case 8: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); break;
                case 9: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); LabelMargin(4, 3, 9); break;
                case 10: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); LabelMargin(3, 3, 9); LabelMargin(5, 3, 10); break;
                case 11: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); LabelMargin(1, 3, 9); LabelMargin(4, 3, 10); LabelMargin(7, 3, 11); break;
                case 12: LabelMargin(1, 2, 1); LabelMargin(3, 2, 2); LabelMargin(5, 2, 3); LabelMargin(7, 2, 4); LabelMargin(1, 1, 5); LabelMargin(3, 1, 6); LabelMargin(5, 1, 7); LabelMargin(7, 1, 8); LabelMargin(1, 3, 9); LabelMargin(3, 3, 10); LabelMargin(5, 3, 11); LabelMargin(7, 3, 12); break;
            }
        }
    }
    public static void AddUpdateAppSettings(string key, string value)
    {
        try
        {
            var configFile = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            if (settings[key] == null)
            {
                settings.Add(key, value);
            }
            else
            {
                settings[key].Value = value;
            }
            configFile.Save(ConfigurationSaveMode.Modified);
            System.Configuration.ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }
        catch (ConfigurationErrorsException)
        {

        }
    }
    public HomePage()
    {
        ifreadconfig = true;
        ViewModel = App.GetService<HomeViewModel>();
        InitializeComponent();
        _fileHelper = new FileHelper();
        if (ifreadconfig)
        {
            readconfig();
            ifreadconfig = false;
        }
        FromTo.Text = min + " To " + max;
    }
    private Random random = new Random();
    public async void Gennum(int num)
    {

        if (flist != null)
        {
            if (flist != null && flist.Length > 0)
            {
                ranlist = Enumerable.Range(0, flist.Length).ToArray();
                HashSet<int> uniqueNumbersSet = new HashSet<int>(ranlist);

                //将HashSet转换为List，方便随机抽取
                List<int> uniqueNumbersList = uniqueNumbersSet.ToList();

                //确保有足够的元素进行随机抽取
                if (uniqueNumbersList.Count >= num)
                {
                    //创建一个新的列表来存放随机抽取的数字
                    List<int> selectedNumbers = new List<int>();

                    //随机抽取num个不重复的数字
                    while (selectedNumbers.Count < num)
                    {
                        int randomIndex = random.Next(uniqueNumbersList.Count);
                        int randomNumber = uniqueNumbersList[randomIndex];

                        selectedNumbers.Add(randomNumber);
                        uniqueNumbersList.RemoveAt(randomIndex);   //移除已选中的数字，避免下次抽中
                    }

                    //将抽取的数字分配给Label控件
                    int index = 0;
                    List<TextBlock> textBlockCollection = new List<TextBlock>();
                    textBlockCollection.Add(Num1);
                    textBlockCollection.Add(Num2);
                    textBlockCollection.Add(Num3);
                    textBlockCollection.Add(Num4);
                    textBlockCollection.Add(Num5);
                    textBlockCollection.Add(Num6);
                    textBlockCollection.Add(Num7);
                    textBlockCollection.Add(Num8);
                    textBlockCollection.Add(Num9);
                    textBlockCollection.Add(Num10);
                    textBlockCollection.Add(Num11);
                    textBlockCollection.Add(Num12);

                    foreach (var label in textBlockCollection)
                    {
                        if (index < selectedNumbers.Count)
                        {
                            label.Text = flist[selectedNumbers[index]].ToString();

                            index++;
                        }
                        else
                        {
                            break;   //如果selectedNumbers的数量不足num，退出循环
                        }
                    }
                }
            }
        }

    }
    private async void End(object sender, RoutedEventArgs e)
    {
        Start.IsEnabled = true;
        Stop.IsEnabled = false;
        Start.Visibility = Visibility.Visible;
        Stop.Visibility = Visibility.Collapsed;
        running = false;
        List<TextBlock> allTextBlocks = new List<TextBlock>
        {
            Num1, Num2, Num3, Num4, Num5, Num6,
            Num7, Num8, Num9, Num10, Num11, Num12
        };
        if (mode != 3)
        {
            await WriteTextBlocksToCsvAsync(allTextBlocks, "history.csv", min, max, once);
        }
        if (mode == 2)
        {
            Addwhitelist();
        }
    }

    private async void UpdateUIOnMainThread(Action action)
    {
        if (this.Dispatcher != null)
        {
            await this.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => action());
        }
        else
        {
            // 如果Dispatcher为空，考虑是否可以在当前线程直接执行action，或者记录日志、抛出更友好的异常等
            Debug.WriteLine("Dispatcher is null, unable to update UI on main thread.");
            // 根据实际情况决定是否直接执行action
            // action();
        }
    }
    public void readconfig()
    {
        try
        {
            var appSettings = System.Configuration.ConfigurationManager.AppSettings;
            min = int.Parse((string)ApplicationData.Current.LocalSettings.Values["min"]);
            max = int.Parse((string)ApplicationData.Current.LocalSettings.Values["max"]);
            once = int.Parse((string)ApplicationData.Current.LocalSettings.Values["once"]);
            mode = int.Parse((string)ApplicationData.Current.LocalSettings.Values["mode"]);
        }
        catch (ConfigurationErrorsException)
        {


        }
    }
    public async void Addwhitelist()
    {
        AddUniqueNumbersFromLabels(new Microsoft.UI.Xaml.Controls.TextBlock[] { Num1, Num2, Num3, Num4, Num5, Num6, Num7, Num8, Num9, Num10, Num11, Num12 });
        await _fileHelper.WriteArrayToFileAsync(whitelist, min, max);
    }
    private List<int>? uniqueNumbers = new List<int>();
    private void AddUniqueNumbersFromLabels(Microsoft.UI.Xaml.Controls.TextBlock[] labels)
    {
        foreach (Microsoft.UI.Xaml.Controls.TextBlock label in labels)
        {
            if (label.Text != null)
            {
                string content = label.Text?.ToString();
                if (!string.IsNullOrEmpty(content) && int.TryParse(content, out int number))
                {
                    // 添加到集合中，自动去除重复项
                    uniqueNumbers.AddIfNew(number);
                }
            }
        }
        if (uniqueNumbers != null)
        {
            whitelist = uniqueNumbers.ToArray();
        }
    }


    private async void Start_ClickAsync(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        //AddUpdateAppSettings("min", min.ToString());
        //AddUpdateAppSettings("max", max.ToString());
        //AddUpdateAppSettings("once", once.ToString());
        whitelist = await _fileHelper.ReadArrayFromFileAsync(min, max);
        List<int> numbersList = new List<int>();
        flist = null;
        if (mode == 2)
        {
            if (whitelist != null)
            {
                for (int i = min; i <= max; i++)
                {
                    if (!whitelist.Contains(i))
                    {
                        numbersList.Add(i);
                    }
                }
                if (numbersList != null && numbersList.Count >= once)
                {
                    flist = numbersList.ToArray();
                    numbersList = null;

                }
                else
                {
                    whitelist = null;
                    await _fileHelper.DelWriteListAsync(min, max);
                    flist = Enumerable.Range(min, max - min + 1).ToArray();
                }
            }
            else
            {
                flist = Enumerable.Range(min, max - min + 1).ToArray();
            }

        }
        else
        {
            flist = Enumerable.Range(min, max - min + 1).ToArray();
        }
        Stop.IsEnabled = true;
        Start.IsEnabled = false;
        Stop.Visibility = Microsoft.UI.Xaml.Visibility.Visible;
        Start.Visibility = Microsoft.UI.Xaml.Visibility.Collapsed;
        InitLabelMargin();
        ChangeLabelPosition(once);
        running = true;
        if (mode != 3)
        {
            try
            {
                while (running)
                {
                    Gennum(once); //Gennum 方法已改为异步版本
                    await Task.Delay(delay);
                }
            }
            finally
            {

            }

        }
        else
        {
            while (running)
            {
                Gennum(once); //Gennum 方法已改为异步版本
                await Task.Delay(delay);
            }
            flist = Enumerable.Range(min, max - min + 1).ToArray();
            GenNumFromComplexList(once);
            List<TextBlock> allTextBlocks = new List<TextBlock>
        {
            Num1, Num2, Num3, Num4, Num5, Num6,
            Num7, Num8, Num9, Num10, Num11, Num12
        };
            await WriteTextBlocksToCsvAsync(allTextBlocks, "history.csv", min, max, once);
        }


    }
    public void MakeComplexList(int[] possibilities, int min)
    {
        int listindex = 0;
        complexlist = null;
        List<int> dynamicArray = new List<int>();
        for (int i = 0; i < flist.Length; i++)
        {
            for (int j = 0; j < possibilities[i]; j++)
            {
                dynamicArray.Add(flist[i]);
                listindex++;
            }
        }
        complexlist = dynamicArray.ToArray();
    }
    public static void FindResultIndex(int result)
    {
        resultindex = 0;
        for (int i = 0; i < flist.Length; i++)
        {
            if (flist[i] == result)
            {
                resultindex = i;
            }
        }
    }
    public async void GenNumFromComplexList(int once)
    {
        Random random = new Random();
        int randomIndex = 0;
        List<int> resultlist = new List<int>();
        List<int> posslist = new List<int>();
        possibilities = await _fileHelper.ReadPossibilitiesListAsync(min, max);
        for (int i = 0; i < once; i++)
        {
            MakeComplexList(possibilities, min);
            randomIndex = random.Next(complexlist.Length);

            // 使用随机索引从数组中选取元素
            resultlist.Add(complexlist[randomIndex]);
            possibilities[resultlist[i] - min] = 0;
        }
        result = resultlist.ToArray();
        possibilities = await _fileHelper.ReadPossibilitiesListAsync(min, max);
        MakeComplexList(possibilities, min);
        HashSet<int> setToRemove = new HashSet<int>(result);

        // 创建一个新的数组来存放结果
        List<int> resultArray = new List<int>();

        // 遍历第一个数组，如果元素不在setToRemove中则添加至结果列表
        foreach (int item in flist)
        {
            if (!setToRemove.Contains(item))
            {
                resultArray.Add(item);
            }
        }

        // 将结果列表转换为数组（如果需要的话）
        int[] newArray = resultArray.ToArray();
        complexlist = complexlist.Concat(newArray).ToArray();
        int index = 0;
        List<TextBlock> textBlockCollection = new List<TextBlock>();
        textBlockCollection.Add(Num1);
        textBlockCollection.Add(Num2);
        textBlockCollection.Add(Num3);
        textBlockCollection.Add(Num4);
        textBlockCollection.Add(Num5);
        textBlockCollection.Add(Num6);
        textBlockCollection.Add(Num7);
        textBlockCollection.Add(Num8);
        textBlockCollection.Add(Num9);
        textBlockCollection.Add(Num10);
        textBlockCollection.Add(Num11);
        textBlockCollection.Add(Num12);

        foreach (var label in textBlockCollection)
        {
            if (index < once)
            {
                label.Text = result[index].ToString();

                index++;
            }
            else
            {
                break;
            }
        }
        GenPossibilitiesListAsync(min, max);

    }
    //public void GenPossibilitiesList(int min, int max)
    //{

    //    possibilities = new int[max - min + 1];

    //    // 遍历数字列表，更新计数数组
    //    foreach (int num in complexlist)
    //    {
    //        if (min <= num && num <= max)
    //        {
    //            possibilities[num - min]++;
    //        }
    //    }
    //    for (int i = 0; i < possibilities.Length; i++)
    //    {
    //        if (possibilities[i] < 2)
    //        {
    //            goto Goon;
    //        }
    //    }
    //    for (int j = 0; j < possibilities.Length; j++)
    //    {
    //        possibilities[j] -= 1;
    //    }
    //Goon:
    //    string config = min.ToString() + "to" + max.ToString();
    //    string folderpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "\\possibilities";
    //    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "\\possibilities\\" + config;
    //    string filePath = $"{path}.txt";
    //    if (!Directory.Exists(folderpath))
    //    {
    //        Directory.CreateDirectory(folderpath);
    //    }
    //    if (!File.Exists(filePath))
    //    {
    //        // 文件不存在，创建文件
    //        using (FileStream fs = File.Create(filePath))
    //        {
    //            // 文件已成功创建，此处可选择写入初始内容，或保持为空
    //        }
    //    }
    //    using (StreamWriter writer = new StreamWriter(filePath, false)) // false表示覆盖写入
    //    {
    //        foreach (var item in possibilities)
    //        {
    //            writer.WriteLine(item);
    //        }
    //    }
    //}

    //public int[] ReadPossibilitiesList(int min, int max)
    //{
    //    string config = min.ToString() + "to" + max.ToString();
    //    string folderpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "\\possibilities";
    //    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "\\possibilities\\" + config;
    //    string filePath = $"{path}.txt";

    //    if (!File.Exists(filePath))
    //    {
    //        int[] fill = new int[max - min + 1];
    //        for (int i = 0; i < max - min + 1; i++)
    //        {
    //            fill[i] = 1;
    //        }
    //        return fill;
    //    }

    //    List<int> resultList = new List<int>();

    //    using (StreamReader reader = new StreamReader(filePath))
    //    {
    //        string line;
    //        while ((line = reader.ReadLine()) != null)
    //        {
    //            if (int.TryParse(line, out int number))
    //            {
    //                resultList.Add(number);
    //            }
    //        }
    //    }

    //    return resultList.ToArray();

    //}
    //public int[] ReadArrayFromFile(int min, int max)
    //{
    //    string config = min.ToString() + "to" + max.ToString();
    //    string folderpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "\\whitelists";
    //    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "\\whitelists\\" + config;
    //    string filePath = $"{path}.txt";

    //    if (!File.Exists(filePath))
    //    {
    //        return null;
    //    }

    //    List<int> resultList = new List<int>();

    //    using (StreamReader reader = new StreamReader(filePath))
    //    {
    //        string line;
    //        while ((line = reader.ReadLine()) != null)
    //        {
    //            if (int.TryParse(line, out int number))
    //            {
    //                resultList.Add(number);
    //            }
    //        }
    //    }

    //    return resultList.ToArray();
    //}
    //public void DelWriteList(int min, int max)
    //{
    //    string config = min.ToString() + "to" + max.ToString();
    //    string folderpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "\\whitelists";
    //    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "\\whitelists\\" + config;
    //    string filePath = $"{path}.txt";
    //    using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
    //    {
    //        // 移动文件指针到文件开始位置
    //        fileStream.Seek(0, SeekOrigin.Begin);

    //        // 清空文件内容
    //        fileStream.SetLength(0); // 这行代码将文件长度设置为0，从而清空内容
    //    }
    //}
    //public void WriteArrayToFile(int[] array, int min, int max)
    //{
    //    string config = min.ToString() + "to" + max.ToString();
    //    string folderpath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "\\whitelists";
    //    string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory) + "\\whitelists\\" + config;
    //    string filePath = $"{path}.txt";
    //    if (!Directory.Exists(folderpath))
    //    {
    //        Directory.CreateDirectory(folderpath);
    //    }
    //    if (!File.Exists(filePath))
    //    {
    //        // 文件不存在，创建文件
    //        using (FileStream fs = File.Create(filePath))
    //        {
    //            // 文件已成功创建，此处可选择写入初始内容，或保持为空
    //        }
    //    }
    //    using (StreamWriter writer = new StreamWriter(filePath, false)) // false表示覆盖写入
    //    {
    //        foreach (var item in array)
    //        {
    //            writer.WriteLine(item);
    //        }
    //    }
    //}
    public async Task GenPossibilitiesListAsync(int min, int max)
    {
        possibilities = new int[max - min + 1];

        // 遍历数字列表，更新计数数组
        foreach (int num in complexlist)
        {
            if (min <= num && num <= max)
            {
                possibilities[num - min]++;
            }
        }

        for (int i = 0; i < possibilities.Length; i++)
        {
            if (possibilities[i] < 2)
            {
                goto Goon;
            }
        }

        for (int j = 0; j < possibilities.Length; j++)
        {
            possibilities[j] -= 1;
        }

    Goon:
        string config = $"{min}to{max}";
        StorageFolder localFolder = ApplicationData.Current.LocalFolder;
        StorageFolder folder = await localFolder.CreateFolderAsync("possibilities", CreationCollisionOption.OpenIfExists);
        StorageFile file = await folder.CreateFileAsync($"{config}.txt", CreationCollisionOption.OpenIfExists);

        // 检查文件是否已存在，如果不存在则创建
        if (file == null)
        {
            file = await folder.CreateFileAsync($"{config}.txt", CreationCollisionOption.OpenIfExists);
        }

        using (Stream stream = await file.OpenStreamForWriteAsync())
        using (StreamWriter writer = new StreamWriter(stream))
        {
            foreach (var item in possibilities)
            {
                writer.WriteLine(item);
            }
        }
    }
}
public static class ListExtensions
{
    public static void AddIfNew<T>(this List<T> list, T item) where T : IEquatable<T>
    {
        if (list != null)
        {

            if (!list.Contains(item))
            {
                list.Add(item);
            }
        }
    }
}

public class FileHelper
{
    private static readonly StorageFolder LocalFolder = ApplicationData.Current.LocalFolder;

    public async Task<int[]> ReadPossibilitiesListAsync(int min, int max)
    {
        string config = $"{min}to{max}";
        string fileName = $"{config}.txt";
        StorageFile file = await LocalFolder.TryGetItemAsync(fileName) as StorageFile;

        if (file == null)
        {
            int[] fill = new int[max - min + 1];
            for (int i = 0; i < max - min + 1; i++)
            {
                fill[i] = 1;
            }
            return fill;
        }

        List<int> resultList = new List<int>();
        using (StreamReader reader = new StreamReader(await file.OpenStreamForReadAsync()))
        {
            string line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                if (int.TryParse(line, out int number))
                {
                    resultList.Add(number);
                }
            }
        }

        return resultList.ToArray();
    }

    public async Task<int[]> ReadArrayFromFileAsync(int min, int max)
    {
        string config = $"{min}to{max}";
        string fileName = $"{config}.txt";
        StorageFile file = await LocalFolder.TryGetItemAsync(fileName) as StorageFile;

        if (file == null)
        {
            return null;
        }

        List<int> resultList = new List<int>();
        using (StreamReader reader = new StreamReader(await file.OpenStreamForReadAsync()))
        {
            string line;
            while ((line = await reader.ReadLineAsync()) != null)
            {
                if (int.TryParse(line, out int number))
                {
                    resultList.Add(number);
                }
            }
        }

        return resultList.ToArray();
    }

    public async Task DelWriteListAsync(int min, int max)
    {
        string config = $"{min}to{max}";
        string fileName = $"{config}.txt";
        StorageFile file = await LocalFolder.TryGetItemAsync(fileName) as StorageFile;

        if (file != null)
        {
            using (IRandomAccessStream stream = await file.OpenAsync(FileAccessMode.ReadWrite))
            {
                stream.Size = 0; // Clear the file content
            }
        }
    }

    public async Task WriteArrayToFileAsync(int[] array, int min, int max)
    {
        string config = $"{min}to{max}";
        StorageFolder localFolder = ApplicationData.Current.LocalFolder;
        StorageFolder folder = await localFolder.CreateFolderAsync("whitelists", CreationCollisionOption.OpenIfExists);
        StorageFile file = await folder.CreateFileAsync($"{config}.txt", CreationCollisionOption.OpenIfExists);

        // 检查文件是否已存在，如果不存在则创建
        if (file == null)
        {
            file = await folder.CreateFileAsync($"{config}.txt", CreationCollisionOption.ReplaceExisting);
        }

        using (Stream stream = await file.OpenStreamForWriteAsync())
        using (StreamWriter writer = new StreamWriter(stream))
        {
            foreach (var item in array)
            {
                await writer.WriteLineAsync(item.ToString());
            }
        }
    }

}
