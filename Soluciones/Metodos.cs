using Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscosDatos
{
    public class Metodos
    {
        public List<Articulos> listar()
        {

            List<Articulos> lista = new List<Articulos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select a.Id, a.Codigo,a.Nombre, a.Descripcion, m.Descripcion, c.Descripcion ,a.ImagenUrl  from ARTICULOS a , Marcas m , Categorias c ";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)lector["Id"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"];

                    lista.Add(aux);
                }
                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    public void agregar(Articulos nuevo)
    {
            AccesoDeDatos datos = new AccesoDeDatos();  
        try
        {
                datos.setearConsulta("insert into(Nombre,Codigo,Descripcion, ImagenUrl,IdMarca,IdCategoria )values(" + nuevo.Nombre + "','" + nuevo.Codigo + "','" + nuevo.Descripcion + "',1 ,@idMarca,@idCategoria)");
                datos.ejecutarAccion();           
        }
        catch (Exception)
        {

            throw;
        }
            finally
            {
                datos.cerrarLectura();
            }
    }

    }
}






