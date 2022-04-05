using System.Windows.Forms;
using System.Collections.Generic;

namespace Calculator
{
    public partial class MainScreen : Form
    {
        //Dysplay Atributes:
        public string Dysplay { get; set; }
        public string SecondDysplay { get; set; }

        //Validation Atributes
        public bool OperatorWasSelected { get; set; }

        //Calculator Atributes:
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public char OperateChar { get; set; }
        public double Result { get; set; }

        //Initialize:
        public MainScreen()
        {
            InitializeComponent();
            RefreshDysplayValue();
        }

        //Calculator Methods:
        public void AddNewScreenItem(char item)
        {
            if (!OperatorWasSelected)
            {
                Dysplay += item;
                RefreshDysplayValue();
            }
            else 
            {
                SecondDysplay += item;
                RefreshSecondDysplayValue();
            }            
        }

        public void RemoveLastScreenItem()
        {
            if (!OperatorWasSelected)
            {
                if (Dysplay.Length > 0)
                {
                    Dysplay = Dysplay.Remove(Dysplay.Length - 1);
                    RefreshDysplayValue();
                }
            }
            else 
            {
                if (SecondDysplay.Length > 0) 
                {
                    SecondDysplay = SecondDysplay.Remove(Dysplay.Length - 1);
                    RefreshSecondDysplayValue();
                }
            }

            
        }

        public void RefreshDysplayValue()
        {
            DysplayTextBox.Text = Dysplay;
        }

        public void RefreshSecondDysplayValue() 
        {
            SecondDysplayTextBox.Text = SecondDysplay;
        }

        public void ClearSecondNumberValue() 
        {
            SecondDysplay = "0";
            RefreshSecondDysplayValue();
        }

        public void ClearEverything()
        {
            Dysplay = "0";
            SecondDysplay = "";
            RefreshDysplayValue();
            RefreshSecondDysplayValue();
            OperatorWasSelected = false;
        }

        public void SetOperator(char operationchar)
        {
            if (!OperatorWasSelected)
            {
                GetFirstNumber();

                OperateChar = operationchar;
                FormatDysplayWithOperator();
            }
            else
            {
                ChangeOperator(operationchar);
            }

            OperatorWasSelected = true;
            RefreshDysplayValue();
        }

        public void ChangeOperator(char operationchar)
        {
            Dysplay = Dysplay.Replace(OperateChar, operationchar);
            OperateChar = operationchar;
        }

        public void FormatDysplayWithOperator()
        {
            Dysplay += OperateChar;
            RefreshDysplayValue();
        }

        public void GetFirstNumber()
        {
            FirstNumber = double.Parse(Dysplay);
        }

        public void GetSecondNumber()
        {

        }

        public void GetResult()
        {

        }

        //Button Actions:
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

        private void PlusButton_Click(object sender, System.EventArgs e)
        {
            SetOperator('+');
        }

        private void SubtractButton_Click(object sender, System.EventArgs e)
        {
            SetOperator('-');
        }

        private void MultiplyButton_Click(object sender, System.EventArgs e)
        {
            SetOperator('*');
        }

        private void DivisionButton_Click(object sender, System.EventArgs e)
        {
            SetOperator('/');
        }

        private void CeButton_Click(object sender, System.EventArgs e)
        {
            ClearSecondNumberValue();
        }
    }
}
