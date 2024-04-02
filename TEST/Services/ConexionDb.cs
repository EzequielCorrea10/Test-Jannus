using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Objects;
using TEST.Model;
using System.Collections.Generic;
using System.Linq;


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
        var list = new List<Product>();
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("sp_GetProducts", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string name = Convert.ToString(reader["Name"]);
                        decimal price = Convert.ToDecimal(reader["Price"]);
                        int productTypeId = Convert.ToInt32(reader["ProductTypeId"]);

                        Product product = new Product(id, name, price, productTypeId);
                        list.Add(product);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
        }
        return list;
    }

    internal List<ProductType> GetProductTypes()
    {
        var list = new List<ProductType>();
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("sp_GetProductTypes", connection);
                command.CommandType = CommandType.StoredProcedure;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id"]);
                        string description = Convert.ToString(reader["Description"]);

                        ProductType productType = new ProductType(id, description);
                        list.Add(productType);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
        }
        return list;
    }
}