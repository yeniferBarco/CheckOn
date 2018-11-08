namespace CheckOn
{
    partial class FrmCallCenterMaleta
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grbCallCenterVuelo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDocumentoUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscarVuelo = new System.Windows.Forms.Button();
            this.lbInfoMaleta = new System.Windows.Forms.ListBox();
            this.cmbOpciones = new System.Windows.Forms.ComboBox();

            this.lbInfoPasajero = new System.Windows.Forms.ListBox();
            this.btnVerMapa = new System.Windows.Forms.Button();

            this.btnVolver = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbCallCenterVuelo.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;

            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.43685F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.56315F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124F));

            this.tableLayoutPanel1.Controls.Add(this.grbCallCenterVuelo, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.055961F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.94404F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(815, 453);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // grbCallCenterVuelo
            // 
            this.grbCallCenterVuelo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCallCenterVuelo.AutoSize = true;
            this.grbCallCenterVuelo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbCallCenterVuelo.Controls.Add(this.tableLayoutPanel3);
            this.grbCallCenterVuelo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            this.grbCallCenterVuelo.Location = new System.Drawing.Point(158, 32);
            this.grbCallCenterVuelo.Name = "grbCallCenterVuelo";
            this.grbCallCenterVuelo.Size = new System.Drawing.Size(529, 376);

            this.grbCallCenterVuelo.TabIndex = 2;
            this.grbCallCenterVuelo.TabStop = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnVolver, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1, 26);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.63636F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.36364F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(529, 323);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.Controls.Add(this.txtDocumentoUsuario, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnVerMapa, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscarVuelo, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbInfoMaleta, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbOpciones, 0, 1);

            this.tableLayoutPanel2.Controls.Add(this.lbInfoPasajero, 0, 2);

            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.69663F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.30337F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(523, 196);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // txtDocumentoUsuario
            // 
            this.txtDocumentoUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocumentoUsuario.Location = new System.Drawing.Point(236, 28);
            this.txtDocumentoUsuario.MaxLength = 20;
            this.txtDocumentoUsuario.Name = "txtDocumentoUsuario";
            this.txtDocumentoUsuario.Size = new System.Drawing.Size(193, 20);
            this.txtDocumentoUsuario.TabIndex = 6;
            this.txtDocumentoUsuario.TextChanged += new System.EventHandler(this.txtDocumentoUsuario_TextChanged);
            // 
            // btnBuscarVuelo
            // 
            this.btnBuscarVuelo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnBuscarVuelo.BackColor = System.Drawing.SystemColors.Menu;
            this.btnBuscarVuelo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarVuelo.Location = new System.Drawing.Point(438, 26);
            this.btnBuscarVuelo.Name = "btnBuscarVuelo";
            this.btnBuscarVuelo.Size = new System.Drawing.Size(78, 25);
            this.btnBuscarVuelo.TabIndex = 4;
            this.btnBuscarVuelo.Text = "BUSCAR";
            this.btnBuscarVuelo.UseVisualStyleBackColor = false;
            this.btnBuscarVuelo.Click += new System.EventHandler(this.btnBuscarVuelo_Click_1);
            // 
            // lbInfoMaleta
            // 
            this.lbInfoMaleta.FormattingEnabled = true;
            this.lbInfoMaleta.Location = new System.Drawing.Point(236, 57);
            this.lbInfoMaleta.Name = "lbInfoMaleta";
            this.lbInfoMaleta.Size = new System.Drawing.Size(193, 134);
            this.lbInfoMaleta.TabIndex = 11;
            // 
            // cmbOpciones
            // 

            this.cmbOpciones.Anchor = System.Windows.Forms.AnchorStyles.None;

            this.cmbOpciones.FormattingEnabled = true;
            this.cmbOpciones.Items.AddRange(new object[] {
            "-- Selecione una opcion --",
            "Cedula del pasajero",
            "ID Maleta"});

            this.cmbOpciones.Location = new System.Drawing.Point(34, 28);
            this.cmbOpciones.Name = "cmbOpciones";
            this.cmbOpciones.Size = new System.Drawing.Size(165, 21);
            this.cmbOpciones.TabIndex = 12;
            // 

            // lbInfoPasajero
            // 
            this.lbInfoPasajero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInfoPasajero.FormattingEnabled = true;
            this.lbInfoPasajero.Location = new System.Drawing.Point(11, 58);
            this.lbInfoPasajero.Name = "lbInfoPasajero";
            this.lbInfoPasajero.Size = new System.Drawing.Size(210, 134);
            this.lbInfoPasajero.TabIndex = 10;
            // 
            // btnVerMapa
            // 
            this.btnVerMapa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerMapa.BackColor = System.Drawing.SystemColors.Menu;
            this.btnVerMapa.Location = new System.Drawing.Point(435, 170);
            this.btnVerMapa.Name = "btnVerMapa";
            this.btnVerMapa.Size = new System.Drawing.Size(85, 23);
            this.btnVerMapa.TabIndex = 6;
            this.btnVerMapa.Text = "Ver Mapa";
            this.btnVerMapa.UseVisualStyleBackColor = false;
            this.btnVerMapa.Click += new System.EventHandler(this.btnVerMapa_Click);

            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.BackColor = System.Drawing.SystemColors.Menu;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolver.Location = new System.Drawing.Point(204, 296);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(121, 24);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 477);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(815, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FrmCallCenterMaleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 499);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmCallCenterMaleta";
            this.Text = "Call center maleta";
            this.Load += new System.EventHandler(this.FrmCallCenterMaleta_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grbCallCenterVuelo.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtDocumentoUsuario;
        private System.Windows.Forms.Button btnBuscarVuelo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListBox lbInfoPasajero;
        private System.Windows.Forms.ListBox lbInfoMaleta;
        private System.Windows.Forms.ComboBox cmbOpciones;

        private System.Windows.Forms.Button btnVerMapa;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.GroupBox grbCallCenterVuelo;
        public System.Windows.Forms.Button btnVolver;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

    }
}