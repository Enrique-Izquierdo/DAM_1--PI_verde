using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportShare.Clase;
using System.Windows.Forms;

namespace SportShare.Clase
{
    class Participar
    {
        /*atributos*/
        private string alias_usuario;
        private int id_actividad;
        private bool tiene_plaza;
        private int pos_Inscripcion;

        /*propiedades*/
        public string Alias_usuario { get {return alias_usuario; } set {alias_usuario=value; } }
        public int Id_actividad { get { return id_actividad; } set { id_actividad = value; } }
        public bool Tiene_plaza { get { return tiene_plaza; } set { tiene_plaza=value; } }
        public int Pos_Inscripcion { get { return pos_Inscripcion; } set { pos_Inscripcion = value; } }

        /*constructores*/
        public Participar() { }
        public Participar(string alias_usuario, int id_actividad, bool tiene_plaza, int pos_Inscripcion)
        {
            this.alias_usuario = alias_usuario;
            this.id_actividad = id_actividad;
            this.tiene_plaza = tiene_plaza;
            this.pos_Inscripcion = pos_Inscripcion;
        }

        /*metodos de interface*/

        public int InscripcionCreadoraEvento(MySqlConnection conexion)
        {
            int retorno;
            pos_Inscripcion = 1;
            string consulta = String.Format("INSERT INTO Participar (id_actividad,alias_usuario, tiene_plaza, posicion)" +
                " VALUES ('{0}',@alias_usu,@tPlaza,@Pos)",id_actividad);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("alias_usu", alias_usuario);
            comando.Parameters.AddWithValue("tPlaza", tiene_plaza);
            comando.Parameters.AddWithValue("Pos", pos_Inscripcion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }


        public int InscripcionUsuarioaEvento(MySqlConnection conexion)
        {
            int retorno;
            pos_Inscripcion = ObtenerPosicionInscripcion(conexion, id_actividad);
            string consulta = String.Format("INSERT INTO Participar (alias_usuario, id_actividad, tiene_plaza, posicion)" +
                " VALUES (@alias_usu,@id_act,@tPlaza,@Pos)");

            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("alias_usu", alias_usuario);
            comando.Parameters.AddWithValue("id_act", id_actividad);
            comando.Parameters.AddWithValue("tPlaza", tiene_plaza);
            comando.Parameters.AddWithValue("Pos", pos_Inscripcion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public int ObternerPosicionListaEspera(int numPlazas)
        {
            int posListaEspera = pos_Inscripcion - numPlazas;
            return posListaEspera;
        }




        /*Métodos implementación*/
        private int ObtenerPosicionInscripcion(MySqlConnection conexion, int id_Actividad)
        {
            int posicion=0;
            string consulta = string.Format("SELECT MAX(posicion) FROM Participar WHERE id_actividad={0}", id_Actividad);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            reader.Read();
            //while (reader.Read())
            //{
                posicion = reader.GetInt32(0)+1;
            //}
            reader.Close();
            return posicion;
        }

        public static bool UsuarioParticipaEnActividad(MySqlConnection conexion, string idusu, int idacti)
        {
            string consulta = string.Format("Select alias_usuario from Participar where alias_usuario='{0}' AND id_actividad='{1}'", idusu, idacti);
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
