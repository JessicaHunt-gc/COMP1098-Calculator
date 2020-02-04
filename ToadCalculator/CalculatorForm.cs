using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToadCalculator
{
    public enum operation { Add, Subtract, Multiply, Divide };
    public partial class CalculatorForm : Form
    {
        private string CurrentDisplay = "0";
        private long firstOperand = 0;
        public long secondOperand = 0;
        public operation Operation;
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {            
            
        }

        /// <summary>
        /// Append to the calculator's input field the paramater number value.
        /// </summary>
        /// <param name="number">a number between 0-9 to append to the input</param>
        private void AddInput(int number)
        {          
            if (CurrentDisplay.Equals("0")) // when the current display is '0' start with the new number
                CurrentDisplay = number.ToString();
            else
                CurrentDisplay += number;
            DisplayResultText.Text = CurrentDisplay;
        }
        private void PerformOperation(operation op)
        {
            Operation = op;
            firstOperand = long.Parse(CurrentDisplay);
            CurrentDisplay = "0";
        }
        #region Numeric Button Handlers


        private void button3_Click(object sender, EventArgs e)
        {
            AddInput(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddInput(4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddInput(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddInput(2);
        }



        private void button5_Click(object sender, EventArgs e)
        {
            AddInput(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddInput(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddInput(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddInput(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddInput(9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AddInput(0);
        }

        #endregion

        #region Operation button handlers
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            PerformOperation(operation.Add);
        }



        private void buttonMinus_Click(object sender, EventArgs e)
        {

            PerformOperation(operation.Subtract);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {

            PerformOperation(operation.Multiply);
        }

        #endregion
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

        #region Testing code from class - Not calculator related

        private void DisplayResultText_TextChanged(object sender, EventArgs e)
        {

        }
        public int getValue(int toReturn)
        {
            try
            {
                throw new FormatException("Its broken!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ooops an error occured...");
                throw ex;
            }
            return toReturn;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var val = getValue(5);
                sbyte parsed = Convert.ToSByte(textBox1.Text);
                //throw new Exception("We broke it!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter a valid sbyte value, error: " + ex.Message, "Input error, you dummy");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Please enter a smaller sbyte value, error: " + ex.Message, "Input error, you dummy");
                throw ex;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //if(textBox1.Text =="")
            if(String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("You need to enter some value");
            }

        }
        #endregion
    }
}
