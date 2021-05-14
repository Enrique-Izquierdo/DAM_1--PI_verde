using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SportShare.Clase;

namespace SportShare
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        ConexionBD bd = new ConexionBD();
       

        private void tkbPrecioCrear_Scroll(object sender, EventArgs e)
        {
            lblPrecioNumCrear.Text = tkbPrecioCrear.Value.ToString() + "$";
            lblPrecioNumCrear.Visible = true;
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            txtNomUsuPerfil.Text = Datos.usu.Alias;
            txtNombreMiPerfil.Text = Datos.usu.Nombre;
            txtApellidosMiPerfil.Text = Datos.usu.Apellidos;
            txtDepPrefMiPerfil.Text = Datos.usu.Deportepreferido;
            txtPesoMiPerfil.Text = Convert.ToString(Datos.usu.Peso);
            txtTelefonoMiPerfil.Text = Convert.ToString(Datos.usu.Telefono);
            txtAlturaMiPerfil.Text = Convert.ToString(Datos.usu.Altura);
            txtPoblaciónMiPerfil.Text = Datos.usu.Poblacion;
            txtProvinciaMiPerfil.Text = Datos.usu.Provincia;
            txtEnfermedadesMiPerfil.Text = Datos.usu.Enfermedades;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            txtAlturaMiPerfil.ReadOnly = false;
            txtPesoMiPerfil.ReadOnly = false;
            txtNombreMiPerfil.ReadOnly = false;
            txtApellidosMiPerfil.ReadOnly = false;
            txtDepPrefMiPerfil.ReadOnly = false;
            txtNomUsuPerfil.ReadOnly = false;
            txtPoblaciónMiPerfil.ReadOnly = false;
            txtProvinciaMiPerfil.ReadOnly = false;
            txtTelefonoMiPerfil.ReadOnly = false;
            txtEnfermedadesMiPerfil.ReadOnly = false;
            btnConfirmarMod.Visible = true;
            bd.CerrarConexion();


            
        }

        private void btnConfirmarMod_Click(object sender, EventArgs e)
        {

            bd.AbrirConexion();
            string idusu = Datos.usu.Alias;
            Usuario usu = new Usuario(txtNomUsuPerfil.Text, Datos.usu.Contraseña, txtNombreMiPerfil.Text, txtApellidosMiPerfil.Text, Datos.usu.Fechanacimiento, Convert.ToDouble(txtPesoMiPerfil.Text), Convert.ToDouble(txtAlturaMiPerfil.Text), Convert.ToInt32(txtTelefonoMiPerfil.Text), txtPoblaciónMiPerfil.Text, txtProvinciaMiPerfil.Text, txtDepPrefMiPerfil.Text, txtEnfermedadesMiPerfil.Text);
            usu.ModificarUsuario(bd.Conexion, usu, idusu);
            bd.CerrarConexion();
            txtAlturaMiPerfil.ReadOnly = true;
            txtPesoMiPerfil.ReadOnly = true;
            txtNombreMiPerfil.ReadOnly = true;
            txtApellidosMiPerfil.ReadOnly = true;
            txtDepPrefMiPerfil.ReadOnly = true;
            txtNomUsuPerfil.ReadOnly = true;
            txtPoblaciónMiPerfil.ReadOnly = true;
            txtProvinciaMiPerfil.ReadOnly = true;
            txtTelefonoMiPerfil.ReadOnly = true;
            txtEnfermedadesMiPerfil.ReadOnly = true;
            btnConfirmarMod.Visible = false;
        }
    }
}
