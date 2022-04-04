using System.Windows.Forms;
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
            RefreshDysplayValue();
        }

        public void AddNewScreenItem(char item)
        {
            ScreenItems.Add(item);
            Dysplay += item;
            RefreshDysplayValue();
        }

        public void RemoveLastScreenItem()
        {
            int lastItemIndex = ScreenItems.Count - 1;
            if (lastItemIndex != -1)
            {                
                ScreenItems.Remove(ScreenItems[lastItemIndex]);
                Dysplay = Dysplay.Remove(Dysplay.Length - 1);
                RefreshDysplayValue();
            }
        }

        public void RefreshDysplayValue() 
        {            
            DysplayTextBox.Text = Dysplay;
        }

        public void ClearEverything() 
        {
            ScreenItems.Clear();
            Dysplay = "0";
            RefreshDysplayValue();
        }

        private void NumberOneButton_Click(object sender, System.EventArgs e)
        {
            AddNewScreenItem('1');
        }

        private void NumberTwoButton_Click(object sender, System.EventArgs e)
        {
            AddNewScreenItem('2');
        }

        private void NumberThreeButton_Click(object sender, System.EventArgs e)
        {
            AddNewScreenItem('3');
        }

        private void NumberFourButton_Click(object sender, System.EventArgs e)
        {
            AddNewScreenItem('4');
        }

        private void NumberFiveButton_Click(object sender, System.EventArgs e)
        {
            AddNewScreenItem('5');
        }

        private void NumberSixButton_Click(object sender, System.EventArgs e)
        {
            AddNewScreenItem('6');
        }

        private void NumberSevenButton_Click(object sender, System.EventArgs e)
        {
            AddNewScreenItem('7');
        }

        private void NumberEightButton_Click(object sender, System.EventArgs e)
        {
            AddNewScreenItem('8');
        }

        private void NumberNineButton_Click(object sender, System.EventArgs e)
        {
            AddNewScreenItem('9');
        }

        private void NumberZeroButton_Click(object sender, System.EventArgs e)
        {
            AddNewScreenItem('0');
        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            ClearEverything();
        }

        private void BackspaceButton_Click(object sender, System.EventArgs e)
        {
            RemoveLastScreenItem();
        }
    }
}
