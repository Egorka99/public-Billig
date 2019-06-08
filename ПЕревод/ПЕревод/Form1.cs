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
            if (int.TryParse(textBoxP.Text, out int P) && int.TryParse(textBoxQ.Text, out int Q) && textBoxNumber.Text.Length > 0)
                textBoxOutput.Text = TranslateFromPToQ.FromPToQ(textBoxNumber.Text, P, Q);
            else MessageBox.Show("Проверьте правильность ввода данных");
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка " + error.Message);
            }
        }    
          
    }  
} 
