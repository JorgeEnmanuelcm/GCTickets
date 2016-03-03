namespace GCTickets.Consultas
{
    partial class UsuariosConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosConsulta));
            this.UsuariosdataGridView = new System.Windows.Forms.DataGridView();
            this.BuscarcomboBox = new System.Windows.Forms.ComboBox();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.Buscarlabel = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UsuariosdataGridView
            // 
            this.UsuariosdataGridView.AllowUserToAddRows = false;
            this.UsuariosdataGridView.AllowUserToDeleteRows = false;
            this.UsuariosdataGridView.AllowUserToOrderColumns = true;
            this.UsuariosdataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.UsuariosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosdataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.UsuariosdataGridView.Location = new System.Drawing.Point(12, 70);
            this.UsuariosdataGridView.Name = "UsuariosdataGridView";
            this.UsuariosdataGridView.ReadOnly = true;
            this.UsuariosdataGridView.RowHeadersVisible = false;
            this.UsuariosdataGridView.Size = new System.Drawing.Size(535, 204);
            this.UsuariosdataGridView.TabIndex = 0;
            // 
            // BuscarcomboBox
            // 
            this.BuscarcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarcomboBox.FormattingEnabled = true;
            this.BuscarcomboBox.Location = new System.Drawing.Point(68, 28);
            this.BuscarcomboBox.Name = "BuscarcomboBox";
            this.BuscarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.BuscarcomboBox.TabIndex = 1;
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(195, 29);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(271, 20);
            this.BuscartextBox.TabIndex = 2;
            this.BuscartextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscartextBox_KeyPress);
            // 
            // Buscarlabel
            // 
            this.Buscarlabel.AutoSize = true;
            this.Buscarlabel.Location = new System.Drawing.Point(9, 28);
            this.Buscarlabel.Name = "Buscarlabel";
            this.Buscarlabel.Size = new System.Drawing.Size(40, 13);
            this.Buscarlabel.TabIndex = 3;
            this.Buscarlabel.Text = "Buscar";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(472, 28);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 4;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // UsuariosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 303);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Buscarlabel);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.BuscarcomboBox);
            this.Controls.Add(this.UsuariosdataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsuariosConsulta";
            this.Text = "Consulta de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsuariosdataGridView;
        private System.Windows.Forms.ComboBox BuscarcomboBox;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.Label Buscarlabel;
        private System.Windows.Forms.Button Buscarbutton;
    }
}