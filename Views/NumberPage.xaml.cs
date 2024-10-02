using Windows.Storage;
using Random_Number_Generator.ViewModels;
using Random_Number_Generator.Core.Models;
using Microsoft.UI.Xaml.Controls;
using System.Diagnostics;
using Random_Number_Generator.Core.Services;
using CommunityToolkit.WinUI.UI.Controls;
using Microsoft.UI.Xaml.Navigation;
using System.Reflection.Metadata;
using Microsoft.VisualBasic;

namespace Random_Number_Generator.Views
{
    public sealed partial class NumberPage : Page
    {
        public NumberViewModel ViewModel { get; }
        public NumberPage()
        {
            InitializeComponent();
            ViewModel = (NumberViewModel)DataContext;
            if (ViewModel == null)
            {
                // 如果 DataContext 为空，则手动创建 ViewModel 并设置 DataContext
                ViewModel = new NumberViewModel(new NumberHistoryDataService());
                DataContext = ViewModel;
            }
            InitializeAsync();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            ViewModel.OnNavigatedTo(e.Parameter);
        }
        private async void InitializeAsync()
        {
            // 获取应用本地文件夹路径
            StorageFolder localFolder = ApplicationData.Current.LocalFolder;

            // 创建文件路径
            string fileName = "history.csv";
            StorageFile file = await localFolder.CreateFileAsync(fileName, CreationCollisionOption.OpenIfExists);

            // 读取文件内容
            string fileContent = await FileIO.ReadTextAsync(file);

            // 解析CSV内容
            List<NumberHistory> numberHistories = ParseCsv(fileContent);

            // 将解析后的数据加载到ViewModel
            try
            {
                var viewModel = App.GetService<NumberViewModel>();
                viewModel.LoadData(numberHistories);
            }
            catch (Exception ex)
            {
                // 记录异常信息
                Debug.WriteLine($"Failed to get NumberViewModel: {ex.Message}");
            }
        }

        private List<NumberHistory> ParseCsv(string csvContent)
        {
            var numberHistories = new List<NumberHistory>();

            if (string.IsNullOrWhiteSpace(csvContent))
            {
                return numberHistories;
            }

            var lines = csvContent.Split('\n');
            foreach (var line in lines)
            {
                var fields = line.Split(',');
                if (fields.Length >= 4)
                {
                    DateTime date;
                    int from, to, result;

                    if (DateTime.TryParse(fields[0], out date) && int.TryParse(fields[1], out from) && int.TryParse(fields[2], out to) && int.TryParse(fields[3], out result))
                    {
                        numberHistories.Add(new NumberHistory
                        {
                            Date = date.ToString(),
                            From = from,
                            To = to,
                            Result = result
                        });
                    }
                }
            }

            return numberHistories;
        }
    }
}
