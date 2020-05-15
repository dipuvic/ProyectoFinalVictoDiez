namespace Presentation
{
    partial class FormPanelPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanelPrincipal));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblFrase = new System.Windows.Forms.Label();
            this.TmrDate = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.PbxLogo);
            this.flowLayoutPanel1.Controls.Add(this.LblFecha);
            this.flowLayoutPanel1.Controls.Add(this.LblFrase);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(91, 90);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(569, 286);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // PbxLogo
            // 
            this.PbxLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PbxLogo.Image = global::Presentation.Properties.Resources.ELECTRO_DH_blanco;
            this.PbxLogo.Location = new System.Drawing.Point(3, 3);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.PbxLogo.Size = new System.Drawing.Size(566, 78);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxLogo.TabIndex = 3;
            this.PbxLogo.TabStop = false;
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.Transparent;
            this.LblFecha.Location = new System.Drawing.Point(3, 84);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.LblFecha.Size = new System.Drawing.Size(566, 39);
            this.LblFecha.TabIndex = 3;
            this.LblFecha.Text = "Fecha actual";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFrase
            // 
            this.LblFrase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblFrase.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFrase.ForeColor = System.Drawing.Color.Transparent;
            this.LblFrase.Location = new System.Drawing.Point(3, 148);
            this.LblFrase.Margin = new System.Windows.Forms.Padding(3, 25, 3, 0);
            this.LblFrase.Name = "LblFrase";
            this.LblFrase.Padding = new System.Windows.Forms.Padding(0, 15, 0, 5);
            this.LblFrase.Size = new System.Drawing.Size(566, 127);
            this.LblFrase.TabIndex = 4;
            this.LblFrase.Text = "Frase célebre";
            this.LblFrase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TmrDate
            // 
            this.TmrDate.Tick += new System.EventHandler(this.TmrDate_Tick);
            // 
            // FormPanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(12)))), ((int)(((byte)(28)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 576);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPanelPrincipal";
            this.Text = "FormPanelPrincipal";
            this.Load += new System.EventHandler(this.FormPanelPrincipal_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Timer TmrDate;
        private System.Windows.Forms.Label LblFrase;
    }
}