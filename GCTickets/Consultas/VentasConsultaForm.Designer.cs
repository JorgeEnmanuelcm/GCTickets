namespace GCTickets.Consultas
{
    partial class VentasConsultaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasConsultaForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Titulolabel = new System.Windows.Forms.Label();
            this.VentasdataGridView = new System.Windows.Forms.DataGridView();
            this.CanttextBox = new System.Windows.Forms.TextBox();
            this.Cantlabel = new System.Windows.Forms.Label();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.Buscarlabel = new System.Windows.Forms.Label();
            this.BuscarcomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VentasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 18;
            this.label2.Text = "Desde:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hasta:";
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(314, 60);
            this.HastadateTimePicker.MaxDate = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            this.HastadateTimePicker.MinDate = new System.DateTime(2016, 2, 4, 0, 0, 0, 0);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.HastadateTimePicker.TabIndex = 16;
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(115, 60);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.DesdedateTimePicker.TabIndex = 15;
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Titulolabel.Location = new System.Drawing.Point(223, 18);
            this.Titulolabel.Name = "Titulolabel";
            this.Titulolabel.Size = new System.Drawing.Size(194, 23);
            this.Titulolabel.TabIndex = 7;
            this.Titulolabel.Text = "Consulta de Ventas";
            // 
            // VentasdataGridView
            // 
            this.VentasdataGridView.AllowUserToAddRows = false;
            this.VentasdataGridView.AllowUserToDeleteRows = false;
            this.VentasdataGridView.AllowUserToOrderColumns = true;
            this.VentasdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VentasdataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.VentasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentasdataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.VentasdataGridView.Location = new System.Drawing.Point(12, 122);
            this.VentasdataGridView.Name = "VentasdataGridView";
            this.VentasdataGridView.ReadOnly = true;
            this.VentasdataGridView.RowHeadersVisible = false;
            this.VentasdataGridView.Size = new System.Drawing.Size(645, 213);
            this.VentasdataGridView.TabIndex = 8;
            // 
            // CanttextBox
            // 
            this.CanttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanttextBox.Location = new System.Drawing.Point(202, 351);
            this.CanttextBox.Name = "CanttextBox";
            this.CanttextBox.ReadOnly = true;
            this.CanttextBox.Size = new System.Drawing.Size(215, 20);
            this.CanttextBox.TabIndex = 9;
            // 
            // Cantlabel
            // 
            this.Cantlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cantlabel.AutoSize = true;
            this.Cantlabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantlabel.Location = new System.Drawing.Point(12, 353);
            this.Cantlabel.Name = "Cantlabel";
            this.Cantlabel.Size = new System.Drawing.Size(184, 14);
            this.Cantlabel.TabIndex = 10;
            this.Cantlabel.Text = "Cantidad actual de registros:";
            this.Cantlabel.Click += new System.EventHandler(this.Cantlabel_Click);
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscartextBox.Location = new System.Drawing.Point(202, 86);
            this.BuscartextBox.MaxLength = 18;
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(359, 20);
            this.BuscartextBox.TabIndex = 13;
            this.BuscartextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscartextBox_KeyPress);
            // 
            // Buscarlabel
            // 
            this.Buscarlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscarlabel.AutoSize = true;
            this.Buscarlabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarlabel.Location = new System.Drawing.Point(9, 88);
            this.Buscarlabel.Name = "Buscarlabel";
            this.Buscarlabel.Size = new System.Drawing.Size(51, 14);
            this.Buscarlabel.TabIndex = 11;
            this.Buscarlabel.Text = "Buscar:";
            // 
            // BuscarcomboBox
            // 
            this.BuscarcomboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscarcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuscarcomboBox.FormattingEnabled = true;
            this.BuscarcomboBox.Items.AddRange(new object[] {
            "VentaId"});
            this.BuscarcomboBox.Location = new System.Drawing.Point(68, 85);
            this.BuscarcomboBox.Name = "BuscarcomboBox";
            this.BuscarcomboBox.Size = new System.Drawing.Size(124, 21);
            this.BuscarcomboBox.TabIndex = 12;
            this.BuscarcomboBox.TextChanged += new System.EventHandler(this.BuscarcomboBox_TextChanged);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.Image = global::GCTickets.Properties.Resources._1458006602_Magnifier;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(567, 60);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(90, 46);
            this.Buscarbutton.TabIndex = 14;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // VentasConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(669, 379);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.Titulolabel);
            this.Controls.Add(this.VentasdataGridView);
            this.Controls.Add(this.CanttextBox);
            this.Controls.Add(this.Cantlabel);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.Buscarlabel);
            this.Controls.Add(this.BuscarcomboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentasConsultaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentasConsultaForm";
            this.Load += new System.EventHandler(this.VentasConsultaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VentasdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label Titulolabel;
        private System.Windows.Forms.DataGridView VentasdataGridView;
        private System.Windows.Forms.TextBox CanttextBox;
        private System.Windows.Forms.Label Cantlabel;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.Label Buscarlabel;
        private System.Windows.Forms.ComboBox BuscarcomboBox;
    }
}