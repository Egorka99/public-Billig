using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Translation; 

namespace ПЕревод
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }  
          
  
        private void buttonTranslater_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxNumber.Text))
                    throw new Exception("Исходное число пусто"); 
                if (string.IsNullOrEmpty(textBoxP.Text)) 
                    throw new Exception("P не заполнено");
                if (string.IsNullOrEmpty(textBoxQ.Text)) 
                    throw new Exception("Q не заполнено");



                if (int.TryParse(textBoxP.Text, out int P) && int.TryParse(textBoxQ.Text, out int Q) && textBoxNumber.Text.Length > 0)
                {
                    string digits = "0123456789ABCDEFGHIJKLMNOPQRSTU";
                    string number = textBoxNumber.Text;

                    for (int i = 0; i < number.Length; i++)  
                    {    
                        if (digits.IndexOf(number[i]) >= P)   
                        {
                            throw new Exception("Число не входит в " + P.ToString() + "-ную систему счисления.");
                        } 
                    }
                      

                    int j = number.IndexOf(','); 
                       
                    for (int i = 0; i < number.Length; i++)
                    { 
                         
                        if (number[i] == '.') 
                        {
                            throw new Exception("Дробь записывается с помощью запятой"); 
                        }
                        if ((number[i] >= 'а' && number[i] <= 'я') || (number[i] >= 'А' && number[i] <= 'Я'))
                        {
                            throw new Exception("Некорректный ввод букв.");
                        } 
                        if (number[i] >= 'a' && number[i] <= 'z')
                        {
                            throw new Exception("Должны использоватся заглавные английские буквы."); 
                        }
                        if (!char.IsLetterOrDigit(number[i]) && number[i] != ',')
                        {
                            throw new Exception("Некорректный ввод : символ { " + number[i] + " }"); 
                        }
                        if (number[i] == ',' && i != j) 
                        {
                            throw new Exception("Запятых больше 1."); 
                        }
                    }     

                    if (P < 2 || P > 30)
                    {
                        throw new Exception("Ошибка!!!Неверный ввод P(2<=P<=30)."); 
                    }
                    if (Q < 2 || Q > 30)   
                    {
                        throw new Exception("Ошибка!!!Неверный ввод Q(2<=Q<=30)."); 
                    }

                    textBoxOutput.Text = TranslateFromPToQ.FromPToQ(textBoxNumber.Text, P, Q);
                }
            else MessageBox.Show("Проверьте правильность ввода данных");

            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка: " + error.Message);
            }
        }     
          
    }  
} 
