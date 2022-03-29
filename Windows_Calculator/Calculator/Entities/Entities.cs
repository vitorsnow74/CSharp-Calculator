using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Entities
{
    public class Entities
    {
        public List<string> Items { get; set; }
        public List<double> Numbers { get; set; } = new List<double>();
        public List<string> Operators { get; set; }
    }
}
