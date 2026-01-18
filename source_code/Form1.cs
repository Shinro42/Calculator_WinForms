namespace Calculator
{
    public partial class Form1 : Form
    {

        private double FirstNum = 0;
        private double SecondNum = 0;
        private char Operator = ' ';
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void print_num(int num)
        {
            if (count == 1)
            {
                count++;
                textCalc.Text = "";
            }
            if (textCalc.Text == "0" || count == -1)
            {
                textCalc.Text = num.ToString();
                count = 0;
            }
            else if (textCalc.Text == "-0")
            {
                textCalc.Text = "-" + num.ToString();
            }
            else
            {
                textCalc.Text = textCalc.Text + num.ToString();
            }
        }

        private void Operation(char SecondOperator)
        {
            SecondNum = Convert.ToDouble(textCalc.Text);

            string expr = Convert.ToString(FirstNum) + " " + Operator + " " + Convert.ToString(SecondNum) + " = ";


            switch (Operator)
            {
                case '+':
                    FirstNum += SecondNum;
                    break;
                case '-':
                    FirstNum -= SecondNum;
                    break;
                case '*':
                    FirstNum *= SecondNum;
                    break;
                case '/':
                    if (SecondNum == 0)
                    {
                        count = -1;
                        textCalc.Text = "Error";
                    }
                    else
                    {
                        FirstNum /= SecondNum;
                    }
                    break;
            }
            if (count != -1 && Operator != ' ')
            {
                History.Items.Insert(0, expr + Convert.ToString(FirstNum));
            }

            switch (SecondOperator)
            {
                case '+':
                    textCalc.Text = Convert.ToString(FirstNum) + " +";
                    Operator = '+';
                    count = 1;
                    break;
                case '=':
                    if (count == 0)
                    {
                        FirstNum = Convert.ToDouble(textCalc.Text);
                    }
                    if (count != -1)
                    {
                        textCalc.Text = Convert.ToString(FirstNum);
                        count = 0;
                    }
                    Operator = ' ';
                    break;
                case '-':
                    textCalc.Text = Convert.ToString(FirstNum) + " -";
                    Operator = '-';
                    count = 1;
                    break;
                case '*':
                    textCalc.Text = Convert.ToString(FirstNum) + " *";
                    Operator = '*';
                    count = 1;
                    break;
                case '/':
                    
                    textCalc.Text = Convert.ToString(FirstNum) + " /";
                    Operator = '/';
                    count = 1;
                    
                    break;
                case '%':
                    Operator = ' ';
                    count = 0;
                    History.Items.Insert(0, Convert.ToString(FirstNum) + "% " + "= " + Convert.ToString(FirstNum / 100));
                    FirstNum /= 100;
                    textCalc.Text = Convert.ToString(FirstNum);
                    break;
                case 's':
                    Operator = ' ';
                    count = 0;
                    History.Items.Insert(0, Convert.ToString(FirstNum) + "² " + "= " + Convert.ToString(FirstNum * FirstNum));
                    FirstNum *= FirstNum;
                    textCalc.Text = Convert.ToString(FirstNum);
                    break;
                case 'r':
                    Operator = ' ';
                    count = 0;
                    if (FirstNum < 0)
                    {
                        textCalc.Text = "Error";
                        count = -1;
                    }
                    else
                    {
                        History.Items.Insert(0, "√" + Convert.ToString(FirstNum) + " = " + Convert.ToString(Math.Sqrt(FirstNum)));
                        FirstNum = Math.Sqrt(FirstNum);
                        textCalc.Text = Convert.ToString(FirstNum);
                    }
                    break;
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            print_num(1);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            print_num(2);

        }
        private void btn3_Click(object sender, EventArgs e)
        {
            print_num(3);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            print_num(4);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            print_num(5);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            print_num(6);
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            print_num(7);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            print_num(8);
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            print_num(9);
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            print_num(0);
        }
        private void btn_unary_minus_Click(object sender, EventArgs e)
        {
            if (textCalc.Text.IndexOf("-") == -1)
            {
                textCalc.Text = "-" + textCalc.Text;
            }
            else
            {
                textCalc.Text = textCalc.Text.Remove(0, 1);
            }

        }
        private void btn_frac_Click(object sender, EventArgs e)
        {
            if (textCalc.Text.IndexOf(",") == -1)
            {
                textCalc.Text += ",";
            }
        }
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textCalc.Text = "0";
            Operator = ' ';
            FirstNum = 0;
            SecondNum = 0;
            count = 0;
        }
        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (textCalc.Text.Length == 1 || (textCalc.Text.Length == 2 && textCalc.Text.IndexOf("-") > -1))
            {
                textCalc.Text = "0";
            }
            else
            {
                if (count == 1)
                {
                    Operator = ' ';
                    textCalc.Text = textCalc.Text.Remove(textCalc.Text.Length - 2);
                }
                else
                {
                    textCalc.Text = textCalc.Text.Remove(textCalc.Text.Length - 1);
                }
            }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (Operator == ' ')
            {
                FirstNum = Convert.ToDouble(textCalc.Text);
                Operator = '+';
                textCalc.Text += " +";
                count += 1;
            }
            else if (count == 1 && Operator != '+')
            {
                Operator = '+';
                textCalc.Text = textCalc.Text.Remove(textCalc.Text.Length - 2) + " +";
            }
            else if (count == 2)
            {
                Operation('+');
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (Operator == ' ')
            {
                FirstNum = Convert.ToDouble(textCalc.Text);
                Operator = '-';
                textCalc.Text += " -";
                count += 1;
            }
            else if (count == 1 && Operator != '-')
            {
                Operator = '-';
                textCalc.Text = textCalc.Text.Remove(textCalc.Text.Length - 2) + " -";
            }
            else if (count == 2)
            {
                Operation('-');
            }
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            Operation('=');
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            if (Operator == ' ')
            {
                FirstNum = Convert.ToDouble(textCalc.Text);
                Operator = '*';
                textCalc.Text += " *";
                count += 1;
            }
            else if (count == 1 && Operator != '*')
            {
                Operator = '*';
                textCalc.Text = textCalc.Text.Remove(textCalc.Text.Length - 2) + " *";
            }
            else if (count == 2)
            {
                Operation('*');
            }
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            if (Operator == ' ')
            {
                FirstNum = Convert.ToDouble(textCalc.Text);
                Operator = '/';
                textCalc.Text += " /";
                count += 1;
            }
            else if (count == 1 && Operator != '/')
            {
                Operator = '/';
                textCalc.Text = textCalc.Text.Remove(textCalc.Text.Length - 2) + " /";
            }
            else if (count == 2)
            {
                Operation('/');
            }
        }

        private void btn_perc_Click(object sender, EventArgs e)
        {
            if (Operator == ' ')
            {
                FirstNum = Convert.ToDouble(textCalc.Text);
                History.Items.Insert(0, textCalc.Text + "% " + "= " + Convert.ToString(FirstNum / 100));
                FirstNum /= 100;
                textCalc.Text = Convert.ToString(FirstNum);
            }
            else if (count == 1)
            {
                Operator = ' ';
                textCalc.Text = textCalc.Text.Remove(textCalc.Text.Length - 2);
                FirstNum = Convert.ToDouble(textCalc.Text);
                History.Items.Insert(0, textCalc.Text + "% " + "= " + Convert.ToString(FirstNum / 100));
                FirstNum /= 100;
                textCalc.Text = Convert.ToString(FirstNum);
                count = 0;
            }
            else if (count == 2)
            {
                Operation('%');
            }
        }

        private void btn_sq_Click(object sender, EventArgs e)
        {
            if (Operator == ' ')
            {
                FirstNum = Convert.ToDouble(textCalc.Text);
                History.Items.Insert(0, textCalc.Text + "² " + "= " + Convert.ToString(FirstNum * FirstNum));
                FirstNum *= FirstNum;
                textCalc.Text = Convert.ToString(FirstNum);
            }
            else if (count == 1)
            {
                Operator = ' ';
                textCalc.Text = textCalc.Text.Remove(textCalc.Text.Length - 2);
                FirstNum = Convert.ToDouble(textCalc.Text);
                History.Items.Insert(0, textCalc.Text + "² " + "= " + Convert.ToString(FirstNum * FirstNum));
                FirstNum *= FirstNum;
                textCalc.Text = Convert.ToString(FirstNum);
                count = 0;
            }
            else if (count == 2)
            {
                Operation('s');
            }
        }

        private void btn_sqr_Click(object sender, EventArgs e)
        {
            if (Operator == ' ')
            {
               
                FirstNum = Convert.ToDouble(textCalc.Text);
                if (FirstNum < 0)
                {
                    textCalc.Text = "Error";
                    count = -1;
                }
                else
                {
                    History.Items.Insert(0, "√" + textCalc.Text + " = " + Convert.ToString(Math.Sqrt(FirstNum)));
                    FirstNum = Math.Sqrt(FirstNum);
                    textCalc.Text = Convert.ToString(FirstNum);
                }
             
            }
            else if (count == 1)
            {
                Operator = ' ';
                textCalc.Text = textCalc.Text.Remove(textCalc.Text.Length - 2);
                FirstNum = Convert.ToDouble(textCalc.Text);
                if (FirstNum < 0)
                {
                    textCalc.Text = "Error";
                    count = -1;
                }
                else
                {
                    History.Items.Insert(0, "√" + textCalc.Text + " = " + Convert.ToString(Math.Sqrt(FirstNum)));
                    FirstNum = Math.Sqrt(FirstNum);
                    textCalc.Text = Convert.ToString(FirstNum);
                }
            }
            else if (count == 2)
            {
                Operation('r');
            }
        }

        private void btn_clear_history_Click(object sender, EventArgs e)
        {
            History.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
