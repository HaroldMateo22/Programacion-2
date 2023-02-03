﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }
        public string titulo;
        string operacion;
        double num1;
        double num2;
        double resultado;

        private void Form1_Load(object sender, EventArgs e)
        {
            dibujarpanelnumerico();
            lblejercicio.Text = titulo;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dibujarpanelnumerico()
        {
            char[] numeros;
            numeros = "7894563210.".ToCharArray();
            panelnumerico.Controls.Clear();
            foreach(char numero in numeros)
            {
                Button btnnumero = new Button();
                btnnumero.Text = numero.ToString();
                btnnumero.Size = new Size(55, 55);
                btnnumero.FlatStyle = FlatStyle.Flat;
                btnnumero.ForeColor = Color.White;
                btnnumero.BackColor = Color.Transparent;
                btnnumero.BackgroundImage = Properties.Resources.circulogrisclaro;
                btnnumero.BackgroundImageLayout = ImageLayout.Stretch;
                btnnumero.FlatAppearance.BorderSize = 0;
                btnnumero.FlatAppearance.MouseDownBackColor = Color.Transparent;
                btnnumero.FlatAppearance.MouseOverBackColor = Color.Transparent;
                panelnumerico.Controls.Add(btnnumero);
                btnnumero.Click += Btnnumero_Click;
            }
        }

        private void Btnnumero_Click(object sender, EventArgs e)
        {
            string numerostring = ((Button)sender).Text;
            if(txtpantalla.Text == "0")
            {
                txtpantalla.Clear();
            }
            txtpantalla.Text += numerostring;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            operacion = btndiv.Text;
            definiroperacion();

        }
        private void definiroperacion()
        {
            asignardatos();
            if(num2 > 0)
            {
                lblnum1.Text = txtpantalla.Text;
                lbloperacion.Text = operacion;
                txtpantalla.Text = "0";
            }
        }
        private void asignardatos()
        {
            num1 = Convert.ToDouble(lblnum1.Text);
            num2 = Convert.ToDouble(txtpantalla.Text);
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            calcular();
        }
        private void calcular()
        {
            asignardatos();
            if(lbloperacion.Text == btndiv.Text)
            {
                dividir();
            }
            void dividir()
            {
                resultado = num1 / num2;
                txtpantalla.Text = resultado.ToString();
                lbloperacion.Text = "0";
                lblnum1.Text = "0";
            }
        }
    }
}
