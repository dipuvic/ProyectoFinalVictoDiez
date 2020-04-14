namespace Presentation
{
    partial class Producto
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtReferencia = new System.Windows.Forms.TextBox();
            this.LblNIF = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblCalle = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(44, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(648, 113);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.LblNombre);
            this.flowLayoutPanel2.Controls.Add(this.TxtReferencia);
            this.flowLayoutPanel2.Controls.Add(this.LblNIF);
            this.flowLayoutPanel2.Controls.Add(this.TxtDescripcion);
            this.flowLayoutPanel2.Controls.Add(this.LblCalle);
            this.flowLayoutPanel2.Controls.Add(this.TxtPrecio);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(335, 100);
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
            this.LblNombre.Text = "Referencia:";
            this.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtReferencia
            // 
            this.TxtReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtReferencia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReferencia.Location = new System.Drawing.Point(83, 2);
            this.TxtReferencia.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.Size = new System.Drawing.Size(230, 21);
            this.TxtReferencia.TabIndex = 1;
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
            this.LblNIF.Text = "Descripción:";
            this.LblNIF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtDescripcion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtDescripcion.Location = new System.Drawing.Point(83, 30);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(230, 20);
            this.TxtDescripcion.TabIndex = 3;
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
            this.LblCalle.Text = "Precio:";
            this.LblCalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPrecio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtPrecio.Location = new System.Drawing.Point(83, 55);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(230, 20);
            this.TxtPrecio.TabIndex = 6;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.panel1);
            this.flowLayoutPanel3.Controls.Add(this.BtnIngresar);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(338, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(296, 97);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 19);
            this.panel1.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIngresar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.Location = new System.Drawing.Point(97, 28);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(105, 32);
            this.BtnIngresar.TabIndex = 1;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(778, 615);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Producto";
            this.Text = "Producto";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtReferencia;
        private System.Windows.Forms.Label LblNIF;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblCalle;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnIngresar;
    }
}