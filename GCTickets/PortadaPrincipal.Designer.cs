namespace GCTickets
{
    partial class PortadaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortadaPrincipal));
            this.PortadamenuStrip = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroTipoEvenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoEventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoEventoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.PortadatoolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.PortadamenuStrip.SuspendLayout();
            this.PortadatoolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortadamenuStrip
            // 
            this.PortadamenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.PortadamenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PortadamenuStrip.Name = "PortadamenuStrip";
            this.PortadamenuStrip.Size = new System.Drawing.Size(681, 24);
            this.PortadamenuStrip.TabIndex = 0;
            this.PortadamenuStrip.Text = "PortadamenuStrip";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroUsuariosToolStripMenuItem,
            this.registroTipoEvenoToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registroUsuariosToolStripMenuItem
            // 
            this.registroUsuariosToolStripMenuItem.Name = "registroUsuariosToolStripMenuItem";
            this.registroUsuariosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registroUsuariosToolStripMenuItem.Text = "Registro Usuarios";
            this.registroUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registroUsuariosToolStripMenuItem_Click);
            // 
            // registroTipoEvenoToolStripMenuItem
            // 
            this.registroTipoEvenoToolStripMenuItem.Name = "registroTipoEvenoToolStripMenuItem";
            this.registroTipoEvenoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registroTipoEvenoToolStripMenuItem.Text = "Registro Tipo Evento";
            this.registroTipoEvenoToolStripMenuItem.Click += new System.EventHandler(this.registroTipoEvenoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.tipoEventoToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // tipoEventoToolStripMenuItem
            // 
            this.tipoEventoToolStripMenuItem.Name = "tipoEventoToolStripMenuItem";
            this.tipoEventoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.tipoEventoToolStripMenuItem.Text = "Tipo Evento";
            this.tipoEventoToolStripMenuItem.Click += new System.EventHandler(this.tipoEventoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoEventoToolStripMenuItem1});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // tipoEventoToolStripMenuItem1
            // 
            this.tipoEventoToolStripMenuItem1.Name = "tipoEventoToolStripMenuItem1";
            this.tipoEventoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.tipoEventoToolStripMenuItem1.Text = "Tipo Evento";
            this.tipoEventoToolStripMenuItem1.Click += new System.EventHandler(this.tipoEventoToolStripMenuItem1_Click);
            // 
            // PortadatoolStrip
            // 
            this.PortadatoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.PortadatoolStrip.Location = new System.Drawing.Point(0, 24);
            this.PortadatoolStrip.Name = "PortadatoolStrip";
            this.PortadatoolStrip.Size = new System.Drawing.Size(681, 25);
            this.PortadatoolStrip.TabIndex = 1;
            this.PortadatoolStrip.Text = "PortadatoolStrip";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // PortadaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 368);
            this.Controls.Add(this.PortadatoolStrip);
            this.Controls.Add(this.PortadamenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.PortadamenuStrip;
            this.Name = "PortadaPrincipal";
            this.Text = "Portada Principal";
            this.PortadamenuStrip.ResumeLayout(false);
            this.PortadamenuStrip.PerformLayout();
            this.PortadatoolStrip.ResumeLayout(false);
            this.PortadatoolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip PortadamenuStrip;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroTipoEvenoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip PortadatoolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoEventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoEventoToolStripMenuItem1;
    }
}