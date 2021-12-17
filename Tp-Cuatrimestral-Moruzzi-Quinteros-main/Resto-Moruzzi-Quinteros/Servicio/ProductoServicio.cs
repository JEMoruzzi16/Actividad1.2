using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Servicio;

namespace Servicio
{
    public class ProductoServicio
    {
        public List<Producto> listar()
        {
            List<Producto> lista = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Pr.Codigo, Pr.IdTipoProducto,Pr.DescripcionPlato, Pr.Precio, Pr.Stock FROM Producto as Pr where Estado = 1");
                datos.ejecutarLectura();
                

                while(datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Codigo = (int)datos.Lector["Codigo"];
                    aux.IdTipoProducto = (int)datos.Lector["IdTipoProducto"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Stock = (int)datos.Lector["Stock"];
                    aux.DescripcionPlato = (string)datos.Lector["DescripcionPlato"];

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

        public void agregar(Producto newProducto)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("insert into Producto(IdTipoProducto, Precio, Stock, Estado, DescripcionPlato) values(@IdTipoProducto, @Precio, @Stock, @Estado, @DescripcionPlato)");
                accesoDatos.setearParametro("@IdTipoProducto",newProducto.IdTipoProducto);
                accesoDatos.setearParametro("@Precio", newProducto.Precio);
                accesoDatos.setearParametro("@Stock",newProducto.Stock);
                accesoDatos.setearParametro("@Estado",newProducto.Estado);
                accesoDatos.setearParametro("@DescripcionPlato",newProducto.DescripcionPlato);           
                accesoDatos.ejecutarAccion();    
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public void modificar(Producto productoModificado)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("update Producto set IdTipoProducto = @IdTipoProducto, Precio = @Precio, Stock = @Stock, Estado=@Estado, DescripcionPlato=@DescripcionPlato where Codigo=@Codigo");
                accesoDatos.setearParametro("@IdTipoProducto", productoModificado.IdTipoProducto);
                accesoDatos.setearParametro("@Precio",productoModificado.Precio);
                accesoDatos.setearParametro("@Stock",productoModificado.Stock);
                accesoDatos.setearParametro("@Estado",productoModificado.Estado);
                accesoDatos.setearParametro("@DescripcionPlato",productoModificado.DescripcionPlato);
                accesoDatos.setearParametro("@Codigo",productoModificado.Codigo);
                accesoDatos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

        }

        public void Eliminar(int codigoEliminado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Producto SET Estado = 0 where Codigo = @Codigo");
                datos.setearParametro("@Codigo", codigoEliminado);
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
        public Producto buscarPorCodigo(int codigo, int codigoTipo)
        {
            Producto aux = new Producto();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select IdTipoProducto,Precio,Stock,Estado,DescripcionPlato from producto where Codigo = @codigo");
                datos.setearParametro("@codigo", codigo);
                //datos.setearParametro("@IdTipo", codigoTipo);
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    aux.Codigo = codigo;
                    aux.IdTipoProducto = (int)datos.Lector["IdTipoProducto"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Stock = (int)datos.Lector["Stock"];
                    aux.Estado = (Boolean)datos.Lector["Estado"];
                    aux.DescripcionPlato = (string)datos.Lector["DescripcionPlato"];
                }
                return aux;
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

        public Producto buscarXDescripcion(string descripcion)
        {
            Producto aux = new Producto();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Codigo, IdTipoProducto,Precio,Stock,Estado,DescripcionPlato from producto where DescripcionPlato LIKE @descripcion");
                datos.setearParametro("@descripcion", descripcion);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    aux.Codigo = (int)datos.Lector["Codigo"];
                    aux.IdTipoProducto = (int)datos.Lector["IdTipoProducto"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Stock = (int)datos.Lector["Stock"];
                    aux.Estado = (Boolean)datos.Lector["Estado"];
                    aux.DescripcionPlato = (string)datos.Lector["DescripcionPlato"];
                }
                return aux;
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

        public List<Producto> listarProductosXPedido(List<Pedido_Producto> ListaPedidoProducto, int nroPedido)
        {

            List<Producto> lista = new List<Producto>();
            //AccesoDatos datos1 = new AccesoDatos();
            try
            {
                //datos1.setearConsulta("SELECT CodigoProducto FROM Pedido_Producto WHERE NroPedido = @Pedido");
                //datos1.setearParametro("@pedido",nroPedido );
                //datos1.ejecutarLectura();


                foreach (Pedido_Producto item in ListaPedidoProducto)
                {
                    AccesoDatos datos = new AccesoDatos();
                    datos.setearConsulta("SELECT Pr.Codigo, Pr.IdTipoProducto,Pr.DescripcionPlato, Pr.Precio, Pr.Stock FROM Producto as Pr where Pr.Codigo=@codigo");
                    datos.setearParametro("@codigo", item.codigoProducto);
                    datos.ejecutarLectura();

                    if (datos.Lector.Read())
                    {
                        Producto aux = new Producto();
                        aux.Codigo = (int)datos.Lector["Codigo"];
                        aux.IdTipoProducto = (int)datos.Lector["IdTipoProducto"];
                        aux.Precio = (decimal)datos.Lector["Precio"];
                        aux.Stock = (int)datos.Lector["Stock"];
                        aux.DescripcionPlato = (string)datos.Lector["DescripcionPlato"];

                        lista.Add(aux);
                        datos.cerrarConexion();
                        
                    }

                }



                //while (datos1.Lector.Read())
                //{
                //    datos.setearConsulta("SELECT Pr.Codigo, Pr.IdTipoProducto,Pr.DescripcionPlato, Pr.Precio, Pr.Stock FROM Producto as Pr where Pr.Codigo=@codigo");
                //    datos.setearParametro("@codigo",(int)datos1.Lector["CodigoProducto"]);
                //    int aver= (int)datos1.Lector["CodigoProducto"];
                //    datos.ejecutarLectura();

                //    while (datos.Lector.Read())
                //    {
                //        Producto aux = new Producto();
                //        aux.Codigo = (int)datos.Lector["Codigo"];
                //        aux.IdTipoProducto = (int)datos.Lector["IdTipoProducto"];
                //        aux.Precio = (decimal)datos.Lector["Precio"];
                //        aux.Stock = (int)datos.Lector["Stock"];
                //        aux.DescripcionPlato = (string)datos.Lector["DescripcionPlato"];

                //        lista.Add(aux);
                //    }
                //}
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //datos.cerrarConexion();
                //datos1.cerrarConexion();
            }

        }
    }
}
