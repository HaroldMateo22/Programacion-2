using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loteria_intento_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num1 = rand.Next(1, 10);
            int num2 = rand.Next(1, 10);
            int num3 = rand.Next(1, 10);
            txtnum1.Text = num1.ToString();
            txtnum2.Text = num2.ToString();
            txtnum3.Text = num3.ToString();
        }

        private void btncomparar_Click(object sender, EventArgs e)
        {
            int numacertados = 0;
            int premio = 0;
            int num1 = int.Parse(txtnum1.Text);
            int num2 = int.Parse(txtnum2.Text);
            int num3 = int.Parse(txtnum3.Text);
            int nummanual = int.Parse(txtmanual1.Text);
            int nummanual2 = int.Parse(txtmanual2.Text);
            int nummanual3 = int.Parse(txtmanual3.Text);


            if(txtmanual1.Text == txtnum1.Text || txtmanual1.Text == txtnum2.Text || txtmanual1.Text == txtnum3.Text)
            {
                numacertados++;
            }
            if (txtmanual2.Text == txtnum1.Text || txtmanual2.Text == txtnum2.Text || txtmanual2.Text == txtnum3.Text)
            {
                numacertados++;
            }
            if (txtmanual3.Text == txtnum1.Text || txtmanual3.Text == txtnum2.Text || txtmanual3.Text == txtnum3.Text)
            {
                numacertados++;
            }


            if (numacertados == 1)
            {
                lblresultado.Text = "acertaste " + numacertados.ToString() + " numero";
            }
            else
            {
                lblresultado.Text = "acertaste " + numacertados.ToString() + " numeros";
            }


            if (numacertados == 0)
            {
                lblpremio.Text = "Te Pelaste";
            }
            if (numacertados == 1)
            {
                lblpremio.Text = "Ganaste 2,000";
            }
            if (numacertados == 2)
            {
                lblpremio.Text = "Ganaste 5,000";
            }
            if (numacertados == 3)
            {
                lblpremio.Text = "Ganaste 10,000";
            }
            numacertados = 0;
            premio = 0;
        }
    }
}
