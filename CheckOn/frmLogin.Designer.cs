namespace CheckOn
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tblLogin = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 442);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(799, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tblLogin
            // 
            this.tblLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tblLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tblLogin.ColumnCount = 5;
            this.tblLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tblLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tblLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tblLogin.Controls.Add(this.btnRegistrar, 1, 7);
            this.tblLogin.Controls.Add(this.btnIngresar, 1, 6);
            this.tblLogin.Controls.Add(this.txtContrasena, 1, 4);
            this.tblLogin.Controls.Add(this.txtUsuario, 1, 3);
            this.tblLogin.Controls.Add(this.label1, 1, 2);
            this.tblLogin.Location = new System.Drawing.Point(0, -2);
            this.tblLogin.Name = "tblLogin";
            this.tblLogin.Padding = new System.Windows.Forms.Padding(1);
            this.tblLogin.RowCount = 9;
            this.tblLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.52874F));
            this.tblLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.91304F));
            this.tblLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tblLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tblLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tblLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tblLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tblLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tblLogin.Size = new System.Drawing.Size(799, 441);
            this.tblLogin.TabIndex = 2;
            this.tblLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.AutoSize = true;
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnRegistrar.Location = new System.Drawing.Point(280, 294);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 3, 2, 3);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(271, 33);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "REGISTRARSE";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.AutoSize = true;
            this.btnIngresar.BackColor = System.Drawing.SystemColors.Menu;
            this.btnIngresar.Location = new System.Drawing.Point(280, 255);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Padding = new System.Windows.Forms.Padding(1);
            this.btnIngresar.Size = new System.Drawing.Size(270, 33);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click_1);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContrasena.Location = new System.Drawing.Point(280, 178);
            this.txtContrasena.MaxLength = 20;
            this.txtContrasena.MinimumSize = new System.Drawing.Size(4, 4);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(270, 20);
            this.txtContrasena.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Location = new System.Drawing.Point(280, 144);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(270, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 104);
            this.label1.MinimumSize = new System.Drawing.Size(270, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "¡ Bienvenido !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 464);
            this.Controls.Add(this.tblLogin);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tblLogin.ResumeLayout(false);
            this.tblLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tblLogin;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label label1;
    }
}

