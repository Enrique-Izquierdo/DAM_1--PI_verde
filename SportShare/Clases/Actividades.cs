using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShare.Clases
{
    class Actividades
    {
        private string tipoActividad;
        private string nombre;
        private string descripcion;
        private DateTime fechahora;
        private string direccion;
        private string localidad;
        private string provincia;
        private int maxparticpantes;
        private DateTime fechalimite;
        private int edadmin;
        private string niveldeportivo;
        private string materiales;
        private double precio;
        private string organizador;


        public string TipoActividad { get { return tipoActividad; } set { tipoActividad = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public DateTime Fechahora { get { return fechahora; } set { fechahora = value; } }
        public string Localidad { get { return localidad; } set { localidad = value; } }
        public string Provincia { get { return provincia; } set { provincia = value; } }
        public int Maxparticpantes { get { return maxparticpantes; } set { maxparticpantes = value; } }
        public DateTime Fechalimite { get { return fechalimite; } set {fechalimite = value; } }
        public int Edadmin { get { return edadmin; } set { edadmin = value; } }
        public string Niveldeportivo { get { return niveldeportivo; } set { niveldeportivo = value; } }
        public string Materiales { get { return materiales; } set { materiales = value; } }
        public double Precio { get { return precio; } set { precio = value; } }
        public string Organizador { get { return organizador; } set { organizador = value; } }

        public Actividades(string tipoact, string nom, string desc, DateTime feho, string dire, string loca, string pro, int maxparti, DateTime fechalimi, int edmin, string niveldepor, string mate, double pre, string orga)
        {
            tipoActividad = tipoact;
            nombre = nom;
            descripcion = desc;
            fechahora = feho;
            direccion = dire;
            localidad = loca;
            provincia = pro;
            maxparticpantes = maxparti;
            fechalimite = fechalimi;
            edadmin = edmin;
            niveldeportivo = niveldepor;
            materiales = mate;
            precio = pre;
            organizador = orga;
        }

        public string List<Actividades> BuscarActividad()
        {

        }

        public string List<Actividades> ActividadesEnTuPoblacion() 
        {

        }

        public void InfoActividad()
        {

        }
    }
}
