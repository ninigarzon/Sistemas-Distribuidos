using Guia5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Guia5.Pages.Administracion
{
    public partial class GestionTipoProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            ProductoTipoModel model = new ProductoTipoModel();
            TipoProducto tipoProducto = crearTipoProducto();
            Lb1Result.Text = model.InsertaProductoTipo(tipoProducto);
        }

        private TipoProducto crearTipoProducto()
        {
            TipoProducto tipoProducto = new TipoProducto();
            tipoProducto.Nombre = TxtNombre.Text;
            return tipoProducto;
        }
    }
}