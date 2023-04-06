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
           // CategoriaLector categoria = new CategoriaLector();  
            MarcarLector marca= new MarcarLector();
            try
            {
               // cboCategoria.DataSource = categoria.listar();
                cboMarca.DataSource = marca.listar();
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
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtImagen.Text;
                articulo.Codigo = txtCodigo.Text;
             //   articulo.IdMarca = cboMarca.SelectedItem;


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
    }
}
