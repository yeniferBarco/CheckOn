namespace CheckOn
{
    partial class FrmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicial));
            this.prbCargaInicial = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // prbCargaInicial
            // 
            this.prbCargaInicial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.prbCargaInicial.Location = new System.Drawing.Point(298, 423);
            this.prbCargaInicial.Name = "prbCargaInicial";
            this.prbCargaInicial.Size = new System.Drawing.Size(507, 23);
            this.prbCargaInicial.TabIndex = 0;
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(843, 492);
            this.Controls.Add(this.prbCargaInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInicial";
            this.Text = "pantalla inicial";
            this.Load += new System.EventHandler(this.FrmInicial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prbCargaInicial;
    }
}