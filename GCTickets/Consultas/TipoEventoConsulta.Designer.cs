namespace GCTickets.Consultas
{
    partial class TipoEventoConsulta
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
            this.TipoEventodataGridView = new System.Windows.Forms.DataGridView();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.BuscarcomboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TipoEventodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoEventodataGridView
            // 
            this.TipoEventodataGridView.AllowUserToAddRows = false;
            this.TipoEventodataGridView.AllowUserToDeleteRows = false;
            this.TipoEventodataGridView.AllowUserToOrderColumns = true;
            this.TipoEventodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TipoEventodataGridView.Location = new System.Drawing.Point(12, 81);
            this.TipoEventodataGridView.Name = "TipoEventodataGridView";
            this.TipoEventodataGridView.ReadOnly = true;
            this.TipoEventodataGridView.Size = new System.Drawing.Size(516, 150);
            this.TipoEventodataGridView.TabIndex = 0;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(421, 41);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 1;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(293, 41);
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(122, 20);
            this.BuscartextBox.TabIndex = 2;
            // 
            // BuscarcomboBox
            // 
            this.BuscarcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarcomboBox.FormattingEnabled = true;
            this.BuscarcomboBox.Location = new System.Drawing.Point(166, 41);
            this.BuscarcomboBox.Name = "BuscarcomboBox";
            this.BuscarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.BuscarcomboBox.TabIndex = 3;
            // 
            // TipoEventoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 261);
            this.Controls.Add(this.BuscarcomboBox);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.TipoEventodataGridView);
            this.Name = "TipoEventoConsulta";
            this.Text = "Consulta Tipo Evento ";
            ((System.ComponentModel.ISupportInitialize)(this.TipoEventodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TipoEventodataGridView;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.ComboBox BuscarcomboBox;
    }
}