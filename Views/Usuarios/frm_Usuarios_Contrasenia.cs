using PaisCiudad.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaisCiudad.Model;

namespace PaisCiudad.Views.Usuarios
{
    public partial class frm_Usuarios_Contrasenia : Form
    {
        private int usuarioId;

        public frm_Usuarios_Contrasenia(int id)
        {
            InitializeComponent();
            usuarioId = id;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                UsuariosController usuariosController = new UsuariosController();
                var usuario = usuariosController.ObtenerUsuarioPorId(usuarioId);

                if (usuario != null)
                {
                    if (txt_contraseniaNueva.Text.Trim() == txt_confirmarContrasenia.Text.Trim())
                    {
                        usuario.Password = txt_contraseniaNueva.Text.Trim();
                        var resultado = usuariosController.ActualizarUsuario(usuario);

                        if (resultado == "OK")
                        {
                            MessageBox.Show("Contraseña actualizada.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar la contraseña.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden.");
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario.");
                }
            }
        }
        private void frm_Usuarios_Contrasenia_Load(object sender, EventArgs e)
        {

        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txt_contraseniaNueva.Text))
            {
                MessageBox.Show("Ingrese la nueva contraseña.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_confirmarContrasenia.Text))
            {
                MessageBox.Show("Confirme la nueva contraseña.");
                return false;
            }
            return true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
