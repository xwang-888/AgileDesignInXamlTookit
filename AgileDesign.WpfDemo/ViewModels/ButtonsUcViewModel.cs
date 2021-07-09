using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace AgileDesign.WpfDemo.ViewModels
{
    public class ButtonsUcViewModel : ObservableObject
    {
        private bool _isIndicator;

        public bool IsIndicator
        {
            get => _isIndicator;
            set { _isIndicator = value; OnPropertyChanged(); }
        }


        public AsyncRelayCommand LoadingBtnCommand => new(LoadingBtn);

        private async Task LoadingBtn()
        {
            IsIndicator = true;
            await Task.Delay(3000);
            IsIndicator = false;
        }



    }
}
