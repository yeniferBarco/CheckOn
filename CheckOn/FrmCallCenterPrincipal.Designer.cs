namespace CheckOn
{
    partial class FrmCallCenterPrincipal
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
            this.grbCallCenter = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tblAsesor = new System.Windows.Forms.TableLayoutPanel();
            this.grbAsesor = new System.Windows.Forms.GroupBox();
            this.lbInfoVuelo = new System.Windows.Forms.ListBox();
            this.btnBuscarMaleta = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btmBuscar = new System.Windows.Forms.Button();
            this.txtIdVuelo = new System.Windows.Forms.TextBox();
            this.grbCallCenter.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tblAsesor.SuspendLayout();
            this.grbAsesor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCallCenter
            // 
            this.grbCallCenter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbCallCenter.Controls.Add(this.tableLayoutPanel3);
            this.grbCallCenter.Location = new System.Drawing.Point(213, 67);
            this.grbCallCenter.Name = "grbCallCenter";
            this.grbCallCenter.Size = new System.Drawing.Size(535, 362);
            this.grbCallCenter.TabIndex = 0;
            this.grbCallCenter.TabStop = false;
            // 

            // tblAsesor
            // 
            this.tblAsesor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblAsesor.ColumnCount = 3;
            this.tblAsesor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.98013F));
            this.tblAsesor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.01987F));
            this.tblAsesor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tblAsesor.Controls.Add(this.grbAsesor, 1, 1);
            this.tblAsesor.Location = new System.Drawing.Point(-163, -49);
            this.tblAsesor.Name = "tblAsesor";
            this.tblAsesor.RowCount = 3;
            this.tblAsesor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.81481F));
            this.tblAsesor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.18519F));
            this.tblAsesor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tblAsesor.Size = new System.Drawing.Size(861, 460);
            this.tblAsesor.TabIndex = 5;
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
            this.grbAsesor.Controls.Add(this.btnBuscarMaleta);
            this.grbAsesor.Controls.Add(this.btnBorrar);
            this.grbAsesor.Controls.Add(this.label1);
            this.grbAsesor.Controls.Add(this.btmBuscar);
            this.grbAsesor.Controls.Add(this.txtIdVuelo);
            this.grbAsesor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbAsesor.Location = new System.Drawing.Point(208, 67);
            this.grbAsesor.Name = "grbAsesor";
            this.grbAsesor.Size = new System.Drawing.Size(521, 362);
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
            // btnBuscarMaleta
            // 
            this.btnBuscarMaleta.Location = new System.Drawing.Point(285, 286);
            this.btnBuscarMaleta.Name = "btnBuscarMaleta";
            this.btnBuscarMaleta.Size = new System.Drawing.Size(102, 23);
            this.btnBuscarMaleta.TabIndex = 19;
            this.btnBuscarMaleta.Text = "Buscar Maleta";
            this.btnBuscarMaleta.UseVisualStyleBackColor = true;
            this.btnBuscarMaleta.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(164, 286);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(69, 23);
            this.btnBorrar.TabIndex = 18;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnAggPasajero_Click);
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

            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.63636F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.36364F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(518, 323);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblNombre, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscar, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDocumento, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblTipoUsuario, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtUsuario, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtNombre, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 65);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.69663F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.30337F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(512, 196);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(3, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 34);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Código Vuelo";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(293, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(216, 28);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // lblDocumento
            // 
            this.lblDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(3, 124);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(73, 36);
            this.lblDocumento.TabIndex = 9;
            this.lblDocumento.Text = "Vuelo nacional";
            this.lblDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(82, 127);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(3, 160);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(73, 36);
            this.lblTipoUsuario.TabIndex = 13;
            this.lblTipoUsuario.Text = "Vuelo internacional";
            this.lblTipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(82, 163);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(177, 20);
            this.txtUsuario.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(82, 29);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(177, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 62);
            this.label2.TabIndex = 3;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // tblAsesor
            // 
            this.tblAsesor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tblAsesor.ColumnCount = 3;
            this.tblAsesor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.52113F));
            this.tblAsesor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.47887F));
            this.tblAsesor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tblAsesor.Controls.Add(this.grbAsesor, 1, 1);
            this.tblAsesor.Location = new System.Drawing.Point(12, 12);
            this.tblAsesor.Name = "tblAsesor";
            this.tblAsesor.RowCount = 3;
            this.tblAsesor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.81481F));
            this.tblAsesor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.18519F));
            this.tblAsesor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tblAsesor.Size = new System.Drawing.Size(839, 460);
            this.tblAsesor.TabIndex = 5;
            // 
            // grbAsesor
            // 
            this.grbAsesor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbAsesor.AutoSize = true;
            this.grbAsesor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grbAsesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grbAsesor.Controls.Add(this.lbInfoVuelo);
            this.grbAsesor.Controls.Add(this.btnBuscarMaleta);
            this.grbAsesor.Controls.Add(this.btnBorrar);
            this.grbAsesor.Controls.Add(this.label1);
            this.grbAsesor.Controls.Add(this.btmBuscar);
            this.grbAsesor.Controls.Add(this.txtIdVuelo);
            this.grbAsesor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbAsesor.Location = new System.Drawing.Point(165, 67);
            this.grbAsesor.Name = "grbAsesor";
            this.grbAsesor.Size = new System.Drawing.Size(521, 362);
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
            // btnBuscarMaleta
            // 
            this.btnBuscarMaleta.BackColor = System.Drawing.SystemColors.Menu;
            this.btnBuscarMaleta.Location = new System.Drawing.Point(287, 308);
            this.btnBuscarMaleta.Name = "btnBuscarMaleta";
            this.btnBuscarMaleta.Size = new System.Drawing.Size(102, 23);
            this.btnBuscarMaleta.TabIndex = 4;
            this.btnBuscarMaleta.Text = "Buscar Maleta";
            this.btnBuscarMaleta.UseVisualStyleBackColor = false;
            this.btnBuscarMaleta.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnBorrar.Location = new System.Drawing.Point(166, 308);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(69, 23);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnAggPasajero_Click);
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
            this.btmBuscar.BackColor = System.Drawing.SystemColors.Menu;
            this.btmBuscar.Location = new System.Drawing.Point(326, 59);
            this.btmBuscar.Name = "btmBuscar";
            this.btmBuscar.Size = new System.Drawing.Size(86, 23);
            this.btmBuscar.TabIndex = 2;
            this.btmBuscar.Text = "Buscar";
            this.btmBuscar.UseVisualStyleBackColor = false;
            this.btmBuscar.Click += new System.EventHandler(this.btmBuscar_Click);
            // 
            // txtIdVuelo
            // 
            this.txtIdVuelo.Location = new System.Drawing.Point(179, 61);
            this.txtIdVuelo.Name = "txtIdVuelo";
            this.txtIdVuelo.Size = new System.Drawing.Size(103, 20);
            this.txtIdVuelo.TabIndex = 1;
            // 
            // FrmCallCenterPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 497);
            this.Controls.Add(this.tblAsesor);
            this.Controls.Add(this.grbCallCenter);
            this.Name = "FrmCallCenterPrincipal";
            this.Text = "FrmCallCenterPrincipal";
            this.grbCallCenter.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tblAsesor.ResumeLayout(false);
            this.tblAsesor.PerformLayout();
            this.grbAsesor.ResumeLayout(false);
            this.grbAsesor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCallCenter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TableLayoutPanel tblAsesor;
        private System.Windows.Forms.GroupBox grbAsesor;
        private System.Windows.Forms.ListBox lbInfoVuelo;
        private System.Windows.Forms.Button btnBuscarMaleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btmBuscar;
        private System.Windows.Forms.TextBox txtIdVuelo;
        private System.Windows.Forms.Button btnBorrar;
    }
}