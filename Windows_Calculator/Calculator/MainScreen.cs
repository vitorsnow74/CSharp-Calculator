using System.Windows.Forms;
using Calculator.Entities.Controller;

namespace Calculator
{
    public partial class MainScreen : Form
    {
        Controller controller = new Controller();

        public MainScreen()
        {
            InitializeComponent();  
            
        }
        public void RefreshTextBox() 
        {
            DysplayTextBox.Text = controller.DysplayItems.ToString();
        }
               
        private void NumberOneButton_Click(object sender, System.EventArgs e)
        {
            controller.AddKeyboardInput("1");
            RefreshTextBox();
        }

        private void NumberTwoButton_Click(object sender, System.EventArgs e)
        {
            controller.AddKeyboardInput("2");
            RefreshTextBox();
        }

        private void NumberThreeButton_Click(object sender, System.EventArgs e)
        {
            controller.AddKeyboardInput("3");
            RefreshTextBox();
        }

        private void NumberFourButton_Click(object sender, System.EventArgs e)
        {
            controller.AddKeyboardInput("4");
            RefreshTextBox();
        }

        private void NumberFiveButton_Click(object sender, System.EventArgs e)
        {
            controller.AddKeyboardInput("5");
            RefreshTextBox();
        }

        private void NumberSixButton_Click(object sender, System.EventArgs e)
        {
            controller.AddKeyboardInput("6");
            RefreshTextBox();
        }

        private void NumberSevenButton_Click(object sender, System.EventArgs e)
        {
            controller.AddKeyboardInput("7");
            RefreshTextBox();
        }

        private void NumberEightButton_Click(object sender, System.EventArgs e)
        {
            controller.AddKeyboardInput("8");
            RefreshTextBox();
        }

        private void NumberNineButton_Click(object sender, System.EventArgs e)
        {
            controller.AddKeyboardInput("9");
            RefreshTextBox();
        }

        private void NumberZeroButton_Click(object sender, System.EventArgs e)
        {
            controller.AddKeyboardInput("0");
            RefreshTextBox();
        }

        private void ClearButton_Click(object sender, System.EventArgs e)
        {
            controller.RemoveKeyboardInput();
            RefreshTextBox();
        }       
    }
}
