using DataLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductService
    {
        public static bool TryAgregarProducto(Product product, out string mensaje)
        {
            // Validación de negocio
            if (string.IsNullOrWhiteSpace(product.Name) || product.Price <= 0 || product.Stock < 0)
            {
                mensaje = "Please enter valid product data.";
                return false;
            }

            try
            {
                bool agregado = ProductDAO.addProduct(product);

                if (string.IsNullOrWhiteSpace(product.Name))
                {
                    mensaje = "Product name cannot be empty.";
                    return false;
                }
                if (product.Price <= 0)
                {
                    mensaje = "Price must be greater than 0.";
                    return false;
                }
                if (product.Stock < 0)
                {
                    mensaje = "Stock cannot be negative.";
                    return false;
                }
                

                if (agregado = true)
                {
                    mensaje = "Product added successfully!";
                }
                else
                {
                    mensaje = "Product was not added.";
                }

                return agregado;

            }
            catch (Exception ex)
            {
                mensaje = "Error while adding product: " + ex.Message;
                return false;
            }
        }


        public static List<Product> GetInactiveProducts()
        {
            return ProductDAO.GetInactiveProducts();
        }



        public static (string Nombre, int Cantidad) ObtenerProductoMenorStock()
        {
            return DatosDAO.ObtenerProductoMenorStock();
        }


        public static (string Nombre, int Cantidad) ObtenerProductoMayorStock()
        {
            return DatosDAO.ObtenerProductoMayorStock();
        }

        public static (string Nombre, int Stock) ObtenerUnProductoAgotado()
        {
            return DatosDAO.ObtenerUnProductoAgotado();
        }


    }





}
