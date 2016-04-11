namespace GCTickets.Registros
{
    partial class VentasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasForm));
            this.VentadataGridView = new System.Windows.Forms.DataGridView();
            this.EventoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventocomboBox = new System.Windows.Forms.ComboBox();
            this.TicketcomboBox = new System.Windows.Forms.ComboBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.UsuarioscomboBox = new System.Windows.Forms.ComboBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DescripcionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.CanttextBox = new System.Windows.Forms.TextBox();
            this.Imprimirbutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.VentaIdlabel = new System.Windows.Forms.Label();
            this.Eventolabel = new System.Windows.Forms.Label();
            this.VendidoPorlabel = new System.Windows.Forms.Label();
            this.Fechalabel = new System.Windows.Forms.Label();
            this.Cantlabel = new System.Windows.Forms.Label();
            this.Ticketlabel = new System.Windows.Forms.Label();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.Totallabel = new System.Windows.Forms.Label();
            this.Titulolabel = new System.Windows.Forms.Label();
            this.VentaIdtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.VentadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VentadataGridView
            // 
            this.VentadataGridView.AllowUserToAddRows = false;
            this.VentadataGridView.AllowUserToDeleteRows = false;
            this.VentadataGridView.AllowUserToOrderColumns = true;
            this.VentadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VentadataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventoId});
            this.VentadataGridView.Location = new System.Drawing.Point(12, 302);
            this.VentadataGridView.Name = "VentadataGridView";
            this.VentadataGridView.ReadOnly = true;
            this.VentadataGridView.RowHeadersVisible = false;
            this.VentadataGridView.Size = new System.Drawing.Size(559, 125);
            this.VentadataGridView.TabIndex = 0;
            // 
            // EventoId
            // 
            this.EventoId.HeaderText = "EventoId";
            this.EventoId.Name = "EventoId";
            this.EventoId.ReadOnly = true;
            // 
            // EventocomboBox
            // 
            this.EventocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EventocomboBox.FormattingEnabled = true;
            this.EventocomboBox.Location = new System.Drawing.Point(96, 131);
            this.EventocomboBox.Name = "EventocomboBox";
            this.EventocomboBox.Size = new System.Drawing.Size(172, 21);
            this.EventocomboBox.TabIndex = 1;
            // 
            // TicketcomboBox
            // 
            this.TicketcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TicketcomboBox.FormattingEnabled = true;
            this.TicketcomboBox.Location = new System.Drawing.Point(390, 68);
            this.TicketcomboBox.Name = "TicketcomboBox";
            this.TicketcomboBox.Size = new System.Drawing.Size(184, 21);
            this.TicketcomboBox.TabIndex = 4;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(62, 433);
            this.TotaltextBox.MaxLength = 12;
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.ReadOnly = true;
            this.TotaltextBox.Size = new System.Drawing.Size(227, 20);
            this.TotaltextBox.TabIndex = 8;
            // 
            // UsuarioscomboBox
            // 
            this.UsuarioscomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsuarioscomboBox.FormattingEnabled = true;
            this.UsuarioscomboBox.Location = new System.Drawing.Point(96, 178);
            this.UsuarioscomboBox.Name = "UsuarioscomboBox";
            this.UsuarioscomboBox.Size = new System.Drawing.Size(172, 21);
            this.UsuarioscomboBox.TabIndex = 2;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(96, 224);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(172, 20);
            this.FechadateTimePicker.TabIndex = 3;
            // 
            // DescripcionrichTextBox
            // 
            this.DescripcionrichTextBox.Location = new System.Drawing.Point(387, 161);
            this.DescripcionrichTextBox.MaxLength = 59;
            this.DescripcionrichTextBox.Name = "DescripcionrichTextBox";
            this.DescripcionrichTextBox.Size = new System.Drawing.Size(184, 84);
            this.DescripcionrichTextBox.TabIndex = 6;
            this.DescripcionrichTextBox.Text = "";
            this.DescripcionrichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripcionrichTextBox_KeyPress);
            // 
            // CanttextBox
            // 
            this.CanttextBox.Location = new System.Drawing.Point(390, 115);
            this.CanttextBox.MaxLength = 3;
            this.CanttextBox.Name = "CanttextBox";
            this.CanttextBox.Size = new System.Drawing.Size(184, 20);
            this.CanttextBox.TabIndex = 5;
            this.CanttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CanttextBox_KeyPress);
            // 
            // Imprimirbutton
            // 
            this.Imprimirbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Imprimirbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Imprimirbutton.Image = global::GCTickets.Properties.Resources._1459716739_News;
            this.Imprimirbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Imprimirbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Imprimirbutton.Location = new System.Drawing.Point(496, 469);
            this.Imprimirbutton.Name = "Imprimirbutton";
            this.Imprimirbutton.Size = new System.Drawing.Size(75, 46);
            this.Imprimirbutton.TabIndex = 22;
            this.Imprimirbutton.Text = "Imprimir";
            this.Imprimirbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imprimirbutton.UseVisualStyleBackColor = true;
            this.Imprimirbutton.Click += new System.EventHandler(this.Imprimirbutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbutton.Image = global::GCTickets.Properties.Resources._1458006586_Add;
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Agregarbutton.Location = new System.Drawing.Point(496, 252);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 44);
            this.Agregarbutton.TabIndex = 7;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Buscarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Buscarbutton.Image = global::GCTickets.Properties.Resources._1458006602_Magnifier;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Buscarbutton.Location = new System.Drawing.Point(206, 69);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(62, 45);
            this.Buscarbutton.TabIndex = 0;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Nuevobutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Nuevobutton.Image = global::GCTickets.Properties.Resources._1458006564_EditDocument;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Nuevobutton.Location = new System.Drawing.Point(13, 470);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 45);
            this.Nuevobutton.TabIndex = 0;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Guardarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Guardarbutton.Image = global::GCTickets.Properties.Resources._1458006725_Diskette;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Guardarbutton.Location = new System.Drawing.Point(115, 470);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 46);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Eliminarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Eliminarbutton.Image = global::GCTickets.Properties.Resources._1458006437_Cancel;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Eliminarbutton.Location = new System.Drawing.Point(214, 470);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 46);
            this.Eliminarbutton.TabIndex = 0;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // VentaIdlabel
            // 
            this.VentaIdlabel.AutoSize = true;
            this.VentaIdlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VentaIdlabel.Location = new System.Drawing.Point(36, 76);
            this.VentaIdlabel.Name = "VentaIdlabel";
            this.VentaIdlabel.Size = new System.Drawing.Size(58, 13);
            this.VentaIdlabel.TabIndex = 0;
            this.VentaIdlabel.Text = "Venta Id:";
            // 
            // Eventolabel
            // 
            this.Eventolabel.AutoSize = true;
            this.Eventolabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eventolabel.Location = new System.Drawing.Point(45, 134);
            this.Eventolabel.Name = "Eventolabel";
            this.Eventolabel.Size = new System.Drawing.Size(49, 13);
            this.Eventolabel.TabIndex = 0;
            this.Eventolabel.Text = "Evento:";
            // 
            // VendidoPorlabel
            // 
            this.VendidoPorlabel.AutoSize = true;
            this.VendidoPorlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendidoPorlabel.Location = new System.Drawing.Point(17, 181);
            this.VendidoPorlabel.Name = "VendidoPorlabel";
            this.VendidoPorlabel.Size = new System.Drawing.Size(77, 13);
            this.VendidoPorlabel.TabIndex = 0;
            this.VendidoPorlabel.Text = "Vendido Por:";
            // 
            // Fechalabel
            // 
            this.Fechalabel.AutoSize = true;
            this.Fechalabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fechalabel.Location = new System.Drawing.Point(51, 224);
            this.Fechalabel.Name = "Fechalabel";
            this.Fechalabel.Size = new System.Drawing.Size(43, 13);
            this.Fechalabel.TabIndex = 0;
            this.Fechalabel.Text = "Fecha:";
            // 
            // Cantlabel
            // 
            this.Cantlabel.AutoSize = true;
            this.Cantlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantlabel.Location = new System.Drawing.Point(324, 115);
            this.Cantlabel.Name = "Cantlabel";
            this.Cantlabel.Size = new System.Drawing.Size(60, 13);
            this.Cantlabel.TabIndex = 0;
            this.Cantlabel.Text = "Cantidad:";
            // 
            // Ticketlabel
            // 
            this.Ticketlabel.AutoSize = true;
            this.Ticketlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ticketlabel.Location = new System.Drawing.Point(339, 71);
            this.Ticketlabel.Name = "Ticketlabel";
            this.Ticketlabel.Size = new System.Drawing.Size(45, 13);
            this.Ticketlabel.TabIndex = 0;
            this.Ticketlabel.Text = "Ticket:";
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcionlabel.Location = new System.Drawing.Point(309, 164);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(75, 13);
            this.Descripcionlabel.TabIndex = 0;
            this.Descripcionlabel.Text = "Descripcion:";
            // 
            // Totallabel
            // 
            this.Totallabel.AutoSize = true;
            this.Totallabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totallabel.Location = new System.Drawing.Point(14, 436);
            this.Totallabel.Name = "Totallabel";
            this.Totallabel.Size = new System.Drawing.Size(42, 14);
            this.Totallabel.TabIndex = 0;
            this.Totallabel.Text = "Total:";
            // 
            // Titulolabel
            // 
            this.Titulolabel.AutoSize = true;
            this.Titulolabel.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Titulolabel.Location = new System.Drawing.Point(193, 18);
            this.Titulolabel.Name = "Titulolabel";
            this.Titulolabel.Size = new System.Drawing.Size(191, 23);
            this.Titulolabel.TabIndex = 0;
            this.Titulolabel.Text = "Registro de Ventas";
            // 
            // VentaIdtextBox
            // 
            this.VentaIdtextBox.Location = new System.Drawing.Point(96, 72);
            this.VentaIdtextBox.MaxLength = 6;
            this.VentaIdtextBox.Name = "VentaIdtextBox";
            this.VentaIdtextBox.Size = new System.Drawing.Size(104, 20);
            this.VentaIdtextBox.TabIndex = 0;
            this.VentaIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VentaIdtextBox_KeyPress);
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(586, 528);
            this.Controls.Add(this.VentaIdtextBox);
            this.Controls.Add(this.Titulolabel);
            this.Controls.Add(this.Totallabel);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.Ticketlabel);
            this.Controls.Add(this.Cantlabel);
            this.Controls.Add(this.Fechalabel);
            this.Controls.Add(this.VendidoPorlabel);
            this.Controls.Add(this.Eventolabel);
            this.Controls.Add(this.VentaIdlabel);
            this.Controls.Add(this.Imprimirbutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.CanttextBox);
            this.Controls.Add(this.DescripcionrichTextBox);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.UsuarioscomboBox);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.TicketcomboBox);
            this.Controls.Add(this.EventocomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.VentadataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VentasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GC Tickets";
            this.Load += new System.EventHandler(this.VentasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VentadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VentadataGridView;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ComboBox EventocomboBox;
        private System.Windows.Forms.ComboBox TicketcomboBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.ComboBox UsuarioscomboBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.RichTextBox DescripcionrichTextBox;
        private System.Windows.Forms.TextBox CanttextBox;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Imprimirbutton;
        private System.Windows.Forms.Label VentaIdlabel;
        private System.Windows.Forms.Label Eventolabel;
        private System.Windows.Forms.Label VendidoPorlabel;
        private System.Windows.Forms.Label Fechalabel;
        private System.Windows.Forms.Label Cantlabel;
        private System.Windows.Forms.Label Ticketlabel;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.Label Totallabel;
        private System.Windows.Forms.Label Titulolabel;
        private System.Windows.Forms.TextBox VentaIdtextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventoId;
    }
}