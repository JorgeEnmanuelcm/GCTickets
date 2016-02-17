namespace GCTickets
{
    partial class PagPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagPrincipalForm));
            this.PagPrincipalmenuStrip = new System.Windows.Forms.MenuStrip();
            this.PagPrincipaltoolStrip = new System.Windows.Forms.ToolStrip();
            this.UsuariostoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.VentastoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PagPrincipaltoolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PagPrincipalmenuStrip
            // 
            this.PagPrincipalmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PagPrincipalmenuStrip.Name = "PagPrincipalmenuStrip";
            this.PagPrincipalmenuStrip.Size = new System.Drawing.Size(659, 24);
            this.PagPrincipalmenuStrip.TabIndex = 0;
            this.PagPrincipalmenuStrip.Text = "PagPrincipalmenuStrip";
            // 
            // PagPrincipaltoolStrip
            // 
            this.PagPrincipaltoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.UsuariostoolStripButton,
            this.toolStripSeparator2,
            this.VentastoolStripButton});
            this.PagPrincipaltoolStrip.Location = new System.Drawing.Point(0, 24);
            this.PagPrincipaltoolStrip.Name = "PagPrincipaltoolStrip";
            this.PagPrincipaltoolStrip.Size = new System.Drawing.Size(659, 25);
            this.PagPrincipaltoolStrip.TabIndex = 1;
            this.PagPrincipaltoolStrip.Text = "PagPrincipaltoolStrip";
            // 
            // UsuariostoolStripButton
            // 
            this.UsuariostoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UsuariostoolStripButton.Image = global::GCTickets.Properties.Resources._1455583405_userconfig;
            this.UsuariostoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UsuariostoolStripButton.Name = "UsuariostoolStripButton";
            this.UsuariostoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.UsuariostoolStripButton.Text = "UsuariostoolStripButton";
            // 
            // VentastoolStripButton
            // 
            this.VentastoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VentastoolStripButton.Image = global::GCTickets.Properties.Resources._1455739878_create_ticket;
            this.VentastoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VentastoolStripButton.Name = "VentastoolStripButton";
            this.VentastoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.VentastoolStripButton.Text = "VentastoolStripButton";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // PagPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 413);
            this.Controls.Add(this.PagPrincipaltoolStrip);
            this.Controls.Add(this.PagPrincipalmenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.PagPrincipalmenuStrip;
            this.Name = "PagPrincipalForm";
            this.Text = "GC Tickets";
            this.PagPrincipaltoolStrip.ResumeLayout(false);
            this.PagPrincipaltoolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip PagPrincipalmenuStrip;
        private System.Windows.Forms.ToolStrip PagPrincipaltoolStrip;
        private System.Windows.Forms.ToolStripButton UsuariostoolStripButton;
        private System.Windows.Forms.ToolStripButton VentastoolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

