using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PaisCiudad.Config;
using PaisCiudad.Controller;

namespace PaisCiudad.Model
{
    public class CiudadesModel
    {
        public int IdCiudad { get; set; }
        public string Detalle { get; set; }
        public int IdPais { get; set; }

        public DataTable todosconrelacion()
        {
            var cadena = "SELECT Ciudades.IdCiudad, Ciudades.Detalle as Ciudad, Paises.IdPais, Paises.Detalle as 'Pais' FROM Ciudades INNER JOIN Paises ON Ciudades.IdPais = Paises.IdPais";
            using (var cn = ConexionBDD.GetConnection())
            {
                try
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(cadena, cn);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
                catch (SqlException ex)
                {
                    ControlErrores.ManejarErrorSql(ex, "Error al insertar el autor.");
                }
                catch (Exception ex)
                {
                    ControlErrores.ManejarErrorGeneral(ex, "Error al insertar el autor.");
                }
                return null;
            }
        }

        public DataTable ObtenerCiudadPorId(string idCiudad)
        {
            var query = "SELECT * FROM Ciudades WHERE IdCiudad = @IdCiudad";
            using (var cn = ConexionBDD.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, cn);
                    command.Parameters.AddWithValue("@IdCiudad", idCiudad);

                    SqlDataAdapter adaptador = new SqlDataAdapter(command);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    return tabla;
                }
                catch (SqlException ex)
                {
                    ControlErrores.ManejarErrorSql(ex, "Error al obtener la ciudad.");
                }
                catch (Exception ex)
                {
                    ControlErrores.ManejarErrorGeneral(ex, "Error al obtener la ciudad.");
                }
                return null;
            }

        }

        public bool ActualizarCiudad(string idCiudad, string detalle, string idPais)
        {
            var query = "UPDATE Ciudades SET Detalle = @Detalle, IdPais = @IdPais WHERE IdCiudad = @IdCiudad";
            using (var cn = ConexionBDD.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, cn);
                    command.Parameters.AddWithValue("@IdCiudad", idCiudad);
                    command.Parameters.AddWithValue("@Detalle", detalle);
                    command.Parameters.AddWithValue("@IdPais", idPais);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex)
                {
                    ControlErrores.ManejarErrorSql(ex, "Error al actualizar la ciudad.");
                }
                catch (Exception ex)
                {
                    ControlErrores.ManejarErrorGeneral(ex, "Error al actualizar la ciudad.");
                }
                return false;
            }
        }

        public bool AgregarCiudad(string detalle, string idPais)
        {
            var query = "INSERT INTO Ciudades (Detalle, IdPais) VALUES (@Detalle, @IdPais)";
            using (var cn = ConexionBDD.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, cn);
                    command.Parameters.AddWithValue("@Detalle", detalle);
                    command.Parameters.AddWithValue("@IdPais", idPais);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex)
                {
                    ControlErrores.ManejarErrorSql(ex, "Error al añadir la ciudad.");
                }
                catch (Exception ex)
                {
                    ControlErrores.ManejarErrorGeneral(ex, "Error al añadir la ciudad.");
                }
                return false;
            }
        }

        public bool EliminarCiudad(int idCiudad)
        {
            var query = "DELETE FROM Ciudades WHERE IdCiudad = @IdCiudad";
            using (var cn = ConexionBDD.GetConnection())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, cn);
                    command.Parameters.AddWithValue("@IdCiudad", idCiudad);

                    int filasAfectadas = command.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
                catch (SqlException ex)
                {
                    ControlErrores.ManejarErrorSql(ex, "Error al eliminar la ciudad.");
                }
                catch (Exception ex)
                {
                    ControlErrores.ManejarErrorGeneral(ex, "Error al eliminar la ciudad.");
                }
                return false;
            }
        }
    }
}
