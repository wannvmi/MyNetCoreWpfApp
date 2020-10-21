using System;
using System.Collections.ObjectModel;

using MyNetCoreWpfApp.Contracts.ViewModels;
using MyNetCoreWpfApp.Core.Contracts.Services;
using MyNetCoreWpfApp.Core.Models;
using MyNetCoreWpfApp.Helpers;

namespace MyNetCoreWpfApp.ViewModels
{
    public class DataGridViewModel : Observable, INavigationAware
    {
        private readonly ISampleDataService _sampleDataService;

        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

        public DataGridViewModel(ISampleDataService sampleDataService)
        {
            _sampleDataService = sampleDataService;
        }

        public async void OnNavigatedTo(object parameter)
        {
            Source.Clear();

            // TODO WTS: Replace this with your actual data
            var data = await _sampleDataService.GetGridDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }

        public void OnNavigatedFrom()
        {
        }
    }
}
