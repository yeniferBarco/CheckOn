namespace CheckOn
{
    partial class FrmAsesorInfoVuelo
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
            this.tblAsesor = new System.Windows.Forms.TableLayoutPanel();
            this.grbAsesor = new System.Windows.Forms.GroupBox();
            this.lbInfoVuelo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btmBuscar = new System.Windows.Forms.Button();
            this.txtIdVuelo = new System.Windows.Forms.TextBox();
            this.btnAggPasajero = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tblAsesor.SuspendLayout();
            this.grbAsesor.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblAsesor
            // 
            this.tblAsesor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblAsesor.ColumnCount = 3;
            this.tblAsesor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.98013F));
            this.tblAsesor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.01987F));
            this.tblAsesor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblAsesor.Controls.Add(this.grbAsesor, 1, 1);
            this.tblAsesor.Location = new System.Drawing.Point(1, 16);
            this.tblAsesor.Name = "tblAsesor";
            this.tblAsesor.RowCount = 3;
            this.tblAsesor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.81481F));
            this.tblAsesor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.18519F));
            this.tblAsesor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tblAsesor.Size = new System.Drawing.Size(861, 460);
            this.tblAsesor.TabIndex = 4;
            // 
            // grbAsesor
            // 
            this.grbAsesor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAsesor.AutoSize = true;
            this.grbAsesor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbAsesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grbAsesor.Controls.Add(this.lbInfoVuelo);
            this.grbAsesor.Controls.Add(this.button1);
            this.grbAsesor.Controls.Add(this.btnAggPasajero);
            this.grbAsesor.Controls.Add(this.label1);
            this.grbAsesor.Controls.Add(this.btmBuscar);
            this.grbAsesor.Controls.Add(this.txtIdVuelo);
            this.grbAsesor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbAsesor.Location = new System.Drawing.Point(210, 67);
            this.grbAsesor.Name = "grbAsesor";
            this.grbAsesor.Size = new System.Drawing.Size(527, 362);
            this.grbAsesor.TabIndex = 0;
            this.grbAsesor.TabStop = false;
            // 
            // lbInfoVuelo
            // 
            this.lbInfoVuelo.FormattingEnabled = true;
            this.lbInfoVuelo.Location = new System.Drawing.Point(73, 107);
            this.lbInfoVuelo.Name = "lbInfoVuelo";
            this.lbInfoVuelo.Size = new System.Drawing.Size(390, 160);
            this.lbInfoVuelo.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id del vuelo";
            // 
            // btmBuscar
            // 
            this.btmBuscar.Location = new System.Drawing.Point(326, 59);
            this.btmBuscar.Name = "btmBuscar";
            this.btmBuscar.Size = new System.Drawing.Size(86, 23);
            this.btmBuscar.TabIndex = 2;
            this.btmBuscar.Text = "Buscar";
            this.btmBuscar.UseVisualStyleBackColor = true;
            this.btmBuscar.Click += new System.EventHandler(this.btmBuscar_Click);
            // 
            // txtIdVuelo
            // 
            this.txtIdVuelo.Location = new System.Drawing.Point(179, 61);
            this.txtIdVuelo.Name = "txtIdVuelo";
            this.txtIdVuelo.Size = new System.Drawing.Size(103, 20);
            this.txtIdVuelo.TabIndex = 1;
            // 
            // btnAggPasajero
            // 
            this.btnAggPasajero.Location = new System.Drawing.Point(289, 283);
            this.btnAggPasajero.Name = "btnAggPasajero";
            this.btnAggPasajero.Size = new System.Drawing.Size(103, 23);
            this.btnAggPasajero.TabIndex = 18;
            this.btnAggPasajero.Text = "Agregar Pasajero";
            this.btnAggPasajero.UseVisualStyleBackColor = true;
            this.btnAggPasajero.Click += new System.EventHandler(this.btnAggPasajero_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAsesorInfoVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 497);
            this.Controls.Add(this.tblAsesor);
            this.Name = "FrmAsesorInfoVuelo";
            this.Text = "FrmAsesorInfoVuelo";
            this.tblAsesor.ResumeLayout(false);
            this.tblAsesor.PerformLayout();
            this.grbAsesor.ResumeLayout(false);
            this.grbAsesor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblAsesor;
        private System.Windows.Forms.GroupBox grbAsesor;
        private System.Windows.Forms.Button btmBuscar;
        private System.Windows.Forms.TextBox txtIdVuelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbInfoVuelo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAggPasajero;
    }
}