using System;

namespace EjercicioPictureBox
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
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btnocultar = new System.Windows.Forms.Button();
            this.txtimagen = new System.Windows.Forms.TextBox();
            this.btnmostrartodos = new System.Windows.Forms.Button();
            this.ptbblanco = new System.Windows.Forms.PictureBox();
            this.ptbverde = new System.Windows.Forms.PictureBox();
            this.ptbrojo = new System.Windows.Forms.PictureBox();
            this.ptbsiliconvalley = new System.Windows.Forms.PictureBox();
            this.ptbibm = new System.Windows.Forms.PictureBox();
            this.ptbnsa = new System.Windows.Forms.PictureBox();
            this.ptbnasa = new System.Windows.Forms.PictureBox();
            this.ptbmicrosoft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbblanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbverde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbrojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbsiliconvalley)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbibm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbnsa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbnasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbmicrosoft)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(80, 210);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(89, 34);
            this.btnmostrar.TabIndex = 7;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar1_Click);
            // 
            // btnocultar
            // 
            this.btnocultar.Location = new System.Drawing.Point(620, 210);
            this.btnocultar.Name = "btnocultar";
            this.btnocultar.Size = new System.Drawing.Size(86, 34);
            this.btnocultar.TabIndex = 8;
            this.btnocultar.Text = "Ocultar";
            this.btnocultar.UseVisualStyleBackColor = true;
            this.btnocultar.Click += new System.EventHandler(this.btnocultar_Click);
            // 
            // txtimagen
            // 
            this.txtimagen.Location = new System.Drawing.Point(342, 67);
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.Size = new System.Drawing.Size(100, 20);
            this.txtimagen.TabIndex = 0;
            // 
            // btnmostrartodos
            // 
            this.btnmostrartodos.Location = new System.Drawing.Point(342, 379);
            this.btnmostrartodos.Name = "btnmostrartodos";
            this.btnmostrartodos.Size = new System.Drawing.Size(100, 29);
            this.btnmostrartodos.TabIndex = 9;
            this.btnmostrartodos.Text = "Mostrar Todos";
            this.btnmostrartodos.UseVisualStyleBackColor = true;
            this.btnmostrartodos.Click += new System.EventHandler(this.btnmostrartodos_Click);
            // 
            // ptbblanco
            // 
            this.ptbblanco.Image = global::EjercicioPictureBox.Properties.Resources.blanco;
            this.ptbblanco.Location = new System.Drawing.Point(50, 434);
            this.ptbblanco.Name = "ptbblanco";
            this.ptbblanco.Size = new System.Drawing.Size(16, 15);
            this.ptbblanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbblanco.TabIndex = 12;
            this.ptbblanco.TabStop = false;
            this.ptbblanco.Click += new System.EventHandler(this.ptbblanco_Click);
            // 
            // ptbverde
            // 
            this.ptbverde.Image = global::EjercicioPictureBox.Properties.Resources.verde;
            this.ptbverde.Location = new System.Drawing.Point(3, 434);
            this.ptbverde.Name = "ptbverde";
            this.ptbverde.Size = new System.Drawing.Size(16, 15);
            this.ptbverde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbverde.TabIndex = 11;
            this.ptbverde.TabStop = false;
            this.ptbverde.Click += new System.EventHandler(this.ptbverde_Click);
            // 
            // ptbrojo
            // 
            this.ptbrojo.Image = global::EjercicioPictureBox.Properties.Resources.rojo;
            this.ptbrojo.Location = new System.Drawing.Point(25, 434);
            this.ptbrojo.Name = "ptbrojo";
            this.ptbrojo.Size = new System.Drawing.Size(16, 15);
            this.ptbrojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbrojo.TabIndex = 10;
            this.ptbrojo.TabStop = false;
            this.ptbrojo.Click += new System.EventHandler(this.ptbrojo_Click);
            // 
            // ptbsiliconvalley
            // 
            this.ptbsiliconvalley.Image = global::EjercicioPictureBox.Properties.Resources.siliconvalley;
            this.ptbsiliconvalley.Location = new System.Drawing.Point(581, 30);
            this.ptbsiliconvalley.Name = "ptbsiliconvalley";
            this.ptbsiliconvalley.Size = new System.Drawing.Size(155, 125);
            this.ptbsiliconvalley.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbsiliconvalley.TabIndex = 6;
            this.ptbsiliconvalley.TabStop = false;
            this.ptbsiliconvalley.DoubleClick += new System.EventHandler(this.ptbsiliconvalley_DoubleClick_1);
            // 
            // ptbibm
            // 
            this.ptbibm.Image = global::EjercicioPictureBox.Properties.Resources.ibm;
            this.ptbibm.Location = new System.Drawing.Point(50, 30);
            this.ptbibm.Name = "ptbibm";
            this.ptbibm.Size = new System.Drawing.Size(155, 125);
            this.ptbibm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbibm.TabIndex = 5;
            this.ptbibm.TabStop = false;
            this.ptbibm.DoubleClick += new System.EventHandler(this.ptbibm_DoubleClick);
            // 
            // ptbnsa
            // 
            this.ptbnsa.Image = global::EjercicioPictureBox.Properties.Resources.nsa;
            this.ptbnsa.Location = new System.Drawing.Point(581, 292);
            this.ptbnsa.Name = "ptbnsa";
            this.ptbnsa.Size = new System.Drawing.Size(155, 125);
            this.ptbnsa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbnsa.TabIndex = 4;
            this.ptbnsa.TabStop = false;
            this.ptbnsa.DoubleClick += new System.EventHandler(this.ptbnsa_DoubleClick);
            // 
            // ptbnasa
            // 
            this.ptbnasa.Image = global::EjercicioPictureBox.Properties.Resources.nasa;
            this.ptbnasa.Location = new System.Drawing.Point(249, 143);
            this.ptbnasa.Name = "ptbnasa";
            this.ptbnasa.Size = new System.Drawing.Size(290, 173);
            this.ptbnasa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbnasa.TabIndex = 3;
            this.ptbnasa.TabStop = false;
            this.ptbnasa.DoubleClick += new System.EventHandler(this.ptbnasa_DoubleClick);
            // 
            // ptbmicrosoft
            // 
            this.ptbmicrosoft.Image = global::EjercicioPictureBox.Properties.Resources.microsoft;
            this.ptbmicrosoft.Location = new System.Drawing.Point(50, 292);
            this.ptbmicrosoft.Name = "ptbmicrosoft";
            this.ptbmicrosoft.Size = new System.Drawing.Size(155, 125);
            this.ptbmicrosoft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbmicrosoft.TabIndex = 2;
            this.ptbmicrosoft.TabStop = false;
            this.ptbmicrosoft.DoubleClick += new System.EventHandler(this.ptbmicrosoft_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptbblanco);
            this.Controls.Add(this.ptbverde);
            this.Controls.Add(this.ptbrojo);
            this.Controls.Add(this.btnmostrartodos);
            this.Controls.Add(this.txtimagen);
            this.Controls.Add(this.btnocultar);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.ptbsiliconvalley);
            this.Controls.Add(this.ptbibm);
            this.Controls.Add(this.ptbnsa);
            this.Controls.Add(this.ptbnasa);
            this.Controls.Add(this.ptbmicrosoft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbblanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbverde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbrojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbsiliconvalley)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbibm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbnsa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbnasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbmicrosoft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ptbsiliconvalley_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox ptbmicrosoft;
        private System.Windows.Forms.PictureBox ptbnasa;
        private System.Windows.Forms.PictureBox ptbnsa;
        private System.Windows.Forms.PictureBox ptbibm;
        private System.Windows.Forms.PictureBox ptbsiliconvalley;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.Button btnocultar;
        private System.Windows.Forms.TextBox txtimagen;
        private System.Windows.Forms.Button btnmostrartodos;
        private System.Windows.Forms.PictureBox ptbrojo;
        private System.Windows.Forms.PictureBox ptbverde;
        private System.Windows.Forms.PictureBox ptbblanco;
    }
}

