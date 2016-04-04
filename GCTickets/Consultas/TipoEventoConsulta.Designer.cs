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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoEventoConsulta));
            this.TipoEventodataGridView = new System.Windows.Forms.DataGridView();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.BuscarcomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarlabel = new System.Windows.Forms.Label();
            this.CanttextBox = new System.Windows.Forms.TextBox();
            this.Cantlabel = new System.Windows.Forms.Label();
            this.Titulolabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TipoEventodataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoEventodataGridView
            // 
            this.TipoEventodataGridView.AllowUserToAddRows = false;
            this.TipoEventodataGridView.AllowUserToDeleteRows = false;
            this.TipoEventodataGridView.AllowUserToOrderColumns = true;
            this.TipoEventodataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.TipoEventodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TipoEventodataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.TipoEventodataGridView.Location = new System.Drawing.Point(12, 113);
            this.TipoEventodataGridView.Name = "TipoEventodataGridView";
            this.TipoEventodataGridView.ReadOnly = true;
            this.TipoEventodataGridView.RowHeadersVisible = false;
            this.TipoEventodataGridView.Size = new System.Drawing.Size(484, 157);
            this.TipoEventodataGridView.TabIndex = 0;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.Image = global::GCTickets.Properties.Resources._1458006602_Magnifier;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(421, 66);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 41);
            this.Buscarbutton.TabIndex = 2;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Location = new System.Drawing.Point(186, 66);
            this.BuscartextBox.MaxLength = 14;
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(229, 20);
            this.BuscartextBox.TabIndex = 1;
            this.BuscartextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscartextBox_KeyPress);
            // 
            // BuscarcomboBox
            // 
            this.BuscarcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarcomboBox.FormattingEnabled = true;
            this.BuscarcomboBox.Items.AddRange(new object[] {
            "TipoEventoId",
            "Descripcion"});
            this.BuscarcomboBox.Location = new System.Drawing.Point(59, 66);
            this.BuscarcomboBox.Name = "BuscarcomboBox";
            this.BuscarcomboBox.Size = new System.Drawing.Size(121, 21);
            this.BuscarcomboBox.TabIndex = 0;
            this.BuscarcomboBox.TextChanged += new System.EventHandler(this.BuscarcomboBox_TextChanged);
            // 
            // Buscarlabel
            // 
            this.Buscarlabel.AutoSize = true;
            this.Buscarlabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarlabel.Location = new System.Drawing.Point(9, 68);
            this.Buscarlabel.Name = "Buscarlabel";
            this.Buscarlabel.Size = new System.Drawing.Size(51, 14);
            this.Buscarlabel.TabIndex = 0;
            this.Buscarlabel.Text = "Buscar:";
            // 
            // CanttextBox
            // 
            this.CanttextBox.Location = new System.Drawing.Point(208, 285);
            this.CanttextBox.Name = "CanttextBox";
            this.CanttextBox.ReadOnly = true;
            this.CanttextBox.Size = new System.Drawing.Size(207, 20);
            this.CanttextBox.TabIndex = 0;
            // 
            // Cantlabel
            // 
            this.Cantlabel.AutoSize = true;
            this.Cantlabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantlabel.Location = new System.Drawing.Point(9, 285);
            this.Cantlabel.Name = "Cantlabel";
            this.Cantlabel.Size = new System.Drawing.Size(188, 14);
            this.Cantlabel.TabIndex = 0;
            this.Cantlabel.Text = "Cantidad actual de registros: ";
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Titulolabel.Location = new System.Drawing.Point(129, 19);
            this.Titulolabel.Name = "Titulolabel";
            this.Titulolabel.Size = new System.Drawing.Size(263, 23);
            this.Titulolabel.TabIndex = 23;
            this.Titulolabel.Text = "Consulta de Tipos Eventos";
            // 
            // TipoEventoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(509, 317);
            this.Controls.Add(this.Titulolabel);
            this.Controls.Add(this.Cantlabel);
            this.Controls.Add(this.CanttextBox);
            this.Controls.Add(this.Buscarlabel);
            this.Controls.Add(this.BuscarcomboBox);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.TipoEventodataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TipoEventoConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GC Tickets";
            this.Load += new System.EventHandler(this.TipoEventoConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TipoEventodataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TipoEventodataGridView;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.ComboBox BuscarcomboBox;
        private System.Windows.Forms.Label Buscarlabel;
        private System.Windows.Forms.TextBox CanttextBox;
        private System.Windows.Forms.Label Cantlabel;
        private System.Windows.Forms.Label Titulolabel;
    }
}