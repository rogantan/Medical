using _10._02.Models;
using _10._02.Models.Data;
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
        public string LastName { get; set; }
        public string Name { get; set; }
        public string Otchestvo { get; set; }
        public string Phone {  get; set; }

        public RelayCommand CancelCommand { get; set; }
        public RelayCommand SaveClientCommand { get; set; }

        public AddClientViewModel()
        {
            CancelCommand = new RelayCommand(Cancel);
            SaveClientCommand = new RelayCommand(SaveClient);
        }

        void Cancel(object o)
        {
            Application.Current.Windows.OfType<AddClientWindow>().FirstOrDefault()?.Close();
        }

        void SaveClient(object o)
        {
            if (!(Phone.Length > 0 && Phone.Length < 13))
            {
                MessageBox.Show("Неверный формат номера телефона", "Ошибка");
            }
            else
            {
                MyDatabase db = new MyDatabase();
                Client client = new Client();
                client.LastName = LastName;
                client.Name = Name;
                client.Otchestvo = Otchestvo;
                client.Phone = Phone;
                db.Clients.Add(client);
                db.SaveChanges();
                MessageBox.Show("Данные клиента успешно сохранены!");
                Application.Current.Windows.OfType<AddClientWindow>().FirstOrDefault()?.Close();
            }
        }
    }
}
