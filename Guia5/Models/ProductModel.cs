using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guia5.Models
{
    public class ProductModel
    {

        public string InsertaProducto(Producto product)
        {
            try
            {
                AutossEntities entities = new AutossEntities();
                entities.Producto.Add(product);
                entities.SaveChanges();
                return product.Nombre + "Producto Adicionado";

            }
            catch (Exception e)
            {
                return "Error:" +e;
            }
        }

        public string  AtucalizaProducto(int id, Producto producto)
        {
            try
            {
                AutossEntities entities = new AutossEntities();
                Producto product = entities.Producto.Find(id);
                product.Nombre = producto.Nombre;
                product.Precio = producto.Precio;
                product.TipoID = producto.TipoID;
                product.Descripcion = producto.Descripcion;
                product.Imagen = producto.Imagen;
                entities.SaveChanges();
                return producto.Nombre + "Producto Actualizado";
            }
            catch (Exception e)
            {

                return "Error:" + e;
            }
        }

        public string BorrarProdcuto(int id, Producto producto)
        {
            try
            {
                AutossEntities entities = new AutossEntities();
                Producto product = entities.Producto.Find(id);
                entities.Producto.Attach(producto);
                entities.Producto.Remove(producto);
                return producto.Nombre + "Producto Actualizado";
            }
            catch (Exception e)
            {
                return "Error:" + e;
            }
        }

        public Producto GetProducto (int id)
        {
            try
            {
                using (AutossEntities db = new AutossEntities())
                {
                    Producto producto = db.Producto.Find(id);   
                    return producto;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Producto> GetTodoProducto ()
        {
            try
            {
                using (AutossEntities db = new AutossEntities())
                {
                    List<Producto> producto = (from x in db.Producto select x).ToList();
                    return producto;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Producto> GetTodoProductoTipo(int tipoId)
        {
            try
            {
                using (AutossEntities db = new AutossEntities())
                {
                    List<Producto> producto = (from x in db.Producto where x.TipoID == tipoId select x).ToList();
                    return producto;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}