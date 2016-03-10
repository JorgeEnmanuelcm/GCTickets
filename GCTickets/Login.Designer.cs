namespace GCTickets
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.NombreUsuariolabel = new System.Windows.Forms.Label();
            this.Contrasenialabel = new System.Windows.Forms.Label();
            this.NombreUsuariotextBox = new System.Windows.Forms.TextBox();
            this.ContraseniatextBox = new System.Windows.Forms.TextBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Entrarbutton = new System.Windows.Forms.Button();
            this.LoginerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LoginerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreUsuariolabel
            // 
            this.NombreUsuariolabel.AutoSize = true;
            this.NombreUsuariolabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuariolabel.Location = new System.Drawing.Point(31, 73);
            this.NombreUsuariolabel.Name = "NombreUsuariolabel";
            this.NombreUsuariolabel.Size = new System.Drawing.Size(107, 14);
            this.NombreUsuariolabel.TabIndex = 0;
            this.NombreUsuariolabel.Text = "Nombre Usuario:";
            // 
            // Contrasenialabel
            // 
            this.Contrasenialabel.AutoSize = true;
            this.Contrasenialabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasenialabel.Location = new System.Drawing.Point(53, 143);
            this.Contrasenialabel.Name = "Contrasenialabel";
            this.Contrasenialabel.Size = new System.Drawing.Size(81, 14);
            this.Contrasenialabel.TabIndex = 1;
            this.Contrasenialabel.Text = "Contraseña:";
            // 
            // NombreUsuariotextBox
            // 
            this.NombreUsuariotextBox.Location = new System.Drawing.Point(140, 73);
            this.NombreUsuariotextBox.Name = "NombreUsuariotextBox";
            this.NombreUsuariotextBox.Size = new System.Drawing.Size(159, 20);
            this.NombreUsuariotextBox.TabIndex = 2;
            this.NombreUsuariotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreUsuariotextBox_KeyPress);
            // 
            // ContraseniatextBox
            // 
            this.ContraseniatextBox.Location = new System.Drawing.Point(140, 143);
            this.ContraseniatextBox.Name = "ContraseniatextBox";
            this.ContraseniatextBox.Size = new System.Drawing.Size(159, 20);
            this.ContraseniatextBox.TabIndex = 3;
            this.ContraseniatextBox.UseSystemPasswordChar = true;
            this.ContraseniatextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContraseniatextBox_KeyPress);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(63, 214);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 4;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Entrarbutton
            // 
            this.Entrarbutton.Location = new System.Drawing.Point(192, 214);
            this.Entrarbutton.Name = "Entrarbutton";
            this.Entrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Entrarbutton.TabIndex = 5;
            this.Entrarbutton.Text = "Entrar";
            this.Entrarbutton.UseVisualStyleBackColor = true;
            this.Entrarbutton.Click += new System.EventHandler(this.Entrarbutton_Click);
            // 
            // LoginerrorProvider
            // 
            this.LoginerrorProvider.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.Entrarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.ContraseniatextBox);
            this.Controls.Add(this.NombreUsuariotextBox);
            this.Controls.Add(this.Contrasenialabel);
            this.Controls.Add(this.NombreUsuariolabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NombreUsuariolabel;
        private System.Windows.Forms.Label Contrasenialabel;
        private System.Windows.Forms.TextBox NombreUsuariotextBox;
        private System.Windows.Forms.TextBox ContraseniatextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Entrarbutton;
        private System.Windows.Forms.ErrorProvider LoginerrorProvider;
    }
}