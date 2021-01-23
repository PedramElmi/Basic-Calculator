using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    /// <summary>
    /// A Basic Calculator Form
    /// </summary>
    public partial class Form1 : Form
    {

        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Clearing Methods
        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">the event sender</param>
        /// <param name="e">the event arguments</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            // clears the text box input from the user
            this.UserInputText.Text = string.Empty;

            // Focus the user input text box
            FocusInputText();

        }

        /// <summary>
        /// Deletes one character where the selection locates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelButton_Click(object sender, EventArgs e)
        {

            DeleteTexValue();
            
        }

        #endregion

        #region Operator Methods
        /// <summary>
        /// this method will add / to the user input text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DivButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");

        }

        /// <summary>
        /// this method will add * to the user input text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MultButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");


        }

        /// <summary>
        /// this method will add - to the user input text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");


        }

        /// <summary>
        /// this method will add + to the user input text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");

        }

        /// <summary>
        /// this method will start the calculation of the written math expression in the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultButton_Click(object sender, EventArgs e)
        {
            // calculates the math expression in the user text box
            CalculateEquation();

            // Focus the user input text box
            FocusInputText();
        }

        private void CurlyBracesButton_Click(object sender, EventArgs e)
        {

            InsertTextValue("()");

            // correct the selection so the selection will be inside of the braces like this: (|)
            this.UserInputText.SelectionStart -= 1;
            this.UserInputText.SelectionLength = 0;

        }

        #endregion

        #region Number Methods
        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");

        }

        private void PlusMinusButton_Click(object sender, EventArgs e)
        {

            // Focus the user input text box
            FocusInputText();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");



        }


        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");


        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");


        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");


        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");


        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");


        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");


        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");


        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");


        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");

        }

        #endregion

        #region Calculate Math Expression

        /// <summary>
        /// calculates the equation with the math expression in the input text box
        /// </summary>
        private void CalculateEquation()
        {
                       
            this.CalculationResultText.Text = ParseOperation();

        }


        /// <summary>
        /// Parses the user input or the equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                // get the user equation input
                var input = this.UserInputText.Text;

                // removes all spaces
                input = input.Replace(" ", "");


                // calculates math expression with the DataTable class
                double result = Convert.ToDouble(new DataTable().Compute(input, null));


                return result.ToString();
            }
            catch (Exception ex)
            {

                return $"Invalid Equation. {ex.Message}";
            }

        }

        #endregion

        #region Private Helper

        /// <summary>
        /// focuses the user input text box
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// insert the given text to the user input text box
        /// </summary>
        /// <param name="value">the value to insert</param>
        private void InsertTextValue(string value)
        {
            // remember the selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            // restore the selection start
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            // set selection length to zero
            this.UserInputText.SelectionLength = 0;

            // Focus the user input text box
            FocusInputText();
        }

        /// <summary>
        /// Deletes the character in the selected text value
        /// </summary>
        private void DeleteTexValue()
        {

            // remember the selection start
            var selectionStart = this.UserInputText.SelectionStart;

            try
            {
                this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart - 1, 1);
                this.UserInputText.SelectionStart = selectionStart - 1;
                this.UserInputText.SelectionLength = 0;
            }

            catch (ArgumentOutOfRangeException)
            {

            }

            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
            finally
            {
                // Focus the user input text box
                FocusInputText();
            }
        }

        #endregion

    }
}
