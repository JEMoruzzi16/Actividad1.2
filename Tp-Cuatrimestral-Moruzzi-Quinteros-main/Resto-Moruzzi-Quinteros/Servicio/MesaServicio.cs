using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Servicio;

namespace Servicio
{
    public class MesaServicio
    {
        public Mesa dibujarMesa(int numeroDeMesa)
        {
            Mesa nuevaMesa = new Mesa();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select M.Capacidad,M.Estado  from Mesa as M where M.Nro = @nro");
                datos.setearParametro("@nro", numeroDeMesa);
                datos.ejecutarLectura();
                while(datos.Lector.Read())
                {
                    nuevaMesa.NumeroMesa = numeroDeMesa;
                    nuevaMesa.MaxCapacidad = (int)datos.Lector["Capacidad"];
                    nuevaMesa.Estado = (Boolean)datos.Lector["Estado"];
                }

                return nuevaMesa;
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

        public void abrirMesa(int nro)
        {
            Mesa auxMesa = new Mesa();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Mesa set Estado=1 where Nro= @nro;");
                datos.setearParametro("@nro", nro);
                datos.ejecutarLectura();
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
        public void cerrarMesa(int nro)
        {
            Mesa auxMesa = new Mesa();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Mesa set Estado=0 where Nro= @nro;");
                datos.setearParametro("@nro", nro);
                datos.ejecutarLectura();
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
