namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool option = false;
        double result = 0;
        string checkOperator = "";
        List<string> options = new List<string>();
        List<double> nums = new List<double>();
        private void numsEvent(object sender, EventArgs e)
        {

            if (resultTextBox.Text == "0" || option)
            {
                resultTextBox.Clear();
            }

            option = false;
            Button button = sender as Button;
            resultTextBox.Text += button.Text;
        }

        private void opertionsEvent(object sender, EventArgs e)
        {
            option = true;
            Button button = sender as Button;
            string newOperator = button.Text;

            resultLabel.Text = resultLabel.Text + " " + resultTextBox.Text + " " + newOperator;

            nums.Add(double.Parse(resultTextBox.Text));


            switch (checkOperator)
            {
                case "+": resultTextBox.Text = (result + double.Parse(resultTextBox.Text)).ToString(); break;
                case "/": resultTextBox.Text = (result / double.Parse(resultTextBox.Text)).ToString(); break;
                case "*": resultTextBox.Text = (result * double.Parse(resultTextBox.Text)).ToString(); break;
                case "-": resultTextBox.Text = (result - double.Parse(resultTextBox.Text)).ToString(); break;
            }

            result = double.Parse(resultTextBox.Text);
            resultTextBox.Text = result.ToString();
            checkOperator = newOperator;
            options.Add(checkOperator);
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
            resultLabel.Text = "";
            checkOperator = "";
            result = 0;
            option = false;
        }
        private void equalButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            option = false;

            nums.Add(double.Parse(resultTextBox.Text));
            switch (checkOperator)
            {
                case "+": resultTextBox.Text = (result + double.Parse(resultTextBox.Text)).ToString(); break;
                case "/": resultTextBox.Text = (result / double.Parse(resultTextBox.Text)).ToString(); break;
                case "*": resultTextBox.Text = (result * double.Parse(resultTextBox.Text)).ToString(); break;
                case "-": resultTextBox.Text = (result - double.Parse(resultTextBox.Text)).ToString(); break;
            }

            result = double.Parse(resultTextBox.Text);
            resultTextBox.Text = result.ToString();

            checkOperator = "";
            nums.Clear();
        }

        private void pointButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text == "0")
            {
                resultTextBox.Text = "0";
            }
            else if (option)
            {
                resultTextBox.Text = "0";
            }
            if (!resultTextBox.Text.Contains("."))
            {
                resultTextBox.Text += ",";
            }
            option = false;
        }
    }
}