using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Objects;
using System.Collections.Generic;
using System.Linq;
using TEST.Database;

public class ConexionDB
{
    //Servicios

    public void InsertProduct(int typeId, string name, decimal price)
    {
        try
        {
            using (var context = new TestEntities1())
            {
                context.sp_InsertProduct(name,price,typeId);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al borrar el producto " + ex.Message);
        }
    }
    public void InsertProductType(string description)
    {
        try
        {
            using (var context = new TestEntities1())
            {
                context.sp_InsertProductType(description);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al borrar el producto " + ex.Message);
        }
    }

    public void EditProduct(int id,int typeId, string name, decimal price)
    {
        try
        {
            using (var context = new TestEntities1())
            {
                context.sp_ModifyProduct(id, name, price, typeId);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al editar el producto " + ex.Message);
        }
    }

    public void DeleteProduct(int id)
    {
        try
        {
            using (var context = new TestEntities1())
            {
                context.sp_DeleteProduct(id);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al borrar el producto " + ex.Message);
        }
    }

    internal List<Product> GetProducts()
    {
        List<Product> list = new List<Product>();
        try
        {
            using (var context = new TestEntities1())
            {
                 list = context.Product.ToList();

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al obtener los productos: " + ex.Message);
        }
        return list;
    }

    internal List<ProductType> GetProductTypes()
    {
        List<ProductType> list = new List<ProductType>();
        try
        {

            using (var context = new TestEntities1())
            {
                list = context.ProductType.ToList();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al obtener los tipos de productos: " + ex.Message);
        }
        return list;
    }
}