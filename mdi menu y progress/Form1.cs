namespace mdi_menu_y_progress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void arvhivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Nuevo = new Form2();

            Nuevo.MdiParent = this;
            Nuevo.Show();
            Nuevo.WindowState = FormWindowState.Maximized;
        }
    }
}