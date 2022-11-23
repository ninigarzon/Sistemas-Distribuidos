using Guia5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Guia5
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Llenar_Paginas();
        }

        private void Llenar_Paginas ()
        {
            ProductModel productModel = new ProductModel ();
            List<Producto> productos = productModel.GetTodoProducto ();
            if (productos != null)
            {
                foreach (Producto producto in productos)
                {
                    Panel ProductosPanel = new Panel();
                    ImageButton imageButton = new ImageButton();
                    Label lb1Nombre = new Label();
                    Label lb1Precio = new Label();

                    imageButton.ImageUrl = "~/Imagenes/images/" + producto.Imagen;
                    imageButton.CssClass = "productoImagen";
                    imageButton.PostBackUrl = "~/Pages/Producto.aspx?id=" + producto.ID;

                    lb1Nombre.Text = producto.Nombre;
                    lb1Nombre.CssClass = "productoNombre";

                    lb1Precio.Text = "$" + producto.Precio;
                    lb1Precio.CssClass = "productoPrecio";

                    ProductosPanel.Controls.Add(imageButton);
                    ProductosPanel.Controls.Add(new Literal { Text = "<br/>" });
                    ProductosPanel.Controls.Add(lb1Nombre);
                    ProductosPanel.Controls.Add(new Literal { Text = "<br/>" });
                    ProductosPanel.Controls.Add(lb1Precio);

                    pnlProductos.Controls.Add(ProductosPanel);
                }
            }
            else
            {
                pnlProductos.Controls.Add(new Literal { Text = "No se encontraron Productos" });
            }
        }
    }
}