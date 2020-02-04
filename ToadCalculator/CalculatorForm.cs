using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToadCalculator
{
    public enum operation { Add, Subtract, Multiply, Divide };
    public partial class CalculatorForm : Form
    {
        public string CurrentDisplay = "0";
        public long firstOperand = 0;
        public long secondOperand = 0;
        public operation Operation;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CurrentDisplay.Equals("0"))
                CurrentDisplay = "3";
            else
                CurrentDisplay += "3";
            DisplayResultText.Text = CurrentDisplay;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CurrentDisplay.Equals("0"))
                CurrentDisplay = "4";
            else
                CurrentDisplay += "4";
            DisplayResultText.Text = CurrentDisplay;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CurrentDisplay.Equals("0"))
                CurrentDisplay = "1";
            else
                CurrentDisplay += "1";
            DisplayResultText.Text = CurrentDisplay;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CurrentDisplay.Equals("0"))
                CurrentDisplay = "2";
            else
                CurrentDisplay += "2";
            DisplayResultText.Text = CurrentDisplay;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CurrentDisplay.Equals("0"))
                CurrentDisplay = "5";
            else
                CurrentDisplay += "5";

            DisplayResultText.Text = CurrentDisplay;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (CurrentDisplay.Equals("0"))
                CurrentDisplay = "6";
            else
                CurrentDisplay += "6";
            DisplayResultText.Text = CurrentDisplay;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (CurrentDisplay.Equals("0"))
                CurrentDisplay = "7";
            else
                CurrentDisplay += "7";
            DisplayResultText.Text = CurrentDisplay;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (CurrentDisplay.Equals("0"))
                CurrentDisplay = "8";
            else
                CurrentDisplay += "8";
            DisplayResultText.Text = CurrentDisplay;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (CurrentDisplay.Equals("0"))
                CurrentDisplay = "9";
            else
                CurrentDisplay += "9";
            DisplayResultText.Text = CurrentDisplay;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (CurrentDisplay.Equals("0"))
                CurrentDisplay = "0";
            else
                CurrentDisplay += "0";
            DisplayResultText.Text = CurrentDisplay;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Operation = operation.Add;
            firstOperand = long.Parse(CurrentDisplay);
            CurrentDisplay = "0";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Operation = operation.Subtract;
            firstOperand = long.Parse(CurrentDisplay);
            CurrentDisplay = "0";
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Operation = operation.Multiply;
            firstOperand = long.Parse(CurrentDisplay);
            CurrentDisplay = "0";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            long result = 0;
            secondOperand = long.Parse(CurrentDisplay);
            switch(Operation)
            {
                case operation.Add:
                    result = firstOperand + secondOperand;
                    break;
                case operation.Subtract:
                    result = firstOperand - secondOperand;
                    break;
                case operation.Multiply:
                    result = firstOperand * secondOperand;
                    break;
                default:
                    break;
            }

            CurrentDisplay = DisplayResultText.Text = result.ToString();
            
        }
    }
}
