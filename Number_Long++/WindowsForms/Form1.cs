using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Number_Long__;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxA_KeyPress(object sender, KeyPressEventArgs e)
        {


            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 45 && e.KeyChar != (char)Keys.Back)
            {             
                    e.Handled = true;
            }
            
        }

        private void textBoxB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 45 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Main()
        {
            BigNumber a = new BigNumber(textBoxA.Text);
            BigNumber b = new BigNumber(textBoxB.Text);
            string operation = comboBox1.Text;
            switch(operation)
            {
                case "+":
                    {
                        Answer.Text = (a + b).ToString();
                        break;
                    }
                case "-":
                    {
                        Answer.Text = (a - b).ToString();
                        break;
                    }
                case "*":
                    {
                        Answer.Text = (a * b).ToString();
                        break;
                    }
                case "/":
                    {
                        MessageBox.Show("Егор поел говна, код хуета, ку ");
                        //Answer.Text = (a / b).ToString();
                        Answer.Text = (a / Convert.ToInt32(textBoxB.Text)).ToString();
                        break;
                    }
                default:
                    {
                        break; 
                    }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxA.TextLength > 0 && textBoxB.TextLength > 0)
            {
                Main();
            }
            else
            {
                MessageBox.Show("Введите текст");
            }
        }
    }
}
