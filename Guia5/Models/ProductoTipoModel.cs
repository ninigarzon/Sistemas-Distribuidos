using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guia5.Models
{
    public class ProductoTipoModel
    {
        public string InsertaProductoTipo (TipoProducto tipoProducto)
        {
			try
			{
				AutossEntities entities	= new AutossEntities();
                entities.TipoProducto.Add(tipoProducto);
                entities.SaveChanges();
                return tipoProducto.Nombre + "Tipo de producto Adicionado";
            }
			catch (Exception e)
			{
                return "Error: " + e;
			}
        }

        public string ActualizaTipoProducto (int id, TipoProducto tipoProducto)
        {
            try
            {
                AutossEntities entities = new AutossEntities();
                TipoProducto TipoProducto = entities.TipoProducto.Find(id);
                TipoProducto.Nombre = tipoProducto.Nombre;
                entities.SaveChanges();
                return tipoProducto.Nombre + "Tipo producto actualizado";
            }
            catch (Exception e)
            {
                return "Error: " + e;
            }
        }

        public string BorrarTipoProducto(int id, TipoProducto tipoProducto)
        {
            try
            {
                AutossEntities entities = new AutossEntities();
                TipoProducto TipoProducto = entities.TipoProducto.Find(id);
                entities.TipoProducto.Attach(tipoProducto);
                entities.TipoProducto.Remove(TipoProducto);
                entities.SaveChanges();
                return tipoProducto.Nombre + "Tipo producto eliminado";
            }
            catch (Exception e)
            {

                return "Error: " + e;
            }
        }
    }
}