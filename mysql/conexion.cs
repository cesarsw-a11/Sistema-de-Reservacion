using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace El_Balcon_de_Chalita.mysql
{
    class conexion
    {
        public static MySqlConnection Conexion()
        {

            string servidor = "localhost";
            string basededatos = "elbalcondechalita";
            string usuario = "root";
            string password = "";

            string cadenaConexion = "Database=" + basededatos + "; Data Source=" + servidor + "; User Id= " + usuario + "; Password=" + password + "";


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
