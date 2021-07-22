using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgileDesign.WpfDemo.Views.Window;
using AgileDesignThemes.Wpf;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace AgileDesign.WpfDemo.ViewModels
{
    public class MessageUcViewModel: ObservableObject
    {
        public RelayCommand OpenDialogWindowCommand => new(OpenDialogWindow);
        public RelayCommand OpenWindowCommand => new(OpenWindow);
        public RelayCommand InfoCommand => new(Info);
        public RelayCommand ErrorCommand => new(Error);
        public RelayCommand SuccessCommand => new(Success);
        public RelayCommand WarningCommand => new(Warning);

        private void OpenDialogWindow()
        {
            var main = new MessageWindow() { Width = 500, Height = 500 };
            main.Show();
        }
        private void OpenWindow()
        {
            var main = new MessageWindow() { Width = 500, Height = 500 };
            main.ShowDialog();
        }

        private void Info() => Message.Info("This is a normal message.");
        private void Error() => Message.Error("This is a Error message.",5);
        private void Success() => Message.Success("This is a Success message.");
        private void Warning() => Message.Warning("This is a Warning message.");

    }
}
