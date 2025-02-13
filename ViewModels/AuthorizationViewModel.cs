using _10._02.Models;
using _10._02.Models.Data;
using System.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _10._02.Views;

namespace _10._02.ViewModels
{
    class AuthorizationViewModel
    {
        public MyDatabase db = new MyDatabase();
        public string Login {  get; set; }
        public string Password { get; set; }

        public RelayCommand LogInCommand { get; set; }

        public AuthorizationViewModel()
        {
            LogInCommand = new RelayCommand(LogIn);
        }

        void LogIn(object o)
        {
            var u = db.Engineers.Where(x => x.Login == Login && x.Password == Password).FirstOrDefault();
            if (u != null)
            {
                MainWindow w = new MainWindow();
                Application.Current.MainWindow.Close();
                Application.Current.MainWindow = w;
                Application.Current.MainWindow.Show();
            }
            else
                MessageBox.Show("Incorrect login/password");
        }

    }
}
