namespace GCTickets
{
    partial class AyudaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AyudaForm));
            this.AyudarichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // AyudarichTextBox
            // 
            this.AyudarichTextBox.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AyudarichTextBox.Location = new System.Drawing.Point(12, 12);
            this.AyudarichTextBox.Name = "AyudarichTextBox";
            this.AyudarichTextBox.ReadOnly = true;
            this.AyudarichTextBox.Size = new System.Drawing.Size(260, 202);
            this.AyudarichTextBox.TabIndex = 0;
            this.AyudarichTextBox.Text = resources.GetString("AyudarichTextBox.Text");
            // 
            // AyudaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(164)))));
            this.ClientSize = new System.Drawing.Size(284, 226);
            this.Controls.Add(this.AyudarichTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AyudaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayuda";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox AyudarichTextBox;
    }
}