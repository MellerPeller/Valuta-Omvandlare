using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Valuta_Omvandlare
{
    public partial class Form1 : Form
    {

        double sek = 0;
        double dollar = 0;
        double pund = 0;
        double euro = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            


            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            


            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            

           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                sek *= 10;
                sek += textBox1.Text[i] - 48;
            }
            dollar = sek * 0.092;
            pund = sek * 0.074;
            euro = sek * 0.086;

            textBox2.Text = dollar.ToString();
            textBox3.Text = pund.ToString();
            textBox4.Text = euro.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             sek = 0;
             dollar = 0;
             pund = 0;
             euro = 0;
            textBox1.Text = sek.ToString();
            textBox2.Text = dollar.ToString();
            textBox3.Text = pund.ToString();
            textBox4.Text = euro.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox2.Text.Length; i++)
            {
                dollar *= 10;
                dollar += textBox2.Text[i] - 48;
            }
            sek = dollar * 10.85;
            pund = dollar * 0.8;
            euro = dollar * 0.93;

            textBox1.Text = sek.ToString();
            textBox3.Text = pund.ToString();
            textBox4.Text = euro.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                pund *= 10;
                pund += textBox3.Text[i] - 48;
            }
            sek = pund * 13.56;
            dollar = pund * 1.25;
            euro = pund * 1.17;

            textBox1.Text = sek.ToString();
            textBox2.Text = dollar.ToString();
            textBox4.Text = euro.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox4.Text.Length; i++)
            {
                euro *= 10;
                euro += textBox4.Text[i] - 48;
            }
            sek = euro * 11.63;
            dollar = euro * 1.07;
            pund = euro * 0.86;

            textBox1.Text = sek.ToString();
            textBox2.Text = dollar.ToString();
            textBox3.Text = pund.ToString();
        }

      
        private void Button1_Hover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor= Color.White;
        }

        private void Button2_Hover(object sender, EventArgs e)
        {
            button2.BackColor = Color.LimeGreen;
        }

        private void Button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }
        private void Button3_Hover(object sender, EventArgs e)
        {
            button3.BackColor = Color.LimeGreen;
        }

        private void Button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.White;
        }
        private void Button4_Hover(object sender, EventArgs e)
        {
            button4.BackColor = Color.LimeGreen;
        }

        private void Button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
        }
        private void Button5_Hover(object sender, EventArgs e)
        {
            button5.BackColor = Color.LimeGreen;
        }

        private void Button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.White;
        }
    }
}
