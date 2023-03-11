using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiteDBProject
{
    public partial class Form1 : Form
    {

        public List<Customer> lstPersonas = new List<Customer>();
        private int n = 0;

        public enum columnas
        {
            nombre = 0,
            apellido = 1,
            telefono = 2,
            cedula = 3,
            edad = 4
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void btninsert_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDB.LiteDatabase(@"C:\Temp\MyData.db"))
            {
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<Customer>("customers");

                foreach (Customer customer in lstPersonas)
                {
                    col.Insert(customer);
                }
            }
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (txtapellido.Text == "" || txtcedula.Text == "" || txtnombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Falta Informacion", MessageBoxIcon.Error.ToString());
            }
            else
            {
                DateTime fechausuario = dtpedad.Value;
                DateTime fechaactual = DateTime.Now;
                int diferencia = fechaactual.Year - fechausuario.Year;
                if (fechausuario > fechaactual.AddYears(-diferencia))
                {
                    diferencia--;
                }

                Customer customer = new Customer();

                customer.Name = txtnombre.Text;
                customer.LastName = txtapellido.Text;
                customer.Phones = new string[] { txtTelefono.Text };
                customer.Identification = txtcedula.Text;
                customer.BornDate = diferencia.ToString() + "Years";

                lstPersonas.Add(customer);



                n = dtgvCustomers.Rows.Add();

                dtgvCustomers.Rows[n].Cells[(int)columnas.nombre].Value = txtnombre.Text;
                dtgvCustomers.Rows[n].Cells[(int)columnas.apellido].Value = txtapellido.Text;
                dtgvCustomers.Rows[n].Cells[(int)columnas.telefono].Value = txtTelefono.Text;
                dtgvCustomers.Rows[n].Cells[(int)columnas.cedula].Value = txtcedula.Text;
                dtgvCustomers.Rows[n].Cells[(int)columnas.edad].Value = diferencia;


                txtapellido.Text = "";
                txtcedula.Text = "";
                txtnombre.Text = "";
                txtTelefono.Text = "";
                dtpedad.Value = DateTime.Now;
            }
        }



        public class Customer
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public string Identification { get; set; }
            public string BornDate { get; set; }
            public string[] Phones { get; set; }
            public bool IsActive { get; set; }
        }
    }
}

