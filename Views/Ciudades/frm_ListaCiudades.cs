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
using PaisCiudad.Controller;
using PaisCiudad.Model;
using PaisCiudad.Views;

namespace PaisCiudad.Views.Ciudades
{
    public partial class frm_ListaCiudades : Form
    {
        CiudadesController _ciudadesController = new CiudadesController();
        public frm_ListaCiudades()
        {
            InitializeComponent();
        }

        private void frm_ListaCiudades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pubsDataSet.Paises' Puede moverla o quitarla según sea necesario.
            //this.paisesTableAdapter.Fill(this.pubsDataSet.Paises);
            // TODO: esta línea de código carga datos en la tabla 'pubsDataSet.Ciudades' Puede moverla o quitarla según sea necesario.
            //this.ciudadesTableAdapter.Fill(this.pubsDataSet.Ciudades);

            dgv_Ciudades.DataSource = _ciudadesController.todosconrelacion();
            /*dgvCiudades.Columns["Ciudad"].Visible = true;
            dgvCiudades.Columns["IdCiudad"].Visible = false;
            dgvCiudades.Columns["Pais"].Visible = true;
            dgvCiudades.Columns["IdPais"].Visible = false;*/

            dgv_Ciudades.Columns[0].Visible = false;
            dgv_Ciudades.Columns[1].Visible = true;
            dgv_Ciudades.Columns[2].Visible = false;
            dgv_Ciudades.Columns[3].Visible = true;

            // Ciudades.IdCiudad, Ciudades.Detalle as Ciudad, Paises.IdPais, Paises.Detalle AS 'Pais' FROM Ciudades 

            DataGridViewButtonColumn btnGrid = new DataGridViewButtonColumn();
            btnGrid.HeaderText = "Editar";
            btnGrid.Name = "Editar";
            btnGrid.Text = "Editar";
            btnGrid.UseColumnTextForButtonValue = true;
            dgv_Ciudades.Columns.Add(btnGrid);
        }

        private void dgv_Ciudades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_Ciudades.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                var id = dgv_Ciudades.Rows[e.RowIndex].Cells["IdCiudad"].Value.ToString();
                frm_Ciudades _Ciudades = new frm_Ciudades(id, dgv_Ciudades);
                _Ciudades.ShowDialog();
            }
        }

        private void btn_NuevaCiudad_Click(object sender, EventArgs e)
        {
            frm_NuevaCiudad nuevaCiudadForm = new frm_NuevaCiudad();
            nuevaCiudadForm.ShowDialog();
            dgv_Ciudades.DataSource = _ciudadesController.todosconrelacion();
        }

        private void btn_EliminarCiudad_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Ciudades.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione una registro para eliminar.");
                    return;
                }

                int idCiudad = Convert.ToInt32(dgv_Ciudades.SelectedRows[0].Cells["IdCiudad"].Value);

                CiudadesController _ciudadesController = new CiudadesController();
                bool exito = _ciudadesController.EliminarCiudad(idCiudad);

                if (exito)
                {
                    MessageBox.Show("Ciudad eliminada correctamente.");
                    CargarCiudades();
                }
                else
                {
                    MessageBox.Show("Error al eliminar la ciudad.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }

        private void CargarCiudades()
        {
            try
            {
                CiudadesController _ciudadesController = new CiudadesController();
                var ciudades = _ciudadesController.ObtenerTodasLasCiudades();
                dgv_Ciudades.DataSource = ciudades;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al cargar las ciudades: " + ex.Message);
            }
        }
    }
}
