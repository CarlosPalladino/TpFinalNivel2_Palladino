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
                comando.CommandText = "select A.Id,Codigo,Nombre,A.Descripcion ,ImagenUrl,Precio,A.IdCategoria,A.IdMarca,C.Descripcion Categoria, M.Descripcion Marca from ARTICULOS A ,CATEGORIAS C , MARCAS M";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];

                    if (!(lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)lector["ImagenUrl"];

                    aux.Precio = (decimal)lector["Precio"]; 
                    Console.WriteLine("precio");
                    aux.IdCategoria = (int)lector["IdCategoria"];
                    aux.IdMarca = (int)lector["IdMarca"];

                    aux.Marcas = new Marcas();
                    aux.Marcas.Id = (int)lector["Id"];
                    aux.Marcas.Descripcion = (string)lector["Marca"];

                    aux.Categoria = new Categorias();
                    aux.Categoria.Id = (int)lector["Id"];
                    aux.Categoria.Descripcion = (string)lector["Categoria"];



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
            AccesoDatos datos = new AccesoDatos();
            try
            {
              
                datos.setearConsulta("Insert into ARTICULOS (Codigo ,Nombre,Descripcion,Precio,IdMarca,IdCategoria,ImagenUrl)values('" + nuevo.Codigo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "','"+ nuevo.Precio +"',@idMarca,@idCategoria,@imagenUrl)");

                datos.setearParametro("@idMarca", nuevo.Marcas.Id);
                datos.setearParametro("@idCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@imagenUrl", nuevo.ImagenUrl);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarLectura();
            }
        }


        public void modificar(Articulos articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Nombre = @nombre, Descripcion = @desc, ImagenUrl = @img, IdMarca = @idMarca, IdCategoria = @idCategoria, Precio = @precio Where Id = @id");
            //  datos.setearConsulta("update POKEMONS set Numero = @numero, Nombre = @nombre, Descripcion = @desc, UrlImagen = @img, IdTipo = @idTipo, IdDebilidad = @idDebilidad Where Id = @id");

                datos.setearParametro("@nombre", articulo.Nombre);
                datos.setearParametro("@desc", articulo.Descripcion);
                datos.setearParametro("@img", articulo.ImagenUrl);
                datos.setearParametro("@idMarca", articulo.Marcas.Id);
                datos.setearParametro("@idCategoria", articulo.Categoria.Id);
                datos.setearParametro("@precio", articulo.Precio);
                datos.setearParametro("@id", articulo.Id);

                datos.ejecutarLectura();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public void eliminar(int Id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("Delete from Articulos where Id= @id");
                datos.setearParametro("@id", Id);
                datos.ejecutarLectura();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }

}






