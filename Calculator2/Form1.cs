using System.Data;

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
            
            Button button = sender as Button;

            string newOperator = button.Text;

            resultLabel.Text += " " + resultTextBox.Text + " " + newOperator;


            double operand = Double.Parse(resultTextBox.Text);

            switch (checkOperator)
            {
                case "+": result += operand;break;
                case "/": result /= operand; break;
                case "*": result *= operand; break;
                case "-": result -= operand;break;
            }

            option = true;
            checkOperator = newOperator;
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
            resultLabel.Text += resultTextBox.Text;
            option = false;


            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), resultLabel.Text);
            DataRow row = table.NewRow();
            table.Rows.Add(row);

            double result1 = double.Parse((string)row["expression"]);
            MessageBox.Show(result1.ToString());

            resultLabel.Text = "";
            resultTextBox.Text = result1.ToString();


            //finish
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

