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

    internal List<TEST.Model.Product> GetProducts()
    {
        List<TEST.Model.Product> list = new List<TEST.Model.Product>();
        try
        {
            using (var context = new TestEntities1())
            {
                var query = from product in context.Product
                            join productType in context.ProductType
                            on product.ProductTypeId equals productType.Id
                            select new TEST.Model.Product
                            {
                                Id = product.Id,
                                Name = product.Name,
                                ProductType = productType.description,
                                Price = product.Price.Value
                            };
                list = query.ToList();

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al obtener los productos: " + ex.Message);
        }
        return list;
    }

    internal List<TEST.Model.ProductType> GetProductTypes()
    {
        List<TEST.Model.ProductType> list = new List<TEST.Model.ProductType>();
        try
        {
            using (var context = new TestEntities1())
            {
                var query = from produtype in context.ProductType
                            select new TEST.Model.ProductType
                            {
                                Id = produtype.Id,
                                Description = produtype.description
                            };
                list = query.ToList();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al obtener los tipos de productos: " + ex.Message);
        }
        return list;
    }

    internal List<TEST.Model.Product> GetStock()
    {
        List<TEST.Model.Product> list = new List<TEST.Model.Product>();
        try
        {
            using (var context = new TestEntities1())
            {
                var query = from stock in context.Stock
                            join product in context.Product
                            on stock.ProductId equals product.Id
                            join productType in context.ProductType
                            on product.ProductTypeId equals productType.Id
                            select new TEST.Model.Product
                            {
                                Id = product.Id,
                                Name = product.Name,
                                Price = product.Price.Value,
                                ProductType = productType.description
                            };
                list = query.ToList();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al obtener los tipos de productos: " + ex.Message);
        }
        return list;
    }
}