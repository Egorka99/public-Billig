using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            BigNumber a;
            BigNumber b;
             
            try  
            { 
                new BigNumber(textBoxA.Text);
                new BigNumber(textBoxB.Text);
            } 
            catch (Exception e) 
            { 
                MessageBox.Show(e.Message, "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1); 
            } 

            a = new BigNumber(textBoxA.Text);
            b = new BigNumber(textBoxB.Text);

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
                       
                        if (int.TryParse(textBoxB.Text, out int B))
                        {
                            Answer.Text = (a / B).ToString();
                        } 
                        else
                        { 
                            MessageBox.Show("Превышена длина делителя!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
                Stopwatch sw = new Stopwatch();
                 
                sw.Start();  
                Main();                  
                sw.Stop(); 

                labelTime.Text = (sw.Elapsed).ToString();

                sw.Start();

                for (int i = 0; i < 100; i++)
                {
                    Main(); 
                } 

                sw.Stop();

                labelTime1.Text = (sw.Elapsed).ToString();

                sw.Start();

                for (int i = 0; i < 10000; i++)
                {
                    Main();
                }
                  
                sw.Stop();

                labelTime2.Text = (sw.Elapsed).ToString();

            }  
            else  
            { 
                MessageBox.Show("Введите текст", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
 