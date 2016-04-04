namespace GCTickets.Consultas
{
    partial class EventosConsultaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventosConsultaForm));
            this.Buscarlabel = new System.Windows.Forms.Label();
            this.BuscarcomboBox = new System.Windows.Forms.ComboBox();
            this.BuscartextBox = new System.Windows.Forms.TextBox();
            this.CanttextBox = new System.Windows.Forms.TextBox();
            this.Cantlabel = new System.Windows.Forms.Label();
            this.EventosdataGridView = new System.Windows.Forms.DataGridView();
            this.Titulolabel = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EventosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscarlabel
            // 
            this.Buscarlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscarlabel.AutoSize = true;
            this.Buscarlabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarlabel.Location = new System.Drawing.Point(12, 105);
            this.Buscarlabel.Name = "Buscarlabel";
            this.Buscarlabel.Size = new System.Drawing.Size(51, 14);
            this.Buscarlabel.TabIndex = 0;
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
            "EventoId",
            "NombreEvento"});
            this.BuscarcomboBox.Location = new System.Drawing.Point(62, 102);
            this.BuscarcomboBox.Name = "BuscarcomboBox";
            this.BuscarcomboBox.Size = new System.Drawing.Size(145, 21);
            this.BuscarcomboBox.TabIndex = 0;
            this.BuscarcomboBox.TextChanged += new System.EventHandler(this.BuscarcomboBox_TextChanged);
            // 
            // BuscartextBox
            // 
            this.BuscartextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuscartextBox.Location = new System.Drawing.Point(213, 103);
            this.BuscartextBox.MaxLength = 18;
            this.BuscartextBox.Name = "BuscartextBox";
            this.BuscartextBox.Size = new System.Drawing.Size(328, 20);
            this.BuscartextBox.TabIndex = 1;
            this.BuscartextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BuscartextBox_KeyPress);
            // 
            // CanttextBox
            // 
            this.CanttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanttextBox.Location = new System.Drawing.Point(195, 368);
            this.CanttextBox.Name = "CanttextBox";
            this.CanttextBox.ReadOnly = true;
            this.CanttextBox.Size = new System.Drawing.Size(271, 20);
            this.CanttextBox.TabIndex = 0;
            this.CanttextBox.TextChanged += new System.EventHandler(this.CanttextBox_TextChanged);
            // 
            // Cantlabel
            // 
            this.Cantlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cantlabel.AutoSize = true;
            this.Cantlabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantlabel.Location = new System.Drawing.Point(9, 368);
            this.Cantlabel.Name = "Cantlabel";
            this.Cantlabel.Size = new System.Drawing.Size(184, 14);
            this.Cantlabel.TabIndex = 0;
            this.Cantlabel.Text = "Cantidad actual de registros:";
            // 
            // EventosdataGridView
            // 
            this.EventosdataGridView.AllowUserToAddRows = false;
            this.EventosdataGridView.AllowUserToDeleteRows = false;
            this.EventosdataGridView.AllowUserToOrderColumns = true;
            this.EventosdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventosdataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.EventosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventosdataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.EventosdataGridView.Location = new System.Drawing.Point(12, 139);
            this.EventosdataGridView.Name = "EventosdataGridView";
            this.EventosdataGridView.ReadOnly = true;
            this.EventosdataGridView.RowHeadersVisible = false;
            this.EventosdataGridView.Size = new System.Drawing.Size(610, 213);
            this.EventosdataGridView.TabIndex = 0;
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Titulolabel.Location = new System.Drawing.Point(208, 24);
            this.Titulolabel.Name = "Titulolabel";
            this.Titulolabel.Size = new System.Drawing.Size(205, 23);
            this.Titulolabel.TabIndex = 0;
            this.Titulolabel.Text = "Consulta de Eventos";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.Enabled = false;
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(137, 77);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.DesdedateTimePicker.TabIndex = 3;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.Enabled = false;
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(336, 77);
            this.HastadateTimePicker.MaxDate = new System.DateTime(2020, 12, 11, 0, 0, 0, 0);
            this.HastadateTimePicker.MinDate = new System.DateTime(2016, 2, 4, 0, 0, 0, 0);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(145, 20);
            this.HastadateTimePicker.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hasta:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "Desde:";
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Imprimirbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Imprimirbutton.Image = global::GCTickets.Properties.Resources._1459716739_News;
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Imprimirbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Imprimirbutton.Location = new System.Drawing.Point(547, 358);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 45);
            this.Imprimirbutton.TabIndex = 27;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Buscarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.Image = global::GCTickets.Properties.Resources._1458006602_Magnifier;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(547, 77);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 45);
            this.Buscarbutton.TabIndex = 2;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // EventosConsultaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(634, 407);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.Titulolabel);
            this.Controls.Add(this.EventosdataGridView);
            this.Controls.Add(this.CanttextBox);
            this.Controls.Add(this.Cantlabel);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.BuscartextBox);
            this.Controls.Add(this.Buscarlabel);
            this.Controls.Add(this.BuscarcomboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EventosConsultaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GC Tickets";
            ((System.ComponentModel.ISupportInitialize)(this.EventosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label Buscarlabel;
        private System.Windows.Forms.ComboBox BuscarcomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox BuscartextBox;
        private System.Windows.Forms.TextBox CanttextBox;
        private System.Windows.Forms.Label Cantlabel;
        private System.Windows.Forms.DataGridView EventosdataGridView;
        private System.Windows.Forms.Label Titulolabel;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Imprimirbutton;
    }
}