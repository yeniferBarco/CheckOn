namespace CheckOn
{
    partial class FrmAsesorAsignarCodigo
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCodMaleta = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.grbCallCenterVuelo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.57232F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.42768F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel1.Controls.Add(this.grbCallCenterVuelo, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-24, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.92661F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.07339F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(862, 453);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // grbCallCenterVuelo
            // 
            this.grbCallCenterVuelo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCallCenterVuelo.AutoSize = true;
            this.grbCallCenterVuelo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grbCallCenterVuelo.Controls.Add(this.button1);
            this.grbCallCenterVuelo.Controls.Add(this.btnRegistrar);
            this.grbCallCenterVuelo.Controls.Add(this.label4);
            this.grbCallCenterVuelo.Controls.Add(this.label3);
            this.grbCallCenterVuelo.Controls.Add(this.label2);
            this.grbCallCenterVuelo.Controls.Add(this.label1);
            this.grbCallCenterVuelo.Controls.Add(this.txtApellidos);
            this.grbCallCenterVuelo.Controls.Add(this.txtCodMaleta);
            this.grbCallCenterVuelo.Controls.Add(this.txtCedula);
            this.grbCallCenterVuelo.Controls.Add(this.txtNombres);
            this.grbCallCenterVuelo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbCallCenterVuelo.Location = new System.Drawing.Point(181, 52);
            this.grbCallCenterVuelo.Name = "grbCallCenterVuelo";
            this.grbCallCenterVuelo.Size = new System.Drawing.Size(541, 356);
            this.grbCallCenterVuelo.TabIndex = 2;
            this.grbCallCenterVuelo.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(184, 263);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Codigo Maleta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellidos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombres";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(257, 104);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(121, 20);
            this.txtApellidos.TabIndex = 3;
            // 
            // txtCodMaleta
            // 
            this.txtCodMaleta.Location = new System.Drawing.Point(257, 190);
            this.txtCodMaleta.Name = "txtCodMaleta";
            this.txtCodMaleta.Size = new System.Drawing.Size(121, 20);
            this.txtCodMaleta.TabIndex = 2;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(257, 147);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(121, 20);
            this.txtCedula.TabIndex = 1;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(257, 62);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(121, 20);
            this.txtNombres.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAsesorAsignarCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 499);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAsesorAsignarCodigo";
            this.Text = "Asignar código a maleta";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.grbCallCenterVuelo.ResumeLayout(false);
            this.grbCallCenterVuelo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grbCallCenterVuelo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCodMaleta;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Button button1;
    }
}