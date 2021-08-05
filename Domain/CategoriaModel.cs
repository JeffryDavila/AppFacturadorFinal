using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccess;

namespace Domain
{
    public class CategoriaModel
    {
        CategoriaData categoria = new CategoriaData();
        public DataTable Lista_de_categoria()
        {
            return categoria.Listarcategoria();
        }

        public void Agregar_categoria(string codigo, string nombre)
        {
            categoria.Codigo = codigo;
            categoria.Nombre = nombre;
            categoria.InsertarCategoria();
        }

        public void Editar_categoria(int idcategoria,string codigo, string nombre)
        {
            categoria.Idcategoria = idcategoria;
            categoria.Codigo = codigo;
            categoria.Nombre = nombre;
            categoria.EditarCategoria();
        }

        public void Eliminar_Categoria(int idcategoria)
        {
            categoria.Idcategoria = idcategoria;
            categoria.EliminarCategoria();
        }

        public int obtenerIdCategoria()
        {
            return categoria.obtener_idcategoria();
        }

    }
}
