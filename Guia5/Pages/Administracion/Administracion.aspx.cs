using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Guia5
{
    public partial class Administracion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void grdProductos_RowEditing (object sender, GridViewEditEventArgs e)
        {
            GridViewRow FILA = grdProductos.Rows[e.NewEditIndex];
            int filaId = Convert.ToInt32(FILA.Cells[1].Text);
            Response.Redirect("~/Pages/Administracion/GestionProducto.aspx?id=" + filaId);
        }
    }
}