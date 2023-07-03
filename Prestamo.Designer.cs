namespace Biblioteca
{
    partial class Prestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamo));
            this.Bienvenida = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTPersonales = new System.Windows.Forms.Panel();
            this.Lugar = new System.Windows.Forms.ComboBox();
            this.Raza = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DDPrestamo = new System.Windows.Forms.Panel();
            this.MTPrestamo = new System.Windows.Forms.TextBox();
            this.Cuota = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DTPersonales.SuspendLayout();
            this.DDPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bienvenida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Bienvenida.Location = new System.Drawing.Point(82, 41);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(175, 36);
            this.Bienvenida.TabIndex = 0;
            this.Bienvenida.Text = "Bienvenido, ";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Black;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegresar.Location = new System.Drawing.Point(659, 394);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(133, 42);
            this.btnRegresar.TabIndex = 1;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Black;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmar.Location = new System.Drawing.Point(250, 331);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(293, 42);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar Prestamo";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(47, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datos Personales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(427, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Detalle del Prestamo:";
            // 
            // DTPersonales
            // 
            this.DTPersonales.BackColor = System.Drawing.Color.Firebrick;
            this.DTPersonales.Controls.Add(this.Lugar);
            this.DTPersonales.Controls.Add(this.Raza);
            this.DTPersonales.Controls.Add(this.label4);
            this.DTPersonales.Controls.Add(this.label3);
            this.errorProvider1.SetIconAlignment(this.DTPersonales, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.DTPersonales.Location = new System.Drawing.Point(52, 142);
            this.DTPersonales.Name = "DTPersonales";
            this.DTPersonales.Size = new System.Drawing.Size(331, 141);
            this.DTPersonales.TabIndex = 6;
            // 
            // Lugar
            // 
            this.Lugar.BackColor = System.Drawing.Color.Black;
            this.Lugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Lugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lugar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lugar.FormattingEnabled = true;
            this.Lugar.Location = new System.Drawing.Point(148, 81);
            this.Lugar.Name = "Lugar";
            this.Lugar.Size = new System.Drawing.Size(156, 21);
            this.Lugar.TabIndex = 3;
            // 
            // Raza
            // 
            this.Raza.BackColor = System.Drawing.Color.Black;
            this.Raza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Raza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Raza.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Raza.FormattingEnabled = true;
            this.Raza.Location = new System.Drawing.Point(148, 26);
            this.Raza.Name = "Raza";
            this.Raza.Size = new System.Drawing.Size(156, 21);
            this.Raza.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(8, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lugar Origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(83, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Raza:";
            // 
            // DDPrestamo
            // 
            this.DDPrestamo.BackColor = System.Drawing.Color.Firebrick;
            this.DDPrestamo.Controls.Add(this.MTPrestamo);
            this.DDPrestamo.Controls.Add(this.Cuota);
            this.DDPrestamo.Controls.Add(this.label5);
            this.DDPrestamo.Controls.Add(this.label6);
            this.DDPrestamo.Location = new System.Drawing.Point(424, 142);
            this.DDPrestamo.Name = "DDPrestamo";
            this.DDPrestamo.Size = new System.Drawing.Size(344, 141);
            this.DDPrestamo.TabIndex = 7;
            // 
            // MTPrestamo
            // 
            this.MTPrestamo.BackColor = System.Drawing.Color.Black;
            this.MTPrestamo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MTPrestamo.Location = new System.Drawing.Point(165, 24);
            this.MTPrestamo.Name = "MTPrestamo";
            this.MTPrestamo.Size = new System.Drawing.Size(157, 20);
            this.MTPrestamo.TabIndex = 4;
            // 
            // Cuota
            // 
            this.Cuota.BackColor = System.Drawing.Color.Black;
            this.Cuota.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cuota.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cuota.FormattingEnabled = true;
            this.Cuota.Location = new System.Drawing.Point(165, 77);
            this.Cuota.Name = "Cuota";
            this.Cuota.Size = new System.Drawing.Size(157, 21);
            this.Cuota.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(92, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cuotas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(8, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Monto Prestamo:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.DDPrestamo);
            this.Controls.Add(this.DTPersonales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.Bienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prestamo";
            this.Text = "Prestamo";
            this.Load += new System.EventHandler(this.Prestamo_Load);
            this.DTPersonales.ResumeLayout(false);
            this.DTPersonales.PerformLayout();
            this.DDPrestamo.ResumeLayout(false);
            this.DDPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Bienvenida;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DTPersonales;
        private System.Windows.Forms.ComboBox Lugar;
        private System.Windows.Forms.ComboBox Raza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel DDPrestamo;
        private System.Windows.Forms.ComboBox Cuota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MTPrestamo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}