﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.CodeDom.Compiler;

namespace LiteDBProject
{
    public partial class Form1 : Form
    {
        public string resultado;

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
        /*
        static void Valid(string[] args)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"C:\Users\Ender\Documents\Nuevos Proyectos\Programacion2\Calculadora\LiteDBProject - Copy\Resources\XmlPersonas.xml");
            UsingXmlReader(path);
        }


        private static void UsingXmlReader(string path)
        {
            XmlReader xmlReader = XmlReader.Create(path);

            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "nombres"))
                {
                    if (xmlReader.HasAttributes)
                    {
                        
                    }
                }
            }
        }
        */
        public int diferencia;

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
                
                XmlDocument xmlDock = new XmlDocument();
                xmlDock.Load(@"C:\Users\epsi.ESTUDIANTE\Documents\FuryProyects\LiteDBProject - Copy\Resources\XmlPersonas.xml");

                string tagname = "comprador";
                XmlNodeList nodes = xmlDock.GetElementsByTagName(tagname);

                foreach (XmlNode node in nodes)
                {
                    string nombres = node.SelectSingleNode("nombres").InnerText;
                    string apellidos = node.SelectSingleNode("apellidos").InnerText;
                    string telefonos = node.SelectSingleNode("telefonos").InnerText;
                    string cedulas = node.SelectSingleNode("cedulas").InnerText;
                    string edades = node.SelectSingleNode("edades").InnerText;
                if (node.InnerText.Contains(txtbusqueda.Text))
                {
                    dtgvCustomers.Rows.Add(nombres,apellidos, telefonos, cedulas, edades);
                }
                else
                {
                    MessageBox.Show("Informacion No Encontrada", MessageBoxIcon.Error.ToString());
                }
                }
                /*
                

                /////////////////////////////////////////////////////////////////////////////////////////////////

                DataSet ds = new DataSet();
                ds.ReadXml(@"C:\Users\epsi.ESTUDIANTE\Documents\FuryProyects\LiteDBProject - Copy\Resources\XmlPersonas.xml");

                var query = from comprador in ds.Tables[0].AsEnumerable()
                            where comprador.Field<string>("comprador").Contains(txtbusqueda.Text.ToString())
                            select new
                            {
                                nombres = comprador.Field<string>("nombres"),
                                apellidos = comprador.Field<string>("apellidos"),
                                telefonos = comprador.Field<string>("telefonos"),
                                cedulas = comprador.Field<string>("cedulas"),
                                edades = comprador.Field<string>("edades")
                            };
                dtgvCustomers.DataSource = query.ToList();

                /////////////////////////////////////////////////////////////////////////////////////////////////

                var filename = @"C:\Users\epsi.ESTUDIANTE\Documents\FuryProyects\LiteDBProject - Copy\Resources\XmlPersonas.xml";
                XElement personasXML = XElement.Load(filename);


                var compradores = from x in personasXML.Element("compradores").Elements("comprador")
                                  select x;

                foreach(var comprador in compradores)
                {
                    
                }
                */
            
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
                diferencia = fechaactual.Year - fechausuario.Year;
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

        private void btnbuscardb_Click(object sender, EventArgs e)
        {
            using (var db = new LiteDB.LiteDatabase(@"C:\Temp\MyData.db"))
            {
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<Customer>("customers");


                if (txtnombre.Text != "")
                {
                    var results = col.Query()
                   .Where(x => x.Name.Contains(txtnombre.Text))
                   .OrderBy(x => x.Name)
                   .Select(x => new { x.Name})
                   .Limit(10)
                   .ToList();

                    foreach (var x in results)
                    {
                        n = dtgvCustomers.Rows.Add();
                        dtgvCustomers.Rows[n].Cells[(int)columnas.nombre].Value = results.ToList();
                    }
                }
                else if (txtapellido.Text != "")
                {
                    
                }
                else if (txtcedula.Text != "")
                {
                    
                }
                else if (txtTelefono.Text != "")
                {
                    
                }
                else
                {
                    MessageBox.Show("Ingrese la informacion a buscar", MessageBoxIcon.Error.ToString());
                }
            }
        }
    }
}

