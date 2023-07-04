namespace WinFormsApp_dz2_3
{
    public partial class Form1 : Form
    {
        private double firstNumber;
        private double secondNumber;
        private string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            // Обробка натискання кнопок з цифрами
            Button button = (Button)sender;
            string digit = button.Text;

            textBox1.Text += digit;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            // Обробка натискання кнопок з операторами (+, -, *, /)
            Button button = (Button)sender;
            operation = button.Text;
            firstNumber = double.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Обробка натискання кнопки "Clear"
            textBox1.Clear();
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Обробка натискання кнопки "="
            secondNumber = double.Parse(textBox1.Text);
            double result = 0;

           
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }

            textBox1.Text = result.ToString();
        }
    }
}
