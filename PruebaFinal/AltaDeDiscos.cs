using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using DiscosDatos;
using System.Configuration;

namespace PruebaFinal
{
    public partial class AltaDeDiscos : Form
    {
        private OpenFileDialog archivo = null;
        private Articulos articulo = null;
        public AltaDeDiscos()
        {
            InitializeComponent();
        }
        public AltaDeDiscos(Articulos articulo)
        {
            this.articulo = articulo;
            InitializeComponent();
            Text = "Modificación";
        }
        private void AltaDeDiscos_Load(object sender, EventArgs e)
        {
            CategoriaLector categoria = new CategoriaLector();
            MarcarLector marca = new MarcarLector();
            try
            {
                cboMarca.DataSource = marca.listar();

                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = categoria.listar();

                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                if (articulo != null)
                {

                    txtNombre.Text = articulo.Nombre;
                    txtCodigo.Text = articulo.Codigo;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagen.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txtPrecio.Text = articulo.Precio.ToString();
                }

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
                if (articulo != null)

                    articulo = new Articulos();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtImagen.Text;

                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marcas = (Marcas)cboMarca.SelectedItem;
                articulo.Categoria = (Categorias)cboCategoria.SelectedItem;

                if (articulo.Id != 0)
                {

                    metodos.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");


                }
                else
                {
                    metodos.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
                if (archivo != null && txtImagen.Text.ToUpper().Contains("HTTP"))
                    guardarImagen();
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

        private void NuevaFoto_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg |png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

            }

        }

        private void guardarImagen()
        {
            File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpeta-img"] + "C:\\Articulos");

        }
    }
}
