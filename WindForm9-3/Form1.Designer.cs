
namespace WindForm9_3
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.listElementos = new System.Windows.Forms.ListView();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.dtColorFavorito = new System.Windows.Forms.DateTimePicker();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.rbtnSoltero = new System.Windows.Forms.RadioButton();
            this.lblColorFav = new System.Windows.Forms.Label();
            this.ckbMayor = new System.Windows.Forms.CheckBox();
            this.lblmayor = new System.Windows.Forms.Label();
            this.grBoxEstadoCiv = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.grBoxEstadoCiv.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(80, 38);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(275, 35);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // listElementos
            // 
            this.listElementos.HideSelection = false;
            this.listElementos.Location = new System.Drawing.Point(83, 326);
            this.listElementos.Name = "listElementos";
            this.listElementos.Size = new System.Drawing.Size(207, 97);
            this.listElementos.TabIndex = 3;
            this.listElementos.UseCompatibleStateImageBehavior = false;
            this.listElementos.SelectedIndexChanged += new System.EventHandler(this.listElementos_SelectedIndexChanged);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(83, 75);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(60, 13);
            this.lblFechaNac.TabIndex = 4;
            this.lblFechaNac.Text = "Fecha Nac";
            // 
            // dtColorFavorito
            // 
            this.dtColorFavorito.Location = new System.Drawing.Point(150, 75);
            this.dtColorFavorito.Name = "dtColorFavorito";
            this.dtColorFavorito.Size = new System.Drawing.Size(200, 20);
            this.dtColorFavorito.TabIndex = 5;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Location = new System.Drawing.Point(22, 19);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(61, 17);
            this.rbtnCasado.TabIndex = 6;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // rbtnSoltero
            // 
            this.rbtnSoltero.AutoSize = true;
            this.rbtnSoltero.Location = new System.Drawing.Point(133, 19);
            this.rbtnSoltero.Name = "rbtnSoltero";
            this.rbtnSoltero.Size = new System.Drawing.Size(58, 17);
            this.rbtnSoltero.TabIndex = 7;
            this.rbtnSoltero.TabStop = true;
            this.rbtnSoltero.Text = "Soltero";
            this.rbtnSoltero.UseVisualStyleBackColor = true;
            // 
            // lblColorFav
            // 
            this.lblColorFav.AutoSize = true;
            this.lblColorFav.Location = new System.Drawing.Point(86, 243);
            this.lblColorFav.Name = "lblColorFav";
            this.lblColorFav.Size = new System.Drawing.Size(69, 13);
            this.lblColorFav.TabIndex = 9;
            this.lblColorFav.Text = "Color favorito";
            // 
            // ckbMayor
            // 
            this.ckbMayor.AutoSize = true;
            this.ckbMayor.Location = new System.Drawing.Point(160, 128);
            this.ckbMayor.Name = "ckbMayor";
            this.ckbMayor.Size = new System.Drawing.Size(75, 17);
            this.ckbMayor.TabIndex = 10;
            this.ckbMayor.Text = "Soy mayor";
            this.ckbMayor.UseVisualStyleBackColor = true;
            // 
            // lblmayor
            // 
            this.lblmayor.AutoSize = true;
            this.lblmayor.Location = new System.Drawing.Point(89, 128);
            this.lblmayor.Name = "lblmayor";
            this.lblmayor.Size = new System.Drawing.Size(66, 13);
            this.lblmayor.TabIndex = 11;
            this.lblmayor.Text = "Mayor de 18";
            // 
            // grBoxEstadoCiv
            // 
            this.grBoxEstadoCiv.Controls.Add(this.rbtnSoltero);
            this.grBoxEstadoCiv.Controls.Add(this.rbtnCasado);
            this.grBoxEstadoCiv.Location = new System.Drawing.Point(83, 165);
            this.grBoxEstadoCiv.Name = "grBoxEstadoCiv";
            this.grBoxEstadoCiv.Size = new System.Drawing.Size(258, 47);
            this.grBoxEstadoCiv.TabIndex = 12;
            this.grBoxEstadoCiv.TabStop = false;
            this.grBoxEstadoCiv.Text = "Estado Civil ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 243);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(390, 399);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnPerfil.TabIndex = 15;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.grBoxEstadoCiv);
            this.Controls.Add(this.lblmayor);
            this.Controls.Add(this.ckbMayor);
            this.Controls.Add(this.lblColorFav);
            this.Controls.Add(this.dtColorFavorito);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.listElementos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grBoxEstadoCiv.ResumeLayout(false);
            this.grBoxEstadoCiv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListView listElementos;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.DateTimePicker dtColorFavorito;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.RadioButton rbtnSoltero;
        private System.Windows.Forms.Label lblColorFav;
        private System.Windows.Forms.CheckBox ckbMayor;
        private System.Windows.Forms.Label lblmayor;
        private System.Windows.Forms.GroupBox grBoxEstadoCiv;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnPerfil;
    }
}

