using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShare.Clase
{
    class Campeonato
    {
        private int idcampeonato;
        private string nombre;
        private string descripcion;
        
        public int Idcampeonato { get { return idcampeonato; } set { idcampeonato = value;  } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value;  } }

        public Campeonato(int idcampe, string nom, string desc)
        {
            idcampeonato = idcampe;
            nombre = nom;
            descripcion = desc;
        }
    }
}
