namespace LogInDiseño
{
    partial class FormLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picBoxMaximizar = new System.Windows.Forms.PictureBox();
            this.picBoxLogoS = new System.Windows.Forms.PictureBox();
            this.picBoxRestaurar = new System.Windows.Forms.PictureBox();
            this.picBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.picBoxLogoFondo = new System.Windows.Forms.PictureBox();
            this.picBoxCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngerar = new System.Windows.Forms.Button();
            this.linkLblContraseña = new System.Windows.Forms.LinkLabel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.linkLblRegistrarse = new System.Windows.Forms.LinkLabel();
            this.picBoxUsuario = new System.Windows.Forms.PictureBox();
            this.picBoxContraseña = new System.Windows.Forms.PictureBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxContraseña)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(54)))));
            this.panelLogo.Controls.Add(this.picBoxMaximizar);
            this.panelLogo.Controls.Add(this.picBoxLogoS);
            this.panelLogo.Controls.Add(this.picBoxRestaurar);
            this.panelLogo.Controls.Add(this.picBoxMinimizar);
            this.panelLogo.Controls.Add(this.picBoxLogoFondo);
            this.panelLogo.Controls.Add(this.picBoxCerrar);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panelLogo.Location = new System.Drawing.Point(530, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 350);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // picBoxMaximizar
            // 
            this.picBoxMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMaximizar.Image")));
            this.picBoxMaximizar.Location = new System.Drawing.Point(211, 3);
            this.picBoxMaximizar.Name = "picBoxMaximizar";
            this.picBoxMaximizar.Size = new System.Drawing.Size(15, 15);
            this.picBoxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMaximizar.TabIndex = 11;
            this.picBoxMaximizar.TabStop = false;
            this.picBoxMaximizar.Visible = false;
            this.picBoxMaximizar.Click += new System.EventHandler(this.picBoxMaximizar_Click);
            // 
            // picBoxLogoS
            // 
            this.picBoxLogoS.BackColor = System.Drawing.Color.Black;
            this.picBoxLogoS.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoS.Image")));
            this.picBoxLogoS.Location = new System.Drawing.Point(81, 136);
            this.picBoxLogoS.Name = "picBoxLogoS";
            this.picBoxLogoS.Size = new System.Drawing.Size(90, 69);
            this.picBoxLogoS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogoS.TabIndex = 10;
            this.picBoxLogoS.TabStop = false;
            this.picBoxLogoS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxLogoS_MouseDown);
            // 
            // picBoxRestaurar
            // 
            this.picBoxRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxRestaurar.Image")));
            this.picBoxRestaurar.Location = new System.Drawing.Point(211, 3);
            this.picBoxRestaurar.Name = "picBoxRestaurar";
            this.picBoxRestaurar.Size = new System.Drawing.Size(15, 15);
            this.picBoxRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxRestaurar.TabIndex = 8;
            this.picBoxRestaurar.TabStop = false;
            this.picBoxRestaurar.Click += new System.EventHandler(this.picBoxRestaurar_Click);
            // 
            // picBoxMinimizar
            // 
            this.picBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimizar.Image")));
            this.picBoxMinimizar.Location = new System.Drawing.Point(190, 3);
            this.picBoxMinimizar.Name = "picBoxMinimizar";
            this.picBoxMinimizar.Size = new System.Drawing.Size(15, 15);
            this.picBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMinimizar.TabIndex = 7;
            this.picBoxMinimizar.TabStop = false;
            this.picBoxMinimizar.Click += new System.EventHandler(this.picBoxMinimizar_Click);
            // 
            // picBoxLogoFondo
            // 
            this.picBoxLogoFondo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogoFondo.Image")));
            this.picBoxLogoFondo.Location = new System.Drawing.Point(39, 94);
            this.picBoxLogoFondo.Name = "picBoxLogoFondo";
            this.picBoxLogoFondo.Size = new System.Drawing.Size(175, 160);
            this.picBoxLogoFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogoFondo.TabIndex = 9;
            this.picBoxLogoFondo.TabStop = false;
            this.picBoxLogoFondo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxLogoFondo_MouseDown);
            // 
            // picBoxCerrar
            // 
            this.picBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCerrar.Image")));
            this.picBoxCerrar.Location = new System.Drawing.Point(232, 3);
            this.picBoxCerrar.Name = "picBoxCerrar";
            this.picBoxCerrar.Size = new System.Drawing.Size(15, 15);
            this.picBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxCerrar.TabIndex = 6;
            this.picBoxCerrar.TabStop = false;
            this.picBoxCerrar.Click += new System.EventHandler(this.picBoxCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "INICIAR SESIÓN";
            // 
            // btnIngerar
            // 
            this.btnIngerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(168)))), ((int)(((byte)(99)))));
            this.btnIngerar.FlatAppearance.BorderSize = 0;
            this.btnIngerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(92)))), ((int)(((byte)(82)))));
            this.btnIngerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(54)))));
            this.btnIngerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngerar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIngerar.Location = new System.Drawing.Point(59, 239);
            this.btnIngerar.Name = "btnIngerar";
            this.btnIngerar.Size = new System.Drawing.Size(402, 40);
            this.btnIngerar.TabIndex = 3;
            this.btnIngerar.Text = "INGRESAR";
            this.btnIngerar.UseVisualStyleBackColor = false;
            this.btnIngerar.Click += new System.EventHandler(this.btnIngerar_Click);
            // 
            // linkLblContraseña
            // 
            this.linkLblContraseña.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(54)))));
            this.linkLblContraseña.AutoSize = true;
            this.linkLblContraseña.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblContraseña.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLblContraseña.Location = new System.Drawing.Point(55, 195);
            this.linkLblContraseña.Name = "linkLblContraseña";
            this.linkLblContraseña.Size = new System.Drawing.Size(203, 20);
            this.linkLblContraseña.TabIndex = 0;
            this.linkLblContraseña.TabStop = true;
            this.linkLblContraseña.Text = "¿Olvidaste tu contraseña?";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsuario.Location = new System.Drawing.Point(100, 77);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(361, 25);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter_1);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtContraseña.Location = new System.Drawing.Point(100, 145);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(361, 25);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // linkLblRegistrarse
            // 
            this.linkLblRegistrarse.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(92)))), ((int)(((byte)(54)))));
            this.linkLblRegistrarse.AutoSize = true;
            this.linkLblRegistrarse.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblRegistrarse.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLblRegistrarse.Location = new System.Drawing.Point(120, 296);
            this.linkLblRegistrarse.Name = "linkLblRegistrarse";
            this.linkLblRegistrarse.Size = new System.Drawing.Size(255, 20);
            this.linkLblRegistrarse.TabIndex = 4;
            this.linkLblRegistrarse.TabStop = true;
            this.linkLblRegistrarse.Text = "¿No tiene una cuenta? Registrate";
            this.linkLblRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblRegistrarse_LinkClicked);
            // 
            // picBoxUsuario
            // 
            this.picBoxUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUsuario.Image")));
            this.picBoxUsuario.Location = new System.Drawing.Point(59, 77);
            this.picBoxUsuario.Name = "picBoxUsuario";
            this.picBoxUsuario.Size = new System.Drawing.Size(28, 25);
            this.picBoxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUsuario.TabIndex = 5;
            this.picBoxUsuario.TabStop = false;
            // 
            // picBoxContraseña
            // 
            this.picBoxContraseña.Image = ((System.Drawing.Image)(resources.GetObject("picBoxContraseña.Image")));
            this.picBoxContraseña.Location = new System.Drawing.Point(59, 145);
            this.picBoxContraseña.Name = "picBoxContraseña";
            this.picBoxContraseña.Size = new System.Drawing.Size(28, 25);
            this.picBoxContraseña.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxContraseña.TabIndex = 6;
            this.picBoxContraseña.TabStop = false;
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(225)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(780, 350);
            this.Controls.Add(this.picBoxContraseña);
            this.Controls.Add(this.picBoxUsuario);
            this.Controls.Add(this.linkLblRegistrarse);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.linkLblContraseña);
            this.Controls.Add(this.btnIngerar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form LogIn";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formLogIn_MouseDown);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogoFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxContraseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngerar;
        private System.Windows.Forms.LinkLabel linkLblContraseña;
        private System.Windows.Forms.PictureBox picBoxCerrar;
        private System.Windows.Forms.PictureBox picBoxRestaurar;
        private System.Windows.Forms.PictureBox picBoxMinimizar;
        private System.Windows.Forms.PictureBox picBoxLogoS;
        private System.Windows.Forms.PictureBox picBoxLogoFondo;
        private System.Windows.Forms.PictureBox picBoxMaximizar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.LinkLabel linkLblRegistrarse;
        private System.Windows.Forms.PictureBox picBoxUsuario;
        private System.Windows.Forms.PictureBox picBoxContraseña;
    }
}

