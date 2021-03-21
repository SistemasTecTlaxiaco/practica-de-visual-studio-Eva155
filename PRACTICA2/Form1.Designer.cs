
namespace PRACTICA2
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
            this.Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iNICIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOCALESENRENTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.precioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direcciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosIncluidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mENSAJESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aYUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.enviarComentariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sOPORTETÉCNICOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felicitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quejasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sugerenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pERFILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gUSTOSYPREFERENCIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.Contenedor.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Menu.Controls.Add(this.pictureBox2);
            this.Menu.Controls.Add(this.button1);
            this.Menu.Controls.Add(this.button2);
            this.Menu.Controls.Add(this.button3);
            this.Menu.Controls.Add(this.button4);
            this.Menu.Controls.Add(this.button7);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(259, 450);
            this.Menu.TabIndex = 1;
            this.Menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu_Paint);
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.Plum;
            this.Contenedor.Controls.Add(this.button6);
            this.Contenedor.Controls.Add(this.pictureBox1);
            this.Contenedor.Controls.Add(this.menuStrip1);
            this.Contenedor.Controls.Add(this.button5);
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(259, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(541, 450);
            this.Contenedor.TabIndex = 2;
            this.Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Contenedor_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNICIOToolStripMenuItem,
            this.lOCALESENRENTAToolStripMenuItem,
            this.mENSAJESToolStripMenuItem,
            this.aYUDAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(541, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            this.iNICIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERFILToolStripMenuItem,
            this.gUSTOSYPREFERENCIASToolStripMenuItem});
            this.iNICIOToolStripMenuItem.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            this.iNICIOToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.iNICIOToolStripMenuItem.Text = "INICIO";
            // 
            // lOCALESENRENTAToolStripMenuItem
            // 
            this.lOCALESENRENTAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.precioToolStripMenuItem,
            this.direcciónToolStripMenuItem,
            this.medidasToolStripMenuItem,
            this.serviciosIncluidosToolStripMenuItem});
            this.lOCALESENRENTAToolStripMenuItem.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOCALESENRENTAToolStripMenuItem.Name = "lOCALESENRENTAToolStripMenuItem";
            this.lOCALESENRENTAToolStripMenuItem.Size = new System.Drawing.Size(188, 23);
            this.lOCALESENRENTAToolStripMenuItem.Text = "LOCALES EN RENTA";
            // 
            // precioToolStripMenuItem
            // 
            this.precioToolStripMenuItem.Name = "precioToolStripMenuItem";
            this.precioToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.precioToolStripMenuItem.Text = "Precio";
            // 
            // direcciónToolStripMenuItem
            // 
            this.direcciónToolStripMenuItem.Name = "direcciónToolStripMenuItem";
            this.direcciónToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.direcciónToolStripMenuItem.Text = "Dirección";
            this.direcciónToolStripMenuItem.Click += new System.EventHandler(this.direcciónToolStripMenuItem_Click);
            // 
            // medidasToolStripMenuItem
            // 
            this.medidasToolStripMenuItem.Name = "medidasToolStripMenuItem";
            this.medidasToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.medidasToolStripMenuItem.Text = "Medidas";
            // 
            // serviciosIncluidosToolStripMenuItem
            // 
            this.serviciosIncluidosToolStripMenuItem.Name = "serviciosIncluidosToolStripMenuItem";
            this.serviciosIncluidosToolStripMenuItem.Size = new System.Drawing.Size(232, 24);
            this.serviciosIncluidosToolStripMenuItem.Text = "Servicios incluidos";
            // 
            // mENSAJESToolStripMenuItem
            // 
            this.mENSAJESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.felicitacionesToolStripMenuItem,
            this.quejasToolStripMenuItem,
            this.sugerenciasToolStripMenuItem});
            this.mENSAJESToolStripMenuItem.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mENSAJESToolStripMenuItem.Name = "mENSAJESToolStripMenuItem";
            this.mENSAJESToolStripMenuItem.Size = new System.Drawing.Size(101, 23);
            this.mENSAJESToolStripMenuItem.Text = "MENSAJES";
            // 
            // aYUDAToolStripMenuItem
            // 
            this.aYUDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enviarComentariosToolStripMenuItem,
            this.sOPORTETÉCNICOToolStripMenuItem});
            this.aYUDAToolStripMenuItem.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aYUDAToolStripMenuItem.Name = "aYUDAToolStripMenuItem";
            this.aYUDAToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.aYUDAToolStripMenuItem.Text = "AYUDA";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("AR JULIAN", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "TE DAMOS LA BIENVENIDA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "NOMBRE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // enviarComentariosToolStripMenuItem
            // 
            this.enviarComentariosToolStripMenuItem.Name = "enviarComentariosToolStripMenuItem";
            this.enviarComentariosToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.enviarComentariosToolStripMenuItem.Text = "Enviar comentarios";
            // 
            // sOPORTETÉCNICOToolStripMenuItem
            // 
            this.sOPORTETÉCNICOToolStripMenuItem.Name = "sOPORTETÉCNICOToolStripMenuItem";
            this.sOPORTETÉCNICOToolStripMenuItem.Size = new System.Drawing.Size(237, 24);
            this.sOPORTETÉCNICOToolStripMenuItem.Text = "SOPORTE TÉCNICO";
            // 
            // felicitacionesToolStripMenuItem
            // 
            this.felicitacionesToolStripMenuItem.Name = "felicitacionesToolStripMenuItem";
            this.felicitacionesToolStripMenuItem.Size = new System.Drawing.Size(362, 24);
            this.felicitacionesToolStripMenuItem.Text = "Comienza a conversar con alguien";
            // 
            // quejasToolStripMenuItem
            // 
            this.quejasToolStripMenuItem.Name = "quejasToolStripMenuItem";
            this.quejasToolStripMenuItem.Size = new System.Drawing.Size(362, 24);
            this.quejasToolStripMenuItem.Text = "Buscar una dirección";
            // 
            // sugerenciasToolStripMenuItem
            // 
            this.sugerenciasToolStripMenuItem.Name = "sugerenciasToolStripMenuItem";
            this.sugerenciasToolStripMenuItem.Size = new System.Drawing.Size(362, 24);
            this.sugerenciasToolStripMenuItem.Text = "HISTORIAL DE BÚSQUEDAS";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "CUIDAD O PAÍS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 319);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(256, 36);
            this.button4.TabIndex = 6;
            this.button4.Text = "EMAIL";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PRACTICA2.Properties.Resources.tienda;
            this.pictureBox1.Location = new System.Drawing.Point(83, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PRACTICA2.Properties.Resources.perfil;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pERFILToolStripMenuItem
            // 
            this.pERFILToolStripMenuItem.Name = "pERFILToolStripMenuItem";
            this.pERFILToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.pERFILToolStripMenuItem.Text = "PERFIL";
            // 
            // gUSTOSYPREFERENCIASToolStripMenuItem
            // 
            this.gUSTOSYPREFERENCIASToolStripMenuItem.Name = "gUSTOSYPREFERENCIASToolStripMenuItem";
            this.gUSTOSYPREFERENCIASToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.gUSTOSYPREFERENCIASToolStripMenuItem.Text = "GUSTOS Y PREFERENCIAS";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(380, 391);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 36);
            this.button5.TabIndex = 10;
            this.button5.Text = "CERRAR SESIÓN";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            this.button5.MouseCaptureChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("AR JULIAN", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(111, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(322, 36);
            this.button6.TabIndex = 11;
            this.button6.Text = "ARRENDADORES DE LOCALES";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(3, 361);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(256, 36);
            this.button7.TabIndex = 7;
            this.button7.Text = "NÚMERO DE TELÉFONO";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Menu.ResumeLayout(false);
            this.Contenedor.ResumeLayout(false);
            this.Contenedor.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Menu;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iNICIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOCALESENRENTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem precioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direcciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosIncluidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mENSAJESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aYUDAToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem felicitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quejasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sugerenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarComentariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sOPORTETÉCNICOToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem pERFILToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gUSTOSYPREFERENCIASToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

