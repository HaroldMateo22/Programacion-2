using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGrid
{
    public partial class Form1 : Form
    {
        private int n = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            int n = dtgvproductos.Rows.Add();

            dtgvproductos.Rows[n].Cells[0].Value = txtcodigo.Text;
            dtgvproductos.Rows[n].Cells[1].Value = txtnombre.Text;
            dtgvproductos.Rows[n].Cells[2].Value = txtprecio.Text;

            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtprecio.Text = "";
        }

        private void dtgvproductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            if (n != -1)
            {
                lblinformacion.Text = (string)dtgvproductos.Rows[n].Cells[1].Value;
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dtgvproductos.Rows.RemoveAt(n);
            }
        }
    }
}
