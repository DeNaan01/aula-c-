using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello_world2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string numero1 = txbnumero1.Text;
            string numero2 = txbnumero2.Text;

            int total = int.Parse(numero1) + int.Parse(numero2);

            lbresultado.Text = total.ToString();
            //lbresultado.Text = txbnumero1.Text + txbnumero2.Text;

        }

        private void btnsubtrair_Click(object sender, EventArgs e)
        {
            string numero1 = txbnumero1.Text;
            string numero2 = txbnumero2.Text;

            int total = int.Parse(numero1) - int.Parse(numero2);

            lbresultado.Text = total.ToString();
        }

        private void btnmultplicar_Click(object sender, EventArgs e)
        {
            string numero1 = txbnumero1.Text;
            string numero2 = txbnumero2.Text;

            int total = int.Parse(numero1) * int.Parse(numero2);

            lbresultado.Text = total.ToString();

        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            string numero1 = txbnumero1.Text;
            string numero2 = txbnumero2.Text;

            int total = int.Parse(numero1) / int.Parse(numero2);

            lbresultado.Text = total.ToString();
        }

        private void btnmaiormenor_Click(object sender, EventArgs e)
        {

            int numero3 = int.Parse(txbnumero3.Text);
            //string numero3 = txbnumero3.Text;

            if (numero3 > 0)
            {
                lbresultado2.Text = "o numero digitado é maior que 0";
            }
            else
            {
                lbresultado2.Text = "o numero digitado é menor que 0";
            }
        }

        private void lbnumero1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnimparpar_Click_1(object sender, EventArgs e)
        {
            int numero3 = int.Parse(txbnumero3.Text);

            if (numero3 % 2 == 0)
            {
                lbresultado2.Text = "o numero digitado é par";
            }
            else
            {
                lbresultado2.Text = "o numero digitado é impar";
            }
        }
    }
}
