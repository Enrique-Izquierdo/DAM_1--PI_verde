using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace SportShare.Clase
{
    class Valoracion
    {
        private int idValoracion;
        private string contenido_Valoracion;
        private string idUsuarioEmisor;
        private string idUsuarioReceptor;
        private int id_actividad;
        private DateTime fechaHora;
        public string Contenido_Valoracion { get { return contenido_Valoracion; } set { contenido_Valoracion = value; } }
        public string IdUsuarioEmisor{ get { return idUsuarioEmisor; } set { idUsuarioEmisor = value; } }
        public string IdUsuarioReceptor { get { return idUsuarioReceptor; } set { idUsuarioReceptor = value; } }
        public int Id_actividad { get { return id_actividad; } set { id_actividad = value; } }
        public DateTime FechaHora { get { return fechaHora; } set { fechaHora = value; } }

        public Valoracion(string con, string usuemi,string usurec, DateTime fec)
        {
            contenido_Valoracion=con;
            idUsuarioEmisor = usuemi;
            idUsuarioReceptor = usurec;
            fechaHora = fec;
        }
        public void EnviarValoracion(MySqlConnection conexion,Valoracion val)
        {
            int retorno;
           switch(Datos.val.Contenido_Valoracion)
            {
                case "Contento":
                    string insertar = String.Format("INSERT INTO Valoración (contenido_Valoracion,fecha_hora,id_usuarioEmisor,id_usuarioReceptor) VALUES " +
                                    "('{0}','{1}','{2}','{3}','{4}','{5}')", val.contenido_Valoracion, val.fechaHora, val.idUsuarioEmisor, val.idUsuarioReceptor);
                    string update = String.Format("UPDATE Usuarios SET total+1, total_positivas+1 WHERE alias='{0}';", val.idUsuarioReceptor);

                    MySqlCommand comando = new MySqlCommand(insertar, conexion);
                    MySqlCommand comando2 = new MySqlCommand(update, conexion);
                    comando.ExecuteNonQuery();
                    comando2.ExecuteNonQuery();

                    break;
                case "Neutral":
                    string insertar2 = String.Format("INSERT INTO Valoración (contenido_Valoracion,fecha_hora,id_usuarioEmisor,id_usuarioReceptor) VALUES " +
                                    "('{0}','{1}','{2}','{3}','{4}','{5}')", val.contenido_Valoracion, val.fechaHora, val.idUsuarioEmisor, val.idUsuarioReceptor);
                    string update2 = String.Format("UPDATE Usuarios SET total+1, total_indiferentes+1 WHERE alias='{0}';", val.idUsuarioReceptor);


                    MySqlCommand comando3 = new MySqlCommand(insertar2, conexion);
                    MySqlCommand comando4 = new MySqlCommand(update2, conexion);
                    comando3.ExecuteNonQuery();
                    comando4.ExecuteNonQuery();
                    break;

                case "Triste":
                    string insertar3 = String.Format("INSERT INTO Valoración (contenido_Valoracion,fecha_hora,id_usuarioEmisor,id_usuarioReceptor) VALUES " +
                                    "('{0}','{1}','{2}','{3}','{4}','{5}')", val.contenido_Valoracion, val.fechaHora, val.idUsuarioEmisor, val.idUsuarioReceptor);
                    string update3 = String.Format("UPDATE Usuarios SET total+1, total_indiferentes+1 WHERE alias='{0}';", val.idUsuarioReceptor);

                    MySqlCommand comando5 = new MySqlCommand(insertar3, conexion);
                    MySqlCommand comando6 = new MySqlCommand(update3, conexion);
                    comando5.ExecuteNonQuery();
                    comando6.ExecuteNonQuery();
                    break;
                default:
                    break;
            }    

        }
    }



}
