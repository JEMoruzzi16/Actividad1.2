using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Servicio;
namespace Servicio
{
    public class Pedido_ProductoServicio
    {
        public void agregar(int numeroPedido, int codigoProducto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Pedido_Producto(NroPedido,CodigoProducto) values(@Pedido,@Producto)");
                datos.setearParametro("@Pedido", numeroPedido);
                datos.setearParametro("@Producto", codigoProducto);
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

        public List<Pedido_Producto> getLista(int numeroPedido)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Pedido_Producto> lista = new List<Pedido_Producto>();
            try
            {
                datos.setearConsulta("SELECT CodigoProducto from Pedido_Producto WHERE NroPedido = @nroPedido");
                datos.setearParametro("@nroPedido", numeroPedido);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Pedido_Producto aux = new Pedido_Producto();
                    aux.nroPedido = numeroPedido;
                    aux.codigoProducto = (int)datos.Lector["CodigoProducto"];
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
        
    }

}
