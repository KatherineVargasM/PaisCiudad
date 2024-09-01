using PaisCiudad.Views.Ciudades;
using PaisCiudad.Views.Paises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaisCiudad.Views
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void lISTACIUDADESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ListaCiudades listaCiudades = new frm_ListaCiudades();
            listaCiudades.Show();
        }

        private void lISTAPAISESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ListaPaises listaPaises = new frm_ListaPaises();
            listaPaises.Show();
        }
    }
}
