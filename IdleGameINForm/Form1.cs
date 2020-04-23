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
        private int[] CompNumber = new int[] { };
        public static int countOfSteps = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = $"step{countOfSteps}/9";
            if (textBox1.Text.Length == 4)
            {
                countOfSteps++;
                int[] arr = ParseToArray(NumberInText(textBox1.Text));
                int count = Game.CountOfTastes(CompNumber, arr);
                label2.Text = $"Count of tastes = > {count.ToString()}";
                bool[] boolArray = Game.AreTastes(CompNumber, arr);
                string boolResult = null;
                for (int i = 0; i < boolArray.Length; i++)
                {
                    boolResult += boolArray[i] + "  ";
                }
                label3.Text = boolResult;
            }
            else
            {
                MessageBox.Show("The number is not four-digit");
            }
        }
        // Ֆունկցիան ստանում է տող և եթե տողում նրմուծված են թվեր վերադարձնում է ամբողջ թիվ
        // Եթե տողում թվերից բացի կան այլ նշաններ վերադարձնում է -1
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
        // Ֆունկցիան ստանում է ամբողջ թիվ, որը վերածում է 
        // միանիշ թվերի զանգվածի համապատասխան հաջորդականությամբ
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Comp comp = new Comp();
            CompNumber = comp.CompNumber;       
        }
    }
}
