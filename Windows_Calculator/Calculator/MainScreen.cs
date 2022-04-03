using System.Windows.Forms;
using Calculator.Entities;
using Calculator;
using System.Collections.Generic;

namespace Calculator
{
    public partial class MainScreen : Form
    {
        public string Dysplay { get; set; }
        public List<char> ScreenItems { get; set; } = new List<char>();
        
        public MainScreen()
        {
            InitializeComponent();              
            DysplayTextBox.Text = Dysplay;

        }

        public void AddScreenItem(char item)
        {
            ScreenItems.Add(item);
            Dysplay += item;
            DysplayTextBox.Text = Dysplay;
        }

        public void RemoveLastScreenItem()
        {
            int lastItemIndex = ScreenItems.Count - 1;
            if (lastItemIndex != -1)
            {                
                ScreenItems.Remove(ScreenItems[lastItemIndex]);
                RemoveLastNumberOf(Dysplay);
                DysplayTextBox.Text = Dysplay;
            }
        }

        public string RemoveLastNumberOf(string variable) 
        {
            string newVariable = "";
            if (variable.Length > 0) {

                int lastItemIndex = variable.Length - 1;
                for (int i = 0; i < lastItemIndex; i++)
                {
                    newVariable += variable[i];                    
                }
            }

            return newVariable;
        }

        private void NumberOneButton_Click(object sender, System.EventArgs e)
        {
            AddScreenItem('1');
        }

        private void NumberTwoButton_Click(object sender, System.EventArgs e)
        {
            AddScreenItem('2');
        }

        private void NumberThreeButton_Click(object sender, System.EventArgs e)
        {
            AddScreenItem('3');
        }

        private void NumberFourButton_Click(object sender, System.EventArgs e)
        {
            AddScreenItem('4');
        }

        private void NumberFiveButton_Click(object sender, System.EventArgs e)
        {
            AddScreenItem('5');
        }

        private void NumberSixButton_Click(object sender, System.EventArgs e)
        {
            AddScreenItem('6');
        }

        private void NumberSevenButton_Click(object sender, System.EventArgs e)
        {
            AddScreenItem('7');
        }

        private void NumberEightButton_Click(object sender, System.EventArgs e)
        {
            AddScreenItem('8');
        }

        private void NumberNineButton_Click(object sender, System.EventArgs e)
        {
            AddScreenItem('9');
        }

        private void NumberZeroButton_Click(object sender, System.EventArgs e)
        {
            AddScreenItem('0');
        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            RemoveLastScreenItem();
        }       
    }
}
