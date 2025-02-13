using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._02.Models
{
    class Request
    {
        public int Id { get; set; }
        public Client Client { get; set; }
        public Equipment Equipment { get; set; }
        public Engineer Engineer { get; set; }
        public DateTime Date = DateTime.Now;
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
