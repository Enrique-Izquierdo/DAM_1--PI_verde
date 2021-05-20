using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportShare.Clase;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SportShare.Clase
{
    class Mensaje
    {
        private int idMensaje;
        private string usuarioemisor;
        private string cuerpo;
        private string usuarioReceptor;
        private DateTime fechahora;

        public int Idmensaje { get { return idMensaje; } set { idMensaje = value; } }
        public string Usuarioemisor { get { return usuarioemisor; } set { usuarioemisor = value; } }
        public string Usuarioreceptor { get { return usuarioReceptor; } set { usuarioReceptor = value; } }
        public string Cuerpo { get { return cuerpo; } set { cuerpo = value; } }
        public DateTime Fechahora { get { return fechahora; } set { fechahora = value; } }

        public Mensaje(string usemi, string usurecep, string cuer,  DateTime fechaho)
        {
            usuarioemisor = usemi;
            usuarioReceptor = usurecep;
            cuerpo = cuer;
            fechahora = fechaho;
        }

        public int EnviarMensaje(MySqlConnection conexion, Mensaje men)
        {
            int retorno;

                string consulta = string.Format("INSERT INTO Mensaje (id_usuarioEmisor,id_usuarioReceptor,texto_mensaje,fecha_hora) " +
                    "VALUES " + "('{0}','{1}','{2}','{3}')", men.usuarioemisor, men.usuarioReceptor, men.cuerpo, men.fechahora.ToString("yyyy/MM/dd - hh:mm:ss"));

                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                retorno = comando.ExecuteNonQuery();

                return retorno;
            
        }

        public static List<Mensaje> BuscarMensajesEnviados(MySqlConnection conexion, string idusu)
        {
           List<Mensaje> lista=new List<Mensaje>();
            string seleccion = String.Format("Select id_usuarioEmisor,id_usuarioReceptor,texto_mensaje,fecha_hora" +
                               " from Mensaje WHERE id_usuarioEmisor='{0}'", idusu);

            MySqlCommand comando = new MySqlCommand(seleccion, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    Mensaje men = new Mensaje(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3));
                    lista.Add(men);

                }
            }
            reader.Close();
            return lista;

        }

        public static List<Mensaje> BuscarMensajesRecibidos(MySqlConnection conexion, string idusu)
        {
            List<Mensaje> lista = new List<Mensaje>();
            string seleccion = String.Format("Select id_usuarioEmisor,id_usuarioReceptor,texto_mensaje,fecha_hora" +
                               " from Mensaje WHERE id_usuarioReceptor='{0}'", idusu);

            MySqlCommand comando = new MySqlCommand(seleccion, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    Mensaje men = new Mensaje(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3));
                    lista.Add(men);

                }
            }
            reader.Close();
            return lista;

        }

        


    }
}
