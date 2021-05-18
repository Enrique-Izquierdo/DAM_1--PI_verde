using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportShare
{
    public partial class Pantalla_Evento : Form
    {
        public Pantalla_Evento()
        {
            InitializeComponent();
        }

        private void btnValorar_Click(object sender, EventArgs e)
        {
            Valoración valorac = new Valoración();
            valorac.Show();
        }

        private void Pantalla_Evento_Load(object sender, EventArgs e)
        {
            txtCampeonato.Text = Convert.ToString(Datos.act.Id_campeonato);
            txtCodigo.Text = Convert.ToString(Datos.act.Id_actividad);
            txtDescripcion.Text = Datos.act.Descripcion;
            txtDia.Text = Convert.ToString(Datos.act.Fecha_hora.ToString("yyyy-MM-dd"));
            txtHora.Text = Convert.ToString(Datos.act.Fecha_hora.ToString("HH:mm:ss"));
            txtLocalizacion.Text = Datos.act.Poblacion;
            txtMateriales.Text = Datos.act.Material_necesario;
            txtNivelDeportivo.Text = Datos.act.NivelDeportivo_exigido;
            txtOrganizador.Text = Datos.act.Alias_creador;
            txtPrecio.Text = Convert.ToString(Datos.act.Precio_actividad);
        }
    }
}
