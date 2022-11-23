using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guia5.Models
{
    public class CompraModel
    {
        public string InsertCompra (Compra compra)
        {
            try
            {
                AutossEntities entities = new AutossEntities();
                entities.Compra.Add(compra);
                entities.SaveChanges();
                return compra.Fecha + "Compra adicionada";
            }
            catch (Exception e)
            {
                return "Error: " + e;
			}
        }

        public string ActualizaCompra (int id, Compra compra)
        {
            try
            {
                AutossEntities entities = new AutossEntities();
                Compra Compra = entities.Compra.Find(id);
                Compra.Fecha = compra.Fecha;
                Compra.ClienteID = compra.ClienteID;
                Compra.Cantidad = compra.Cantidad;
                Compra.IsInCart = compra.IsInCart;
                Compra.ProductoID = compra.ProductoID;
                entities.SaveChanges();
                return compra.Fecha + "Carrito compras Actualizado";
            }
            catch (Exception e)
            {
                return "Error: " + e;
            }
        }

        public string BorraCompra (int id, Compra compra)
        {
            try
            {
                AutossEntities entities = new AutossEntities();
                Compra Compra = entities.Compra.Find(id);
                entities.Compra.Attach(compra);
                entities.Compra.Remove(Compra);
                entities.SaveChanges();
                return compra.Fecha + "Borrado Exitosamente";
            }
            catch (Exception e)
            {
                return "Error: " + e;
            }
        }
    }
}