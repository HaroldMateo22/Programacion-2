using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crear_Clase__base_de_datos
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            using (var db = new LiteDataBase(@"C:\Temp\MyData.db"))
            {
                // Get a collection (or create, if doesn't exist)
                var col = db.GetCollection<Customer>("customers");



                // Create your new customer instance
                var customer = new Customer
                {
                    Name = "John Doe",
                    Phones = new string[] { "8000-0000", "9000-0000" },
                    IsActive = true
                };







                // Insert new customer document (Id will be auto-incremented)
                col.Insert(customer);



                var cliente1 = new Customer
                {
                    Name = "Derick Peralta",
                    Phones = new string[] { "809-345-2020", "809-456-6785" },
                    IsActive = true
                };
                col.Insert(cliente1);



                var cliente2 = new Customer
                {
                    Name = "Dera Josefa",
                    Phones = new string[] { "809-404-0440", "809-456-2341" },
                    IsActive = false
                };
                col.Insert(cliente2);






                // Update a document inside a collection
                customer.Name = "Carlos Doe";



                col.Update(customer);



                // Index document using document Name property
                col.EnsureIndex(x => x.Name);



                // Use LINQ to query documents (filter, sort, transform)
                var results = col.Query()
                    .Where(x => x.Name.StartsWith("D"))
                    .OrderBy(x => x.Name)
                    .Select(x => new { x.Name, NameUpper = x.Name.ToUpper() })
                    .Limit(10)
                    .ToList();



                // Let's create an index in phone numbers (using expression). It's a multikey index
                col.EnsureIndex(x => x.Phones);



                // and now we can query phones
                var r = col.FindOne(x => x.Phones.Contains("8888-5555"));

            }
        }


        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string[] Phones { get; set; }
            public bool IsActive { get; set; }
        }
    }
}
