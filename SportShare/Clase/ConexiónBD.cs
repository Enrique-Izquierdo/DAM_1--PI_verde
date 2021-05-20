using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SportShare.Clase;

namespace SportShare.Clase
{
    class ConexionBD
    {

        private MySqlConnection conexion;

        public MySqlConnection Conexion { get { return conexion; } }

        public ConexionBD()
        {
            string server = "server=sportshare1.cxvvol0hxfeb.us-east-1.rds.amazonaws.com;";
            string port = "port=3306;";
            string database = "database=sportshare;";
            string usuario = "uid=admin_sport;";
            string password = "pwd=Adminsport23;";
            string convert = "Convert Zero Datetime=True;";
            string connectionstring = server + port + database + usuario + password + convert;


            conexion = new MySqlConnection(connectionstring);
        }

        public bool AbrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
        public bool CerrarConexion()
        {
            try
            {
                conexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
    }

   
}
