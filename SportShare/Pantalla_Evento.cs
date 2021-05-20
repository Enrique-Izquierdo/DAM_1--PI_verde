using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SportShare.Clase;

namespace SportShare
{
    public partial class Pantalla_Evento : Form
    {
        public Pantalla_Evento()
        {
            InitializeComponent();
        }

        ConexionBD bd = new ConexionBD();

        private void btnValorar_Click(object sender, EventArgs e)
        {
            Valoración valorac = new Valoración();
            valorac.Show();
        }

        private void Pantalla_Evento_Load(object sender, EventArgs e)
        {
            txtCampeonato.Text = Convert.ToString(Datos.act.Id_campeonato);
            txtNombre_Evento.Text = Datos.act.Nombre;
            txtDescripcion.Text = Datos.act.Descripcion;
            txtDireccion_Evento.Text = Datos.act.Direccion;
            txtPoblacion_Evento.Text = Datos.act.Poblacion;
            txtProvincia_Evento.Text = Datos.act.Provincia;
            txtDia.Text = Convert.ToString(Datos.act.Fecha_hora.ToString("yyyy-MM-dd"));
            txtHora.Text = Convert.ToString(Datos.act.Fecha_hora.ToString("HH:mm:ss"));
            txtFechaLimiteInscrip_Evento.Text= Convert.ToString(Datos.act.FechaLimite_inscrip.ToString("yyyy-MM-dd"));
            txtParticipAceptada_Evento.Text="";
            txtListaEspera_Evento.Text = "";
            
            txtMateriales.Text = Datos.act.Material_necesario;
            txtNivelDeportivo.Text = Datos.act.NivelDeportivo_exigido;
            txtOrganizador.Text = Datos.act.Alias_creador;
            txtPrecio.Text = Convert.ToString(Datos.act.Precio_actividad);
            txtEdad_Evento.Text = Convert.ToString(Datos.act.Edad_minima);
            txtMaxParticipantes_Evento.Text = Convert.ToString(Datos.act.NumLimite_plazas);

        }

        private void btnSiInscripcion_Evento_Click(object sender, EventArgs e)
        {
            Participar part1 = new Participar();
            part1.Alias_usuario = Datos.usu.Alias;
            part1.Id_actividad = Datos.act.Id_actividad;
            part1.Tiene_plaza = true;
            
            bd.AbrirConexion();
            part1.InscripcionUsuarioaEvento(bd.Conexion);
            int posListaEspera = part1.ObternerPosicionListaEspera(Datos.act.NumLimite_plazas);
            bd.CerrarConexion();

            txtParticipAceptada_Evento.Text = "Si";
            if (posListaEspera > 0)
            {
                txtListaEspera_Evento.Text = posListaEspera.ToString();
            }
            else
            {
                txtListaEspera_Evento.Text = "";
            }
                        
        }
    }
}
