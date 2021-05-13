using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportShare.Clases;

namespace SportShare.Clase
{
    class Usuario
    {
        private string idUsuario;
        private string nombreusuario;
        private string contraseña;
        private string nombre;
        private string apellidos;
        private DateTime fechaNacimiento;
        private double peso;
        private double altura;
        private string email;
        private int telefono;
        private string poblacion;
        private string provincia;
        private string deportePreferido;
        private string enfermedades;
        private string valoracion;

        public string Idusuario { get { return idUsuario;  } set { idUsuario = value;  } }
        public string Nombreusuario { get { return nombreusuario; } set {  nombreusuario = value;  } }
        public string Contraseña { get { return contraseña; } set { contraseña = value;  } }
        public string Nombre { get { return nombre; } set { nombre = value;  } }
    }
}
