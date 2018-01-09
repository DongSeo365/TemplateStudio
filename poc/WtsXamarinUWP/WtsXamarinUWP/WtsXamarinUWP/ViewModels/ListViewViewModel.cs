﻿using System.Collections.ObjectModel;
using WtsXamarinUWP.Core.Helpers;
using WtsXamarinUWP.Mobile.Models;
using WtsXamarinUWP.Mobile.Services;

namespace WtsXamarinUWP.Mobile.ViewModels
{
    public class ListViewViewModel : Observable
    {
        private ObservableCollection<SampleOrder> _sampleData;
        private SampleOrder _selectedItem;

        public ListViewViewModel()
        {
            SampleData = SampleDataService.GetGridSampleData();
            SelectedItem = SampleData[0];
        }

        public ObservableCollection<SampleOrder> SampleData
        {
            get => _sampleData;
            private set => Set(ref _sampleData, value);
        }

        public SampleOrder SelectedItem
        {
            get => _selectedItem;
            set => Set(ref _selectedItem, value);
        }
    }
}
