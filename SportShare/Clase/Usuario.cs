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
    class Usuario
    {
        private int idUsuario;
        private string alias;
        private string contraseña;
        private string nombre;
        private string apellidos;
        private DateTime fechaNacimiento;
        private double peso;
        private double altura;
        private int telefono;
        private string poblacion;
        private string provincia;
        private string deportePreferido;
        private string enfermedades;
        private int valoraciones;

        public int Idusuario { get { return idUsuario; } set { idUsuario = value;  } }
        public string Alias { get { return alias; } set {  alias = value;  } }
        public string Contraseña { get { return contraseña; } set { contraseña = value;  } }
        public string Nombre { get { return nombre; } set { nombre = value;  } }
        public string Apellidos { get { return apellidos; } set { apellidos = value; } }
        public DateTime Fechanacimiento { get { return fechaNacimiento;  } set { fechaNacimiento = value;  } }
        public double Peso { get { return peso; } set { peso = value;  } }
        public double Altura { get { return altura;  } set { altura = value;  } }
        public int Telefono { get { return telefono; } set { telefono = value; } }
        public string Poblacion { get { return poblacion; } set { poblacion = value; } }
        public string Provincia { get { return provincia; } set { provincia = value; } }
        public string Deportepreferido { get { return deportePreferido; } set { deportePreferido = value; } }
        public string Enfermedades { get { return enfermedades; } set { enfermedades = value; } }
        public int Valoracion { get { return valoraciones; } set { valoraciones = value; } }

        public Usuario( string ali, string contra, string nom, string ape, DateTime fechanaci, double pes, double alt, int tel, string pobla, string provi, string deportepre, string enfer)
        {
            alias = ali;
            contraseña = contra;
            nombre = nom;
            apellidos = ape;
            fechaNacimiento = fechanaci;
            peso = pes;
            altura = alt;
            telefono = tel;
            poblacion = pobla;
            provincia = provi;
            deportePreferido = deportepre;
            enfermedades = enfer;
        }

        public int RegistrarUsuario(MySqlConnection conexion,Usuario usu) 
        {
            int retorno;
            
                string consulta = String.Format("INSERT INTO Usuarios (alias,contraseña,nombre,apellidos," +
                    "fecha,telefono,poblacion,provincia,peso,altura,deporte,enfermedades) VALUES " +
                                "('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", usu.alias, usu.contraseña,usu.nombre,usu.apellidos,usu.fechaNacimiento.ToString("yyyy-MM-dd HH:mm:ss"),
                                usu.telefono,usu.poblacion,usu.provincia,Convert.ToDouble(usu.peso),Convert.ToDouble(usu.altura),usu.deportePreferido,usu.enfermedades);

                MySqlCommand comando = new MySqlCommand(consulta,conexion);
                MessageBox.Show(consulta);
                retorno = comando.ExecuteNonQuery();
            


            return retorno;
        }
<<<<<<< HEAD

        public static bool UsuarioExiste(MySqlConnection conexion, string nom)
        {
            string consulta = string.Format("Select alias from Usuarios where alias='{0}'", nom);
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
        public static bool VerificarContraseña(MySqlConnection conexion, string contrasenya, string a)
        {
            bool verificación = false;
            string consulta = string.Format("Select alias,contraseña from Usuarios where alias='{0}'", a);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    if (reader.GetString(1) == contrasenya)
                    {
                        verificación = true;
                    }
                    else { verificación = false; }
                };
            }
            else
            {
                verificación = false;
            }

            reader.Close();
            return verificación;
        }

        public static Usuario BuscarUsuario(MySqlConnection conexion,string idusu)
        {
            Usuario usu = new Usuario("", "", "", "", DateTime.Now, 0, 0, 0, "", "","",""); ;
            string seleccion = String.Format("Select alias,contraseña,nombre,apellidos,fecha,telefono," +
                               "poblacion,provincia,peso,altura,deporte,enfermedades from Usuarios WHERE alias='{0}'",idusu);

            MySqlCommand comando = new MySqlCommand(seleccion, conexion);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    usu = new Usuario(reader.GetString(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetDateTime(4),reader.GetDouble(8), reader.GetDouble(9), 
                        reader.GetInt32(5), reader.GetString(6),reader.GetString(7),reader.GetString(10),reader.GetString(11));
                    
                }
            }
            reader.Close();
            return usu;

        }

        public void ModificarUsuario(MySqlConnection conexion,Usuario usu,string idusu)
        {
            string consulta = string.Format("UPDATE Usuarios SET alias = @a, nombre = @nom,apellidos = @ape, fecha = @fn, " +
                "telefono = @tlf, poblacion = @pob, provincia = @prov, peso = @p, altura = @alt, deporte = @dp, enfermedades=@enf" +
                " WHERE alias = '{0}' ", idusu);
            MySqlCommand comando = new MySqlCommand(consulta, conexion);
            comando.Parameters.AddWithValue("a", usu.alias);
            comando.Parameters.AddWithValue("nom", usu.nombre);
            comando.Parameters.AddWithValue("ape", usu.apellidos);
            comando.Parameters.AddWithValue("tlf", usu.telefono);
            comando.Parameters.AddWithValue("pob", usu.poblacion);
            comando.Parameters.AddWithValue("prov", usu.provincia);
            comando.Parameters.AddWithValue("p", usu.peso);
            comando.Parameters.AddWithValue("alt", usu.altura);
            comando.Parameters.AddWithValue("dp", usu.deportePreferido);
            comando.Parameters.AddWithValue("enf", usu.enfermedades);
            comando.Parameters.AddWithValue("fn", usu.fechaNacimiento);

            comando.ExecuteNonQuery();
        }
=======
>>>>>>> origin/proyC#bueno
    }
}
