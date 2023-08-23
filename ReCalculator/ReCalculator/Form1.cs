namespace ReCalculator
{
    public partial class Form1 : Form
    {
        //private int[] n1 = new int[9];

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearDisplay()
        {
            Display.Text = string.Empty;
        }

        private void UpdateNumber(int number)
        {
            /*for(int i = 0; i < n1.Length; i++)
            {
                n1[0] = number;
                if (n1[i] == null) {
                    n1[i] = number;
                    break;
                }
            }
            System.Console.WriteLine(n1[0]);
            Display.Text = n1.ToString();
            */
        }

        private void AddNumber(object sender, EventArgs e)
        {
            switch (((sender as Button).Name))
            {
                case "Clear":
                    ClearDisplay();
                    break;
                case "Zero":
                    UpdateNumber(0);
                    Display.Text += "0";
                    break;
                case "One":
                    UpdateNumber(1);
                    Display.Text += "1";
                    break;
                case "Two":
                    Display.Text += "2";
                    break;
                case "Three":
                    Display.Text += "3";
                    break;
                case "Four":
                    Display.Text += "4";
                    break;
                case "Five":
                    Display.Text += "5";
                    break;
                case "Six":
                    Display.Text += "6";
                    break;
                case "Seven":
                    Display.Text += "7";
                    break;
                case "Eight":
                    Display.Text += "8";
                    break;
                case "Nine":
                    Display.Text += "9";
                    break;
            }

        }

    }
}