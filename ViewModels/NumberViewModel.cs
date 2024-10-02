using CommunityToolkit.Mvvm.ComponentModel;
using Random_Number_Generator.Contracts.ViewModels;
using Random_Number_Generator.Core.Contracts.Services;
using Random_Number_Generator.Core.Models;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Random_Number_Generator.ViewModels
{
    public partial class NumberViewModel : ObservableRecipient, INavigationAware
    {
        private readonly INumberHistoryDataService _sampleDataService;

        public ObservableCollection<NumberHistory> Source { get; } = new ObservableCollection<NumberHistory>();

        public NumberViewModel(INumberHistoryDataService sampleDataService)
        {
            _sampleDataService = sampleDataService ?? throw new ArgumentNullException(nameof(sampleDataService));
        }

        public async void OnNavigatedTo(object parameter)
        {
            await LoadData();
        }

        public void OnNavigatedFrom()
        {
        }

        public void LoadData(List<NumberHistory> data)
        {
            AddDataToList(data);
        }

        private void AddDataToList(IEnumerable<NumberHistory> data)
        {
            Source.Clear();
            foreach (var item in data)
            {
                Source.Add(item);
            }
        }

        private async Task LoadData()
        {
            try
            {
                var data = await _sampleDataService.GetGridDataAsync();
                AddDataToList(data);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading data: {ex.Message}");
            }
        }
    }
}
