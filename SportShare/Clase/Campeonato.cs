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
    }
}
