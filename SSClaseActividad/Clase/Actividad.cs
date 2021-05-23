using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShare.Clase
{
    class Actividad
    {
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
        private string informacion_extra;
        private double precio_actividad; // campo "dinero" de la tabla "Actividades" de la BD
        private int id_creador;
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
        public DateTime FechaLimite_inscrip { get { return fechaLimite_inscrip; } set {fechaLimite_inscrip = value; } }
        public int Edad_minima { get { return edad_minima; } set { edad_minima = value; } }
        public string NivelDeportivo_exigido { get { return nivelDeportivo_exigido; } set { nivelDeportivo_exigido = value; } }
        public string Informacion_extra { get { return informacion_extra; } set { informacion_extra = value; } }
        public double Precio_actividad { get { return precio_actividad; } set { precio_actividad = value; }}
        public int Id_creador { get { return id_creador; } set { id_creador = value; } }
        public int Id_campeonato { get { return id_campeonato; } set { id_campeonato = value; } }

        /* Constructores */
        public Actividad() { }

        public Actividad(int id_actividad, string tipo, string nombre, string descripcion, string direccion, string poblacion,
            string provincia, DateTime fecha_hora, int numLimite_plazas, string material_necesario, 
            DateTime fechaLimite_inscrip, int edad_minima, string nivelDeportivo_exigido, string informacion_extra, 
            double precio_actividad, int id_creador, int id_campeonato)
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
            this.informacion_extra = informacion_extra;
            this.precio_actividad = precio_actividad;
            this.id_creador = id_creador;
            this.id_campeonato = id_campeonato;
        }


        //métodos de implementación


        public int AgregarActividadBD()
        {
            int retorno;
            string consulta = String.Format("INSERT INTO Actividad (id_actividad, tipo, nombre, descripcion," +
                "direccion, poblacion, provincia, fecha_hora, plazas, requerimientos, fecha_limite, edad_limite," +
                "nivel_requerido, informacion_extra, dinero, id_creador, id_campeonato) VALUES" +
                " ({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'{9}','{10}',{11},'{12}','{13}',{14}," +
                "{15},{16})", id_actividad, tipo, nombre, descripcion, direccion, poblacion, provincia,
                fecha_hora.ToString("yyyy-MM-dd HH:mm:ss"), numLimite_plazas, material_necesario, 
                fechaLimite_inscrip.ToString("yyyy-MM-dd HH:mm:ss"), edad_minima, nivelDeportivo_exigido, 
                informacion_extra, precio_actividad, id_creador, id_campeonato);

            MySqlCommand comando = new MySqlCommand(consulta, ConexBDpST.Conexion);

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }


        // Primer método para buscar usuarios en la Base de Datos.
        // Recibe la conexión y la consulta de búsqueda.
        // Devuelve una lista de usuarios que coinciden con la búsqueda realizada. 
        public List<Actividad> BuscarActividadesBD(MySqlConnection pConexion, string consulta)
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
                        reader.GetInt16(11), reader.GetString(12), reader.GetString(13), reader.GetDouble(14),
                        reader.GetInt16(15), reader.GetInt16(16));
                    lista.Add(emp);          
                }
            }
            reader.Close();
            // devolvemos la lista cargada con los usuarios.
            return lista;
        }


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
            string consulta = string.Format("DELETE FROM Actividades WHERE {0} = '{1}'", pCampo, pValorCampo);
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
            string consulta = string.Format("DELETE FROM Actividades WHERE {0} = {1}", pCampo, pValorCampo);
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
            string consulta = string.Format("DELETE FROM Actividades WHERE {0} = {1}", pCampo, 
                pValorCampo.ToString("yyyy-MM-dd HH:mm:ss"));
            // MessageBox.Show(consulta); //   Se puede activar esta línea para testear la sintaxis de la consulta.
            MySqlCommand comando = new MySqlCommand(consulta, pConexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


    }
}
