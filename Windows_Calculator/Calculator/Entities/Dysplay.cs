using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using Calculator.Entities;

namespace Calculator.Entities
{
    public class Dysplay
    {
        //ATT TELA, MOSTRAR ITENS, LIMPAR TELA, LIMPAR NUMEROS, ADC NUM NA TELA, MOSTRAR RESULT
        public Entities Entities { get; set; } = new Entities();

        public void AddNumbersOnScreen() 
        {
        
        }

        public void RemoveLastNumber()
        {

        }

        public List<string> ShowItemsOnTheScreen() 
        {
            RefreshScreen();
            return Entities.Items;
        }

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
