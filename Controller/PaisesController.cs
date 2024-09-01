using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using PaisCiudad.Model;

namespace PaisCiudad.Controller
{
    public class PaisesController
    {
        private PaisesModel _paisesModel = new PaisesModel();

        public DataTable todos()
        {
            return _paisesModel.todos();
        }

        public DataTable ObtenerPaisPorId(string idPais)
        {
            return _paisesModel.ObtenerPaisPorId(idPais);
        }

        public bool ActualizarPais(string idPais, string detalle)
        {
            return _paisesModel.ActualizarPais(idPais, detalle);
        }

        public bool AgregarPais(string detalle)
        {
            return _paisesModel.AgregarPais(detalle);
        }

        public bool EliminarPais(int idPais)
        {
            return _paisesModel.EliminarPais(idPais);
        }
    }
}
