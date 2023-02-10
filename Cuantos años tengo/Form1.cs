using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuantos_años_tengo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncomparar_Click(object sender, EventArgs e)
        {
            DateTime fechausuario = datetime.Value;
            DateTime fechaactual = DateTime.Now;
            int diferencia = fechaactual.Year - fechausuario.Year;
            if (fechausuario > fechaactual.AddYears(-diferencia))
            {
                diferencia--;
            }
            txtresultado.Text = "Tienes " + diferencia.ToString() + " Años";
        }
    }
}
