using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using DiscosDatos;

namespace Soluciones
{
    public class UserMetodos
    {
        public void Nuevo(Users users)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into USERS set UrlImagenPerfil = @imagen,pass=@pass,email = @email,nombre = @nombre,apellido=@apellido,fechaNacimiento=@fecha where Id = @id");
                //           datos.setearConsulta("Insert into Users SET UrlImagenPerfil = @imagen,pass=@pass,email = @email,nombre = @nombre,apellido=@apellido,fechaNacimiento=@fecha,Id = @id");

                datos.setearParametro("@imagen", users.UrlImagenPerfil);
                datos.setearParametro("@pass", users.pass);
                datos.setearParametro("@email", users.email);
                datos.setearParametro("@nombre", users.nombre);
                datos.setearParametro("@apellido", users.apellido);
                datos.setearParametro("@fecha", users.fechaNacimiento);
                datos.ejecutarAccion();



            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public bool isAdmin()
        {

            Users user = new Users();

            try
            {
                if (user.email.ToLower().Contains("admin@gmail.com"))
                {
                    user.admin = true;
                }

                return false;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void Login(Users user)

        {

        }

    }
}
