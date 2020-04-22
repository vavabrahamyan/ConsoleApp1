using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleGameINForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = ParseToArray(NumberInText(textBox1.Text));
            textBox1.Text = null;
            label1.Text = null;
            for (int i = 0; i < arr.Length; i++)
            {
                label1.Text += arr[i].ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private int NumberInText(string UsersNumber)
        {
            try
            {
                return Convert.ToInt32(UsersNumber);
            }
            catch (FormatException)
            {
                return -1;
            }
        }
        private int[] ParseToArray(int number)
        {
            int digit = 0;
            int num1 = number;
            int num2 = number;
            while (num1 > 0)
            {
                num1 = num1 / 10;
                digit++;
            }
            int[] arr = new int[digit];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arr[i] = num2 % 10;
                num2 = num2 / 10;
            }
            return arr;
        }
    }
}
