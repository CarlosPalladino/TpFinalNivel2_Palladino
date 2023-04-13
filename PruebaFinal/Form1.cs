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
                cboCampo.Items.Add("Nombre");
                cboCampo.Items.Add("Precio");
                cboCampo.Items.Add("Descripcion");


                cargar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvMuestra.Columns["IdMarca"].Visible = false;
            dgvMuestra.Columns["Id"].Visible = false;
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
            if (dgvMuestra.CurrentRow != null)
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

        private void Eliminar_Click(object sender, EventArgs e)

        {
            Metodos metodo = new Metodos();
            Articulos seleccionado;
            try
            {

                DialogResult respuesta = MessageBox.Show("¿estas seguro de que queres eliminarlo?", "eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dgvMuestra.CurrentRow.DataBoundItem;
                    metodo.eliminar(seleccionado.Id);
                    cargar();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> lista;
            string filtro = txtFiltro.Text;
            if (filtro.Length >= 3)
            {
                lista = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marcas.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                lista = listaArticulos;
            }

            dgvMuestra.DataSource = null;
            dgvMuestra.DataSource = lista;
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");


            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Empieza con..");
                cboCriterio.Items.Add("Termina con..");
                cboCriterio.Items.Add("Contiene ..");
            }
        }

        private void Filtrar_Click(object sender, EventArgs e)

        {
            Metodos metodo = new Metodos();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtPrecio.Text;

                dgvMuestra.DataSource = metodo.Filtro(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show(" ¡ Seleccionado un Campo por favor !");
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show(" ¡ Seleccionado un Criterio, por favor !");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio") // aca problema
                if (string.IsNullOrEmpty(txtPrecio.Text))
                {
                    MessageBox.Show("Selecciona un Precio ");
                    return true;
                }
            

               if (!(numerosDecimales(txtPrecio.Text)))
                {
                    MessageBox.Show("Solo Números con . ");
                  return true;
                }
            

            return false;
        }
        private bool numerosDecimales(string cadena)
        {
            foreach (char caracter in cadena)

            {
                if (!(char.IsDigit(caracter)))        // no hay numbers , no son digits,. IsPunctuation, IsSeparator tampoco // tiene que ser Numero entero y/o nro con 
                    return false;
            }
            return true;
        }


        private void Reset_Click(object sender, EventArgs e)
        {
            cargar();
        }
    }
}
