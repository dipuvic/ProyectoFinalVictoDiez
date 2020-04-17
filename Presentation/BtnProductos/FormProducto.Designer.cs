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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtReferencia = new System.Windows.Forms.TextBox();
            this.LblNIF = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblCalle = new System.Windows.Forms.Label();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.DgvProducto = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblListadoProducto = new System.Windows.Forms.Label();
            this.LblEdicionProducto = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblRefBuscar = new System.Windows.Forms.Label();
            this.TxtRefBuscar = new System.Windows.Forms.TextBox();
            this.LblDescBuscar = new System.Windows.Forms.Label();
            this.TxtDescripBuscar = new System.Windows.Forms.TextBox();
            this.LblCatBuscar = new System.Windows.Forms.Label();
            this.TxtCatBuscar = new System.Windows.Forms.TextBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(28, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(548, 106);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.LblNombre);
            this.flowLayoutPanel2.Controls.Add(this.TxtReferencia);
            this.flowLayoutPanel2.Controls.Add(this.LblNIF);
            this.flowLayoutPanel2.Controls.Add(this.TxtDescripcion);
            this.flowLayoutPanel2.Controls.Add(this.LblCategoria);
            this.flowLayoutPanel2.Controls.Add(this.TxtPrecio);
            this.flowLayoutPanel2.Controls.Add(this.LblCalle);
            this.flowLayoutPanel2.Controls.Add(this.TxtCategoria);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(335, 106);
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
            // LblCategoria
            // 
            this.LblCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCategoria.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.ForeColor = System.Drawing.Color.White;
            this.LblCategoria.Location = new System.Drawing.Point(0, 55);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(80, 20);
            this.LblCategoria.TabIndex = 7;
            this.LblCategoria.Text = "Categoria:";
            this.LblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // LblCalle
            // 
            this.LblCalle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCalle.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCalle.ForeColor = System.Drawing.Color.White;
            this.LblCalle.Location = new System.Drawing.Point(0, 80);
            this.LblCalle.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblCalle.Name = "LblCalle";
            this.LblCalle.Size = new System.Drawing.Size(80, 20);
            this.LblCalle.TabIndex = 5;
            this.LblCalle.Text = "Precio:";
            this.LblCalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCategoria.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtCategoria.Location = new System.Drawing.Point(83, 80);
            this.TxtCategoria.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(230, 20);
            this.TxtCategoria.TabIndex = 8;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.panel1);
            this.flowLayoutPanel3.Controls.Add(this.BtnIngresar);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(338, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(205, 103);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 19);
            this.panel1.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIngresar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.Location = new System.Drawing.Point(50, 28);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(105, 32);
            this.BtnIngresar.TabIndex = 1;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // DgvProducto
            // 
            this.DgvProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgvProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProducto.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvProducto.Location = new System.Drawing.Point(150, 294);
            this.DgvProducto.Name = "DgvProducto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvProducto.Size = new System.Drawing.Size(383, 300);
            this.DgvProducto.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 164);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // LblListadoProducto
            // 
            this.LblListadoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblListadoProducto.AutoSize = true;
            this.LblListadoProducto.BackColor = System.Drawing.Color.Transparent;
            this.LblListadoProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListadoProducto.ForeColor = System.Drawing.Color.White;
            this.LblListadoProducto.Location = new System.Drawing.Point(264, 268);
            this.LblListadoProducto.Name = "LblListadoProducto";
            this.LblListadoProducto.Size = new System.Drawing.Size(171, 23);
            this.LblListadoProducto.TabIndex = 8;
            this.LblListadoProducto.Text = "Listado productos";
            // 
            // LblEdicionProducto
            // 
            this.LblEdicionProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblEdicionProducto.BackColor = System.Drawing.Color.Transparent;
            this.LblEdicionProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdicionProducto.ForeColor = System.Drawing.Color.White;
            this.LblEdicionProducto.Location = new System.Drawing.Point(5, 0);
            this.LblEdicionProducto.Name = "LblEdicionProducto";
            this.LblEdicionProducto.Size = new System.Drawing.Size(593, 23);
            this.LblEdicionProducto.TabIndex = 9;
            this.LblEdicionProducto.Text = "Añadir nuevo producto";
            this.LblEdicionProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel5.Controls.Add(this.LblEdicionProducto);
            this.flowLayoutPanel5.Controls.Add(this.groupBox1);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(150, 48);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(607, 203);
            this.flowLayoutPanel5.TabIndex = 10;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(71, 125);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(105, 32);
            this.BtnBuscar.TabIndex = 14;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel6.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel6.Controls.Add(this.BtnBuscar);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(555, 401);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(257, 173);
            this.flowLayoutPanel6.TabIndex = 15;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.label1);
            this.flowLayoutPanel7.Controls.Add(this.LblRefBuscar);
            this.flowLayoutPanel7.Controls.Add(this.TxtRefBuscar);
            this.flowLayoutPanel7.Controls.Add(this.LblDescBuscar);
            this.flowLayoutPanel7.Controls.Add(this.TxtDescripBuscar);
            this.flowLayoutPanel7.Controls.Add(this.LblCatBuscar);
            this.flowLayoutPanel7.Controls.Add(this.TxtCatBuscar);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 5);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(242, 107);
            this.flowLayoutPanel7.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRefBuscar
            // 
            this.LblRefBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblRefBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRefBuscar.ForeColor = System.Drawing.Color.White;
            this.LblRefBuscar.Location = new System.Drawing.Point(0, 33);
            this.LblRefBuscar.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblRefBuscar.Name = "LblRefBuscar";
            this.LblRefBuscar.Size = new System.Drawing.Size(80, 20);
            this.LblRefBuscar.TabIndex = 8;
            this.LblRefBuscar.Text = "Referencia:";
            this.LblRefBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtRefBuscar
            // 
            this.TxtRefBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtRefBuscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtRefBuscar.Location = new System.Drawing.Point(83, 33);
            this.TxtRefBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtRefBuscar.Name = "TxtRefBuscar";
            this.TxtRefBuscar.Size = new System.Drawing.Size(154, 20);
            this.TxtRefBuscar.TabIndex = 12;
            // 
            // LblDescBuscar
            // 
            this.LblDescBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDescBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescBuscar.ForeColor = System.Drawing.Color.White;
            this.LblDescBuscar.Location = new System.Drawing.Point(0, 58);
            this.LblDescBuscar.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblDescBuscar.Name = "LblDescBuscar";
            this.LblDescBuscar.Size = new System.Drawing.Size(80, 20);
            this.LblDescBuscar.TabIndex = 11;
            this.LblDescBuscar.Text = "Descripción:";
            this.LblDescBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtDescripBuscar
            // 
            this.TxtDescripBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtDescripBuscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtDescripBuscar.Location = new System.Drawing.Point(83, 58);
            this.TxtDescripBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtDescripBuscar.Name = "TxtDescripBuscar";
            this.TxtDescripBuscar.Size = new System.Drawing.Size(154, 20);
            this.TxtDescripBuscar.TabIndex = 10;
            // 
            // LblCatBuscar
            // 
            this.LblCatBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCatBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCatBuscar.ForeColor = System.Drawing.Color.White;
            this.LblCatBuscar.Location = new System.Drawing.Point(0, 83);
            this.LblCatBuscar.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblCatBuscar.Name = "LblCatBuscar";
            this.LblCatBuscar.Size = new System.Drawing.Size(80, 20);
            this.LblCatBuscar.TabIndex = 13;
            this.LblCatBuscar.Text = "Categoria:";
            this.LblCatBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCatBuscar
            // 
            this.TxtCatBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCatBuscar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtCatBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCatBuscar.Enabled = false;
            this.TxtCatBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCatBuscar.Location = new System.Drawing.Point(83, 80);
            this.TxtCatBuscar.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TxtCatBuscar.Name = "TxtCatBuscar";
            this.TxtCatBuscar.Size = new System.Drawing.Size(154, 21);
            this.TxtCatBuscar.TabIndex = 9;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(583, 345);
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
            this.BtnEditar.Location = new System.Drawing.Point(583, 306);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(199, 32);
            this.BtnEditar.TabIndex = 18;
            this.BtnEditar.Text = "EDITAR producto seleccionado";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click_1);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(937, 659);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.LblListadoProducto);
            this.Controls.Add(this.DgvProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.DataGridView DgvProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblListadoProducto;
        private System.Windows.Forms.Label LblEdicionProducto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblRefBuscar;
        private System.Windows.Forms.TextBox TxtRefBuscar;
        private System.Windows.Forms.Label LblDescBuscar;
        private System.Windows.Forms.TextBox TxtDescripBuscar;
        private System.Windows.Forms.Label LblCatBuscar;
        private System.Windows.Forms.TextBox TxtCatBuscar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
    }
}