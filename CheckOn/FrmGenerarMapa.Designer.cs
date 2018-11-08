namespace CheckOn
{
    partial class FrmGenerarMapa
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
            this.btnLlegar = new System.Windows.Forms.Button();
            this.btnRuta = new System.Windows.Forms.Button();
            this.btnPolygono = new System.Windows.Forms.Button();
            this.dtgListaUbicacion = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.gmapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.cmbOpciones = new System.Windows.Forms.ComboBox();
            this.txtDocumentoUsuario = new System.Windows.Forms.TextBox();
            this.lblTipoBusqueda = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lbILatitud = new System.Windows.Forms.ListBox();
            this.lblLongitud = new System.Windows.Forms.ListBox();
            this.lbDispositivo = new System.Windows.Forms.ListBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaUbicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLlegar
            // 
            this.btnLlegar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLlegar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLlegar.Location = new System.Drawing.Point(209, 229);
            this.btnLlegar.Name = "btnLlegar";
            this.btnLlegar.Size = new System.Drawing.Size(75, 23);
            this.btnLlegar.TabIndex = 38;
            this.btnLlegar.Text = "Como llegar";
            this.btnLlegar.UseVisualStyleBackColor = false;
            this.btnLlegar.Click += new System.EventHandler(this.btnLlegar_Click);
            // 
            // btnRuta
            // 
            this.btnRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRuta.Location = new System.Drawing.Point(114, 229);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(75, 23);
            this.btnRuta.TabIndex = 37;
            this.btnRuta.Text = "Ruta";
            this.btnRuta.UseVisualStyleBackColor = false;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // btnPolygono
            // 
            this.btnPolygono.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPolygono.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPolygono.Location = new System.Drawing.Point(12, 229);
            this.btnPolygono.Name = "btnPolygono";
            this.btnPolygono.Size = new System.Drawing.Size(75, 23);
            this.btnPolygono.TabIndex = 36;
            this.btnPolygono.Text = "Polígono";
            this.btnPolygono.UseVisualStyleBackColor = false;
            this.btnPolygono.Click += new System.EventHandler(this.btnPolygono_Click);
            // 
            // dtgListaUbicacion
            // 
            this.dtgListaUbicacion.AllowUserToAddRows = false;
            this.dtgListaUbicacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListaUbicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaUbicacion.Location = new System.Drawing.Point(12, 287);
            this.dtgListaUbicacion.Name = "dtgListaUbicacion";
            this.dtgListaUbicacion.ReadOnly = true;
            this.dtgListaUbicacion.Size = new System.Drawing.Size(272, 211);
            this.dtgListaUbicacion.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Longitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Latitud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Dispositivo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Tomato;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Location = new System.Drawing.Point(114, 258);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Agregar.Location = new System.Drawing.Point(12, 258);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 27;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // gmapControl1
            // 
            this.gmapControl1.Bearing = 0F;
            this.gmapControl1.CanDragMap = true;
            this.gmapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmapControl1.GrayScaleMode = false;
            this.gmapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmapControl1.LevelsKeepInMemmory = 5;
            this.gmapControl1.Location = new System.Drawing.Point(302, 5);
            this.gmapControl1.MarkersEnabled = true;
            this.gmapControl1.MaxZoom = 2;
            this.gmapControl1.MinZoom = 2;
            this.gmapControl1.MouseWheelZoomEnabled = true;
            this.gmapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmapControl1.Name = "gmapControl1";
            this.gmapControl1.NegativeMode = false;
            this.gmapControl1.PolygonsEnabled = true;
            this.gmapControl1.RetryLoadTile = 0;
            this.gmapControl1.RoutesEnabled = true;
            this.gmapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmapControl1.ShowTileGridLines = false;
            this.gmapControl1.Size = new System.Drawing.Size(566, 498);
            this.gmapControl1.TabIndex = 26;
            this.gmapControl1.Zoom = 0D;
            // 
            // cmbOpciones
            // 
            this.cmbOpciones.FormattingEnabled = true;
            this.cmbOpciones.Items.AddRange(new object[] {
            "-- Selecione una opcion --",
            "Cedula del pasajero",
            "ID Maleta"});
            this.cmbOpciones.Location = new System.Drawing.Point(12, 42);
            this.cmbOpciones.Name = "cmbOpciones";
            this.cmbOpciones.Size = new System.Drawing.Size(139, 21);
            this.cmbOpciones.TabIndex = 39;
            this.cmbOpciones.SelectedIndexChanged += new System.EventHandler(this.cmbOpciones_SelectedIndexChanged);
            // 
            // txtDocumentoUsuario
            // 
            this.txtDocumentoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocumentoUsuario.Location = new System.Drawing.Point(157, 43);
            this.txtDocumentoUsuario.MaxLength = 20;
            this.txtDocumentoUsuario.Name = "txtDocumentoUsuario";
            this.txtDocumentoUsuario.Size = new System.Drawing.Size(127, 20);
            this.txtDocumentoUsuario.TabIndex = 40;
            // 
            // lblTipoBusqueda
            // 
            this.lblTipoBusqueda.AutoSize = true;
            this.lblTipoBusqueda.Location = new System.Drawing.Point(12, 26);
            this.lblTipoBusqueda.Name = "lblTipoBusqueda";
            this.lblTipoBusqueda.Size = new System.Drawing.Size(78, 13);
            this.lblTipoBusqueda.TabIndex = 41;
            this.lblTipoBusqueda.Text = "Tipo busqueda";
            this.lblTipoBusqueda.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(154, 26);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(70, 13);
            this.lblIdentificacion.TabIndex = 42;
            this.lblIdentificacion.Text = "Identificación";
            // 
            // lbILatitud
            // 
            this.lbILatitud.FormattingEnabled = true;
            this.lbILatitud.Location = new System.Drawing.Point(12, 193);
            this.lbILatitud.Name = "lbILatitud";
            this.lbILatitud.Size = new System.Drawing.Size(129, 17);
            this.lbILatitud.TabIndex = 43;
            // 
            // lblLongitud
            // 
            this.lblLongitud.FormattingEnabled = true;
            this.lblLongitud.Location = new System.Drawing.Point(147, 193);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(137, 17);
            this.lblLongitud.TabIndex = 44;
            // 
            // lbDispositivo
            // 
            this.lbDispositivo.FormattingEnabled = true;
            this.lbDispositivo.Location = new System.Drawing.Point(12, 140);
            this.lbDispositivo.Name = "lbDispositivo";
            this.lbDispositivo.Size = new System.Drawing.Size(272, 30);
            this.lbDispositivo.TabIndex = 45;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Location = new System.Drawing.Point(157, 78);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(126, 23);
            this.btnBuscar.TabIndex = 46;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(12, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Borrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmGenerarMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbDispositivo);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.lbILatitud);
            this.Controls.Add(this.lblIdentificacion);
            this.Controls.Add(this.lblTipoBusqueda);
            this.Controls.Add(this.txtDocumentoUsuario);
            this.Controls.Add(this.cmbOpciones);
            this.Controls.Add(this.btnLlegar);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.btnPolygono);
            this.Controls.Add(this.dtgListaUbicacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.gmapControl1);
            this.Name = "FrmGenerarMapa";
            this.Text = "FrmGenerarMapa";
            this.Load += new System.EventHandler(this.FrmGenerarMapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaUbicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLlegar;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Button btnPolygono;
        private System.Windows.Forms.DataGridView dtgListaUbicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button Agregar;
        private GMap.NET.WindowsForms.GMapControl gmapControl1;
        private System.Windows.Forms.ComboBox cmbOpciones;
        private System.Windows.Forms.TextBox txtDocumentoUsuario;
        private System.Windows.Forms.Label lblTipoBusqueda;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.ListBox lbILatitud;
        private System.Windows.Forms.ListBox lblLongitud;
        private System.Windows.Forms.ListBox lbDispositivo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button button1;
    }
}