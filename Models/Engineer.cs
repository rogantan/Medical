using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._02.Models
{
    class Engineer : NotifyProperty
    {
        private int _id;
        private string _lastname;
        private string _name;
        private string _otchestvo;
        private string _dolzhnost;
        private string _login;
        private string _password;

        public int Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged();
                }
            }
        }
        public string LastName
        {
            get => _lastname;
            set
            {
                if (_lastname != value)
                {
                    _lastname = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Otchestvo
        {
            get => _otchestvo;
            set
            {
                if (_otchestvo != value)
                {
                    _otchestvo = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Dolzhnost
        {
            get => _dolzhnost;
            set
            {
                if (_dolzhnost != value)
                {
                    _dolzhnost = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Login
        {
            get => _login;
            set
            {
                if (_login != value)
                {
                    _login = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
