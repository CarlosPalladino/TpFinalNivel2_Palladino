using Datos;
using DiscosDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaFinal
{
    public partial class Form1 : Form
    {
        private List<Articulos> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        } 

        private void ocultarColumnas()
        {
            dgvMuestra.Columns["IdMarca"].Visible=false;
            dgvMuestra.Columns["IdCategoria"].Visible = false;
            dgvMuestra.Columns["ImagenUrl"].Visible = false;
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
        private void cargar()
        {
            Metodos articulos = new Metodos();

            try
            {
                listaArticulos = articulos.listar();
                dgvMuestra.DataSource = listaArticulos;
                cargarImagen(listaArticulos[0].ImagenUrl);
                ocultarColumnas();

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void dgvMuestra_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvMuestra.CurrentRow != null);
                {
                Articulos seleccionado = (Articulos)dgvMuestra.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            AltaDeDiscos alta = new AltaDeDiscos();
            alta.ShowDialog();
            cargar();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvMuestra.CurrentRow.DataBoundItem;

            AltaDeDiscos modificar = new AltaDeDiscos(seleccionado);
            modificar.ShowDialog();
            cargar();
        }
    }
}
