using PaisCiudad.Controller;
using PaisCiudad.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaisCiudad.Views.Ciudades
{
    public partial class frm_NuevaCiudad : Form
    {
        public frm_NuevaCiudad()
        {
            InitializeComponent();
        }

        private void frm_NuevaCiudad_Load(object sender, EventArgs e)
        {
            PaisesController _paises = new PaisesController();
            cmb_Pais.DataSource = _paises.todos();
            cmb_Pais.DisplayMember = "Detalle";
            cmb_Pais.ValueMember = "IdPais";
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Pais.SelectedValue == null)
                {
                    MessageBox.Show("Por favor selecciona un Pais.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_Detalle.Text))
                {
                    MessageBox.Show("Este campo no puede estar vacio.");
                    return;
                }

                CiudadesController _ciudadesController = new CiudadesController();
                bool exito = _ciudadesController.AgregarCiudad(
                    txt_Detalle.Text,
                    cmb_Pais.SelectedValue.ToString()
                );

                if (exito)
                {
                    MessageBox.Show("Ciudad añadida correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al añadir la ciudad.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Detalle.Text = string.Empty;
            cmb_Pais.SelectedIndex = -1;
        }
    }
}
