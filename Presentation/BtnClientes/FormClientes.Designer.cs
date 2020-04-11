namespace Presentation.BtnClientes
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.LblTituloMostrar = new System.Windows.Forms.Label();
            this.LblInsertarClientes = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtNIF = new System.Windows.Forms.TextBox();
            this.LblNIF = new System.Windows.Forms.Label();
            this.LblCalle = new System.Windows.Forms.Label();
            this.TxtCalle = new System.Windows.Forms.TextBox();
            this.LblMunicipio = new System.Windows.Forms.Label();
            this.TxtMunicipio = new System.Windows.Forms.TextBox();
            this.LblProvincia = new System.Windows.Forms.Label();
            this.TxtProvincia = new System.Windows.Forms.TextBox();
            this.LblCodPostal = new System.Windows.Forms.Label();
            this.TxtCodPostal = new System.Windows.Forms.TextBox();
            this.LblTelf = new System.Windows.Forms.Label();
            this.TxtTelf = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvClientes
            // 
            this.DgvClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvClientes.BackgroundColor = System.Drawing.Color.Navy;
            this.DgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(12, 310);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.Size = new System.Drawing.Size(754, 280);
            this.DgvClientes.TabIndex = 0;
            // 
            // LblTituloMostrar
            // 
            this.LblTituloMostrar.AutoSize = true;
            this.LblTituloMostrar.BackColor = System.Drawing.Color.Transparent;
            this.LblTituloMostrar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloMostrar.ForeColor = System.Drawing.Color.White;
            this.LblTituloMostrar.Location = new System.Drawing.Point(248, 284);
            this.LblTituloMostrar.Name = "LblTituloMostrar";
            this.LblTituloMostrar.Size = new System.Drawing.Size(265, 23);
            this.LblTituloMostrar.TabIndex = 1;
            this.LblTituloMostrar.Text = "Mostrar Datos de los clientes";
            // 
            // LblInsertarClientes
            // 
            this.LblInsertarClientes.AutoSize = true;
            this.LblInsertarClientes.BackColor = System.Drawing.Color.Transparent;
            this.LblInsertarClientes.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInsertarClientes.ForeColor = System.Drawing.Color.White;
            this.LblInsertarClientes.Location = new System.Drawing.Point(272, 9);
            this.LblInsertarClientes.Name = "LblInsertarClientes";
            this.LblInsertarClientes.Size = new System.Drawing.Size(208, 23);
            this.LblInsertarClientes.TabIndex = 2;
            this.LblInsertarClientes.Text = "Ingresar nuevo cliente";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(37, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(690, 217);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.LblNombre);
            this.flowLayoutPanel2.Controls.Add(this.TxtNombre);
            this.flowLayoutPanel2.Controls.Add(this.LblNIF);
            this.flowLayoutPanel2.Controls.Add(this.TxtNIF);
            this.flowLayoutPanel2.Controls.Add(this.LblCalle);
            this.flowLayoutPanel2.Controls.Add(this.TxtCalle);
            this.flowLayoutPanel2.Controls.Add(this.LblMunicipio);
            this.flowLayoutPanel2.Controls.Add(this.TxtMunicipio);
            this.flowLayoutPanel2.Controls.Add(this.LblProvincia);
            this.flowLayoutPanel2.Controls.Add(this.TxtProvincia);
            this.flowLayoutPanel2.Controls.Add(this.LblCodPostal);
            this.flowLayoutPanel2.Controls.Add(this.TxtCodPostal);
            this.flowLayoutPanel2.Controls.Add(this.LblTelf);
            this.flowLayoutPanel2.Controls.Add(this.TxtTelf);
            this.flowLayoutPanel2.Controls.Add(this.LblEmail);
            this.flowLayoutPanel2.Controls.Add(this.TxtEmail);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(335, 217);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(0, 5);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(80, 20);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre:";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtNombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(83, 5);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(230, 21);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtNIF
            // 
            this.TxtNIF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtNIF.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtNIF.Location = new System.Drawing.Point(83, 30);
            this.TxtNIF.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtNIF.Name = "TxtNIF";
            this.TxtNIF.Size = new System.Drawing.Size(230, 20);
            this.TxtNIF.TabIndex = 3;
            // 
            // LblNIF
            // 
            this.LblNIF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNIF.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNIF.ForeColor = System.Drawing.Color.White;
            this.LblNIF.Location = new System.Drawing.Point(0, 30);
            this.LblNIF.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblNIF.Name = "LblNIF";
            this.LblNIF.Size = new System.Drawing.Size(80, 20);
            this.LblNIF.TabIndex = 4;
            this.LblNIF.Text = "NIF:";
            this.LblNIF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCalle
            // 
            this.LblCalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCalle.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCalle.ForeColor = System.Drawing.Color.White;
            this.LblCalle.Location = new System.Drawing.Point(0, 55);
            this.LblCalle.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblCalle.Name = "LblCalle";
            this.LblCalle.Size = new System.Drawing.Size(80, 20);
            this.LblCalle.TabIndex = 5;
            this.LblCalle.Text = "Calle:";
            this.LblCalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCalle
            // 
            this.TxtCalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCalle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtCalle.Location = new System.Drawing.Point(83, 55);
            this.TxtCalle.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtCalle.Name = "TxtCalle";
            this.TxtCalle.Size = new System.Drawing.Size(230, 20);
            this.TxtCalle.TabIndex = 6;
            // 
            // LblMunicipio
            // 
            this.LblMunicipio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblMunicipio.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMunicipio.ForeColor = System.Drawing.Color.White;
            this.LblMunicipio.Location = new System.Drawing.Point(0, 80);
            this.LblMunicipio.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblMunicipio.Name = "LblMunicipio";
            this.LblMunicipio.Size = new System.Drawing.Size(80, 20);
            this.LblMunicipio.TabIndex = 8;
            this.LblMunicipio.Text = "Municipio:";
            this.LblMunicipio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtMunicipio
            // 
            this.TxtMunicipio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtMunicipio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtMunicipio.Location = new System.Drawing.Point(83, 80);
            this.TxtMunicipio.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtMunicipio.Name = "TxtMunicipio";
            this.TxtMunicipio.Size = new System.Drawing.Size(230, 20);
            this.TxtMunicipio.TabIndex = 7;
            // 
            // LblProvincia
            // 
            this.LblProvincia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblProvincia.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProvincia.ForeColor = System.Drawing.Color.White;
            this.LblProvincia.Location = new System.Drawing.Point(0, 105);
            this.LblProvincia.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblProvincia.Name = "LblProvincia";
            this.LblProvincia.Size = new System.Drawing.Size(80, 20);
            this.LblProvincia.TabIndex = 9;
            this.LblProvincia.Text = "Provincia:";
            this.LblProvincia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtProvincia
            // 
            this.TxtProvincia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtProvincia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtProvincia.Location = new System.Drawing.Point(83, 105);
            this.TxtProvincia.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtProvincia.Name = "TxtProvincia";
            this.TxtProvincia.Size = new System.Drawing.Size(230, 20);
            this.TxtProvincia.TabIndex = 10;
            // 
            // LblCodPostal
            // 
            this.LblCodPostal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCodPostal.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodPostal.ForeColor = System.Drawing.Color.White;
            this.LblCodPostal.Location = new System.Drawing.Point(0, 130);
            this.LblCodPostal.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblCodPostal.Name = "LblCodPostal";
            this.LblCodPostal.Size = new System.Drawing.Size(80, 20);
            this.LblCodPostal.TabIndex = 12;
            this.LblCodPostal.Text = "Cod. Postal:";
            this.LblCodPostal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCodPostal
            // 
            this.TxtCodPostal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCodPostal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtCodPostal.Location = new System.Drawing.Point(83, 130);
            this.TxtCodPostal.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtCodPostal.Name = "TxtCodPostal";
            this.TxtCodPostal.Size = new System.Drawing.Size(230, 20);
            this.TxtCodPostal.TabIndex = 11;
            // 
            // LblTelf
            // 
            this.LblTelf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTelf.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelf.ForeColor = System.Drawing.Color.White;
            this.LblTelf.Location = new System.Drawing.Point(0, 155);
            this.LblTelf.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblTelf.Name = "LblTelf";
            this.LblTelf.Size = new System.Drawing.Size(80, 20);
            this.LblTelf.TabIndex = 13;
            this.LblTelf.Text = "Teléfono:";
            this.LblTelf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtTelf
            // 
            this.TxtTelf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtTelf.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtTelf.Location = new System.Drawing.Point(83, 155);
            this.TxtTelf.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtTelf.Name = "TxtTelf";
            this.TxtTelf.Size = new System.Drawing.Size(230, 20);
            this.TxtTelf.TabIndex = 14;
            // 
            // LblEmail
            // 
            this.LblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.ForeColor = System.Drawing.Color.White;
            this.LblEmail.Location = new System.Drawing.Point(0, 180);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(80, 20);
            this.LblEmail.TabIndex = 16;
            this.LblEmail.Text = "Email:";
            this.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtEmail.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtEmail.Location = new System.Drawing.Point(83, 180);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(230, 20);
            this.TxtEmail.TabIndex = 15;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(778, 615);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.LblInsertarClientes);
            this.Controls.Add(this.LblTituloMostrar);
            this.Controls.Add(this.DgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Label LblTituloMostrar;
        private System.Windows.Forms.Label LblInsertarClientes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNIF;
        private System.Windows.Forms.TextBox TxtNIF;
        private System.Windows.Forms.Label LblCalle;
        private System.Windows.Forms.TextBox TxtCalle;
        private System.Windows.Forms.Label LblMunicipio;
        private System.Windows.Forms.TextBox TxtMunicipio;
        private System.Windows.Forms.Label LblProvincia;
        private System.Windows.Forms.TextBox TxtProvincia;
        private System.Windows.Forms.Label LblCodPostal;
        private System.Windows.Forms.TextBox TxtCodPostal;
        private System.Windows.Forms.Label LblTelf;
        private System.Windows.Forms.TextBox TxtTelf;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtEmail;
    }
}