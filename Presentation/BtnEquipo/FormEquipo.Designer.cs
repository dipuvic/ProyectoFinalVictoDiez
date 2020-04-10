namespace Presentation
{
    partial class FormEquipo
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
            this.FlpUsuario = new System.Windows.Forms.FlowLayoutPanel();
            this.iPbxUsuario = new FontAwesome.Sharp.IconPictureBox();
            this.LblNombreApellido = new System.Windows.Forms.Label();
            this.LblCargo = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FlpUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPbxUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // FlpUsuario
            // 
            this.FlpUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FlpUsuario.Controls.Add(this.iPbxUsuario);
            this.FlpUsuario.Controls.Add(this.LblNombreApellido);
            this.FlpUsuario.Controls.Add(this.panel1);
            this.FlpUsuario.Controls.Add(this.LblEmail);
            this.FlpUsuario.Controls.Add(this.panel2);
            this.FlpUsuario.Controls.Add(this.LblCargo);
            this.FlpUsuario.Controls.Add(this.panel3);
            this.FlpUsuario.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpUsuario.Location = new System.Drawing.Point(82, 67);
            this.FlpUsuario.Name = "FlpUsuario";
            this.FlpUsuario.Size = new System.Drawing.Size(606, 279);
            this.FlpUsuario.TabIndex = 0;
            // 
            // iPbxUsuario
            // 
            this.iPbxUsuario.BackColor = System.Drawing.Color.Navy;
            this.iPbxUsuario.Enabled = false;
            this.iPbxUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iPbxUsuario.IconColor = System.Drawing.Color.White;
            this.iPbxUsuario.IconSize = 142;
            this.iPbxUsuario.Location = new System.Drawing.Point(3, 10);
            this.iPbxUsuario.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.iPbxUsuario.Name = "iPbxUsuario";
            this.iPbxUsuario.Size = new System.Drawing.Size(603, 142);
            this.iPbxUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iPbxUsuario.TabIndex = 0;
            this.iPbxUsuario.TabStop = false;
            // 
            // LblNombreApellido
            // 
            this.LblNombreApellido.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreApellido.ForeColor = System.Drawing.Color.Transparent;
            this.LblNombreApellido.Location = new System.Drawing.Point(3, 155);
            this.LblNombreApellido.Name = "LblNombreApellido";
            this.LblNombreApellido.Padding = new System.Windows.Forms.Padding(190, 5, 0, 0);
            this.LblNombreApellido.Size = new System.Drawing.Size(588, 30);
            this.LblNombreApellido.TabIndex = 4;
            this.LblNombreApellido.Text = "Nombre y Apellido";
            this.LblNombreApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblCargo
            // 
            this.LblCargo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargo.ForeColor = System.Drawing.Color.Transparent;
            this.LblCargo.Location = new System.Drawing.Point(3, 223);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Padding = new System.Windows.Forms.Padding(190, 5, 0, 0);
            this.LblCargo.Size = new System.Drawing.Size(588, 30);
            this.LblCargo.TabIndex = 5;
            this.LblCargo.Text = "Cargo";
            this.LblCargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblEmail
            // 
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.Transparent;
            this.LblEmail.Location = new System.Drawing.Point(3, 189);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Padding = new System.Windows.Forms.Padding(190, 5, 0, 0);
            this.LblEmail.Size = new System.Drawing.Size(588, 30);
            this.LblEmail.TabIndex = 6;
            this.LblEmail.Text = "Email";
            this.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Location = new System.Drawing.Point(189, 185);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 1);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Location = new System.Drawing.Point(189, 219);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 1);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Location = new System.Drawing.Point(189, 253);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 1);
            this.panel3.TabIndex = 8;
            // 
            // FormEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(778, 615);
            this.Controls.Add(this.FlpUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEquipo";
            this.Text = "FormEquipo";
            this.Load += new System.EventHandler(this.FormEquipo_Load);
            this.FlpUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iPbxUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlpUsuario;
        private FontAwesome.Sharp.IconPictureBox iPbxUsuario;
        private System.Windows.Forms.Label LblNombreApellido;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}