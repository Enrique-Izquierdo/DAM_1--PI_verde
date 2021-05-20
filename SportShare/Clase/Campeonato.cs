using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SportShare.Clase
{
    class Campeonato
    {
        private int idcampeonato;
        private string nombre;
        private string descripcion;
        
        public int Idcampeonato { get { return idcampeonato; } set { idcampeonato = value;  } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value;  } }

        public Campeonato(string nom, string desc)
        {
            nombre = nom;
            descripcion = desc;
        }

        public int AgregarCampeonato(MySqlConnection conexion,Campeonato cam)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO Campeonato (nombre,descripcion) VALUES " +
                                "('{0}','{1}')",cam.nombre,cam.descripcion);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            retorno=comando.ExecuteNonQuery();
            return retorno;
        }

        public static int SacarIDCampeonato(MySqlConnection conexion,string nombre)
        {
            int idcamp=0;
            string consulta = string.Format("Select id_campeonato from Campeonato where nombre='{0}'",nombre);
            MySqlCommand comando = new MySqlCommand(consulta,conexion );
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    idcamp = reader.GetInt32(0); 
                };
            }

            reader.Close();
            return idcamp;
        }

        public static bool CamepeonatoExiste(MySqlConnection conexion,string nom)
        {
            string consulta = string.Format("Select nombre from Campeonato where nombre='{0}'", nom);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                reader.Close();
                return true;
            }
            else
            {

                reader.Close();
                return false;
            }
        }
    
    }
}
