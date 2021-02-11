
namespace Imagen
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
            this.btnAbrirImagen = new System.Windows.Forms.Button();
            this.btnGuardarImagen = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.SeleccionColor = new System.Windows.Forms.PictureBox();
            this.SeleccionAzul = new System.Windows.Forms.HScrollBar();
            this.SeleccionVerde = new System.Windows.Forms.HScrollBar();
            this.SeleccionRojo = new System.Windows.Forms.HScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeleccionColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirImagen
            // 
            this.btnAbrirImagen.Location = new System.Drawing.Point(28, 26);
            this.btnAbrirImagen.Name = "btnAbrirImagen";
            this.btnAbrirImagen.Size = new System.Drawing.Size(198, 34);
            this.btnAbrirImagen.TabIndex = 0;
            this.btnAbrirImagen.Text = "Abrir Imagen";
            this.btnAbrirImagen.UseVisualStyleBackColor = true;
            this.btnAbrirImagen.Click += new System.EventHandler(this.btnAbrirImagen_Click);
            // 
            // btnGuardarImagen
            // 
            this.btnGuardarImagen.Location = new System.Drawing.Point(367, 25);
            this.btnGuardarImagen.Name = "btnGuardarImagen";
            this.btnGuardarImagen.Size = new System.Drawing.Size(376, 34);
            this.btnGuardarImagen.TabIndex = 1;
            this.btnGuardarImagen.Text = "Guardar Imagen";
            this.btnGuardarImagen.UseVisualStyleBackColor = true;
            this.btnGuardarImagen.Click += new System.EventHandler(this.btnGuardarImagen_Click);
            // 
            // picBox1
            // 
            this.picBox1.Location = new System.Drawing.Point(27, 88);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(352, 294);
            this.picBox1.TabIndex = 0;
            this.picBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(391, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(352, 294);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlControl
            // 
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControl.Controls.Add(this.SeleccionColor);
            this.pnlControl.Controls.Add(this.SeleccionAzul);
            this.pnlControl.Controls.Add(this.SeleccionVerde);
            this.pnlControl.Controls.Add(this.SeleccionRojo);
            this.pnlControl.Controls.Add(this.label3);
            this.pnlControl.Controls.Add(this.label2);
            this.pnlControl.Controls.Add(this.label1);
            this.pnlControl.Controls.Add(this.btnAplicar);
            this.pnlControl.Location = new System.Drawing.Point(27, 388);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(715, 154);
            this.pnlControl.TabIndex = 4;
            // 
            // SeleccionColor
            // 
            this.SeleccionColor.Location = new System.Drawing.Point(37, 116);
            this.SeleccionColor.Name = "SeleccionColor";
            this.SeleccionColor.Size = new System.Drawing.Size(546, 13);
            this.SeleccionColor.TabIndex = 14;
            this.SeleccionColor.TabStop = false;
            // 
            // SeleccionAzul
            // 
            this.SeleccionAzul.Location = new System.Drawing.Point(118, 80);
            this.SeleccionAzul.Maximum = 255;
            this.SeleccionAzul.Name = "SeleccionAzul";
            this.SeleccionAzul.Size = new System.Drawing.Size(437, 22);
            this.SeleccionAzul.TabIndex = 13;
            // 
            // SeleccionVerde
            // 
            this.SeleccionVerde.Location = new System.Drawing.Point(118, 48);
            this.SeleccionVerde.Maximum = 255;
            this.SeleccionVerde.Name = "SeleccionVerde";
            this.SeleccionVerde.Size = new System.Drawing.Size(437, 22);
            this.SeleccionVerde.TabIndex = 12;
            // 
            // SeleccionRojo
            // 
            this.SeleccionRojo.Location = new System.Drawing.Point(118, 12);
            this.SeleccionRojo.Maximum = 255;
            this.SeleccionRojo.Name = "SeleccionRojo";
            this.SeleccionRojo.Size = new System.Drawing.Size(437, 22);
            this.SeleccionRojo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Azul(B)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Verde (G)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rojo(R)";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(617, 38);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 23);
            this.btnAplicar.TabIndex = 3;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 586);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.btnGuardarImagen);
            this.Controls.Add(this.btnAbrirImagen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SeleccionColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirImagen;
        private System.Windows.Forms.Button btnGuardarImagen;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar SeleccionAzul;
        private System.Windows.Forms.HScrollBar SeleccionVerde;
        private System.Windows.Forms.HScrollBar SeleccionRojo;
        private System.Windows.Forms.PictureBox SeleccionColor;
    }
}

