using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Domain
{
    public class ProductosModel
    {
        ProductosData producto = new ProductosData();
        public DataTable Lista_de_productos()
        {
            return producto.Listarproductos();
        }

        public DataTable Lista_de_categoria()
        {
            return producto.Listarcategoria();
        }

        public void Agregar_Producto(int idcategoria, string codigo, string descripcion,decimal precio,decimal precio_promocion)
        {
            producto.Idcategoria = idcategoria;
            producto.Codigo = codigo;
            producto.Descripcion = descripcion;
            producto.Precio = precio;
            producto.PrecioPromo = precio_promocion;
            producto.InsertarProducto();
        }

        public void Editar_Producto(int idproducto,int idcategoria, string codigo, string descripcion,decimal precio,decimal precio_promocion)
        {
            producto.Idproducto = idproducto;
            producto.Idcategoria = idcategoria;
            producto.Codigo = codigo;
            producto.Descripcion = descripcion;
            producto.Precio = precio;
            producto.PrecioPromo = precio_promocion;
            producto.EditarProducto();
        }

        public void Eliminar_Producto(int idproducto)
        {
            producto.Idproducto = idproducto;
            producto.EliminarProducto();
        }

        public DataTable Lista_de_producto_especifico( string descripcion)
        {
            producto.Descripcion_busqueda = descripcion;
            return producto.ListarProducto_especificos();
        }

        public int obtenerIdproducto()
        {
            return producto.obtener_idproducto();
        }
    }
}
