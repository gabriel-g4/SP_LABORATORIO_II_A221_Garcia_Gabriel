using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BibliotecaDeClases
{
    public static class AccesoDatos
    {
        static MySqlCommand command;
        static MySqlConnection connection;
        static string connectionString;

        static AccesoDatos()
        {
        }

        public static bool Guardar(string server, string db, Barco barco, string nombreAlumno)
        {
            bool retorno = false;
            try
            {
                connectionString = $"Server={server}; Database={db}; User ID=root; Password=;SslMode=none;";
                string mensaje = $"Se reparó el {barco.Nombre} a un costo de {barco.Costo} berries.";
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO barcos(mensaje, alumno) " +
                        "VALUES (@mensaje, @alumno)";

                    command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@mensaje", mensaje);
                    command.Parameters.AddWithValue("@alumno", nombreAlumno);
                    command.ExecuteNonQuery();
                    retorno = true;
                }
            }
            catch (MySqlException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return retorno;
        }
    }
}
