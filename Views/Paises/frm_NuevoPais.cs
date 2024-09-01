using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaisCiudad.Config;
using PaisCiudad.Model;
using PaisCiudad.Controller;

namespace PaisCiudad.Views.Paises
{
    public partial class frm_NuevoPais : Form
    {
        private PaisesController _paisesController;
        public frm_NuevoPais()
        {
            InitializeComponent();
            _paisesController = new PaisesController();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string detalle = txt_Detalle.Text.Trim();

                if (string.IsNullOrEmpty(detalle))
                {
                    MessageBox.Show("Por favor, ingrese un detalle para el país.");
                    return;
                }

                bool exito = _paisesController.AgregarPais(detalle);

                if (exito)
                {
                    MessageBox.Show("País agregado correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el país.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
