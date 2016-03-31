namespace GCTickets.Registros
{
    partial class EventosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventosForm));
            this.EventodataGridView = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantDisponible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.EventodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.TipoEventocomboBox = new System.Windows.Forms.ComboBox();
            this.EventoIdtextBox = new System.Windows.Forms.TextBox();
            this.PrecioTtextBox = new System.Windows.Forms.TextBox();
            this.CantDisptextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.NombreEventotextBox = new System.Windows.Forms.TextBox();
            this.LugarEventotextBox = new System.Windows.Forms.TextBox();
            this.EventoIdlabel = new System.Windows.Forms.Label();
            this.TipoIdlabel = new System.Windows.Forms.Label();
            this.NombreEventolabel = new System.Windows.Forms.Label();
            this.FechaEventolabel = new System.Windows.Forms.Label();
            this.LugarEventolabel = new System.Windows.Forms.Label();
            this.Descripcionlabel = new System.Windows.Forms.Label();
            this.CantDisplabel = new System.Windows.Forms.Label();
            this.PrecioTlabel = new System.Windows.Forms.Label();
            this.EventoserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EventodataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventoserrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EventodataGridView
            // 
            this.EventodataGridView.AllowUserToAddRows = false;
            this.EventodataGridView.AllowUserToDeleteRows = false;
            this.EventodataGridView.AllowUserToOrderColumns = true;
            this.EventodataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventodataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.CantDisponible,
            this.PrecioTicket});
            this.EventodataGridView.Location = new System.Drawing.Point(316, 217);
            this.EventodataGridView.Name = "EventodataGridView";
            this.EventodataGridView.ReadOnly = true;
            this.EventodataGridView.RowHeadersVisible = false;
            this.EventodataGridView.Size = new System.Drawing.Size(298, 137);
            this.EventodataGridView.TabIndex = 0;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // CantDisponible
            // 
            this.CantDisponible.HeaderText = "CantDisponible";
            this.CantDisponible.Name = "CantDisponible";
            this.CantDisponible.ReadOnly = true;
            // 
            // PrecioTicket
            // 
            this.PrecioTicket.HeaderText = "PrecioTicket";
            this.PrecioTicket.Name = "PrecioTicket";
            this.PrecioTicket.ReadOnly = true;
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbutton.Image = global::GCTickets.Properties.Resources._1458006586_Add;
            this.Agregarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Agregarbutton.Location = new System.Drawing.Point(539, 164);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 47);
            this.Agregarbutton.TabIndex = 8;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevobutton.Image = global::GCTickets.Properties.Resources._1458006564_EditDocument;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(13, 300);
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
            this.Guardarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton.Image = global::GCTickets.Properties.Resources._1458006725_Diskette;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(106, 300);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 45);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton.Image = global::GCTickets.Properties.Resources._1458006437_Cancel;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(202, 300);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 45);
            this.Eliminarbutton.TabIndex = 0;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // EventodateTimePicker
            // 
            this.EventodateTimePicker.CustomFormat = "";
            this.EventodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EventodateTimePicker.Location = new System.Drawing.Point(106, 180);
            this.EventodateTimePicker.MaxDate = new System.DateTime(2025, 12, 25, 0, 0, 0, 0);
            this.EventodateTimePicker.MinDate = new System.DateTime(2015, 12, 25, 0, 0, 0, 0);
            this.EventodateTimePicker.Name = "EventodateTimePicker";
            this.EventodateTimePicker.Size = new System.Drawing.Size(154, 20);
            this.EventodateTimePicker.TabIndex = 3;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.Image = global::GCTickets.Properties.Resources._1458006602_Magnifier;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(186, 37);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 40);
            this.Buscarbutton.TabIndex = 0;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // TipoEventocomboBox
            // 
            this.TipoEventocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoEventocomboBox.FormattingEnabled = true;
            this.TipoEventocomboBox.Location = new System.Drawing.Point(106, 91);
            this.TipoEventocomboBox.Name = "TipoEventocomboBox";
            this.TipoEventocomboBox.Size = new System.Drawing.Size(154, 21);
            this.TipoEventocomboBox.TabIndex = 1;
            // 
            // EventoIdtextBox
            // 
            this.EventoIdtextBox.Location = new System.Drawing.Point(106, 39);
            this.EventoIdtextBox.Name = "EventoIdtextBox";
            this.EventoIdtextBox.Size = new System.Drawing.Size(75, 20);
            this.EventoIdtextBox.TabIndex = 0;
            this.EventoIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EventoIdtextBox_KeyPress);
            // 
            // PrecioTtextBox
            // 
            this.PrecioTtextBox.Location = new System.Drawing.Point(452, 138);
            this.PrecioTtextBox.MaxLength = 6;
            this.PrecioTtextBox.Name = "PrecioTtextBox";
            this.PrecioTtextBox.Size = new System.Drawing.Size(162, 20);
            this.PrecioTtextBox.TabIndex = 7;
            this.PrecioTtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioTtextBox_KeyPress);
            // 
            // CantDisptextBox
            // 
            this.CantDisptextBox.Location = new System.Drawing.Point(452, 88);
            this.CantDisptextBox.MaxLength = 6;
            this.CantDisptextBox.Name = "CantDisptextBox";
            this.CantDisptextBox.Size = new System.Drawing.Size(162, 20);
            this.CantDisptextBox.TabIndex = 6;
            this.CantDisptextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantDisptextBox_KeyPress);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(451, 46);
            this.DescripciontextBox.MaxLength = 12;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(163, 20);
            this.DescripciontextBox.TabIndex = 5;
            this.DescripciontextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripciontextBox_KeyPress);
            // 
            // NombreEventotextBox
            // 
            this.NombreEventotextBox.Location = new System.Drawing.Point(106, 134);
            this.NombreEventotextBox.MaxLength = 26;
            this.NombreEventotextBox.Name = "NombreEventotextBox";
            this.NombreEventotextBox.Size = new System.Drawing.Size(154, 20);
            this.NombreEventotextBox.TabIndex = 2;
            this.NombreEventotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NombreEventotextBox_KeyPress);
            // 
            // LugarEventotextBox
            // 
            this.LugarEventotextBox.Location = new System.Drawing.Point(106, 227);
            this.LugarEventotextBox.MaxLength = 26;
            this.LugarEventotextBox.Name = "LugarEventotextBox";
            this.LugarEventotextBox.Size = new System.Drawing.Size(154, 20);
            this.LugarEventotextBox.TabIndex = 4;
            this.LugarEventotextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LugarEventotextBox_KeyPress);
            // 
            // EventoIdlabel
            // 
            this.EventoIdlabel.AutoSize = true;
            this.EventoIdlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventoIdlabel.Location = new System.Drawing.Point(37, 42);
            this.EventoIdlabel.Name = "EventoIdlabel";
            this.EventoIdlabel.Size = new System.Drawing.Size(65, 13);
            this.EventoIdlabel.TabIndex = 0;
            this.EventoIdlabel.Text = "Evento ID:";
            // 
            // TipoIdlabel
            // 
            this.TipoIdlabel.AutoSize = true;
            this.TipoIdlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoIdlabel.Location = new System.Drawing.Point(10, 94);
            this.TipoIdlabel.Name = "TipoIdlabel";
            this.TipoIdlabel.Size = new System.Drawing.Size(92, 13);
            this.TipoIdlabel.TabIndex = 0;
            this.TipoIdlabel.Text = "Tipo Evento ID:";
            // 
            // NombreEventolabel
            // 
            this.NombreEventolabel.AutoSize = true;
            this.NombreEventolabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreEventolabel.Location = new System.Drawing.Point(8, 137);
            this.NombreEventolabel.Name = "NombreEventolabel";
            this.NombreEventolabel.Size = new System.Drawing.Size(96, 13);
            this.NombreEventolabel.TabIndex = 0;
            this.NombreEventolabel.Text = "Nombre Evento:";
            // 
            // FechaEventolabel
            // 
            this.FechaEventolabel.AutoSize = true;
            this.FechaEventolabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaEventolabel.Location = new System.Drawing.Point(17, 180);
            this.FechaEventolabel.Name = "FechaEventolabel";
            this.FechaEventolabel.Size = new System.Drawing.Size(85, 13);
            this.FechaEventolabel.TabIndex = 0;
            this.FechaEventolabel.Text = "Fecha Evento:";
            // 
            // LugarEventolabel
            // 
            this.LugarEventolabel.AutoSize = true;
            this.LugarEventolabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LugarEventolabel.Location = new System.Drawing.Point(18, 227);
            this.LugarEventolabel.Name = "LugarEventolabel";
            this.LugarEventolabel.Size = new System.Drawing.Size(84, 13);
            this.LugarEventolabel.TabIndex = 0;
            this.LugarEventolabel.Text = "Lugar Evento:";
            // 
            // Descripcionlabel
            // 
            this.Descripcionlabel.AutoSize = true;
            this.Descripcionlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcionlabel.Location = new System.Drawing.Point(370, 46);
            this.Descripcionlabel.Name = "Descripcionlabel";
            this.Descripcionlabel.Size = new System.Drawing.Size(75, 13);
            this.Descripcionlabel.TabIndex = 0;
            this.Descripcionlabel.Text = "Descripcion:";
            // 
            // CantDisplabel
            // 
            this.CantDisplabel.AutoSize = true;
            this.CantDisplabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantDisplabel.Location = new System.Drawing.Point(325, 91);
            this.CantDisplabel.Name = "CantDisplabel";
            this.CantDisplabel.Size = new System.Drawing.Size(121, 13);
            this.CantDisplabel.TabIndex = 0;
            this.CantDisplabel.Text = "Cantidad Disponible:";
            // 
            // PrecioTlabel
            // 
            this.PrecioTlabel.AutoSize = true;
            this.PrecioTlabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioTlabel.Location = new System.Drawing.Point(363, 141);
            this.PrecioTlabel.Name = "PrecioTlabel";
            this.PrecioTlabel.Size = new System.Drawing.Size(83, 13);
            this.PrecioTlabel.TabIndex = 0;
            this.PrecioTlabel.Text = "Precio Ticket:";
            // 
            // EventoserrorProvider
            // 
            this.EventoserrorProvider.ContainerControl = this;
            // 
            // EventosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(630, 370);
            this.Controls.Add(this.PrecioTlabel);
            this.Controls.Add(this.CantDisplabel);
            this.Controls.Add(this.Descripcionlabel);
            this.Controls.Add(this.LugarEventolabel);
            this.Controls.Add(this.FechaEventolabel);
            this.Controls.Add(this.NombreEventolabel);
            this.Controls.Add(this.TipoIdlabel);
            this.Controls.Add(this.EventoIdlabel);
            this.Controls.Add(this.LugarEventotextBox);
            this.Controls.Add(this.NombreEventotextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.CantDisptextBox);
            this.Controls.Add(this.PrecioTtextBox);
            this.Controls.Add(this.EventoIdtextBox);
            this.Controls.Add(this.TipoEventocomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.EventodateTimePicker);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.EventodataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EventosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GC Tickets";
            this.Load += new System.EventHandler(this.EventosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EventodataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventoserrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.DataGridView EventodataGridView;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.DateTimePicker EventodateTimePicker;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ComboBox TipoEventocomboBox;
        private System.Windows.Forms.TextBox EventoIdtextBox;
        private System.Windows.Forms.TextBox PrecioTtextBox;
        private System.Windows.Forms.TextBox CantDisptextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox NombreEventotextBox;
        private System.Windows.Forms.TextBox LugarEventotextBox;
        private System.Windows.Forms.Label EventoIdlabel;
        private System.Windows.Forms.Label TipoIdlabel;
        private System.Windows.Forms.Label NombreEventolabel;
        private System.Windows.Forms.Label FechaEventolabel;
        private System.Windows.Forms.Label LugarEventolabel;
        private System.Windows.Forms.Label Descripcionlabel;
        private System.Windows.Forms.Label CantDisplabel;
        private System.Windows.Forms.Label PrecioTlabel;
        private System.Windows.Forms.ErrorProvider EventoserrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTicket;
    }
}