using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaisCiudad.Controller;

namespace PaisCiudad.Views.Paises
{
    public partial class frm_Paises : Form
    {

        private PaisesController _paisesController = new PaisesController();
        private string _idPais;
        private DataGridView _dgvPaises;

        public frm_Paises(string idPais, DataGridView dgvPaises)
        {
            InitializeComponent();
            _idPais = idPais;
            _dgvPaises = dgvPaises;
            CargarPais();
        }

        private void CargarPais()
        {
            try
            {
                DataTable dataTable = _paisesController.ObtenerPaisPorId(_idPais);
                if (dataTable.Rows.Count > 0)
                {
                    var detalle = dataTable.Rows[0]["Detalle"].ToString();
                    txt_Detalle.Text = detalle;
                }
                else
                {
                    MessageBox.Show("No se encontró el país con el ID proporcionado.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al cargar los datos: " + ex.Message);
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nuevoDetalle = txt_Detalle.Text;
                bool exito = _paisesController.ActualizarPais(_idPais, nuevoDetalle);

                if (exito)
                {
                    MessageBox.Show("País actualizado correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el país.");
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
