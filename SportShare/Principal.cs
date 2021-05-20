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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        ConexionBD bd = new ConexionBD();
       

        private void tkbPrecioCrear_Scroll(object sender, EventArgs e)
        {
            lblDolar_CrearEvento.Text = tkbPrecio_CrearEvento.Value.ToString() + "$";
            lblDolar_CrearEvento.Visible = true;
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool ControlErroresCrear()
        {
            bool ok = true;
            if (txtDescripcion_CrearEvento.Text == "")
            {
                ok = false;
                errores.SetError(txtDescripcion_CrearEvento, "Introduzca una descripción");                
            }
            else
            {
                errores.SetError(txtDescripcion_CrearEvento, " ");
                //errores.Clear();
            }
            if (txtDireccion_CrearEvento.Text == "")
            {
                ok = false;
                errores.SetError(txtDireccion_CrearEvento, "Introduzca la dirección del evento");                
            }
            else
            {
                errores.SetError(txtDireccion_CrearEvento, " ");
                //errores.Clear();
            }
            if (txtNombre_CrearEvento.Text == "")
            {
                ok = false;
                errores.SetError(txtNombre_CrearEvento, "Introduzca el nombre del evento");                
            }
            else
            {
                errores.SetError(txtNombre_CrearEvento, "");
                //errores.Clear();
            }
            if (txtPoblacion_CrearEvento.Text == "")
            {
                ok = false;
                errores.SetError(txtPoblacion_CrearEvento, "Introduzca la población del evento");                
            }
            else
            {
                errores.SetError(txtPoblacion_CrearEvento, "");
                //errores.Clear();
            }
            if (txtProvincia_CrearEvento.Text == "")
            {
                ok = false;
                errores.SetError(txtProvincia_CrearEvento, "Introduzca la provincia del evento");                
            }
            else
            {
                errores.SetError(txtProvincia_CrearEvento, "");
                //errores.Clear();
            }
            if (cmbDeporte_CrearEvento.Text == "")
            {
                ok = false;
                errores.SetError(cmbDeporte_CrearEvento, "Introduzca el estilo de deporte del evento");                
            }
            else
            {
                errores.SetError(cmbDeporte_CrearEvento, "");
                //errores.Clear();
            }
            if (nudParticipantes_CrearEvento.Text == "")
            {
                ok = false;
                errores.SetError(nudParticipantes_CrearEvento, "Introduzca el número máximo de participantes");                
            }
            else
            {
                errores.SetError(nudParticipantes_CrearEvento, "");
                //errores.Clear();
            }
            if (mtxtFechaHora_CrearEvento.Text == "  /  /       :")
            {
                ok = false;
                errores.SetError(mtxtFechaHora_CrearEvento, "Introduzca la hora del evento");                
            }
            else
            {
                errores.SetError(mtxtFechaHora_CrearEvento, "");
                //errores.Clear();
            }
            return ok;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Refrescar();
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

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
           
            if (Usuario.UsuarioExiste(bd.Conexion, txtDestinatario.Text))
            {
                Mensaje men = new Mensaje(txtNomUsuPerfil.Text, txtDestinatario.Text, txtCuerpoMensaje.Text, DateTime.Now);
                men.EnviarMensaje(bd.Conexion, men);
                txtCuerpoMensaje.Text = "";
                txtDestinatario.Text = "";
                errores.Clear();
            }
            else
            {
                errores.SetError(txtDestinatario, "Escribe un nombre de usuario correcto");
            }
            bd.CerrarConexion();
        }

        private void btnCargarMensajes_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            dgvMensajesEnviados.DataSource = Mensaje.BuscarMensajesEnviados(bd.Conexion, Datos.usu.Alias);
            dgvMensajesRecibidos.DataSource = Mensaje.BuscarMensajesRecibidos(bd.Conexion, Datos.usu.Alias);
            bd.CerrarConexion();
        }

        private void btnAñadirAmigo_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();

            if (Usuario.UsuarioExiste(bd.Conexion, txtAñadirAmigo.Text))
            {
                if (Usuario.Sonamigos(bd.Conexion, Datos.usu.Alias, txtAñadirAmigo.Text) == false)
                {

                    Usuario.AñadirAmigo(bd.Conexion, Datos.usu.Alias, txtAñadirAmigo.Text);
                    Usuario.AñadirAmigo(bd.Conexion, txtAñadirAmigo.Text, Datos.usu.Alias);
                   
                    txtAñadirAmigo.Text = "";                    
                }
                else
                {
                    MessageBox.Show("El usuario " + txtAñadirAmigo.Text + " no existe.");
                }
            }
            else
            {
                MessageBox.Show("El usuario " + txtAñadirAmigo.Text + " ya es tu amigo.");
            }
            bd.CerrarConexion();
        }

        private void btnCrear_CrearEvento_Click(object sender, EventArgs e)
        {
            int resultado;
            if (ControlErroresCrear())
            {

                bd.AbrirConexion();

                Actividad act = new Actividad(cmbDeporte_CrearEvento.Text, txtNombre_CrearEvento.Text,
                                    txtDescripcion_CrearEvento.Text, txtDireccion_CrearEvento.Text, txtPoblacion_CrearEvento.Text,
                                    txtProvincia_CrearEvento.Text, Convert.ToDateTime(mtxtFechaHora_CrearEvento.Text), Convert.ToInt32(nudParticipantes_CrearEvento.Value),
                                    txtMateriales_CrearEvento.Text, dtpFechaLimite_CrearEvento.Value, Convert.ToInt32(nudEdadMinima_CrearEvento.Value),
                                    txtNivelDeportivo_CrearEvento.Text, tkbPrecio_CrearEvento.Value, Datos.usu.Alias);
                act.Id_campeonato = Campeonato.SacarIDCampeonato(bd.Conexion, cmbSelecCamp_CrearEvento.Text);

                resultado = act.AgregarActividadBD(bd.Conexion,Campeonato.SacarIDCampeonato(bd.Conexion,cmbSelecCamp_CrearEvento.Text));
                bd.CerrarConexion();

                if (resultado > 0)   // Si se ha agregado o modificado limpiamos las cajas de texto
                {
                    bd.AbrirConexion();

                    cmbDeporte_CrearEvento.SelectedIndex = -1;
                    txtNombre_CrearEvento.Clear();
                    txtDescripcion_CrearEvento.Clear();
                    txtDireccion_CrearEvento.Clear();
                    txtPoblacion_CrearEvento.Clear();
                    txtProvincia_CrearEvento.Clear();
                    mtxtFechaHora_CrearEvento.Clear();
                    nudParticipantes_CrearEvento.Value = 0;
                    txtMateriales_CrearEvento.Clear();
                    dtpFechaLimite_CrearEvento.Value = DateTime.Now;
                    nudEdadMinima_CrearEvento.Value = 0;
                    txtNivelDeportivo_CrearEvento.Clear();
                    tkbPrecio_CrearEvento.Value = 0;
                    lblDolar_CrearEvento.Text = tkbPrecio_CrearEvento.Value.ToString() + "$";
                    Participar part = new Participar();
                    part.Id_actividad = Actividad.SacarIDActividad(bd.Conexion, act);
                    part.Alias_usuario = Datos.usu.Alias;
                    part.Tiene_plaza = true;
                    part.InscripcionCreadoraEvento(bd.Conexion);
                     
                    errores.Clear();
                }
            }
                    bd.CerrarConexion();
                
        }

        private void CargarBD_CmbDeporte_CrearEvento()
        {
            string consulta = "SELECT tipo FROM Actividad_tipo";
            MySqlCommand comando = new MySqlCommand(consulta, bd.Conexion);
            bd.AbrirConexion();
            MySqlDataReader registro = comando.ExecuteReader();
            //string prueba = "";
            while (registro.Read())
            {
                cmbDeporte_CrearEvento.Items.Add(registro["tipo"].ToString());
                //prueba += registro["tipo"].ToString();
            }
            //MessageBox.Show(prueba);
            bd.CerrarConexion();
        }

        private void CargarBD_CmbDeporte_Buscar()
        {
            string consulta = "SELECT tipo FROM Actividad_tipo";
            MySqlCommand comando = new MySqlCommand(consulta, bd.Conexion);
            bd.AbrirConexion();
            MySqlDataReader registro = comando.ExecuteReader();
            //string prueba = "";
            while (registro.Read())
            {
                cmbDeporte_Buscar.Items.Add(registro["tipo"].ToString());
                //prueba += registro["tipo"].ToString();
            }
            //MessageBox.Show(prueba);
            bd.CerrarConexion();
        }

        private void CargarBD_CmbLocalidad_Buscar()
        {
            //string consulta = "SELECT DISTINCT nombre FROM tiposActividad";
            string consulta = "SELECT DISTINCT poblacion FROM Actividad";
            MySqlCommand comando = new MySqlCommand(consulta, bd.Conexion);
            bd.AbrirConexion();
            MySqlDataReader registro = comando.ExecuteReader();
            //string prueba = "";
            while (registro.Read())
            {
                cmbLocalidad_Buscar.Items.Add(registro["poblacion"].ToString());
                //prueba += registro["poblacion"].ToString();
            }
            //MessageBox.Show(prueba);
            bd.CerrarConexion();
        }

        private void CargarBD_CmbSelecCamp_CrearEvento()
        {
            //string consulta = "SELECT DISTINCT nombre FROM tiposActividad";
            string consulta = "SELECT DISTINCT nombre FROM Campeonato";
            MySqlCommand comando = new MySqlCommand(consulta, bd.Conexion);
            bd.AbrirConexion();
            MySqlDataReader registro = comando.ExecuteReader();
            //string prueba = "";
            while (registro.Read())
            {
                cmbSelecCamp_CrearEvento.Items.Add(registro["nombre"].ToString());
                //prueba += registro["poblacion"].ToString();
            }
            //MessageBox.Show(prueba);
            bd.CerrarConexion();
        }

        private void CargarDGVBuscar_BDActividad(MySqlConnection pConexion, string consulta)
        {
            
            bd.AbrirConexion();
            dgvBuscar.DataSource = Actividad.BuscarActividadesBD(pConexion, consulta);            
            bd.CerrarConexion();
        }

        private void dgvBuscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bd.AbrirConexion();
            Datos.act = Actividad.ObtenerActividad(bd.Conexion, Convert.ToInt32(dgvBuscar.Rows[e.RowIndex].Cells[0].Value));
            Pantalla_Evento panteven = new Pantalla_Evento();
            panteven.ShowDialog();
            bd.CerrarConexion();
        }

        private void btnCrearCampeonato_Click(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            errores.Clear();
            if (txtNomCampeonato.Text == "" || txtDescCampeonato.Text == "")
            {
                errores.SetError(btnCrearCampeonato, "Falta rellenar campos");
            }
            else
            {
                if (Campeonato.CamepeonatoExiste(bd.Conexion, txtNomCampeonato.Text))
                {
                    errores.SetError(txtNomCampeonato, "Este nombre de campeonato no esta disponible");
                }
                else
                {
                    Campeonato cam = new Campeonato(txtNomCampeonato.Text, txtDescCampeonato.Text);
                    cam.AgregarCampeonato(bd.Conexion, cam);
                    txtDescCampeonato.Text = "";
                    txtNomCampeonato.Text = "";
                }
            }
            
            bd.CerrarConexion();
        }

        private void pbxbuscar_Click(object sender, EventArgs e)
        {
            string consulta = String.Format("SELECT * FROM Actividad WHERE tipo='{0}' AND poblacion='{1}' AND fecha_hora>='{2}' AND fecha_hora<='{3}'", cmbDeporte_Buscar.Text, cmbLocalidad_Buscar.Text, dtpDesdeDia_Buscar.Value.ToString("yyyy-MM-dd HH:mm:ss"), dtpHastaDia_Buscar.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            bd.AbrirConexion();
            dgvBuscar.DataSource= Actividad.BuscarActividadesBD(bd.Conexion, consulta);
            bd.CerrarConexion();
        }
        private void Refrescar()
        {

            cmbDeporte_Buscar.Items.Clear();
            cmbLocalidad_Buscar.Items.Clear();
            cmbDeporte_CrearEvento.Items.Clear();
            cmbSelecCamp_CrearEvento.Items.Clear();
            cmbDeporte_Buscar.Text = Datos.usu.Deportepreferido;
            CargarBD_CmbDeporte_Buscar();
            cmbLocalidad_Buscar.Text = Datos.usu.Poblacion;
            CargarBD_CmbLocalidad_Buscar();
            cmbDeporte_CrearEvento.Text = Datos.usu.Deportepreferido;
            CargarBD_CmbDeporte_CrearEvento();
            cmbSelecCamp_CrearEvento.Text = "Ninguno";
            CargarBD_CmbSelecCamp_CrearEvento();

            string consultaInicial = "SELECT * FROM Actividad";
            CargarDGVBuscar_BDActividad(bd.Conexion, consultaInicial);


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
            txtEdadMiPerfil.Text = Convert.ToString(Usuario.CalcularEdad(Datos.usu.Fechanacimiento));
            pbxfotoMiPerfil.Image = Datos.usu.Foto;
            string consulta = string.Format("SELECT * FROM Actividad WHERE tipo='{0}' AND poblacion='{1}'", Datos.usu.Deportepreferido, Datos.usu.Poblacion);
            bd.AbrirConexion();
            dgvBuscar.DataSource = Actividad.BuscarActividadesBD(bd.Conexion, consulta);
            bd.CerrarConexion();
        }

        private void pbxRefrecar_Click(object sender, EventArgs e)
        {
            Refrescar();
            
        }

        private void btnCancelar_CrearEvento_Click(object sender, EventArgs e)
        {
            txtDescripcion_CrearEvento.Clear();
            txtDireccion_CrearEvento.Clear();
            txtMateriales_CrearEvento.Clear();
            txtNivelDeportivo_CrearEvento.Clear();
            txtNombre_CrearEvento.Clear();
            txtPoblacion_CrearEvento.Clear();
            txtProvincia_CrearEvento.Clear();
            mtxtFechaHora_CrearEvento.Clear();
            nudEdadMinima_CrearEvento.Value = 0;
            nudParticipantes_CrearEvento.Value = 0;
            cmbDeporte_CrearEvento.Text = "";
            cmbSelecCamp_CrearEvento.Text = "Ninguno";
            tkbPrecio_CrearEvento.Value = 0;
            lblDolar_CrearEvento.Text = tkbPrecio_CrearEvento.Value + "$";
        }
    }
}
