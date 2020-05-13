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
            this.LblEdicionProducto = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblReferencia = new System.Windows.Forms.Label();
            this.TxtReferencia = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.CmbCategoria = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.DgvProducto = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBReferencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbBCategoria = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iBtnBuscar = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblListadoProducto
            // 
            this.LblListadoProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblListadoProducto.AutoSize = true;
            this.LblListadoProducto.BackColor = System.Drawing.Color.Transparent;
            this.LblListadoProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblListadoProducto.ForeColor = System.Drawing.Color.White;
            this.LblListadoProducto.Location = new System.Drawing.Point(32, 202);
            this.LblListadoProducto.Name = "LblListadoProducto";
            this.LblListadoProducto.Size = new System.Drawing.Size(192, 23);
            this.LblListadoProducto.TabIndex = 8;
            this.LblListadoProducto.Text = "DATOS PRODUCTOS";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel5.Controls.Add(this.LblEdicionProducto);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(29, 25);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(873, 151);
            this.flowLayoutPanel5.TabIndex = 10;
            // 
            // LblEdicionProducto
            // 
            this.LblEdicionProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblEdicionProducto.BackColor = System.Drawing.Color.Transparent;
            this.LblEdicionProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEdicionProducto.ForeColor = System.Drawing.Color.White;
            this.LblEdicionProducto.Location = new System.Drawing.Point(3, 6);
            this.LblEdicionProducto.Margin = new System.Windows.Forms.Padding(3, 6, 3, 25);
            this.LblEdicionProducto.Name = "LblEdicionProducto";
            this.LblEdicionProducto.Size = new System.Drawing.Size(775, 23);
            this.LblEdicionProducto.TabIndex = 26;
            this.LblEdicionProducto.Text = "ALTA PRODUCTO";
            this.LblEdicionProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.LblReferencia);
            this.flowLayoutPanel2.Controls.Add(this.TxtReferencia);
            this.flowLayoutPanel2.Controls.Add(this.LblDescripcion);
            this.flowLayoutPanel2.Controls.Add(this.TxtDescripcion);
            this.flowLayoutPanel2.Controls.Add(this.LblPrecio);
            this.flowLayoutPanel2.Controls.Add(this.TxtPrecio);
            this.flowLayoutPanel2.Controls.Add(this.LblCategoria);
            this.flowLayoutPanel2.Controls.Add(this.CmbCategoria);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 54);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(873, 29);
            this.flowLayoutPanel2.TabIndex = 24;
            // 
            // LblReferencia
            // 
            this.LblReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblReferencia.AutoSize = true;
            this.LblReferencia.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReferencia.ForeColor = System.Drawing.Color.White;
            this.LblReferencia.Location = new System.Drawing.Point(10, 7);
            this.LblReferencia.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.LblReferencia.Name = "LblReferencia";
            this.LblReferencia.Size = new System.Drawing.Size(72, 16);
            this.LblReferencia.TabIndex = 0;
            this.LblReferencia.Text = "Referencia:";
            this.LblReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblReferencia.Visible = false;
            // 
            // TxtReferencia
            // 
            this.TxtReferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtReferencia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtReferencia.Enabled = false;
            this.TxtReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReferencia.Location = new System.Drawing.Point(85, 5);
            this.TxtReferencia.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.Size = new System.Drawing.Size(72, 21);
            this.TxtReferencia.TabIndex = 1;
            this.TxtReferencia.Visible = false;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescripcion.ForeColor = System.Drawing.Color.White;
            this.LblDescripcion.Location = new System.Drawing.Point(177, 7);
            this.LblDescripcion.Margin = new System.Windows.Forms.Padding(20, 5, 0, 0);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(76, 16);
            this.LblDescripcion.TabIndex = 4;
            this.LblDescripcion.Text = "Descripción:";
            this.LblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtDescripcion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtDescripcion.Location = new System.Drawing.Point(256, 5);
            this.TxtDescripcion.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(232, 20);
            this.TxtDescripcion.TabIndex = 3;
            // 
            // LblPrecio
            // 
            this.LblPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.ForeColor = System.Drawing.Color.White;
            this.LblPrecio.Location = new System.Drawing.Point(508, 7);
            this.LblPrecio.Margin = new System.Windows.Forms.Padding(20, 5, 0, 0);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(46, 16);
            this.LblPrecio.TabIndex = 13;
            this.LblPrecio.Text = "Precio:";
            this.LblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtPrecio.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtPrecio.Location = new System.Drawing.Point(557, 5);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(57, 20);
            this.TxtPrecio.TabIndex = 14;
            // 
            // LblCategoria
            // 
            this.LblCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCategoria.ForeColor = System.Drawing.Color.White;
            this.LblCategoria.Location = new System.Drawing.Point(634, 7);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(20, 5, 0, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(64, 16);
            this.LblCategoria.TabIndex = 15;
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
            this.CmbCategoria.Location = new System.Drawing.Point(701, 5);
            this.CmbCategoria.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.CmbCategoria.Name = "CmbCategoria";
            this.CmbCategoria.Size = new System.Drawing.Size(154, 21);
            this.CmbCategoria.TabIndex = 16;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.panel2);
            this.flowLayoutPanel4.Controls.Add(this.BtnIngresar);
            this.flowLayoutPanel4.Controls.Add(this.BtnCancelar);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 86);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(870, 65);
            this.flowLayoutPanel4.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 10);
            this.panel2.TabIndex = 3;
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnIngresar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIngresar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.Color.White;
            this.BtnIngresar.Location = new System.Drawing.Point(300, 19);
            this.BtnIngresar.Margin = new System.Windows.Forms.Padding(300, 3, 3, 3);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(105, 32);
            this.BtnIngresar.TabIndex = 4;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = false;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancelar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(443, 19);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(35, 3, 3, 3);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(105, 32);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Visible = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // LblBuscar
            // 
            this.LblBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.LblBuscar.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.ForeColor = System.Drawing.Color.White;
            this.LblBuscar.Location = new System.Drawing.Point(3, 6);
            this.LblBuscar.Margin = new System.Windows.Forms.Padding(3, 6, 3, 10);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(242, 23);
            this.LblBuscar.TabIndex = 10;
            this.LblBuscar.Text = "BUSCADOR";
            this.LblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.DgvProducto.Location = new System.Drawing.Point(317, 231);
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
            this.DgvProducto.Size = new System.Drawing.Size(513, 416);
            this.DgvProducto.TabIndex = 20;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(202, 260);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(73, 25);
            this.BtnEliminar.TabIndex = 23;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnEditar.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(104, 260);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(73, 25);
            this.BtnEditar.TabIndex = 22;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel3.Controls.Add(this.LblBuscar);
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.TxtBReferencia);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.TxtBDescripcion);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.CmbBCategoria);
            this.flowLayoutPanel3.Controls.Add(this.panel1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(29, 333);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(245, 184);
            this.flowLayoutPanel3.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 44);
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
            this.TxtBReferencia.Location = new System.Drawing.Point(83, 44);
            this.TxtBReferencia.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtBReferencia.Name = "TxtBReferencia";
            this.TxtBReferencia.Size = new System.Drawing.Size(138, 21);
            this.TxtBReferencia.TabIndex = 1;
            this.TxtBReferencia.TextChanged += new System.EventHandler(this.TxtBReferencia_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Descripción:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtBDescripcion
            // 
            this.TxtBDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtBDescripcion.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtBDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBDescripcion.Location = new System.Drawing.Point(83, 70);
            this.TxtBDescripcion.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtBDescripcion.Name = "TxtBDescripcion";
            this.TxtBDescripcion.Size = new System.Drawing.Size(138, 21);
            this.TxtBDescripcion.TabIndex = 16;
            this.TxtBDescripcion.TextChanged += new System.EventHandler(this.TxtBDescripcion_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Categoria:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CmbBCategoria
            // 
            this.CmbBCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmbBCategoria.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CmbBCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbBCategoria.ForeColor = System.Drawing.Color.Black;
            this.CmbBCategoria.FormattingEnabled = true;
            this.CmbBCategoria.Location = new System.Drawing.Point(83, 96);
            this.CmbBCategoria.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.CmbBCategoria.Name = "CmbBCategoria";
            this.CmbBCategoria.Size = new System.Drawing.Size(138, 21);
            this.CmbBCategoria.TabIndex = 14;
            this.CmbBCategoria.TextChanged += new System.EventHandler(this.CmbBCategoria_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iBtnBuscar);
            this.panel1.Location = new System.Drawing.Point(3, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 52);
            this.panel1.TabIndex = 27;
            // 
            // iBtnBuscar
            // 
            this.iBtnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iBtnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.iBtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnBuscar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iBtnBuscar.ForeColor = System.Drawing.Color.White;
            this.iBtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iBtnBuscar.IconColor = System.Drawing.Color.White;
            this.iBtnBuscar.IconSize = 16;
            this.iBtnBuscar.Location = new System.Drawing.Point(56, 15);
            this.iBtnBuscar.Name = "iBtnBuscar";
            this.iBtnBuscar.Rotation = 0D;
            this.iBtnBuscar.Size = new System.Drawing.Size(134, 26);
            this.iBtnBuscar.TabIndex = 17;
            this.iBtnBuscar.Text = "Todos los productos";
            this.iBtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnBuscar.UseVisualStyleBackColor = false;
            this.iBtnBuscar.Click += new System.EventHandler(this.iBtnBuscar_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Location = new System.Drawing.Point(28, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(870, 2);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Location = new System.Drawing.Point(28, 313);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 2);
            this.panel4.TabIndex = 27;
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(937, 659);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.DgvProducto);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.LblListadoProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.FormProducto_Load);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblListadoProducto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.DataGridView DgvProducto;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Label LblEdicionProducto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label LblReferencia;
        private System.Windows.Forms.TextBox TxtReferencia;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBReferencia;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbBCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtBDescripcion;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iBtnBuscar;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.ComboBox CmbCategoria;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnCancelar;
    }
}