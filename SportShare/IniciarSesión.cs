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
using System.Globalization;
using SportShare.Idiomas;
using System.Threading;

namespace SportShare
{
    public partial class IniciarSesión : Form
    {
        public IniciarSesión()
        {
            InitializeComponent();
        }
        private void AplicarIdioma()
        {
            lblIniciarSes.Text = StringRecursos.InicioSes;
            lblNomUsu.Text = StringRecursos.NomUsu;
            lblRegistrar.Text = StringRecursos.Registrar;
            lblContraseña.Text = StringRecursos.Contraseña;
            btnRegistrarse.Text = StringRecursos.Registrarse;
            btnIniciarSesion.Text = StringRecursos.IniciarSesion;
        }
        public bool ControlErrores()
        {
            bool ok = true;
            if (txtNomUsu.Text == "")
            {
                errores.SetError(txtNomUsu, "Introduzca un ID usuario");
                ok = false;
            }
            else
            {
                errores.Clear();
            }
            if (txtContraseña.Text == "")
            {
                errores.SetError(txtContraseña, "Introduzca su contraseña");
                ok = false;
            }
            else
            {
                errores.Clear();
            }
            return ok;
        }
            ConexionBD bd = new ConexionBD();
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            errores.Clear();
            if (ControlErrores())
            {
                if (Usuario.UsuarioExiste(bd.Conexion, txtNomUsu.Text))
                {
                    if (Usuario.VerificarContraseña(bd.Conexion, txtContraseña.Text, txtNomUsu.Text))
                    {
                        Datos.usu = Usuario.BuscarUsuario(bd.Conexion,txtNomUsu.Text);
                        Principal pr = new Principal();
                        
                        
                        pr.ShowDialog();

                    }
                    else
                    {
                        errores.SetError(txtContraseña, "Contraseña incorrecta");
                    }
                }
                else
                {
                    errores.SetError(txtNomUsu, "Nombre de usuario inexistente");
                }
            }
            
            bd.CerrarConexion();
            
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registrarse reg = new Registrarse();
            reg.ShowDialog();

        }

        private void cbxIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cultura = "";
            switch (cbxIdioma.Text)
            {
                case "Castellano":
                    {
                        cultura = "ES-ES";
                        break;
                    }
                case "Inglés":
                    {
                        cultura = "EN-GB";
                        break;
                    }
            }
            Datos.cultura = cultura;
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);
            AplicarIdioma();
            
        }
    }
}
