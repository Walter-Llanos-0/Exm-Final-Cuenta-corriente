namespace CapaPresentacion
{
    partial class FrmRegistro_Usuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtUsuario1 = new System.Windows.Forms.TextBox();
            this.txtContrasenia1 = new System.Windows.Forms.TextBox();
            this.txtApePaterno = new System.Windows.Forms.TextBox();
            this.txtApeMaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnSeleccionarImagen = new System.Windows.Forms.Button();
            this.tblRegistro_Usuario = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "IdUsuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Apellido Paterno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(460, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Apellido Materno(*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(460, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nombres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(460, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Perfil";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(460, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Estado";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(240, 92);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(174, 20);
            this.txtIdUsuario.TabIndex = 9;
            // 
            // txtUsuario1
            // 
            this.txtUsuario1.Location = new System.Drawing.Point(240, 144);
            this.txtUsuario1.Name = "txtUsuario1";
            this.txtUsuario1.Size = new System.Drawing.Size(174, 20);
            this.txtUsuario1.TabIndex = 10;
            // 
            // txtContrasenia1
            // 
            this.txtContrasenia1.Location = new System.Drawing.Point(240, 205);
            this.txtContrasenia1.Name = "txtContrasenia1";
            this.txtContrasenia1.Size = new System.Drawing.Size(174, 20);
            this.txtContrasenia1.TabIndex = 11;
            this.txtContrasenia1.UseSystemPasswordChar = true;
            // 
            // txtApePaterno
            // 
            this.txtApePaterno.Location = new System.Drawing.Point(240, 257);
            this.txtApePaterno.Name = "txtApePaterno";
            this.txtApePaterno.Size = new System.Drawing.Size(174, 20);
            this.txtApePaterno.TabIndex = 12;
            // 
            // txtApeMaterno
            // 
            this.txtApeMaterno.Location = new System.Drawing.Point(642, 92);
            this.txtApeMaterno.Name = "txtApeMaterno";
            this.txtApeMaterno.Size = new System.Drawing.Size(167, 20);
            this.txtApeMaterno.TabIndex = 13;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(643, 140);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(166, 20);
            this.txtNombre.TabIndex = 14;
            // 
            // cboPerfil
            // 
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Items.AddRange(new object[] {
            "Seleccione",
            "Operador",
            "Administrador"});
            this.cboPerfil.Location = new System.Drawing.Point(643, 204);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(166, 21);
            this.cboPerfil.TabIndex = 15;
            this.cboPerfil.Text = "Seleccione";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Seleccione",
            "Activado",
            "Desactivado"});
            this.cboEstado.Location = new System.Drawing.Point(643, 259);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(166, 21);
            this.cboEstado.TabIndex = 16;
            this.cboEstado.Text = "Seleccionar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(962, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "FOTO";
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(879, 142);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(200, 228);
            this.pbFoto.TabIndex = 18;
            this.pbFoto.TabStop = false;
            // 
            // btnSeleccionarImagen
            // 
            this.btnSeleccionarImagen.Location = new System.Drawing.Point(879, 81);
            this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            this.btnSeleccionarImagen.Size = new System.Drawing.Size(200, 29);
            this.btnSeleccionarImagen.TabIndex = 19;
            this.btnSeleccionarImagen.Text = "Seleccionar Foto";
            this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
            this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
            // 
            // tblRegistro_Usuario
            // 
            this.tblRegistro_Usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRegistro_Usuario.Location = new System.Drawing.Point(77, 308);
            this.tblRegistro_Usuario.Name = "tblRegistro_Usuario";
            this.tblRegistro_Usuario.Size = new System.Drawing.Size(769, 196);
            this.tblRegistro_Usuario.TabIndex = 20;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(77, 531);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(125, 45);
            this.btnNuevo.TabIndex = 21;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(240, 531);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 45);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(409, 531);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 45);
            this.btnBuscar.TabIndex = 23;
            this.btnBuscar.Text = "BUscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(576, 531);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(114, 45);
            this.btnActualizar.TabIndex = 24;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(734, 531);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 45);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(913, 416);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(137, 45);
            this.btnLimpiar.TabIndex = 26;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmRegistro_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 597);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.tblRegistro_Usuario);
            this.Controls.Add(this.btnSeleccionarImagen);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.cboPerfil);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApeMaterno);
            this.Controls.Add(this.txtApePaterno);
            this.Controls.Add(this.txtContrasenia1);
            this.Controls.Add(this.txtUsuario1);
            this.Controls.Add(this.txtIdUsuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistro_Usuario";
            this.Text = "FrmRegistro_Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegistro_Usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtUsuario1;
        private System.Windows.Forms.TextBox txtContrasenia1;
        private System.Windows.Forms.TextBox txtApePaterno;
        private System.Windows.Forms.TextBox txtApeMaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnSeleccionarImagen;
        private System.Windows.Forms.DataGridView tblRegistro_Usuario;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}