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
        private string cuerpo;
        private int idUsuarioReceptor;
        private DateTime fechahora;

        public int Idmensaje { get { return idMensaje; } set { idMensaje = value; } }
        public string Cuerpo { get { return cuerpo; } set { cuerpo = value; } }
        public int Idusuarioreceptor { get { return idUsuarioReceptor; } set { idUsuarioReceptor = value; } }
        public DateTime Fechahora { get { return fechahora; } set { fechahora = value; } }

        public Mensaje(string cuer, int idusurecep, DateTime fechaho)
        {
            cuerpo = cuer;
            idUsuarioReceptor = idusurecep;
            fechahora = fechaho;
        }

        public int EnviarMensaje(MySqlConnection conexion, Mensaje men)
        {
            int retorno;

            try
            {
                string consulta = string.Format("INSERT INTO mensaje (cuerpo,idUsuarioReceptor,fechahora) VALUES " + "('{0}','{1}','{2}')", men.idMensaje, men.cuerpo, men.Idusuarioreceptor, men.fechahora.ToString("mmmm/dd/yy - hh:mm:ss"));

                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                retorno = comando.ExecuteNonQuery();

                return retorno;
            }
            catch
            {
                return 0;
            }
        }

        public int ActualizarMensaje(MySqlConnection conexion, Mensaje men)
        {
            int retorno;

            try
            {
                string consulta = string.Format("UPDATE mensaje SET cuerpo='{0}',idUsuarioReceptor='{1}',fechahora={2}" + " WHERE idUsuarioReceptor={1}" + men.cuerpo, men.idUsuarioReceptor, men.fechahora.ToString("mmmm/dd/yy - hh:mm:ss"));

                MySqlCommand comando = new MySqlCommand(consulta, conexion);

                retorno = comando.ExecuteNonQuery();

                return retorno;
            }
            catch
            {
                return 0;
            }
        }

        /*public bool VerificarMensaje(string idMensajeReceptor)
        {
            string consulta = string.Format("SELECT * FROM mensaje " + " WHERE idMensajeReceptor='{0}'", idMensajeReceptor);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            MySqlDataReader reader = comando.ExecuteReader();

            if(reader.HasRows)
            {
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }*/
    }
}
