using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIstBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstfrutas.Items.Add("Banana");
            lstfrutas.Items.Add("Durazno");
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            lstfrutas.Items.Add(txtfruta.Text);
            txtfruta.Text = string.Empty;
        }

        private void lstfrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstfrutas.SelectedIndex != -1)
            {
                lblfruta.Text = (string)lstfrutas.Items[lstfrutas.SelectedIndex];
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            int indice = lstfrutas.SelectedIndex;

            if (indice != -1)
            {
                lstfrutas.Items.RemoveAt(indice);
            }
        }
    }
}
