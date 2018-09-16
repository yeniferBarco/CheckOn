namespace CheckOn
{
    partial class FrmAsesorPrincipal
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
            this.tblRegistro = new System.Windows.Forms.TableLayoutPanel();
            this.grbRegistro = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCrearVuelo = new System.Windows.Forms.Button();
            this.btnBuscarVuelo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tblRegistro.SuspendLayout();
            this.grbRegistro.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblRegistro
            // 
            this.tblRegistro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblRegistro.ColumnCount = 3;
            this.tblRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.98013F));
            this.tblRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.01987F));
            this.tblRegistro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tblRegistro.Controls.Add(this.grbRegistro, 1, 1);
            this.tblRegistro.Location = new System.Drawing.Point(1, 20);
            this.tblRegistro.Name = "tblRegistro";
            this.tblRegistro.RowCount = 3;
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.81481F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.18519F));
            this.tblRegistro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tblRegistro.Size = new System.Drawing.Size(861, 460);
            this.tblRegistro.TabIndex = 3;
            this.tblRegistro.Paint += new System.Windows.Forms.PaintEventHandler(this.tblRegistro_Paint);
            // 
            // grbRegistro
            // 
            this.grbRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbRegistro.AutoSize = true;
            this.grbRegistro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grbRegistro.Controls.Add(this.tableLayoutPanel3);
            this.grbRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbRegistro.Location = new System.Drawing.Point(212, 67);
            this.grbRegistro.Name = "grbRegistro";
            this.grbRegistro.Size = new System.Drawing.Size(534, 362);
            this.grbRegistro.TabIndex = 0;
            this.grbRegistro.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 26);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.63636F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.36364F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(522, 323);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnCrearVuelo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscarVuelo, 2, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.22222F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.77778F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(516, 196);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnCrearVuelo
            // 
            this.btnCrearVuelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCrearVuelo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCrearVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearVuelo.Location = new System.Drawing.Point(19, 93);
            this.btnCrearVuelo.Name = "btnCrearVuelo";
            this.btnCrearVuelo.Size = new System.Drawing.Size(206, 29);
            this.btnCrearVuelo.TabIndex = 4;
            this.btnCrearVuelo.Text = "CREAR VUELO";
            this.btnCrearVuelo.UseVisualStyleBackColor = false;
            this.btnCrearVuelo.Click += new System.EventHandler(this.btnCrearVuelo_Click);
            // 
            // btnBuscarVuelo
            // 
            this.btnBuscarVuelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBuscarVuelo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBuscarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarVuelo.Location = new System.Drawing.Point(286, 93);
            this.btnBuscarVuelo.Name = "btnBuscarVuelo";
            this.btnBuscarVuelo.Size = new System.Drawing.Size(206, 29);
            this.btnBuscarVuelo.TabIndex = 5;
            this.btnBuscarVuelo.Text = "BUSCAR VUELO";
            this.btnBuscarVuelo.UseVisualStyleBackColor = false;
            this.btnBuscarVuelo.Click += new System.EventHandler(this.btnBuscarVuelo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(863, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmAsesorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 497);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tblRegistro);
            this.Name = "FrmAsesorPrincipal";
            this.Text = "Asesor de aerolínea";
            this.tblRegistro.ResumeLayout(false);
            this.tblRegistro.PerformLayout();
            this.grbRegistro.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblRegistro;
        private System.Windows.Forms.GroupBox grbRegistro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCrearVuelo;
        private System.Windows.Forms.Button btnBuscarVuelo;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}