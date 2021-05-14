using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace SportShare.Clase
{
    class Valoración
    {
        private int idValoracion;
        private string contenido_Valoracion;
        private int idUsuario;
        private int id_actividad;
        private DateTime fechaHora;
        public int IdValoracion { get { return idValoracion; } set { idValoracion = value; } }
        public string Contenido_Valoracion { get { return contenido_Valoracion; } set { contenido_Valoracion = value; } }
        public int IdUsuario { get { return idUsuario; } set { idUsuario = value; } }
        public int Id_actividad { get { return id_actividad; } set { id_actividad = value; } }
        public DateTime FechaHora { get { return fechaHora; } set { fechaHora = value; } }

        public Valoración(int idval, string con, int usu, int act, DateTime fec)
        {
            idValoracion  =  idval;
            contenido_Valoracion=con;
            idUsuario = usu;
            id_actividad = act;
            fechaHora = fec;
        }
        public int EnviarValoracion(MySqlConnection conexion, Valoración val)
        {
            int retorno;
            try
            {
                string consulta = String.Format("INSERT INTO Valoración (id_valoracion,contenido_Valoracion,fecha_hora,id_usuario,id_actividad) VALUES " +
                                "('{0}','{1}','{2}','{3}','{4}','{5}')", val.idValoracion,val.contenido_Valoracion,val.fechaHora,val.idUsuario,val.id_actividad);

                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                retorno = comando.ExecuteNonQuery();
            }
            catch
            {
                retorno = 0;
            }


            return retorno;
        }
    }

}
