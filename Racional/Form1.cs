using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Racionales.Model;

namespace Racionales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textBox1.Text);
            int d1 = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox3.Text);
            int d2 = Convert.ToInt16(textBox4.Text);

            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);

            Racional producto = r1.multiplicar(r2);

            textBox5.Text = producto.getNumerador().ToString();
            textBox6.Text = producto.getDenominador().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textBox1.Text);
            int d1 = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox3.Text);
            int d2 = Convert.ToInt16(textBox4.Text);

            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);

            Racional division = r1.dividir(r2);

            textBox5.Text = division.getNumerador().ToString();
            textBox6.Text = division.getDenominador().ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textBox1.Text);
            int d1 = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox3.Text);
            int d2 = Convert.ToInt16(textBox4.Text);

            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);

            Racional suma = r1.sumar(r2);

            textBox5.Text = suma.getNumerador().ToString();
            textBox6.Text = suma.getDenominador().ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(textBox1.Text);
            int d1 = Convert.ToInt16(textBox2.Text);
            int n2 = Convert.ToInt16(textBox3.Text);
            int d2 = Convert.ToInt16(textBox4.Text);

            Racional r1 = new Racional(n1, d1);
            Racional r2 = new Racional(n2, d2);

            Racional resta = r1.restar(r2);

            textBox5.Text = resta.getNumerador().ToString();
            textBox6.Text = resta.getDenominador().ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }


    }
}
