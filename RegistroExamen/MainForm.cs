using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroExamen.UI.Registros;
using RegistroExamen.UI.Consultas;


namespace RegistroExamen
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void registrarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarArticulo view = new RegistrarArticulo();
            view.Show();
        }

        private void consultarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar view = new Consultar();
            view.Show();
        }
    }
}
