using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.models
{
    public class Banks
    {
        public int ID { get; set; }
        public string NameFull { get; set; }
        public string NameShort { get; set; }
        public int Inn { get; set; }
        public int Bik { get; set; }
        public int CorAccount { get; set; }
        public int Account { get; set; }
        public string City { get; set; }
    }
}
