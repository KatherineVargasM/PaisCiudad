using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PaisCiudad.Controller;
using PaisCiudad.Model;

namespace PaisCiudad.Views.Ciudades
{
    public partial class frm_Ciudades : Form
    {
        private DataGridView dgvCiudades;
        private string idCiudad;

        public frm_Ciudades(string id, DataGridView dgv)
        {
            InitializeComponent();
            this.idCiudad = id;
            this.dgvCiudades = dgv;
        }

        private void frm_Ciudades_Load(object sender, EventArgs e)
        {
            PaisesController _paises = new PaisesController();
            cmb_Pais.DataSource = _paises.todos();
            cmb_Pais.DisplayMember = "Detalle";
            cmb_Pais.ValueMember = "IdPais";

            if (!string.IsNullOrEmpty(this.idCiudad))
            {
                CargarCiudad(this.idCiudad);
            }
        }

        private void CargarCiudad(string idCiudad)
        {
            CiudadesController _ciudadesController = new CiudadesController();
            DataTable ciudad = _ciudadesController.ObtenerCiudadPorId(idCiudad);
            if (ciudad.Rows.Count > 0)
            {
                DataRow fila = ciudad.Rows[0];
                txt_Detalle.Text = fila["Detalle"].ToString();
                cmb_Pais.SelectedValue = fila["IdPais"].ToString();
            }
            else
            {
                MessageBox.Show("Ciudad no encontrada.");
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Pais.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, seleccione un país.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_Detalle.Text))
                {
                    MessageBox.Show("Por favor, complete el campo.");
                    return;
                }

                CiudadesController _ciudadesController = new CiudadesController();
                bool exito = _ciudadesController.ActualizarCiudad(
                    this.idCiudad,
                    txt_Detalle.Text,
                    cmb_Pais.SelectedValue.ToString()
                );

                if (exito)
                {
                    MessageBox.Show("Ciudad actualizada correctamente.");

                    if (dgvCiudades != null)
                    {
                        dgvCiudades.DataSource = _ciudadesController.ObtenerTodasLasCiudades();
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar la ciudad.");
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
