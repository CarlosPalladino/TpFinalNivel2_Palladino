using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using DiscosDatos;

namespace PruebaFinal
{
    public partial class AltaDeDiscos : Form
    {
        public AltaDeDiscos()
        {
            InitializeComponent();
        }

        private void AltaDeDiscos_Load(object sender, EventArgs e)
        {
            CategoriaLector categoria = new CategoriaLector();
            MarcarLector marca = new MarcarLector();
            try
            {
                cboMarca.DataSource = marca.listar();
                cboCategoria.DataSource = categoria.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }



        private void Agregar_Click(object sender, EventArgs e)
        {
            Articulos articulo = new Articulos();

            Metodos metodos = new Metodos();
            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtImagen.Text;
           //     articulo.Precio = txtPrecio;
            
                articulo.Marcas = (Marcas)cboMarca.SelectedItem;
                articulo.Categoria = (Categorias)cboCategoria.SelectedItem;


                metodos.agregar(articulo);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }      
        private void cargarImagen(string imagen)
        {
            try
            {
                picbox.Load(imagen);
            }
            catch (Exception)
            {

                {
                    picbox.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoNaLFFSdD4YhW8mqgDBSWY8nHnte6ANHQWz6Lsl37yA&s");

                }
            }
        }
        private void txtImagen_Leave(object sender, EventArgs e)
                    {
            cargarImagen(txtImagen.Text);

        }
    }
}
