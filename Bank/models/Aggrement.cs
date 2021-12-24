using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.models
{
    public class Aggrement
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public string DataOpen { get; set; }
        public string DataClose { get; set; }
        public string Note{ get; set; }

        public static implicit operator List<object>(Aggrement v)
        {
            throw new NotImplementedException();
        }
    }
}
