using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using PaisCiudad.Config;

namespace PaisCiudad.Views.Usuarios
{
    public partial class frm_ReporteUsuarios : Form
    {
        public frm_ReporteUsuarios()
        {
            InitializeComponent();
        }

        private void frm_ReporteUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pubsDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.pubsDataSet.usuario);

            this.reportViewer1.RefreshReport();
            
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
