using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Pyramid_Multi_Tool
{
    public partial class Calc : Form
    {
        decimal num1;
        decimal num2;
        string operation;

        public Calc()
        {
            InitializeComponent();
        }

        private void input(string a)
        {
            if (Output.Text == "0")

                Output.Text = a;

            else

                Output.Text += a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output.Text = "";
        }

        private void One_Button_Click(object sender, EventArgs e)
        {
            input("1");
        }

        private void Two_Button_Click(object sender, EventArgs e)
        {
            input("2");
        }

        private void Three_Button_Click(object sender, EventArgs e)
        {
            input("3");
        }

        private void Four_Button_Click(object sender, EventArgs e)
        {
            input("4");
        }

        private void Five_button_Click(object sender, EventArgs e)
        {
            input("5");
        }

        private void Six_Button_Click(object sender, EventArgs e)
        {
            input("6");
        }

        private void Seven_Button_Click(object sender, EventArgs e)
        {
            input("7");
        }

        private void Eight_Button_Click(object sender, EventArgs e)
        {
            input("8");
        }

        private void Nine_Button_Click(object sender, EventArgs e)
        {
            input("9");
        }

        private void Zero_Button_Click(object sender, EventArgs e)
        {
            input("0");
        }

        private void Plus_Button_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Output.Text);
            operation = "+";
            Output.Text = "0";
        }

        private void Minus_Buttton_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Output.Text);
            operation = "-";
            Output.Text = "0";
        }

        private void Multiply_Button_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Output.Text);
            operation = "*";
            Output.Text = "0";
        }

        private void Divide_Button_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(Output.Text);
            operation = "/";
            Output.Text = "0";
        }

        private void Decimal_Button_Click(object sender, EventArgs e)
        {
            Output.Text += ".";
        }

        private void Equal_Button_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(Output.Text);

            //////////////////////////////// 

            switch (operation)

            {

                case "+":

                    Output.Text = (num1 + num2).ToString();

                    break;

                case "-":

                    Output.Text = (num1 - num2).ToString();

                    break;

                case "*":

                    Output.Text = (num1 * num2).ToString();

                    break;

                case "/":

                    Output.Text = (num1 / num2).ToString();

                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new Main().Show();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
