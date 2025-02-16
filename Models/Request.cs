using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._02.Models
{
    class Request : NotifyProperty
    {
        private int _id;
        private Client _client;
        private Equipment _equipment;
        private Engineer _engineer;
        private DateTime _date;
        private string _description;
        private string _status;
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
        public Client Client
        {
            get => _client;
            set
            {
                if (_client != value)
                {
                    _client = value;
                    OnPropertyChanged();
                }
            }
        }
        public Equipment Equipment
        {
            get => _equipment;
            set
            {
                if (value != _equipment)
                {
                    _equipment = value;
                    OnPropertyChanged();
                }
            }
        }
        public Engineer Engineer
        {
            get => _engineer;
            set
            {
                if (_engineer != value)
                {
                    _engineer = value;
                    OnPropertyChanged();
                }
            }
        }
        public DateTime Date
        {
            get => _date;
            set
            {
                if (_date != value)
                {
                    _date = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Status
        {
            get => _status;
            set
            {
                if (_status != value)
                {
                    _status = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
