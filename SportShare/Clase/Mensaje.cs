using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShare.Clases
{
    class Mensaje
    {
        private string asunto;
        private string cuerpo;
        private int idRemitente;
        private int idEmisor;
        private DateTime fechaEmision;

        public string Asunto { get { return asunto; } set { asunto = value; } }
        public string Cuerpo { get { return cuerpo; } set { cuerpo = value; } }
        public int Idremitente { get { return idRemitente; } set { idRemitente = value; } }
        public int Idemisor { get { return idEmisor; } set { idEmisor = value; } }
        public DateTime Fechaemision { get { return fechaEmision; } set { fechaEmision = value; } }

        public Mensaje(string asunt, string cuer, int idremi, int idemi, DateTime)
        {

        }
    }
}
