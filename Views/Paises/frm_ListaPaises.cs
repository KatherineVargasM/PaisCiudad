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
    public partial class frm_ListaPaises : Form
    {
        PaisesController _paisesController = new PaisesController();
        public frm_ListaPaises()
        {
            InitializeComponent();
        }

        private void frm_ListaPaises_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'pubsDataSet.Paises' Puede moverla o quitarla según sea necesario.
            //this.paisesTableAdapter.Fill(this.pubsDataSet.Paises);

            dgv_Paises.DataSource = _paisesController.todos();

        }



        private void dgv_Paises_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_Paises.Columns["Editar"].Index && e.RowIndex >= 0)
            {
                var id = dgv_Paises.Rows[e.RowIndex].Cells["IdPais"].Value.ToString();
                frm_Paises _paisesForm = new frm_Paises(id, dgv_Paises);
                if (_paisesForm.ShowDialog() == DialogResult.OK)
                {
                    CargarPaises();
                }
            }
        }
        private void btn_NuevoPais_Click(object sender, EventArgs e)
        {
            frm_NuevoPais nuevoPaisForm = new frm_NuevoPais();
            nuevoPaisForm.ShowDialog();
            dgv_Paises.DataSource = _paisesController.todos();
        }

        private void btn_EliminarPais_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Paises.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un registro para eliminar.");
                    return;
                }

                int idPais = Convert.ToInt32(dgv_Paises.SelectedRows[0].Cells["IdPais"].Value);

                bool exito = _paisesController.EliminarPais(idPais);

                if (exito)
                {
                    MessageBox.Show("País eliminado correctamente.");
                    CargarPaises();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el país.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error: " + ex.Message);
            }
        }

        private void CargarPaises()
        {
            try
            {
                var paises = _paisesController.todos();
                dgv_Paises.DataSource = paises;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al cargar los países: " + ex.Message);
            }
        }
    }
}
