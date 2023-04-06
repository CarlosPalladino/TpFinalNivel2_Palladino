using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using DiscosDatos;

namespace Soluciones
{
    public class CategoriaLector
    {

        public List<Categorias> listar()
        {
            List<Categorias> lista = new List<Categorias>();
            AccesoDeDatos datos = new AccesoDeDatos();
            try
            {
                datos.setearConsulta("select id,Descripcion from Categorias");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {

                    Categorias aux = new Categorias();
                    aux.Id = (int)datos.Lector["Id"];
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
                datos.cerrarLectura();
            }
        }

    }
}
