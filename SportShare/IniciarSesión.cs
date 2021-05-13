﻿using System;
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
    public partial class IniciarSesión : Form
    {
        public IniciarSesión()
        {
            InitializeComponent();
        }
        ConexionBD bd = new ConexionBD();
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Principal pr = new Principal();
            pr.ShowDialog();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Registrarse reg = new Registrarse();
            reg.ShowDialog();

        }

        private void IniciarSesión_Load(object sender, EventArgs e)
        {
            bd.AbrirConexion();
            bd.CerrarConexion();
        }
    }
}
