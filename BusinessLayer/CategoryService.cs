using BusinessLayer;
using DataLayer;
using DataLayer;
using Entities;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class CategoriaBL
    {
        public static List<Categoria> ObtenerTodas()
        {
            return CategoryDAO.ObtenerCategorias();
        }
    }
}
