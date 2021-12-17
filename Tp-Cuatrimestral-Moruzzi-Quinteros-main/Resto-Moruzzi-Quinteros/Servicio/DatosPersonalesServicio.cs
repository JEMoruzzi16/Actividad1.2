using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Servicio;

namespace Servicio
{
    public class DatosPersonalesServicio
    {
        public List<DatosPersonales> listar()
        {
            List<DatosPersonales> lista = new List<DatosPersonales>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select DP.Usuario, DP.Nombre, DP.Apellido, DP.FechaNacimiento, DP.FechaIngreso from DatosPersonales as DP");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    DatosPersonales aux = new DatosPersonales();
                    aux.NombreUsuario = (String)datos.Lector["Usuario"];
                    aux.NombreUsuario = (String)datos.Lector["Nombre"];
                    aux.NombreUsuario = (String)datos.Lector["Apellido"];
                    aux.FechaNac = (DateTime)datos.Lector["FechaNacimiento"];
                    aux.FechaNac = (DateTime)datos.Lector["FechaIngreso"];

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

        public void agregar(DatosPersonales nuevo)
        {
            AccesoDatos data = new AccesoDatos();
            try
            {
                data.setearConsulta("INSERT INTO DatosPersonales(Usuario,Nombre,Apellido,FechaNacimiento,FechaIngreso) values (@NombreUsuario , @Nombre,@Apellido, @FechaNacimiento,@FechaIngreso)");
                data.setearParametro("@NombreUsuario", nuevo.NombreUsuario);
                data.setearParametro("@Nombre", nuevo.Nombre);
                data.setearParametro("@Apellido", nuevo.Apellido);
                data.setearParametro("@FechaNacimiento", nuevo.FechaNac);
                data.setearParametro("@FechaIngreso", nuevo.FechaIngreso);
                data.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }

    }
}
