namespace GCTickets.Registros
{
    partial class UsuariosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosForm));
            this.TelefonomaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.UsuarioIdtextBox = new System.Windows.Forms.TextBox();
            this.ApellidostextBox = new System.Windows.Forms.TextBox();
            this.NombrestextBox = new System.Windows.Forms.TextBox();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.UsuarioIdlabel = new System.Windows.Forms.Label();
            this.Nombreslabel = new System.Windows.Forms.Label();
            this.Apellidoslabel = new System.Windows.Forms.Label();
            this.Telefonolabel = new System.Windows.Forms.Label();
            this.Emaillabel = new System.Windows.Forms.Label();
            this.Direccionlabel = new System.Windows.Forms.Label();
            this.NombreUsuariolabel = new System.Windows.Forms.Label();
            this.ConfirmarContrasenialabel = new System.Windows.Forms.Label();
            this.Contrasenialabel = new System.Windows.Forms.Label();
            this.ConfirmarContraseniatextBox = new System.Windows.Forms.TextBox();
            this.ContraseniatextBox = new System.Windows.Forms.TextBox();
            this.NombreUsuariotextBox = new System.Windows.Forms.TextBox();
            this.EsActivocheckBox = new System.Windows.Forms.CheckBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Fotobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FotopictureBox = new System.Windows.Forms.PictureBox();
            this.UsuarioserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FotoopenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FotopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioserrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TelefonomaskedTextBox
            // 
            this.TelefonomaskedTextBox.Location = new System.Drawing.Point(98, 175);
            this.TelefonomaskedTextBox.Mask = "(999)000-0000";
            this.TelefonomaskedTextBox.Name = "TelefonomaskedTextBox";
            this.TelefonomaskedTextBox.Size = new System.Drawing.Size(155, 20);
            this.TelefonomaskedTextBox.TabIndex = 0;
            // 
            // UsuarioIdtextBox
            // 
            this.UsuarioIdtextBox.Location = new System.Drawing.Point(98, 44);
            this.UsuarioIdtextBox.Name = "UsuarioIdtextBox";
            this.UsuarioIdtextBox.Size = new System.Drawing.Size(87, 20);
            this.UsuarioIdtextBox.TabIndex = 1;
            // 
            // ApellidostextBox
            // 
            this.ApellidostextBox.Location = new System.Drawing.Point(98, 136);
            this.ApellidostextBox.Name = "ApellidostextBox";
            this.ApellidostextBox.Size = new System.Drawing.Size(155, 20);
            this.ApellidostextBox.TabIndex = 2;
            // 
            // NombrestextBox
            // 
            this.NombrestextBox.Location = new System.Drawing.Point(98, 91);
            this.NombrestextBox.Name = "NombrestextBox";
            this.NombrestextBox.Size = new System.Drawing.Size(155, 20);
            this.NombrestextBox.TabIndex = 3;
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.Location = new System.Drawing.Point(98, 263);
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(155, 20);
            this.DirecciontextBox.TabIndex = 4;
            this.DirecciontextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(98, 222);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(155, 20);
            this.EmailtextBox.TabIndex = 5;
            // 
            // UsuarioIdlabel
            // 
            this.UsuarioIdlabel.AutoSize = true;
            this.UsuarioIdlabel.Location = new System.Drawing.Point(28, 44);
            this.UsuarioIdlabel.Name = "UsuarioIdlabel";
            this.UsuarioIdlabel.Size = new System.Drawing.Size(55, 13);
            this.UsuarioIdlabel.TabIndex = 6;
            this.UsuarioIdlabel.Text = "Usuario Id";
            // 
            // Nombreslabel
            // 
            this.Nombreslabel.AutoSize = true;
            this.Nombreslabel.Location = new System.Drawing.Point(28, 91);
            this.Nombreslabel.Name = "Nombreslabel";
            this.Nombreslabel.Size = new System.Drawing.Size(49, 13);
            this.Nombreslabel.TabIndex = 7;
            this.Nombreslabel.Text = "Nombres";
            // 
            // Apellidoslabel
            // 
            this.Apellidoslabel.AutoSize = true;
            this.Apellidoslabel.Location = new System.Drawing.Point(28, 139);
            this.Apellidoslabel.Name = "Apellidoslabel";
            this.Apellidoslabel.Size = new System.Drawing.Size(49, 13);
            this.Apellidoslabel.TabIndex = 8;
            this.Apellidoslabel.Text = "Apellidos";
            // 
            // Telefonolabel
            // 
            this.Telefonolabel.AutoSize = true;
            this.Telefonolabel.Location = new System.Drawing.Point(28, 175);
            this.Telefonolabel.Name = "Telefonolabel";
            this.Telefonolabel.Size = new System.Drawing.Size(49, 13);
            this.Telefonolabel.TabIndex = 9;
            this.Telefonolabel.Text = "Telefono";
            // 
            // Emaillabel
            // 
            this.Emaillabel.AutoSize = true;
            this.Emaillabel.Location = new System.Drawing.Point(28, 222);
            this.Emaillabel.Name = "Emaillabel";
            this.Emaillabel.Size = new System.Drawing.Size(32, 13);
            this.Emaillabel.TabIndex = 10;
            this.Emaillabel.Text = "Email";
            // 
            // Direccionlabel
            // 
            this.Direccionlabel.AutoSize = true;
            this.Direccionlabel.Location = new System.Drawing.Point(28, 263);
            this.Direccionlabel.Name = "Direccionlabel";
            this.Direccionlabel.Size = new System.Drawing.Size(52, 13);
            this.Direccionlabel.TabIndex = 11;
            this.Direccionlabel.Text = "Direccion";
            // 
            // NombreUsuariolabel
            // 
            this.NombreUsuariolabel.AutoSize = true;
            this.NombreUsuariolabel.Location = new System.Drawing.Point(331, 44);
            this.NombreUsuariolabel.Name = "NombreUsuariolabel";
            this.NombreUsuariolabel.Size = new System.Drawing.Size(83, 13);
            this.NombreUsuariolabel.TabIndex = 12;
            this.NombreUsuariolabel.Text = "Nombre Usuario";
            // 
            // ConfirmarContrasenialabel
            // 
            this.ConfirmarContrasenialabel.AutoSize = true;
            this.ConfirmarContrasenialabel.Location = new System.Drawing.Point(331, 139);
            this.ConfirmarContrasenialabel.Name = "ConfirmarContrasenialabel";
            this.ConfirmarContrasenialabel.Size = new System.Drawing.Size(108, 13);
            this.ConfirmarContrasenialabel.TabIndex = 14;
            this.ConfirmarContrasenialabel.Text = "Confirmar Contraseña";
            // 
            // Contrasenialabel
            // 
            this.Contrasenialabel.AutoSize = true;
            this.Contrasenialabel.Location = new System.Drawing.Point(331, 91);
            this.Contrasenialabel.Name = "Contrasenialabel";
            this.Contrasenialabel.Size = new System.Drawing.Size(61, 13);
            this.Contrasenialabel.TabIndex = 15;
            this.Contrasenialabel.Text = "Contraseña";
            // 
            // ConfirmarContraseniatextBox
            // 
            this.ConfirmarContraseniatextBox.Location = new System.Drawing.Point(445, 139);
            this.ConfirmarContraseniatextBox.Name = "ConfirmarContraseniatextBox";
            this.ConfirmarContraseniatextBox.Size = new System.Drawing.Size(165, 20);
            this.ConfirmarContraseniatextBox.TabIndex = 16;
            this.ConfirmarContraseniatextBox.UseSystemPasswordChar = true;
            // 
            // ContraseniatextBox
            // 
            this.ContraseniatextBox.Location = new System.Drawing.Point(445, 88);
            this.ContraseniatextBox.Name = "ContraseniatextBox";
            this.ContraseniatextBox.Size = new System.Drawing.Size(165, 20);
            this.ContraseniatextBox.TabIndex = 17;
            this.ContraseniatextBox.UseSystemPasswordChar = true;
            // 
            // NombreUsuariotextBox
            // 
            this.NombreUsuariotextBox.Location = new System.Drawing.Point(445, 41);
            this.NombreUsuariotextBox.Name = "NombreUsuariotextBox";
            this.NombreUsuariotextBox.Size = new System.Drawing.Size(165, 20);
            this.NombreUsuariotextBox.TabIndex = 18;
            // 
            // EsActivocheckBox
            // 
            this.EsActivocheckBox.AutoSize = true;
            this.EsActivocheckBox.Location = new System.Drawing.Point(334, 184);
            this.EsActivocheckBox.Name = "EsActivocheckBox";
            this.EsActivocheckBox.Size = new System.Drawing.Size(77, 17);
            this.EsActivocheckBox.TabIndex = 19;
            this.EsActivocheckBox.Text = "Es Activo?";
            this.EsActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(232, 371);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 21;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Fotobutton
            // 
            this.Fotobutton.Location = new System.Drawing.Point(535, 178);
            this.Fotobutton.Name = "Fotobutton";
            this.Fotobutton.Size = new System.Drawing.Size(75, 38);
            this.Fotobutton.TabIndex = 22;
            this.Fotobutton.Text = "Añadir Foto";
            this.Fotobutton.UseVisualStyleBackColor = true;
            this.Fotobutton.Click += new System.EventHandler(this.Fotobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(133, 371);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 24;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(31, 371);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 25;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(191, 44);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(62, 41);
            this.Buscarbutton.TabIndex = 23;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // FotopictureBox
            // 
            this.FotopictureBox.Location = new System.Drawing.Point(334, 222);
            this.FotopictureBox.Name = "FotopictureBox";
            this.FotopictureBox.Size = new System.Drawing.Size(276, 172);
            this.FotopictureBox.TabIndex = 20;
            this.FotopictureBox.TabStop = false;
            // 
            // UsuarioserrorProvider
            // 
            this.UsuarioserrorProvider.ContainerControl = this;
            // 
            // FotoopenFileDialog
            // 
            this.FotoopenFileDialog.FileName = "FotoopenFileDialog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Holaaaaa";
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 417);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Fotobutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.FotopictureBox);
            this.Controls.Add(this.EsActivocheckBox);
            this.Controls.Add(this.NombreUsuariotextBox);
            this.Controls.Add(this.ContraseniatextBox);
            this.Controls.Add(this.ConfirmarContraseniatextBox);
            this.Controls.Add(this.Contrasenialabel);
            this.Controls.Add(this.ConfirmarContrasenialabel);
            this.Controls.Add(this.NombreUsuariolabel);
            this.Controls.Add(this.Direccionlabel);
            this.Controls.Add(this.Emaillabel);
            this.Controls.Add(this.Telefonolabel);
            this.Controls.Add(this.Apellidoslabel);
            this.Controls.Add(this.Nombreslabel);
            this.Controls.Add(this.UsuarioIdlabel);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.DirecciontextBox);
            this.Controls.Add(this.NombrestextBox);
            this.Controls.Add(this.ApellidostextBox);
            this.Controls.Add(this.UsuarioIdtextBox);
            this.Controls.Add(this.TelefonomaskedTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsuariosForm";
            this.Text = "Registro de Usuarios";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FotopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioserrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TelefonomaskedTextBox;
        private System.Windows.Forms.TextBox UsuarioIdtextBox;
        private System.Windows.Forms.TextBox ApellidostextBox;
        private System.Windows.Forms.TextBox NombrestextBox;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label UsuarioIdlabel;
        private System.Windows.Forms.Label Nombreslabel;
        private System.Windows.Forms.Label Apellidoslabel;
        private System.Windows.Forms.Label Telefonolabel;
        private System.Windows.Forms.Label Emaillabel;
        private System.Windows.Forms.Label Direccionlabel;
        private System.Windows.Forms.Label NombreUsuariolabel;
        private System.Windows.Forms.Label ConfirmarContrasenialabel;
        private System.Windows.Forms.Label Contrasenialabel;
        private System.Windows.Forms.TextBox ConfirmarContraseniatextBox;
        private System.Windows.Forms.TextBox ContraseniatextBox;
        private System.Windows.Forms.TextBox NombreUsuariotextBox;
        private System.Windows.Forms.CheckBox EsActivocheckBox;
        private System.Windows.Forms.PictureBox FotopictureBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Fotobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.ErrorProvider UsuarioserrorProvider;
        private System.Windows.Forms.OpenFileDialog FotoopenFileDialog;
        private System.Windows.Forms.Label label1;
    }
}