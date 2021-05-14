namespace SportShare
{
    partial class IniciarSesión
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbxSportShare = new System.Windows.Forms.PictureBox();
            this.gbxiniciarsesion = new System.Windows.Forms.GroupBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblRegistrar = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtNomUsu = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNomUsu = new System.Windows.Forms.Label();
            this.lblIniciarSes = new System.Windows.Forms.Label();
            this.errores = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSportShare)).BeginInit();
            this.gbxiniciarsesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errores)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxSportShare
            // 
            this.pbxSportShare.Image = global::SportShare.Properties.Resources._1616437656472;
            this.pbxSportShare.InitialImage = null;
            this.pbxSportShare.Location = new System.Drawing.Point(832, 76);
            this.pbxSportShare.Margin = new System.Windows.Forms.Padding(4);
            this.pbxSportShare.Name = "pbxSportShare";
            this.pbxSportShare.Size = new System.Drawing.Size(407, 63);
            this.pbxSportShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSportShare.TabIndex = 0;
            this.pbxSportShare.TabStop = false;
            // 
            // gbxiniciarsesion
            // 
            this.gbxiniciarsesion.Controls.Add(this.btnRegistrarse);
            this.gbxiniciarsesion.Controls.Add(this.lblRegistrar);
            this.gbxiniciarsesion.Controls.Add(this.btnIniciarSesion);
            this.gbxiniciarsesion.Controls.Add(this.txtContraseña);
            this.gbxiniciarsesion.Controls.Add(this.txtNomUsu);
            this.gbxiniciarsesion.Controls.Add(this.lblContraseña);
            this.gbxiniciarsesion.Controls.Add(this.lblNomUsu);
            this.gbxiniciarsesion.Controls.Add(this.lblIniciarSes);
            this.gbxiniciarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxiniciarsesion.Location = new System.Drawing.Point(661, 177);
            this.gbxiniciarsesion.Margin = new System.Windows.Forms.Padding(4);
            this.gbxiniciarsesion.Name = "gbxiniciarsesion";
            this.gbxiniciarsesion.Padding = new System.Windows.Forms.Padding(4);
            this.gbxiniciarsesion.Size = new System.Drawing.Size(748, 635);
            this.gbxiniciarsesion.TabIndex = 1;
            this.gbxiniciarsesion.TabStop = false;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(61, 546);
            this.btnRegistrarse.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(173, 43);
            this.btnRegistrarse.TabIndex = 7;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.AutoSize = true;
            this.lblRegistrar.Location = new System.Drawing.Point(56, 492);
            this.lblRegistrar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(300, 29);
            this.lblRegistrar.TabIndex = 6;
            this.lblRegistrar.Text = "¿No tienes cuenta todavia?";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(499, 391);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(173, 43);
            this.btnIniciarSesion.TabIndex = 5;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(61, 306);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(515, 34);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtNomUsu
            // 
            this.txtNomUsu.Location = new System.Drawing.Point(61, 185);
            this.txtNomUsu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomUsu.Name = "txtNomUsu";
            this.txtNomUsu.Size = new System.Drawing.Size(515, 34);
            this.txtNomUsu.TabIndex = 3;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(56, 257);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(148, 29);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña: ";
            // 
            // lblNomUsu
            // 
            this.lblNomUsu.AutoSize = true;
            this.lblNomUsu.Location = new System.Drawing.Point(56, 137);
            this.lblNomUsu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomUsu.Name = "lblNomUsu";
            this.lblNomUsu.Size = new System.Drawing.Size(236, 29);
            this.lblNomUsu.TabIndex = 1;
            this.lblNomUsu.Text = "Nombre de Usuario: ";
            // 
            // lblIniciarSes
            // 
            this.lblIniciarSes.AutoSize = true;
            this.lblIniciarSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciarSes.Location = new System.Drawing.Point(280, 65);
            this.lblIniciarSes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIniciarSes.Name = "lblIniciarSes";
            this.lblIniciarSes.Size = new System.Drawing.Size(227, 36);
            this.lblIniciarSes.TabIndex = 0;
            this.lblIniciarSes.Text = "Inicio de Sesión";
            // 
            // errores
            // 
            this.errores.ContainerControl = this;
            // 
            // IniciarSesión
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1040);
            this.Controls.Add(this.gbxiniciarsesion);
            this.Controls.Add(this.pbxSportShare);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IniciarSesión";
            this.Text = "Iniciar Sesión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbxSportShare)).EndInit();
            this.gbxiniciarsesion.ResumeLayout(false);
            this.gbxiniciarsesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSportShare;
        private System.Windows.Forms.GroupBox gbxiniciarsesion;
        private System.Windows.Forms.Label lblIniciarSes;
        private System.Windows.Forms.Label lblNomUsu;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtNomUsu;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblRegistrar;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.ErrorProvider errores;
    }
}

