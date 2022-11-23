using Guia5.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Guia5.Pages.Administracion
{
    public partial class GestionProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                GetImagenes();
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                LlenarPagina(id);
            }
        }

        private void LlenarPagina (int id)
        {
            ProductModel productoModel = new ProductModel();
            Producto producto = productoModel.GetProducto(id);

            txtDescripcion.Text = producto.Descripcion;
            txtNombre.Text = producto.Nombre;
            txtPrecio.Text = producto.Precio.ToString();
            ddImagen.SelectedValue = producto.Imagen;
            ddImagen.SelectedValue = producto.TipoID.ToString();
        }

        private void GetImagenes()
        {
            try
            {
                string[] imagenes = Directory.GetFiles(Server.MapPath("~/Imagenes/Images/"));
                ArrayList listaImagenes = new ArrayList();
                foreach (string image in imagenes)
                {
                    string nombreImagen = image.Substring(image.LastIndexOf(@"\", StringComparison.Ordinal) + 1);
                    listaImagenes.Add(nombreImagen);
                }
                ddImagen.DataSource = listaImagenes;
                ddImagen.AppendDataBoundItems = true;
                ddImagen.DataBind();
            }
            catch (Exception e)
            {
                lb1Result.Text = e.ToString();
            }
        }

        private Producto CrearProducto ()
        {
            Producto producto = new Producto();
            producto.Nombre = txtNombre.Text;
            producto.Precio = Convert.ToDecimal(txtPrecio.Text);
            producto.TipoID = Convert.ToInt32(ddITipo.SelectedValue);
            producto.Descripcion = txtDescripcion.Text;
            producto.Imagen = ddImagen.SelectedValue;
            return producto;
        }
        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            ProductModel productoModel = new ProductModel();
            Producto producto = CrearProducto();
            lb1Result.Text = productoModel.InsertaProducto(producto);

            if (!String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                lb1Result.Text = productoModel.AtucalizaProducto(id, producto);
            }
            else
            {
                lb1Result.Text = productoModel.InsertaProducto(producto);
            }
        }
    }
}