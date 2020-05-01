using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Click += Button2_Click;
            button3.Click += Button3_Click;
            button4.Click += delegate (object sender, EventArgs e)
            {
                label7.Text = operation("/", textBox8.Text, textBox7.Text);
            };
            button5.Click += (object sender, EventArgs e) => label9.Text = operation("%", textBox10.Text, textBox9.Text);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label5.Text = operation("*", textBox6.Text, textBox5.Text);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label3.Text = operation("-", textBox4.Text, textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = operation("+", textBox1.Text, textBox2.Text);
        }

        private string operation(string sign, string num1, string num2)
        {
            int number1 = int.Parse(num1);
            int number2 = int.Parse(num2);
            string result = "";
            switch (sign)
            {
                case "+":
                    result = (number1 + number2).ToString();
                    break;
                case "-":
                    result = (number1 - number2).ToString();
                    break;
                case "/":
                    result = (number1 / number2).ToString();
                    break;
                case "*":
                    result = (number1 * number2).ToString();
                    break;
                case "%":
                    result = (number1 % number2).ToString();
                    break;
                default:
                    break;
            }
            return result;
        }

        private void WindowMouseClick(object sender, MouseEventArgs e)
        {
            Ioio(500);
            Ioio(450);
            Ioio(400);
            Ioio(350);
            Ioio(300);
            Ioio(250);
            Ioio(200);
            Ioio(150);
            Ioio(100);
            Ioio(50);
            Ioio(30);
            textBox1.Text = "WARNING!!!";
            Ioio(30);
            textBox3.Text = "WARNING!!!";
            Ioio(30);
            textBox8.Text = "WARNING!!!";
            Ioio(30);
            textBox1.Text = "";
            Ioio(30);
            textBox10.Text = "WARNING!!!";
            Ioio(30);
            textBox3.Text = "";
            Ioio(30);
            textBox2.Text = "WARNING!!!";
            Ioio(30);
            textBox3.Text = "";
            Ioio(30);
            textBox8.Text = "";
            Ioio(30);
            textBox10.Text = "";
            Ioio(30);
            textBox1.Text = "WARNING!!!";
            textBox2.Text = "WARNING!!!";
            textBox3.Text = "WARNING!!!";
            textBox4.Text = "WARNING!!!";
            textBox5.Text = "WARNING!!!";
            textBox6.Text = "WARNING!!!";
            textBox7.Text = "WARNING!!!";
            textBox8.Text = "WARNING!!!";
            textBox9.Text = "WARNING!!!";
            textBox10.Text = "WARNING!!!";
            Ioio(30);
            Ioio(30);
            this.BackColor = Color.Black;
            this.Refresh();
            Application.Exit();

        }

        private void Ioio(int time)
        {
            this.BackColor = Color.Red;
            this.Refresh();
            System.Threading.Thread.Sleep(time);
            this.BackColor = Color.Blue;
            this.Refresh();
            System.Threading.Thread.Sleep(time);
        }
    }
}
