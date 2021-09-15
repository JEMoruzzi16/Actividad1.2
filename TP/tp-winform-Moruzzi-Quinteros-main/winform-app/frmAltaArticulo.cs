using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Servicios;

namespace winform_app
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;

        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloServicio servicio = new ArticuloServicio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                
                articulo.Codigo = tbxCodigo.Text;
                articulo.Nombre = tbxNombre.Text;
                articulo.Descripcion = tbxDescripcion.Text;
                articulo.IdMarca = (Marca)cboMarca.SelectedItem;
                articulo.IdCategoria = (Categoria)cboCategoria.SelectedItem;
                articulo.ImagenUrl = tbxUrlImagen.Text;
                articulo.Precio = decimal.Parse(tbxPrecio.Text);

                if(articulo.Id !=0)
                {   
                    servicio.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    servicio.agregar(articulo);
                    MessageBox.Show("Agregado Exitosamente");
                }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaServicio categoriaServicio = new CategoriaServicio();
            MarcaServicio marcaServicio = new MarcaServicio();
            try
            {
                cboMarca.DataSource = marcaServicio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaServicio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo!=null)
                {
                    tbxCodigo.Text = articulo.Codigo;
                    tbxNombre.Text = articulo.Nombre;
                    tbxDescripcion.Text = articulo.Descripcion;
                    cboMarca.SelectedValue = articulo.IdMarca.Id;
                    cboCategoria.SelectedValue = articulo.IdCategoria.Id; 
                    tbxUrlImagen.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    tbxPrecio.Text = articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void tbxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxUrlImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxUrlImagen.Load("https://c.tenor.com/jwAkhSG3BWEAAAAC/error.gif");
            }
        }

    }
}
