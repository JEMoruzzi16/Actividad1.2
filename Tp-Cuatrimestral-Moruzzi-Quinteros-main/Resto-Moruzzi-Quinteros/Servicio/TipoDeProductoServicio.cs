using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Servicio
{
    public class TipoDeProductoServicio
    {
        public List<TipoDeProducto> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<TipoDeProducto> lista = new List<TipoDeProducto>();
            try
            {
                datos.setearConsulta("SELECT TdP.Id, Tdp.Descripcion from TipoDeProducto as TdP where Estado = 1");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TipoDeProducto aux = new TipoDeProducto();
                    aux.IdTipoProducto = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

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

        public List<TipoDeProducto> listarConDDL()
        {
            AccesoDatos datos = new AccesoDatos();
            List<TipoDeProducto> lista = new List<TipoDeProducto>();
            try
            {
                datos.setearConsulta("SELECT Tdp.Descripcion from TipoDeProducto as TdP");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    TipoDeProducto aux = new TipoDeProducto();
                    aux.Descripcion =(string)datos.Lector["Descripcion"].ToString();

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
        public void agregar(TipoDeProducto nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("INSERT INTO TipoDeProducto(Descripcion) VALUES(@Descripcion)");
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.ejecutarAccion();
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
        public void modificar(TipoDeProducto modificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update TipoDeProducto SET Descripcion=@Descripcion where Id=@Id");
                datos.setearParametro("@Descripcion", modificado.Descripcion);
                datos.setearParametro("@Id", modificado.IdTipoProducto);
                datos.ejecutarAccion();

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
        public void eliminar(TipoDeProducto eliminado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update TipoDeProducto set Estado = 0 where id = @IdTipoProducto");
                datos.setearParametro("@IdTipoProducto", eliminado.IdTipoProducto);
                datos.ejecutarAccion();
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

    }
}
