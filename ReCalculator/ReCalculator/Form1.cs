namespace ReCalculator
{
    public partial class Form1 : Form
    {

        private string displayValue;
        private string subDisplayValue;
        private string operationValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearDisplay()
        {
            if (displayValue != "") displayValue = "";
            else
            {
                subDisplayValue = "";
                operationValue = "";
            }
            UpdateDisplay();
        }

        private void BackErase()
        {
            displayValue = displayValue.Remove(displayValue.Length - 1);
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            Display.Text = displayValue;
            SubDisplay.Text = subDisplayValue;
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
                case "*":
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
            if(subDisplayValue != "" && displayValue != "" && operationValue != "")
            {
                displayValue = Operate(subDisplayValue, displayValue, operationValue);
            }
            UpdateDisplay();
        }

        private void OperationPress(string op)
        {
            if (displayValue != "" || subDisplayValue != "")
            {
                switch (op)
                {
                    case "+":
                        operationValue = "+";
                        break;
                    case "-":
                        operationValue = "-";
                        break;
                    case "*":
                        operationValue = "x";
                        break;
                    case "/":
                        operationValue = "/";
                        break;
                }
                if(displayValue != "") subDisplayValue = displayValue;
                ClearDisplay();
            }
        }

        private void OnButtonPress(object sender, EventArgs e)
        {
            switch (((sender as Button).Name))
            {
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
                    OperationPress("*");
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