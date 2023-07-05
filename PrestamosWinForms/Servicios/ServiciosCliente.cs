using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Win32;
using PrestamosWinForms.Entidades;

namespace PrestamosWinForms.Servicios
{
    internal class ServiciosCliente
    {
        private string? connectionString;

        public ServiciosCliente()
        {
            if (Program.Configuration != null)
            {
                connectionString = Program.Configuration.GetConnectionString("default");
            }
        }

        public void InsertarCliente(Cliente cliente)
        {
            try
            {
                if (connectionString == null ||
                    cliente.Id == string.Empty ||
                    cliente.NombreCompleto == string.Empty)
                {
                    return;
                }

                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.CommandText = "INSERT INTO Clientes " +
                            "(Id,NombreCompleto,NumeroTelefono," +
                            "Email,Direccion)" +
                            "VALUES(" +
                            $"'{cliente.Id}','{cliente.NombreCompleto}','{cliente.NumeroTelefono}'," +
                            $"'{cliente.Email}','{cliente.Direccion}')";

                        cmd.Connection = sqlConnection;

                        sqlConnection.Open();

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public List<Cliente> ObtenerClientes(int pagina, int registros)
        {
            int offSet = (pagina - 1) * registros;

            List<Cliente> clientes = new List<Cliente>();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.CommandText = "SELECT Id,NombreCompleto,NumeroTelefono,Email,Direccion " +
                        "FROM Clientes ORDER BY Id " +
                        $"OFFSET {offSet} ROWS " +
                        $"FETCH NEXT {registros} ROWS ONLY";

                    cmd.Connection = sqlConnection;

                    sqlConnection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Cliente cliente = new Cliente();

                            cliente.Id = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                            cliente.NombreCompleto = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                            cliente.NumeroTelefono = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                            cliente.Email = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                            cliente.Direccion = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);

                            clientes.Add(cliente);
                        }
                        reader.Close();
                    }
                }
            }

            return clientes;
        }

        public int CantidadTotalClientes()
        {
            int count = 0;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.CommandText = "SELECT COUNT (*) FROM Clientes";

                    cmd.Connection = sqlConnection;

                    sqlConnection.Open();

                    count = (int)cmd.ExecuteScalar();
                }
            }

            return count;
        }
    }
}