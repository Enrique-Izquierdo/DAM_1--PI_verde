using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SportShare.Clase
{
    class Actividad
    {
        #region(Enrique)
        /* Atributos */
        private int id_actividad;
        private string tipo;
        private string nombre;
        private string descripcion;
        private string direccion;
        private string poblacion;
        private string provincia;
        private DateTime fecha_hora;
        private int numLimite_plazas; // campo "plazas" de la tabla "Actividades" de la BD
        private string material_necesario; // campo "requerimientos" de la tabla "Actividades" de la BD
        private DateTime fechaLimite_inscrip; //campo "fecha_limite" de la tabla "Actividades" de la BD
        private int edad_minima; // campo "edad_limite" de la tabla "Actividades" de la BD
        private string nivelDeportivo_exigido; // campo "nivel_requerido" de la tabla "Actividades" de la BD
        private double precio_actividad; // campo "dinero" de la tabla "Actividades" de la BD
        private string alias_creador;
        private int id_campeonato;

        /* Propiedades */
        public int Id_actividad { get { return id_actividad; } set { id_actividad = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public string Direccion { get { return direccion; } set { direccion = value; } }
        public string Poblacion { get { return poblacion; } set { poblacion = value; } }
        public string Provincia { get { return provincia; } set { provincia = value; } }
        public DateTime Fecha_hora { get { return fecha_hora; } set { fecha_hora = value; } }
        public int NumLimite_plazas { get { return numLimite_plazas; } set { numLimite_plazas = value; } }
        public string Material_necesario { get { return material_necesario; } set { material_necesario = value; } }
        public DateTime FechaLimite_inscrip { get { return fechaLimite_inscrip; } set { fechaLimite_inscrip = value; } }
        public int Edad_minima { get { return edad_minima; } set { edad_minima = value; } }
        public string NivelDeportivo_exigido { get { return nivelDeportivo_exigido; } set { nivelDeportivo_exigido = value; } }
        public double Precio_actividad { get { return precio_actividad; } set { precio_actividad = value; } }
        public string Alias_creador { get { return alias_creador; } set { alias_creador = value; } }
        public int Id_campeonato { get { return id_campeonato; } set { id_campeonato = value; } }
        #endregion

        #region(Enrique)
        /* Constructores */
        public Actividad() { }

        //Constructor Actividad() que incluye id_actividad, id_creador, id_campeonato.
        public Actividad(int id_actividad, string tipo, string nombre, string descripcion, string direccion, string poblacion,
            string provincia, DateTime fecha_hora, int numLimite_plazas, string material_necesario,
            DateTime fechaLimite_inscrip, int edad_minima, string nivelDeportivo_exigido, double precio_actividad,
            string alias_creador, int id_campeonato)
        {
            this.id_actividad = id_actividad;
            this.tipo = tipo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.direccion = direccion;
            this.poblacion = poblacion;
            this.provincia = provincia;
            this.fecha_hora = fecha_hora;
            this.numLimite_plazas = numLimite_plazas;
            this.material_necesario = material_necesario;
            this.fechaLimite_inscrip = fechaLimite_inscrip;
            this.edad_minima = edad_minima;
            this.nivelDeportivo_exigido = nivelDeportivo_exigido;
            this.precio_actividad = precio_actividad;
            this.alias_creador = alias_creador;
            this.id_campeonato = id_campeonato;
        }

        //Constructor Actividad() que NO incluye id_campeonato.
        public Actividad(int id_actividad, string tipo, string nombre, string descripcion, string direccion, string poblacion,
            string provincia, DateTime fecha_hora, int numLimite_plazas, string material_necesario,
            DateTime fechaLimite_inscrip, int edad_minima, string nivelDeportivo_exigido, double precio_actividad,
            string alias_creador)
        {
            this.id_actividad = id_actividad;
            this.tipo = tipo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.direccion = direccion;
            this.poblacion = poblacion;
            this.provincia = provincia;
            this.fecha_hora = fecha_hora;
            this.numLimite_plazas = numLimite_plazas;
            this.material_necesario = material_necesario;
            this.fechaLimite_inscrip = fechaLimite_inscrip;
            this.edad_minima = edad_minima;
            this.nivelDeportivo_exigido = nivelDeportivo_exigido;
            this.precio_actividad = precio_actividad;
            this.alias_creador = alias_creador;
        }



        //Constructor Actividad() que NO incluye id_actividad.
        public Actividad(string tipo, string nombre, string descripcion, string direccion, string poblacion,
            string provincia, DateTime fecha_hora, int numLimite_plazas, string material_necesario,
            DateTime fechaLimite_inscrip, int edad_minima, string nivelDeportivo_exigido, double precio_actividad,
            string alias_creador, int id_campeonato)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.direccion = direccion;
            this.poblacion = poblacion;
            this.provincia = provincia;
            this.fecha_hora = fecha_hora;
            this.numLimite_plazas = numLimite_plazas;
            this.material_necesario = material_necesario;
            this.fechaLimite_inscrip = fechaLimite_inscrip;
            this.edad_minima = edad_minima;
            this.nivelDeportivo_exigido = nivelDeportivo_exigido;
            this.precio_actividad = precio_actividad;
            this.alias_creador = alias_creador;
            this.id_campeonato = id_campeonato;
        }

        //Constructor Actividad() que NO incluye id_actividad, id_campeonato.
        public Actividad(string tipo, string nombre, string descripcion, string direccion, string poblacion,
            string provincia, DateTime fecha_hora, int numLimite_plazas, string material_necesario,
            DateTime fechaLimite_inscrip, int edad_minima, string nivelDeportivo_exigido, double precio_actividad,
            string alias_creador)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.direccion = direccion;
            this.poblacion = poblacion;
            this.provincia = provincia;
            this.fecha_hora = fecha_hora;
            this.numLimite_plazas = numLimite_plazas;
            this.material_necesario = material_necesario;
            this.fechaLimite_inscrip = fechaLimite_inscrip;
            this.edad_minima = edad_minima;
            this.nivelDeportivo_exigido = nivelDeportivo_exigido;
            this.precio_actividad = precio_actividad;
            this.alias_creador = alias_creador;
        }


        //Constructor Actividad() que NO incluye id_actividad, id_creador, id_campeonato.
        public Actividad(string tipo, string nombre, string descripcion, string direccion, string poblacion,
            string provincia, DateTime fecha_hora, int numLimite_plazas, string material_necesario,
            DateTime fechaLimite_inscrip, int edad_minima, string nivelDeportivo_exigido, double precio_actividad)
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.direccion = direccion;
            this.poblacion = poblacion;
            this.provincia = provincia;
            this.fecha_hora = fecha_hora;
            this.numLimite_plazas = numLimite_plazas;
            this.material_necesario = material_necesario;
            this.fechaLimite_inscrip = fechaLimite_inscrip;
            this.edad_minima = edad_minima;
            this.nivelDeportivo_exigido = nivelDeportivo_exigido;
            this.precio_actividad = precio_actividad;
        }
        #endregion

        #region(Enrique)
        //métodos de implementación

        //método AgregarActividad() que NO incluye id_actividad.

        //public int AgregarActividadBD(MySqlConnection conexion)
        //{
        //    int retorno;
        //    string consulta = String.Format("INSERT INTO Actividad (tipo, nombre, descripcion," +
        //        "direccion, poblacion, provincia, fecha_hora, plazas, requerimientos, fecha_limite, edad_limite," +
        //        "nivel_requerido, dinero, alias_creador, id_campeonato) VALUES" +
        //        " ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},'{8}','{9}',{10},'{11}',{12}," +
        //        "'{13}',{14})", tipo, nombre, descripcion, direccion, poblacion, provincia,
        //        fecha_hora.ToString("yyyy-MM-dd HH:mm:ss"), numLimite_plazas, material_necesario,
        //        fechaLimite_inscrip.ToString("yyyy-MM-dd HH:mm:ss"), edad_minima, nivelDeportivo_exigido,
        //        precio_actividad, alias_creador, id_campeonato);

        //    MySqlCommand comando = new MySqlCommand(consulta,conexion );

        //    retorno = comando.ExecuteNonQuery();

        //    return retorno;
        //}

        //método AgregarActividad() que NO incluye id_actividad, id_creador, id_campeonato.
        public int AgregarActividadBD(MySqlConnection conexion, int id)
        {
            int retorno;
            string consulta = String.Format("INSERT INTO Actividad (tipo, nombre, descripcion," +
                "direccion, poblacion, provincia, fecha_hora, plazas, requerimientos, fecha_limite," +
                " edad_limite, nivel_requerido, dinero, alias_creador,id_campeonato)" +
                " VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},'{8}','{9}',{10},'{11}'" +
                ",{12},'{13}','{14}')", tipo, nombre, descripcion, direccion, poblacion, provincia,
                fecha_hora.ToString("yyyy-MM-dd HH:mm:ss"), numLimite_plazas, material_necesario,
                fechaLimite_inscrip.ToString("yyyy-MM-dd HH:mm:ss"), edad_minima, nivelDeportivo_exigido,
                precio_actividad, alias_creador, id);

            MySqlCommand comando = new MySqlCommand(consulta, conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }



        // Primer método para buscar usuarios en la Base de Datos.
        // Recibe la conexión y la consulta de búsqueda.
        // Devuelve una lista de usuarios que coinciden con la búsqueda realizada. 
        public static List<Actividad> BuscarActividadesBD(MySqlConnection pConexion, string consulta)
        {
            List<Actividad> lista = new List<Actividad>();
            // MessageBox.Show(consulta);   -Se puede activar esta línea para testear la sintaxis de la consulta.

            // Creamos el objeto command al cual le pasamos la consulta y la conexión
            MySqlCommand comando = new MySqlCommand(consulta, pConexion);
            // Ejecutamos el comando y recibimos en un objeto DataReader la lista de registros seleccionados.
            // Recordemos que un objeto DataReader es una especie de tabla de datos virtual.
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)   // En caso que se hayan registros en el objeto reader
            {
                // Recorremos el reader (registro por registro) y cargamos la lista de usuarios.
                while (reader.Read())
                {
                    //MessageBox.Show(reader.GetString(0));
                    Actividad emp = new Actividad(reader.GetInt16(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6),
                        reader.GetDateTime(7), reader.GetInt16(8), reader.GetString(9), reader.GetDateTime(10),
                        reader.GetInt16(11), reader.GetString(12), reader.GetDouble(13),
                        reader.GetString(14)/*, reader.GetInt16(16)*/);
                    lista.Add(emp);
                }
            }
            reader.Close();
            // devolvemos la lista cargada con los usuarios.
            return lista;
        }
        #endregion

        /// <summary>
        /// Elimina todos los registros de la tabla Actividades de la BD, coincidentes con el valor y campo indicados
        /// en los paramentos del método. NOTA: Este método solo es valido para campos de tipo Varchar.
        /// </summary>
        /// <param name="pConexion"></param>
        /// <param name="pCampo">campo (tipo varchar) de la tabla Actividades</param>
        /// <param name="pValorCampo">valor (tipo varchar) de la tabla Actividades</param>
        /// <returns></returns>
        public static int EliminarActividadesBDxVarchar(MySqlConnection pConexion, string pCampo, string pValorCampo)
        {
            int retorno;
            string consulta = string.Format("DELETE FROM Actividad WHERE {0} = '{1}'", pCampo, pValorCampo);
            // MessageBox.Show(consulta); //   Se puede activar esta línea para testear la sintaxis de la consulta.
            MySqlCommand comando = new MySqlCommand(consulta, pConexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        /// <summary>
        /// Elimina todos los registros de la tabla Actividades de la BD, coincidentes con el valor y campo indicados
        /// en los paramentos del método. NOTA: Este método solo es valido para campos de tipo int.
        /// </summary>
        /// <param name="pConexion"></param>
        /// <param name="pCampo">campo (tipo int) de la tabla Actividades</param>
        /// <param name="pValorCampo">valor (tipo int) de la tabla Actividades</param>
        /// <returns></returns>
        public static int EliminarActividadesBDxInt(MySqlConnection pConexion, string pCampo, int pValorCampo)
        {
            int retorno;
            string consulta = string.Format("DELETE FROM Actividad WHERE {0} = {1}", pCampo, pValorCampo);
            // MessageBox.Show(consulta); //   Se puede activar esta línea para testear la sintaxis de la consulta.
            MySqlCommand comando = new MySqlCommand(consulta, pConexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        /// <summary>
        /// Elimina todos los registros de la tabla Actividades de la BD, coincidentes con el valor y campo indicados
        /// en los paramentos del método. NOTA: Este método solo es valido para campos de tipo int.
        /// </summary>
        /// <param name="pConexion"></param>
        /// <param name="pCampo">campo (tipo DateTime) de la tabla Actividades</param>
        /// <param name="pValorCampo">valor (tipo DateTime) de la tabla Actividades</param>
        /// <returns></returns>
        public static int EliminarActividadesBDxDateTime(MySqlConnection pConexion, string pCampo, DateTime pValorCampo)
        {
            int retorno;
            string consulta = string.Format("DELETE FROM Actividad WHERE {0} = {1}", pCampo,
                pValorCampo.ToString("yyyy-MM-dd HH:mm:ss"));
            // MessageBox.Show(consulta); //   Se puede activar esta línea para testear la sintaxis de la consulta.
            MySqlCommand comando = new MySqlCommand(consulta, pConexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static Actividad ObtenerActividad(MySqlConnection conexion, int identificacion)
        {
            Actividad act = new Actividad();
            string consulta = string.Format("SELECT * FROM Actividad WHERE id_actividad={0}", identificacion);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                act.id_actividad = reader.GetInt32(0);
                act.tipo = reader.GetString(1);
                act.nombre = reader.GetString(2);
                act.descripcion = reader.GetString(3);
                act.direccion = reader.GetString(4);
                act.poblacion = reader.GetString(5);
                act.provincia = reader.GetString(6);
                act.fecha_hora = reader.GetDateTime(7);
                act.numLimite_plazas = reader.GetInt32(8);
                act.material_necesario = reader.GetString(9);
                act.fechaLimite_inscrip = reader.GetDateTime(10);
                act.edad_minima = reader.GetInt32(11);
                act.nivelDeportivo_exigido = reader.GetString(12);
                act.precio_actividad = reader.GetInt32(13);
                act.alias_creador = reader.GetString(14);
                act.Id_campeonato = reader.GetInt32(15);

            }
            reader.Close();
            return act;

        }

        public static bool ActividadPasada(MySqlConnection conexion, DateTime fecha)
        {
            TimeSpan diferencia = DateTime.Now - fecha;
            int dif = Convert.ToInt32(diferencia);

            if (dif < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int SacarIDActividad(MySqlConnection conexion, Actividad act)
        {
            int idact = 0;
            string consulta = string.Format("Select id_actividad from Actividad WHERE tipo='{0}' AND nombre='{1}' AND descripcion='{2}' AND direccion='{3}' AND poblacion='{4}'" +
                "AND provincia='{5}' AND fecha_hora='{6}' AND plazas={7} AND requerimientos='{8}' AND fecha_limite='{9}' AND edad_limite={10} AND nivel_requerido='{11}'" +
                "AND dinero={12} AND alias_creador='{13}' AND id_campeonato={14}",act.tipo,act.nombre,act.descripcion,act.direccion,act.poblacion,act.provincia,act.fecha_hora.ToString("yyyy-MM-dd HH:mm:ss"),
                act.numLimite_plazas,act.material_necesario,act.fechaLimite_inscrip.ToString("yyyy-MM-dd HH:mm:ss"), act.edad_minima,act.nivelDeportivo_exigido,act.precio_actividad,act.alias_creador,act.id_campeonato);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();;

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    idact = reader.GetInt32(0);
                }
            }

            reader.Close();
            return idact;

        }
    }
}
