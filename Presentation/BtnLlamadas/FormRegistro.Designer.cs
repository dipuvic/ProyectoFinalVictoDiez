namespace Presentation.BtnLlamadas
{
    partial class FormRegistro
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
            this.LblTituloProveedor = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblUser = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.LblCliente = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.LblRef = new System.Windows.Forms.Label();
            this.TxtRef = new System.Windows.Forms.TextBox();
            this.DgvRegistro = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTituloProveedor
            // 
            this.LblTituloProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblTituloProveedor.BackColor = System.Drawing.Color.Transparent;
            this.LblTituloProveedor.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloProveedor.ForeColor = System.Drawing.Color.White;
            this.LblTituloProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblTituloProveedor.Location = new System.Drawing.Point(69, 30);
            this.LblTituloProveedor.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.LblTituloProveedor.Name = "LblTituloProveedor";
            this.LblTituloProveedor.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.LblTituloProveedor.Size = new System.Drawing.Size(1141, 23);
            this.LblTituloProveedor.TabIndex = 3;
            this.LblTituloProveedor.Text = "REGISTRO DE LLAMADAS";
            this.LblTituloProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.LblUser);
            this.flowLayoutPanel7.Controls.Add(this.TxtUsuario);
            this.flowLayoutPanel7.Controls.Add(this.LblCliente);
            this.flowLayoutPanel7.Controls.Add(this.TxtCliente);
            this.flowLayoutPanel7.Controls.Add(this.LblRef);
            this.flowLayoutPanel7.Controls.Add(this.TxtRef);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(73, 94);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(1107, 35);
            this.flowLayoutPanel7.TabIndex = 55;
            // 
            // LblUser
            // 
            this.LblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.White;
            this.LblUser.Location = new System.Drawing.Point(0, 5);
            this.LblUser.Margin = new System.Windows.Forms.Padding(0);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(53, 16);
            this.LblUser.TabIndex = 23;
            this.LblUser.Text = "Usuario:";
            this.LblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsuario.Location = new System.Drawing.Point(56, 5);
            this.TxtUsuario.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(129, 21);
            this.TxtUsuario.TabIndex = 24;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // LblCliente
            // 
            this.LblCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.ForeColor = System.Drawing.Color.White;
            this.LblCliente.Location = new System.Drawing.Point(225, 7);
            this.LblCliente.Margin = new System.Windows.Forms.Padding(40, 5, 0, 0);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(50, 16);
            this.LblCliente.TabIndex = 34;
            this.LblCliente.Text = "Cliente:";
            this.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtCliente
            // 
            this.TxtCliente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(278, 5);
            this.TxtCliente.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(129, 21);
            this.TxtCliente.TabIndex = 35;
            this.TxtCliente.TextChanged += new System.EventHandler(this.TxtCliente_TextChanged);
            // 
            // LblRef
            // 
            this.LblRef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblRef.AutoSize = true;
            this.LblRef.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRef.ForeColor = System.Drawing.Color.White;
            this.LblRef.Location = new System.Drawing.Point(447, 7);
            this.LblRef.Margin = new System.Windows.Forms.Padding(40, 5, 0, 0);
            this.LblRef.Name = "LblRef";
            this.LblRef.Size = new System.Drawing.Size(72, 16);
            this.LblRef.TabIndex = 36;
            this.LblRef.Text = "Referencia:";
            this.LblRef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtRef
            // 
            this.TxtRef.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TxtRef.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TxtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRef.Location = new System.Drawing.Point(522, 5);
            this.TxtRef.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.TxtRef.Name = "TxtRef";
            this.TxtRef.Size = new System.Drawing.Size(129, 21);
            this.TxtRef.TabIndex = 37;
            this.TxtRef.TextChanged += new System.EventHandler(this.TxtRef_TextChanged);
            // 
            // DgvRegistro
            // 
            this.DgvRegistro.AllowUserToAddRows = false;
            this.DgvRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvRegistro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvRegistro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvRegistro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.DgvRegistro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvRegistro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRegistro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvRegistro.ColumnHeadersHeight = 30;
            this.DgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvRegistro.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvRegistro.EnableHeadersVisualStyles = false;
            this.DgvRegistro.GridColor = System.Drawing.Color.SteelBlue;
            this.DgvRegistro.Location = new System.Drawing.Point(33, 146);
            this.DgvRegistro.Name = "DgvRegistro";
            this.DgvRegistro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRegistro.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvRegistro.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.DgvRegistro.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvRegistro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRegistro.Size = new System.Drawing.Size(1214, 276);
            this.DgvRegistro.TabIndex = 57;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1281, 450);
            this.Controls.Add(this.DgvRegistro);
            this.Controls.Add(this.flowLayoutPanel7);
            this.Controls.Add(this.LblTituloProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistro";
            this.Load += new System.EventHandler(this.FormRegistro_Load);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTituloProveedor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label LblRef;
        private System.Windows.Forms.TextBox TxtRef;
        private System.Windows.Forms.DataGridView DgvRegistro;
    }
}