using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using PaisCiudad.Config;

namespace PaisCiudad.Model
{
    public class PaisesModel
    {
        public int IdPais { get; set; }
        public string Detalle { get; set; }

        public DataTable todos()
        {
            var query = "SELECT IdPais, Detalle FROM Paises";
            using (var cn = ConexionBDD.GetConnection())
            {
                try
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(query, cn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
                catch (SqlException ex)
                {
                    ControlErrores.ManejarErrorSql(ex, "Error al obtener todos los países.");
                }
                catch (Exception ex)
                {
                    ControlErrores.ManejarErrorGeneral(ex, "Error al obtener todos los países.");
                }
                return null;
            }
        }

        public DataTable ObtenerPaisPorId(string idPais)
        {
            var query = "SELECT * FROM Paises WHERE IdPais = @IdPais";
            using (var cn = ConexionBDD.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, cn);
                    command.Parameters.AddWithValue("@IdPais", idPais);

                    SqlDataAdapter adaptador = new SqlDataAdapter(command);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
                catch (SqlException ex)
                {
                    ControlErrores.ManejarErrorSql(ex, "Error al obtener el país.");
                }
                catch (Exception ex)
                {
                    ControlErrores.ManejarErrorGeneral(ex, "Error al obtener el país.");
                }
                return null;
            }
        }

        public bool ActualizarPais(string idPais, string detalle)
        {
            var query = "UPDATE Paises SET Detalle = @Detalle WHERE IdPais = @IdPais";
            using (var cn = ConexionBDD.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, cn);
                    command.Parameters.AddWithValue("@IdPais", idPais);
                    command.Parameters.AddWithValue("@Detalle", detalle);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex)
                {
                    ControlErrores.ManejarErrorSql(ex, "Error al actualizar el país.");
                }
                catch (Exception ex)
                {
                    ControlErrores.ManejarErrorGeneral(ex, "Error al actualizar el país.");
                }
                return false;
            }
        }

        public bool AgregarPais(string detalle)
        {
            var query = "INSERT INTO Paises (Detalle) VALUES (@Detalle)";
            using (var cn = ConexionBDD.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, cn);
                    command.Parameters.AddWithValue("@Detalle", detalle);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex)
                {
                    ControlErrores.ManejarErrorSql(ex, "Error al agregar el país.");
                }
                catch (Exception ex)
                {
                    ControlErrores.ManejarErrorGeneral(ex, "Error al agregar el país.");
                }
                return false;
            }
        }

        public bool EliminarPais(int idPais)
        {
            var query = "DELETE FROM Paises WHERE IdPais = @IdPais";
            using (var cn = ConexionBDD.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, cn);
                    command.Parameters.AddWithValue("@IdPais", idPais);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex)
                {
                    ControlErrores.ManejarErrorSql(ex, "Error al eliminar el país.");
                }
                catch (Exception ex)
                {
                    ControlErrores.ManejarErrorGeneral(ex, "Error al eliminar el país.");
                }
                return false;
            }
        }
    }
}
