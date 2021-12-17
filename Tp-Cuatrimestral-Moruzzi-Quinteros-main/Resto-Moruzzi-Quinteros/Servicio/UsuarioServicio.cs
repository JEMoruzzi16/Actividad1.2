using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Servicio;

namespace Servicio
{
    public class UsuarioServicio
    {
        public void agregar(Usuario nuevo)
        {
            AccesoDatos data = new AccesoDatos();
            try
            {
                data.setearConsulta("INSERT INTO Usuarios(Usuario,Contrasena,Tipo) values (@Usuario,@Contrasena,@Tipo)");
                data.setearParametro("@Usuario", nuevo.NombreUsuario);
                data.setearParametro("@Contrasena", nuevo.Contrasena);
                data.setearParametro("@Tipo", nuevo.Tipo);
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

        public List<Usuario> listar()
        {
            List<Usuario> lista = new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Usr.Usuario, Usr.Contrasena, Usr.Tipo, Usr.Estado FROM Usuarios as Usr where Usr.Estado = 1");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.NombreUsuario = datos.Lector["Usuario"].ToString();
                    aux.Contrasena = datos.Lector["Contrasena"].ToString();
                    aux.Tipo = (int)datos.Lector["Tipo"];
                    aux.Estado = (bool)datos.Lector["Estado"];
                    
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

        public Usuario buscarXUsuario(string objetivo)
        {
            AccesoDatos data = new AccesoDatos();
            Usuario aux= new Usuario();
            try
            {
                data.setearConsulta("SELECT us.Id, us.Usuario, us.Contrasena, us.Tipo, us.Estado FROM Usuarios as us where us.Usuario = @Usuario");
                data.setearParametro("@Usuario", objetivo);
                data.ejecutarLectura();

                while (data.Lector.Read())
                {
                    aux.Id = (int)data.Lector["Id"];
                    aux.NombreUsuario = (string)data.Lector["Usuario"];
                    aux.Contrasena = (string)data.Lector["Contrasena"];
                    aux.Tipo = (int)data.Lector["Tipo"];
                }

                return aux; 
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }


        public Usuario Loguear(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select us.Id, us.Usuario, us.Contrasena, us.Tipo, us.Estado from Usuarios as us where Us.Usuario = @user and Us.Contrasena = @pass");
                datos.setearParametro("@user", usuario.NombreUsuario);
                datos.setearParametro("@pass", usuario.Contrasena);

                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.NombreUsuario = (string)datos.Lector["Usuario"];
                    usuario.Contrasena = (string)datos.Lector["Contrasena"];
                    usuario.Tipo = (int)datos.Lector["Tipo"];
                    usuario.Estado = (bool)datos.Lector["Estado"];
                    /*
                    if((TipoUsuario)datos.Lector["Tipo"] == TipoUsuario.MESERO)
                    {DD
                        usuario.Tipo = TipoUsuario.MESERO;
                    }else
                    {
                        usuario.Tipo = TipoUsuario.GERENTE;
                    }*/
                    return usuario;
                }
                usuario.Tipo = 0;
                return usuario;
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

        public void identificarUser(Usuario user)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT Usr.Usuario, Usr.Contrasena, Usr.Tipo, Usr.Estado FROM Usuarios as Usr where Usr.Usuario = @user AND Usr.Contrasena = @pass ");
                datos.setearParametro("@User", user.NombreUsuario);
                datos.setearParametro("@pass", user.Contrasena);

                datos.ejecutarLectura();
                if (datos.Lector.Read())
                {

                    user.Tipo = (int)(datos.Lector["TipoUser"]) == 2 ? 2 : 1;
                }
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
