namespace ReCalculator
{
    public partial class Form1 : Form
    {

        private string displayValue = "";
        private string subDisplayValue = "";
        private string subDisplay2Value = "";
        private string operationValue = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void CleanDisplay()
        {
            displayValue = "";
            subDisplayValue = "";
            subDisplay2Value = "";
            operationValue = "";
        }

        private void ClearDisplay()
        {
            if (displayValue != "")
            {
                displayValue = "";
                subDisplayValue = subDisplay2Value;
                subDisplay2Value = "";
            }
            else
            {
                subDisplayValue = "";
                subDisplay2Value = "";
                operationValue = "";
            }
            UpdateDisplay();
        }

        private void BackErase()
        {
            if (displayValue.Length > 0)
            {
                displayValue = displayValue.Remove(displayValue.Length - 1);
                UpdateDisplay();
            }
        }

        private void UpdateDisplay()
        {
            Display.Text = displayValue;
            if (subDisplay2Value == "") SubDisplay.Text = subDisplayValue;
            else SubDisplay.Text = subDisplay2Value + " " + operationValue + " " + subDisplayValue + " = ";
            //SubDisplay.Text = subDisplayValue + subDisplay2Value;
            Operation.Text = operationValue;
        }

        private void AddNumber(string number)
        {
            displayValue += number;
            UpdateDisplay();
        }

        private string Operate(string a, string b, string op)
        {
            float n1 = float.Parse(a);
            float n2 = float.Parse(b);
            float result = 0;
            string resultTxt;

            switch (op)
            {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "x":
                    result = n1 * n2;
                    break;
                case "/":
                    result = n1 / n2;
                    break;
            }
            resultTxt = result.ToString();
            return resultTxt;
        }

        private void OnEqualPress()
        {
            if (subDisplayValue != "" && displayValue != "" && operationValue != "")
            {
                if (subDisplay2Value == "")
                {
                    subDisplay2Value = subDisplayValue;
                    subDisplayValue = displayValue;
                    displayValue = Operate(subDisplay2Value, displayValue, operationValue);
                }
                else
                {
                    subDisplay2Value = displayValue;
                    displayValue = Operate(displayValue, subDisplayValue, operationValue);
                }
            }
            UpdateDisplay();
        }

        private void OperationPress(string op)
        {
            if (displayValue != "" || subDisplayValue != "")
            {
                subDisplay2Value = "";
                switch (op)
                {
                    case "+":
                        operationValue = "+";
                        break;
                    case "-":
                        operationValue = "-";
                        break;
                    case "x":
                        operationValue = "x";
                        break;
                    case "/":
                        operationValue = "/";
                        break;
                }
                if (displayValue != "")
                {
                    subDisplayValue = displayValue;
                    displayValue = "";
                }
                else if (subDisplayValue != "" && operationValue == Operation.Text)
                {
                    subDisplayValue = displayValue;
                    displayValue = "";
                }
                UpdateDisplay();
            }
        }

        private void OnButtonPress(object sender, EventArgs e)
        {
            switch (((sender as Button).Name))
            {
                case "Decimal":
                    if (!(displayValue.Contains(","))) displayValue += ",";
                    UpdateDisplay();
                    break;
                case "Equal":
                    OnEqualPress();
                    break;
                case "Plus":
                    OperationPress("+");
                    break;
                case "Minus":
                    OperationPress("-");
                    break;
                case "Multiply":
                    OperationPress("x");
                    break;
                case "Division":
                    OperationPress("/");
                    break;
                case "Backspace":
                    BackErase();
                    break;
                case "Clear":
                    ClearDisplay();
                    break;
                case "Zero":
                    AddNumber("0");
                    break;
                case "One":
                    AddNumber("1");
                    break;
                case "Two":
                    AddNumber("2");
                    break;
                case "Three":
                    AddNumber("3");
                    break;
                case "Four":
                    AddNumber("4");
                    break;
                case "Five":
                    AddNumber("5");
                    break;
                case "Six":
                    AddNumber("6");
                    break;
                case "Seven":
                    AddNumber("7");
                    break;
                case "Eight":
                    AddNumber("8");
                    break;
                case "Nine":
                    AddNumber("9");
                    break;
            }

        }
    }
}