using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaisCiudad.Views.Usuarios
{
    public partial class frm_ListaUsuarios : Form
    {
        public frm_ListaUsuarios()
        {
            InitializeComponent();
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            frm_Usuarios usuarios = new frm_Usuarios();
            usuarios.Show();
        }

        private void frm_ListaUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pubsDataSet.usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.pubsDataSet.usuario);

        }
    }
}
