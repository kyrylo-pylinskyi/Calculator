using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructor
        /// <summary>
        /// Main Window constructor of the program
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        #endregion

        #region Control buttons
        /// <summary>
        /// Method for button named "CE" to Clear TextBox
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void CEButton_Click(object sender, RoutedEventArgs e)
        {
            this.EquationInput.Text = string.Empty;
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "DELL" to Dellete last character in TextBox
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void DellButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteTextValue();
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "=" to calculate the result of equation 
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            CalculateEquation();
            EquationInputFocus();
        }
        #endregion

        #region Operations buttons
        /// <summary>
        /// Method for button named "%" to add division (%) symbol  
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void ProcentButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("%");
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "/" to add division (/) symbol  
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("/");
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "*" to add multiply (*) symbol  
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void MultiplyButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("*");
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "-" to add minus (-) symbol  
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void MinsButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("-");
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "+" to add plus (+) symbol  
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("+");
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "+-" to invert the sign of the result (positive to negative or negative to positive)  
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void PlusMinusButton_Click(object sender, RoutedEventArgs e)
        {
            decimal answer = (-1) * decimal.Parse(ParseOperation());
            this.EquationResult.Content = answer.ToString();
            EquationInputFocus();
        }
        #endregion

        #region Numbers buttons

        /// <summary>
        /// Method for button named "1" to insert text value of (1) to TextBox
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void OneButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("1");
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "2" to insert text value of (2) to TextBox
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("2");
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "3" to insert text value of (3) to TextBox
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("3");
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "4" to insert text value of (4) to TextBox
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void FourButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("4");
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "5" to insert text value of (5) to TextBox
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("5");
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "6" to insert text value of (6) to TextBox
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void SixButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("6");
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "7" to insert text value of (7) to TextBox
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("7");
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "8" to insert text value of (8) to TextBox
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void EightButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("8");
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "9" to insert text value of (9) to TextBox
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void NineButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("9");
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "0" to insert text value of (0) to TextBox
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue("0");
            EquationInputFocus();
        }

        /// <summary>
        /// Method for button named "." to insert text value of (.) to TextBox
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event</param>
        private void DotButton_Click(object sender, RoutedEventArgs e)
        {
            InsertTextValue(".");
            EquationInputFocus();
        }
        #endregion

        #region PrivateMethods

        /// <summary>
        /// Sets back focus to input
        /// </summary>
        private void EquationInputFocus()
        {
            this.EquationInput.Focusable = true;
            this.EquationInput.Focus();
        }

        /// <summary>
        /// Add text value to Input field
        /// </summary>
        /// <param name="value"></param>
        private void InsertTextValue(string value)
        {
            // Remember slection
            var selectionStart = this.EquationInput.SelectionStart;

            // Insert the value
            this.EquationInput.Text = this.EquationInput.Text.Insert(this.EquationInput.SelectionStart, value);

            // Restore the selection
            this.EquationInput.SelectionStart = selectionStart + value.Length;

            // Set Selection Length to zero
            this.EquationInput.SelectionLength = 0;

        }

        /// <summary>
        /// Delete one character
        /// </summary>
        private void DeleteTextValue()
        {

            // return if we dont have value to delete
            if (EquationInput.Text.Length == 0)
                return;

            // Set selector to index one left
            this.EquationInput.SelectionStart -= 1;

            // Remember slection
            var selectionStart = this.EquationInput.SelectionStart;

            // Delete the character
            this.EquationInput.Text = this.EquationInput.Text.Remove(selectionStart, 1);

            // Restore the selection
            this.EquationInput.SelectionStart = selectionStart + 1;

            // Set Selection Length to zero
            this.EquationInput.SelectionLength = 0;

        }


        /// <summary>
        /// Calculates the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {
            // set new content for EquationResult TextBox
            this.EquationResult.Content = ParseOperation();

            // Focus the user input text
            EquationInputFocus();
        }

        /// <summary>
        /// Parses the users equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                // Get the users equation input
                var input = this.EquationInput.Text;

                // Remove all spaces
                input = input.Replace(" ", "");

                // Create a new top-level operation
                var operation = new Operation();
                var leftSide = true;

                // Loop through each character of the input
                // starting from the left working to the right
                for (int i = 0; i < input.Length; i++)
                {
                    // Check if the current character is a number
                    if ("0123456789.".Any(c => input[i] == c))
                    {
                        if (leftSide)
                        {
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                        }
                        else
                        {
                            operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                        }

                    }
                    // If it is an operator ( + - * / ) set the operator type
                    else if ("+-*/%".Any(c => input[i] == c))
                    {
                        // Get the operator type
                        var operatorType = GetOperationType(input[i]);

                        if (operation.RightSide.Length != 0)
                        {
                            operation.LeftSide = CalculateOperation(operation);

                            operation.RightSide = string.Empty;
                        }


                        // Check if we actually have a left side number
                        if (operation.LeftSide.Length == 0)
                        {
                            // Check the operator is not a minus (as they could be creating a negative number)
                            if (operatorType != OperationType.Minus)
                                throw new InvalidOperationException($"Operator (+ * / or more than one -) specified without an left side number");

                            // If we got here, the operator type is a minus, and there is no left number currently, so add the minus to the number
                            operation.LeftSide += input[i];
                        }
                        else
                        {
                            // If we get here, we have a left number and now an operator, so we want to move to the right side

                            // Set the operation type
                            operation.OperationType = operatorType;

                            // Move to the right side
                            leftSide = false;
                        }
                    }
                }

                // If we are done parsing, and there were no exceptions
                // calculate the current operation
                return CalculateOperation(operation);
            }
            catch (Exception ex)
            {
                return $"Invalid equation. {ex.Message}";
            }
        }

        /// <summary>
        /// Calculates an <see cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="operation">The operation to calculate</param>
        private string CalculateOperation(Operation operation)
        {
            // Store the number values of the string representations
            decimal left = 0;
            decimal right = 0;

            // Check if we have a valid left side number
            if (string.IsNullOrEmpty(operation.LeftSide))
                throw new InvalidOperationException($"Left side of the operation was not a number. {operation.LeftSide}");
            else
                left = decimal.Parse(operation.LeftSide, new NumberFormatInfo() { NumberDecimalSeparator = "." });

            // Check if we have a valid right side number
            if (string.IsNullOrEmpty(operation.RightSide))
                throw new InvalidOperationException($"Right side of the operation was not a number. {operation.RightSide}");
            else
                right = decimal.Parse(operation.RightSide, new NumberFormatInfo() { NumberDecimalSeparator = "." });

            try
            {
                // Deside what the type of operation we going to calculate
                switch (operation.OperationType)
                {
                    case OperationType.Plus:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    case OperationType.Procent:
                        return (left % right).ToString();
                    default:
                        throw new InvalidOperationException($"Unknown operator type when calculating operation. { operation.OperationType }");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed to calculate operation {operation.LeftSide} {operation.OperationType} {operation.RightSide}. {ex.Message}");
            }
        }

        /// <summary>
        /// Accepts a character and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">The character to parse</param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationType.Plus;
                case '-':
                    return OperationType.Minus;
                case '/':
                    return OperationType.Divide;
                case '*':
                    return OperationType.Multiply;
                case '%':
                    return OperationType.Procent;
                default:
                    throw new InvalidOperationException($"Unknown operator type { character }");
            }
        }

        /// <summary>
        /// Attempts to add a new character to the current number, checking for valid characters as it goes
        /// </summary>
        /// <param name="currentNumber">The current number string</param>
        /// <param name="newCharacter">The new character to append to the string</param>
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            // Check if there is already a . in the number
            if (newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");

            return currentNumber + newCharacter;
        }

        #endregion
    }
}
