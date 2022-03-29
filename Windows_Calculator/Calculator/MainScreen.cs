using System.Windows.Forms;
using Calculator.Entities.Functions;
using Calculator.Entities.Views;

namespace Calculator
{
    public partial class MainScreen : Form
    {
        CalculatorFunctions functions = new CalculatorFunctions();
        Dysplay dysplayItens = new Dysplay();

        public MainScreen()
        {
            InitializeComponent();
            DysplayTextBox.Text = dysplayItens.ToString();

        }
        
        private void NumberOneButton_Click(object sender, System.EventArgs e)
        {
            functions.AddKeyboardInput("1");
            dysplayItens.RefreshTextBox();
        }

        private void NumberTwoButton_Click(object sender, System.EventArgs e)
        {
            functions.AddKeyboardInput("2");
            dysplayItens.RefreshTextBox();
        }

        private void NumberThreeButton_Click(object sender, System.EventArgs e)
        {
            functions.AddKeyboardInput("3");
            dysplayItens.RefreshTextBox();
        }

        private void NumberFourButton_Click(object sender, System.EventArgs e)
        {
            functions.AddKeyboardInput("4");
            dysplayItens.RefreshTextBox();
        }

        private void NumberFiveButton_Click(object sender, System.EventArgs e)
        {
            functions.AddKeyboardInput("5");
            dysplayItens.RefreshTextBox();
        }

        private void NumberSixButton_Click(object sender, System.EventArgs e)
        {
            functions.AddKeyboardInput("6");
            dysplayItens.RefreshTextBox();
        }

        private void NumberSevenButton_Click(object sender, System.EventArgs e)
        {
            functions.AddKeyboardInput("7");
            dysplayItens.RefreshTextBox();
        }

        private void NumberEightButton_Click(object sender, System.EventArgs e)
        {
            functions.AddKeyboardInput("8");
            dysplayItens.RefreshTextBox();
        }

        private void NumberNineButton_Click(object sender, System.EventArgs e)
        {
            functions.AddKeyboardInput("9");
            dysplayItens.RefreshTextBox();
        }

        private void NumberZeroButton_Click(object sender, System.EventArgs e)
        {
            functions.AddKeyboardInput("0");
            dysplayItens.RefreshTextBox();
        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            functions.ClearScreen();
            dysplayItens.RefreshTextBox();
        }       
    }
}
