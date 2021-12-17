using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Servicio;

namespace Servicio
{
    public class MetodoDePagoServicio
    {
        public List<MetodoPago> listar()
        {
            List<MetodoPago> lista = new List<MetodoPago>();
            AccesoDatos datos = new AccesoDatos();         

            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM MetodoPago");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    MetodoPago aux = new MetodoPago();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (String)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public int metodoPorDescripcion(string descripcion)
        {
            MetodoPago metodo = new MetodoPago();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                int idMetodo=0;

                datos.setearConsulta("SELECT Id FROM MetodoPago where Descripcion=@descripcion");
                datos.setearParametro("descripcion", descripcion);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    MetodoPago aux = new MetodoPago();
                    aux.Id = (int)datos.Lector["Id"];
                    idMetodo = aux.Id;
                }

                    return idMetodo;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

    }
}
