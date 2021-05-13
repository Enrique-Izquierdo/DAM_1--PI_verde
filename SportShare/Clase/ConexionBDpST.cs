using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace AEV7
{
    public class ConexionBDpST
    {
        /*------------atributos-------------*/
        #region(atributos)
        // atributo privado - referencia al objeto que se va a crear.
        private static MySqlConnection instancia = null;
        // objeto a utilizar para el bloqueo (no es totalmente necesario en el patrón).
        private static readonly object padlock = new object();
        #endregion

        /*----------constructores-----------*/
        #region(constructores)
        // Contructor privado.
        // No es público para evitar que cualquier otra clase pueda utilizarlo,
        // y por tanto se puedan instaciar objetos de la Clase ConexionBD desde fuera de esta clase.
        private ConexionBDpST () { }
        #endregion

        /*-----------propiedades------------*/
        #region(propiedades)
        // Propiedad que permite el acceso de lectura (GET) a la conexión.
        // Si no existe el objeto se instancia (sólo una vez) y si existe se devuelve su referencia.
        public static MySqlConnection Conexion
        {
            get
            {
                // Se bloquea el objeto para garantizar que sólo un proceso accede a este código 
                // hasta que el bloqueo es liberado (en caso de utilizar threads -hilos-)
                lock (padlock)
                {
                    // Si no existe instancia del objeto conexión a la base de datos la creamos.
                    // En caso de existir instancia no se crea una nueva.
                    if (instancia == null)
                    {
                        instancia = new MySqlConnection();
                        // Se define la cadena de conexión para la conexión.
                        string server = "server=sportshare1.cxvvol0hxfeb.us-east-1.rds.amazonaws.com;";
                        string database = "database=sportshare;";
                        string usuario = "uid=admin_sport;";
                        string password = "pwd=;Adminsport23"; // Aquí faltaría la contraseña correcta
                        instancia.ConnectionString = server + database + usuario + password;
                    }
                    // Se devuelve la instancia de conexión a la base de datos.
                    return instancia;
                }
            }
        }
        #endregion

        /*--------getters y setters---------*/
        #region(getters y setters)
        #endregion

        /*----otros métodos de interface----*/
        #region(otros métodos de interface)
        // Método público para abrir la conexión 
        public static void AbrirConexion()
        {
           if (instancia != null)
                    instancia.Open();
        }
        
        // Método público para cerrar la conexión
        public static void CerrarConexion()
        {
            if (instancia != null)
                instancia.Close();
        }
        #endregion

        /*-----métodos de implementación----*/
        #region(métodos de implementación)
        #endregion

    }
}
