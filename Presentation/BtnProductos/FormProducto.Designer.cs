namespace Presentation
{
    partial class FormProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblListadoProducto = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblEdicionProducto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtReferencia = new System.Windows.Forms.TextBox();
            this.LblNIF = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblCalle = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBReferencia = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.DgvProducto = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // LblListadoProducto
            // 
            this.LblListadoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblListadoProducto.AutoSize = true;
            this.LblListadoProducto.BackColor = System.Drawing.Color.Transparent;
            this.LblListadoProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListadoProducto.ForeColor = System.Drawing.Color.White;
            this.LblListadoProducto.Location = new System.Drawing.Point(523, 331);
            this.LblListadoProducto.Name = "LblListadoProducto";
            this.LblListadoProducto.Size = new System.Drawing.Size(171, 23);
            this.LblListadoProducto.TabIndex = 8;
            this.LblListadoProducto.Text = "Listado productos";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel5.Controls.Add(this.groupBox2);
            this.flowLayoutPanel5.Controls.Add(this.groupBox1);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(46, 32);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(830, 265);
            this.flowLayoutPanel5.TabIndex = 10;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.LblEdicionProducto);
            this.flowLayoutPanel7.Controls.Add(this.label3);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(827, 30);
            this.flowLayoutPanel7.TabIndex = 11;
            // 
            // LblEdicionProducto
            // 
            this.LblEdicionProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblEdicionProducto.BackColor = System.Drawing.Color.Transparent;
            this.LblEdicionProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdicionProducto.ForeColor = System.Drawing.Color.White;
            this.LblEdicionProducto.Location = new System.Drawing.Point(3, 6);
            this.LblEdicionProducto.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.LblEdicionProducto.Name = "LblEdicionProducto";
            this.LblEdicionProducto.Size = new System.Drawing.Size(403, 23);
            this.LblEdicionProducto.TabIndex = 9;
            this.LblEdicionProducto.Text = "Añadir nuevo producto";
            this.LblEdicionProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(412, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Buscar producto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(3, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 215);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.LblNombre);
            this.flowLayoutPanel2.Controls.Add(this.TxtReferencia);
            this.flowLayoutPanel2.Controls.Add(this.LblNIF);
            this.flowLayoutPanel2.Controls.Add(this.TxtDescripcion);
            this.flowLayoutPanel2.Controls.Add(this.LblCalle);
            this.flowLayoutPanel2.Controls.Add(this.TxtPrecio);
            this.flowLayoutPanel2.Controls.Add(this.LblCategoria);
            this.flowLayoutPanel2.Controls.Add(this.CmbCategoria);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(21, 30);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(385, 162);
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
            this.TxtReferencia.Enabled = false;
            this.TxtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReferencia.Location = new System.Drawing.Point(83, 5);
            this.TxtReferencia.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.Size = new System.Drawing.Size(290, 21);
            this.TxtReferencia.TabIndex = 1;
            // 
            // LblNIF
            // 
            this.LblNIF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblNIF.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNIF.ForeColor = System.Drawing.Color.White;
            this.LblNIF.Location = new System.Drawing.Point(0, 31);
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
            this.TxtDescripcion.Location = new System.Drawing.Point(83, 31);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(290, 20);
            this.TxtDescripcion.TabIndex = 3;
            // 
            // LblCalle
            // 
            this.LblCalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCalle.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCalle.ForeColor = System.Drawing.Color.White;
            this.LblCalle.Location = new System.Drawing.Point(0, 56);
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
            this.TxtPrecio.Location = new System.Drawing.Point(83, 56);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(290, 20);
            this.TxtPrecio.TabIndex = 6;
            // 
            // LblCategoria
            // 
            this.LblCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCategoria.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.ForeColor = System.Drawing.Color.White;
            this.LblCategoria.Location = new System.Drawing.Point(0, 81);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(80, 20);
            this.LblCategoria.TabIndex = 7;
            this.LblCategoria.Text = "Categoria:";
            this.LblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbCategoria
            // 
            this.CmbCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbCategoria.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbCategoria.ForeColor = System.Drawing.Color.Black;
            this.CmbCategoria.FormattingEnabled = true;
            this.CmbCategoria.Location = new System.Drawing.Point(83, 81);
            this.CmbCategoria.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(290, 21);
            this.CmbCategoria.TabIndex = 8;
            this.CmbCategoria.Text = "CATEGORIA";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.panel2);
            this.flowLayoutPanel4.Controls.Add(this.BtnIngresar);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 105);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(382, 57);
            this.flowLayoutPanel4.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 10);
            this.panel2.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIngresar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.Location = new System.Drawing.Point(140, 19);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(105, 32);
            this.BtnIngresar.TabIndex = 4;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.flowLayoutPanel3);
            this.groupBox1.Location = new System.Drawing.Point(457, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 215);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.panel3);
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.TxtBReferencia);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(57, 30);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(279, 162);
            this.flowLayoutPanel3.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 39);
            this.panel3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Referencia:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBReferencia
            // 
            this.TxtBReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtBReferencia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtBReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBReferencia.Location = new System.Drawing.Point(83, 50);
            this.TxtBReferencia.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtBReferencia.Name = "TxtBReferencia";
            this.TxtBReferencia.Size = new System.Drawing.Size(138, 21);
            this.TxtBReferencia.TabIndex = 1;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.panel1);
            this.flowLayoutPanel6.Controls.Add(this.iBtnBuscar);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 74);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(270, 62);
            this.flowLayoutPanel6.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 15);
            this.panel1.TabIndex = 3;
            // 
            // iBtnBuscar
            // 
            this.iBtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iBtnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.iBtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iBtnBuscar.ForeColor = System.Drawing.Color.White;
            this.iBtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iBtnBuscar.IconColor = System.Drawing.Color.White;
            this.iBtnBuscar.IconSize = 16;
            this.iBtnBuscar.Location = new System.Drawing.Point(84, 24);
            this.iBtnBuscar.Name = "iBtnBuscar";
            this.iBtnBuscar.Rotation = 0D;
            this.iBtnBuscar.Size = new System.Drawing.Size(105, 32);
            this.iBtnBuscar.TabIndex = 4;
            this.iBtnBuscar.Text = "Buscar";
            this.iBtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iBtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnBuscar.UseVisualStyleBackColor = false;
            this.iBtnBuscar.Click += new System.EventHandler(this.iBtnBuscar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(92, 487);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(199, 32);
            this.BtnEliminar.TabIndex = 19;
            this.BtnEliminar.Text = "ELIMINAR producto seleccionado";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click_1);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(92, 426);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(199, 32);
            this.BtnEditar.TabIndex = 18;
            this.BtnEditar.Text = "EDITAR producto seleccionado";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click_1);
            // 
            // DgvProducto
            // 
            this.DgvProducto.AllowUserToAddRows = false;
            this.DgvProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.DgvProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProducto.ColumnHeadersHeight = 30;
            this.DgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProducto.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvProducto.EnableHeadersVisualStyles = false;
            this.DgvProducto.GridColor = System.Drawing.Color.SteelBlue;
            this.DgvProducto.Location = new System.Drawing.Point(347, 369);
            this.DgvProducto.Name = "DgvProducto";
            this.DgvProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvProducto.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.DgvProducto.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProducto.Size = new System.Drawing.Size(504, 246);
            this.DgvProducto.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(773, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "rescar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(937, 659);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DgvProducto);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.LblListadoProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblListadoProducto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.DataGridView DgvProducto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label LblEdicionProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtReferencia;
        private System.Windows.Forms.Label LblNIF;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label LblCalle;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBReferencia;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iBtnBuscar;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button button1;
    }
}