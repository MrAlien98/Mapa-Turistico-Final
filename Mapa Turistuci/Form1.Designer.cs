namespace Mapa_Turistuci
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btMapa = new System.Windows.Forms.Button();
            this.btEstadistica = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btMapa
            // 
            this.btMapa.BackColor = System.Drawing.Color.LightGray;
            this.btMapa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMapa.Location = new System.Drawing.Point(234, 231);
            this.btMapa.Name = "btMapa";
            this.btMapa.Size = new System.Drawing.Size(196, 43);
            this.btMapa.TabIndex = 0;
            this.btMapa.Text = "VER MAPA";
            this.btMapa.UseVisualStyleBackColor = false;
            this.btMapa.Click += new System.EventHandler(this.BtMapa_Click);
            // 
            // btEstadistica
            // 
            this.btEstadistica.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btEstadistica.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEstadistica.Location = new System.Drawing.Point(234, 292);
            this.btEstadistica.Name = "btEstadistica";
            this.btEstadistica.Size = new System.Drawing.Size(196, 43);
            this.btEstadistica.TabIndex = 1;
            this.btEstadistica.Text = "ESTADÍSTICAS";
            this.btEstadistica.UseVisualStyleBackColor = false;
            this.btEstadistica.Click += new System.EventHandler(this.BtEstadistica_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(149, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 145);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(623, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btEstadistica);
            this.Controls.Add(this.btMapa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DISFRUTA COLOMBIA";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMapa;
        private System.Windows.Forms.Button btEstadistica;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

