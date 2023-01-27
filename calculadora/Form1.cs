using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double numero1 = 0, numero2 =0;
        char operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarnumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtresultado.Text == "0")
                txtresultado.Text = "";

            txtresultado.Text += boton.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtresultado.Text);

            if (operador == '+')
            {
                txtresultado.Text = (numero1 + numero2).ToString();
                numero1 = Convert.ToDouble(txtresultado.Text);
            }
            else if (operador == '─') 
            {
                txtresultado.Text = (numero1 - numero2).ToString();
                numero1 = Convert.ToDouble(txtresultado.Text);
            }
            else if (operador == 'X')
            {
                txtresultado.Text = (numero1 * numero2).ToString();
                numero1 = Convert.ToDouble(txtresultado.Text);
            }
            else if (operador == '∕')
            {
                txtresultado.Text = (numero1 / numero2).ToString();
                numero1 = Convert.ToDouble(txtresultado.Text);
            }
        }

        private void clickoperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            numero1 = Convert.ToDouble(txtresultado.Text);
            operador = Convert.ToChar(boton.Tag);

            txtresultado.Text = "0";
        }
    }
}
