using _10._02.Models;
using _10._02.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _10._02.ViewModels
{
    class AddClientViewModel
    {
        public RelayCommand CancelCommand { get; set; }

        public AddClientViewModel()
        {
            CancelCommand = new RelayCommand(Cancel);
        }

        void Cancel(object o)
        {
            Application.Current.Windows.OfType<AddClientWindow>().FirstOrDefault()?.Close();
        }
    }
}
