using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Calculator.Entities.Controller
{
    public class Controller
    {
        public StringBuilder DysplayItems { get; set; } = new StringBuilder();

        public Controller() 
        {
        }

        public void AddKeyboardInput(string input) 
        {
            DysplayItems.Append(input);
        }
        public void RemoveKeyboardInput() 
        {
            DysplayItems.Clear();
        }
          
    }
}
