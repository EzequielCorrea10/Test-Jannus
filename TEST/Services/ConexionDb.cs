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

    private string connectionString;

    public ConexionDB()
    {
        connectionString = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
    }

        public void ModifyProduct(int id, string nuevoNombre, decimal nuevoPrecio)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("sp_ModifyProduct", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al procedimiento almacenado
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@NewName", nuevoNombre);
                command.Parameters.AddWithValue("@NewPrice", nuevoPrecio);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
        }
    }

    public void InsertProduct(int typeId, string name, decimal price)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("sp_InsertProduct", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al procedimiento almacenado
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@ProductTypeId", typeId);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
        }
    }
    public void InsertProductType(string description)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("sp_InsertProductType", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al procedimiento almacenado
                command.Parameters.AddWithValue("@Description", description);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
        }
    }

    public void EditProduct(int id,int typeId, string name, decimal price)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("sp_ModifyProduct", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros al procedimiento almacenado
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@NewName", name);
                command.Parameters.AddWithValue("@NewPrice", price);
                command.Parameters.AddWithValue("@NewTypeId", typeId);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
        }
    }

    public void DeleteProduct(int id)
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("sp_DeleteProduct", connection);
                command.CommandType = CommandType.StoredProcedure;
                // Agregar parámetros al procedimiento almacenado
                command.Parameters.AddWithValue("@Id", id);
                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
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