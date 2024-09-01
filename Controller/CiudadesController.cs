using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaisCiudad.Model;


namespace PaisCiudad.Controller
{
    class CiudadesController
    {
        CiudadesModel _ciudadesModel = new CiudadesModel();

        public DataTable todosconrelacion()
        {
            return _ciudadesModel.todosconrelacion();
        }

        public DataTable ObtenerTodasLasCiudades()
        {
            return _ciudadesModel.todosconrelacion();
        }

        public DataTable ObtenerCiudadPorId(string idCiudad)
        {
            return _ciudadesModel.ObtenerCiudadPorId(idCiudad);
        }

        public bool ActualizarCiudad(string idCiudad, string detalle, string idPais)
        {
            return _ciudadesModel.ActualizarCiudad(idCiudad, detalle, idPais);
        }

        public bool AgregarCiudad(string detalle, string idPais)
        {
            return _ciudadesModel.AgregarCiudad(detalle, idPais);
        }

        public bool EliminarCiudad(int idCiudad)
        {
            return _ciudadesModel.EliminarCiudad(idCiudad);
        }
    }
}
