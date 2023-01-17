using System;
using MySqlConnector;

namespace Test_E
{
    class Conexion
    {
        public static MySqlConnection getConexion()
        {
            // Seleccion de la Base de datos
            string servidor = "127.0.0.1";
            string puerto = "3306";
            string usuario = "root";
            string password = "admin"; //1379
            string bd = "testdb";

            string cadenaConexion = "server = " + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database=" + bd;
            //string cadenaConexion = "Database= testdb; Data Source= localhost; User Id= root; Password= admin";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }
    }
}
