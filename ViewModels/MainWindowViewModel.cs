using _10._02.Models;
using _10._02.Models.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using _10._02.Views;

namespace _10._02.ViewModels
{
    class MainWindowViewModel
    {
        MyDatabase db = MyDatabase.getInstance();

        public ObservableCollection<Client> Clients { get => db.Clients.Local.ToObservableCollection(); }
        public ObservableCollection<Request> Requests { get => db.Requests.Local.ToObservableCollection(); }
        public ObservableCollection<Engineer> Engineers { get => db.Engineers.Local.ToObservableCollection(); }
        public ObservableCollection<Equipment> Equipments { get => db.Equipments.Local.ToObservableCollection(); }  

        public RelayCommand AddClientCommand {  get; set; }

        public MainWindowViewModel()
        {
            AddClientCommand = new RelayCommand(AddClient);
        }
        

        void AddClient(object o)
        {
            AddClientWindow addClientWindow = new AddClientWindow();
            addClientWindow.ShowDialog();
        }
    }
}
