using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Entities
{
    public class CalculatorEntities
    {
        public List<char> ScreenItems { get; private set; } = new List<char> { '0' };
        public List<double> Numbers { get; private set; } = new List<double>();
        public List<string> Operators { get; private set; } = new List<string>();        

        public void GetNumber(double number) 
        {
            Numbers.Add(number);
        }

        public void GetOperator(string oprt) 
        {
            Operators.Add(oprt);
        }

        public void ClearAll() 
        {
            ScreenItems.Clear();
            Numbers.Clear();
            Operators.Clear();
        }

        //ATT TELA, MOSTRAR ITENS, LIMPAR TELA, LIMPAR NUMEROS, ADC NUM NA TELA, MOSTRAR RESULT



        public string ShowResult()
        {
            return " ";
        }

        public void RefreshScreen()
        {
            
        }

        public void ClearTheRightSideNumber()
        {

        }

        public void ClearAllNumbers()
        {

        }
    }
}
