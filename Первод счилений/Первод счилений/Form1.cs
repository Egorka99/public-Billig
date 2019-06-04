using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Первод_счилений
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxP.Text = "2";
        }

       

        private void buttonFrom10to2_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBoxN10.Text);
            int p= int.Parse(textBoxP.Text);
            string N2 = From10ToP(N, p);
            textBoxNp.Text = N2;
        }

        string From10ToP(int N,int p)
        {
            int digit;
            string res= "";
            while (N != 0)
            {

                digit = N % p;
                N = N / p;
                res = digit + res;

            }
            return res;
        }

        private void buttonPto10_Click(object sender, EventArgs e)
        {
            string Np = textBoxNp.Text;
            int p = int.Parse(textBoxP.Text);
            int N10 = FromPTo10(Np, p);
            textBoxN10.Text = N10.ToString();
        }

        int FromPTo10(string Np,int p)
        {
            int res = 0;
            int n = Np.Length;
            int digit;

            for (int i=0;i<n;i++)
            {
                digit = Np[i] - '0';
                res = res * p + digit;


            }
            return res;
        }

        private void textBoxN10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
