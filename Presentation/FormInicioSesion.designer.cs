namespace Presentation
{
    partial class FormInicioSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioSesion));
            this.iPbxUser = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.iBtnPassword = new FontAwesome.Sharp.IconPictureBox();
            this.BtnAcceso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblAlert = new System.Windows.Forms.Label();
            this.iPbxAlert = new FontAwesome.Sharp.IconPictureBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iPbxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBtnPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPbxAlert)).BeginInit();
            this.SuspendLayout();
            // 
            // iPbxUser
            // 
            this.iPbxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iPbxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.iPbxUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iPbxUser.IconColor = System.Drawing.Color.White;
            this.iPbxUser.Location = new System.Drawing.Point(33, 199);
            this.iPbxUser.Name = "iPbxUser";
            this.iPbxUser.Size = new System.Drawing.Size(32, 32);
            this.iPbxUser.TabIndex = 0;
            this.iPbxUser.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(33, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 2);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Location = new System.Drawing.Point(33, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 2);
            this.panel2.TabIndex = 5;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.TxtPassword.Location = new System.Drawing.Point(82, 262);
            this.TxtPassword.Multiline = true;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(279, 20);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.TabStop = false;
            this.TxtPassword.Text = "Contraseña";
            this.TxtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtPassword_MouseClick);
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // iBtnPassword
            // 
            this.iBtnPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iBtnPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.iBtnPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iBtnPassword.IconColor = System.Drawing.Color.White;
            this.iBtnPassword.Location = new System.Drawing.Point(33, 256);
            this.iBtnPassword.Name = "iBtnPassword";
            this.iBtnPassword.Size = new System.Drawing.Size(32, 32);
            this.iBtnPassword.TabIndex = 3;
            this.iBtnPassword.TabStop = false;
            // 
            // BtnAcceso
            // 
            this.BtnAcceso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAcceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BtnAcceso.FlatAppearance.BorderSize = 0;
            this.BtnAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcceso.ForeColor = System.Drawing.Color.White;
            this.BtnAcceso.Location = new System.Drawing.Point(138, 326);
            this.BtnAcceso.Name = "BtnAcceso";
            this.BtnAcceso.Size = new System.Drawing.Size(130, 32);
            this.BtnAcceso.TabIndex = 3;
            this.BtnAcceso.Text = "A C C E D E R";
            this.BtnAcceso.UseVisualStyleBackColor = false;
            this.BtnAcceso.Click += new System.EventHandler(this.BtnAcceso_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(91, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "A c c e s o   e m p l e a d o s";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 22;
            this.iconButton1.Location = new System.Drawing.Point(380, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(22, 22);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iBtnCerrar_Click);
            // 
            // PbxLogo
            // 
            this.PbxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbxLogo.Image")));
            this.PbxLogo.Location = new System.Drawing.Point(65, 34);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(275, 58);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 8;
            this.PbxLogo.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(138, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 2);
            this.panel3.TabIndex = 6;
            // 
            // LblAlert
            // 
            this.LblAlert.AutoSize = true;
            this.LblAlert.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAlert.ForeColor = System.Drawing.Color.Red;
            this.LblAlert.Location = new System.Drawing.Point(123, 167);
            this.LblAlert.Name = "LblAlert";
            this.LblAlert.Size = new System.Drawing.Size(177, 16);
            this.LblAlert.TabIndex = 9;
            this.LblAlert.Text = "Usuario o Contraseña incorrecto";
            // 
            // iPbxAlert
            // 
            this.iPbxAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.iPbxAlert.ForeColor = System.Drawing.Color.Red;
            this.iPbxAlert.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.iPbxAlert.IconColor = System.Drawing.Color.Red;
            this.iPbxAlert.IconSize = 22;
            this.iPbxAlert.Location = new System.Drawing.Point(95, 164);
            this.iPbxAlert.Name = "iPbxAlert";
            this.iPbxAlert.Size = new System.Drawing.Size(22, 22);
            this.iPbxAlert.TabIndex = 10;
            this.iPbxAlert.TabStop = false;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.TxtUsuario.Location = new System.Drawing.Point(82, 205);
            this.TxtUsuario.Multiline = true;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(279, 20);
            this.TxtUsuario.TabIndex = 0;
            this.TxtUsuario.TabStop = false;
            this.TxtUsuario.Text = "Usuario";
            this.TxtUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtUsuario_MouseClick);
            this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(404, 404);
            this.Controls.Add(this.iPbxAlert);
            this.Controls.Add(this.LblAlert);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PbxLogo);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAcceso);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.iBtnPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.iPbxUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicioSesion";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio Sesión";
            this.Load += new System.EventHandler(this.FormInicioSesion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormInicioSesion_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.iPbxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iBtnPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPbxAlert)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iPbxUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iBtnPassword;
        private System.Windows.Forms.Button BtnAcceso;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblAlert;
        private FontAwesome.Sharp.IconPictureBox iPbxAlert;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsuario;
    }
}