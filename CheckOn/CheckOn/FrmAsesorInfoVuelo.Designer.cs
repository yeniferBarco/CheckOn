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
            this.btnAggPasajero = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTipoVuelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaLlegada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaSalida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoraLlegada = new System.Windows.Forms.TextBox();
            this.lblHoraLlegada = new System.Windows.Forms.Label();
            this.txtHoraSalida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.btmBuscar = new System.Windows.Forms.Button();
            this.txtIdVuelo = new System.Windows.Forms.TextBox();
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
            this.tblAsesor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
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
            this.grbAsesor.Controls.Add(this.button1);
            this.grbAsesor.Controls.Add(this.btnAggPasajero);
            this.grbAsesor.Controls.Add(this.label7);
            this.grbAsesor.Controls.Add(this.txtDestino);
            this.grbAsesor.Controls.Add(this.label6);
            this.grbAsesor.Controls.Add(this.txtTipoVuelo);
            this.grbAsesor.Controls.Add(this.label5);
            this.grbAsesor.Controls.Add(this.txtDiaLlegada);
            this.grbAsesor.Controls.Add(this.label4);
            this.grbAsesor.Controls.Add(this.txtDiaSalida);
            this.grbAsesor.Controls.Add(this.label3);
            this.grbAsesor.Controls.Add(this.txtHoraLlegada);
            this.grbAsesor.Controls.Add(this.lblHoraLlegada);
            this.grbAsesor.Controls.Add(this.txtHoraSalida);
            this.grbAsesor.Controls.Add(this.label2);
            this.grbAsesor.Controls.Add(this.label1);
            this.grbAsesor.Controls.Add(this.txtOrigen);
            this.grbAsesor.Controls.Add(this.btmBuscar);
            this.grbAsesor.Controls.Add(this.txtIdVuelo);
            this.grbAsesor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grbAsesor.Location = new System.Drawing.Point(211, 67);
            this.grbAsesor.Name = "grbAsesor";
            this.grbAsesor.Size = new System.Drawing.Size(529, 362);
            this.grbAsesor.TabIndex = 0;
            this.grbAsesor.TabStop = false;
            // 
            // btnAggPasajero
            // 
            this.btnAggPasajero.Location = new System.Drawing.Point(294, 296);
            this.btnAggPasajero.Name = "btnAggPasajero";
            this.btnAggPasajero.Size = new System.Drawing.Size(115, 23);
            this.btnAggPasajero.TabIndex = 18;
            this.btnAggPasajero.Text = "Agregar Pasajero";
            this.btnAggPasajero.UseVisualStyleBackColor = true;
            this.btnAggPasajero.Click += new System.EventHandler(this.btnAggPasajero_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Destino";
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(378, 245);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(107, 20);
            this.txtDestino.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Origen";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTipoVuelo
            // 
            this.txtTipoVuelo.Location = new System.Drawing.Point(145, 205);
            this.txtTipoVuelo.Name = "txtTipoVuelo";
            this.txtTipoVuelo.Size = new System.Drawing.Size(107, 20);
            this.txtTipoVuelo.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tipo de vuelo";
            // 
            // txtDiaLlegada
            // 
            this.txtDiaLlegada.Location = new System.Drawing.Point(382, 166);
            this.txtDiaLlegada.Name = "txtDiaLlegada";
            this.txtDiaLlegada.Size = new System.Drawing.Size(80, 20);
            this.txtDiaLlegada.TabIndex = 12;
            this.txtDiaLlegada.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = " Dia de llegada\r\n(DD/MM/YYYY)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDiaSalida
            // 
            this.txtDiaSalida.Location = new System.Drawing.Point(159, 166);
            this.txtDiaSalida.Name = "txtDiaSalida";
            this.txtDiaSalida.Size = new System.Drawing.Size(84, 20);
            this.txtDiaSalida.TabIndex = 10;
            this.txtDiaSalida.TextChanged += new System.EventHandler(this.txtDiaSalida_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "   Dia de salida\r\n(DD/MM/YYYY)";
            // 
            // txtHoraLlegada
            // 
            this.txtHoraLlegada.Location = new System.Drawing.Point(378, 121);
            this.txtHoraLlegada.Name = "txtHoraLlegada";
            this.txtHoraLlegada.Size = new System.Drawing.Size(107, 20);
            this.txtHoraLlegada.TabIndex = 8;
            // 
            // lblHoraLlegada
            // 
            this.lblHoraLlegada.AutoSize = true;
            this.lblHoraLlegada.Location = new System.Drawing.Point(284, 124);
            this.lblHoraLlegada.Name = "lblHoraLlegada";
            this.lblHoraLlegada.Size = new System.Drawing.Size(86, 13);
            this.lblHoraLlegada.TabIndex = 7;
            this.lblHoraLlegada.Text = "Hora de Llegada";
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Location = new System.Drawing.Point(145, 121);
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(107, 20);
            this.txtHoraSalida.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hora de salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id del vuelo";
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(145, 245);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(107, 20);
            this.txtOrigen.TabIndex = 3;
            // 
            // btmBuscar
            // 
            this.btmBuscar.Location = new System.Drawing.Point(321, 64);
            this.btmBuscar.Name = "btmBuscar";
            this.btmBuscar.Size = new System.Drawing.Size(75, 23);
            this.btmBuscar.TabIndex = 2;
            this.btmBuscar.Text = "Buscar";
            this.btmBuscar.UseVisualStyleBackColor = true;
            this.btmBuscar.Click += new System.EventHandler(this.btmBuscar_Click);
            // 
            // txtIdVuelo
            // 
            this.txtIdVuelo.Location = new System.Drawing.Point(159, 66);
            this.txtIdVuelo.Name = "txtIdVuelo";
            this.txtIdVuelo.Size = new System.Drawing.Size(107, 20);
            this.txtIdVuelo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
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
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDiaLlegada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoraLlegada;
        private System.Windows.Forms.Label lblHoraLlegada;
        private System.Windows.Forms.TextBox txtHoraSalida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTipoVuelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Button btnAggPasajero;
        private System.Windows.Forms.Button button1;
    }
}