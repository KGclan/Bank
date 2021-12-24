using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.models
{
    public class Account
    {
        public int ID { get; set; }
        public int BankID { get; set; }
        public int AggrementID { get; set; }
        public int TypeID { get; set; }
        public int AccountNumber { get; set; }
    }
}
