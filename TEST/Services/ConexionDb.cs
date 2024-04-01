using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class ConexionDB
{
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
            // Manejar errores, por ejemplo, registrarlos, lanzar excepciones personalizadas, etc.
            Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
        }
    }

    public void InsertProduct(int typeId, string name, float price)
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
                command.Parameters.AddWithValue("@TypeId", typeId);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            // Manejar errores, por ejemplo, registrarlos, lanzar excepciones personalizadas, etc.
            Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
        }
    }

    public void DeleteProduct (int id)
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
            // Manejar errores, por ejemplo, registrarlos, lanzar excepciones personalizadas, etc.
            Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
        }
    }
}