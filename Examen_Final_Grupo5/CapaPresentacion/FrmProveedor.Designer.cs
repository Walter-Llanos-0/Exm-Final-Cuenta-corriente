namespace CapaPresentacion
{
    partial class FrmProveedor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.cboTipoProve = new System.Windows.Forms.ComboBox();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.txtnumerodoc = new System.Windows.Forms.TextBox();
            this.txtapepat = new System.Windows.Forms.TextBox();
            this.txtapemat = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtruc = new System.Windows.Forms.TextBox();
            this.txtrazon = new System.Windows.Forms.TextBox();
            this.txtdomi = new System.Windows.Forms.TextBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.txttele = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtcontacto = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtbanco = new System.Windows.Forms.TextBox();
            this.txtnumcuenta = new System.Windows.Forms.TextBox();
            this.txtnuminter = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proovedores";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboEstado);
            this.panel1.Controls.Add(this.txtnuminter);
            this.panel1.Controls.Add(this.txtnumcuenta);
            this.panel1.Controls.Add(this.txtbanco);
            this.panel1.Controls.Add(this.txtcorreo);
            this.panel1.Controls.Add(this.txtcontacto);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.txttele);
            this.panel1.Controls.Add(this.cboDistrito);
            this.panel1.Controls.Add(this.cboProvincia);
            this.panel1.Controls.Add(this.cboDepartamento);
            this.panel1.Controls.Add(this.txtdomi);
            this.panel1.Controls.Add(this.txtrazon);
            this.panel1.Controls.Add(this.txtruc);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtnombre);
            this.panel1.Controls.Add(this.txtapemat);
            this.panel1.Controls.Add(this.txtapepat);
            this.panel1.Controls.Add(this.txtnumerodoc);
            this.panel1.Controls.Add(this.cboTipoDoc);
            this.panel1.Controls.Add(this.cboTipoProve);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 313);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "IdProovedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tipo Proovedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Numero Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Apellido Paterno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Apellido Materno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nombre";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(129, 21);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(121, 20);
            this.txtid.TabIndex = 7;
            // 
            // cboTipoProve
            // 
            this.cboTipoProve.FormattingEnabled = true;
            this.cboTipoProve.Items.AddRange(new object[] {
            "Seleccione ",
            "Persona Natural",
            "Persona Juridica"});
            this.cboTipoProve.Location = new System.Drawing.Point(129, 63);
            this.cboTipoProve.Name = "cboTipoProve";
            this.cboTipoProve.Size = new System.Drawing.Size(121, 21);
            this.cboTipoProve.TabIndex = 8;
            this.cboTipoProve.SelectedIndexChanged += new System.EventHandler(this.cboTipoProve_SelectedIndexChanged);
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Items.AddRange(new object[] {
            "Seleccione",
            "Dni",
            "Cedula"});
            this.cboTipoDoc.Location = new System.Drawing.Point(129, 105);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.cboTipoDoc.TabIndex = 9;
            this.cboTipoDoc.SelectedIndexChanged += new System.EventHandler(this.cboTipoDoc_SelectedIndexChanged);
            // 
            // txtnumerodoc
            // 
            this.txtnumerodoc.Location = new System.Drawing.Point(129, 150);
            this.txtnumerodoc.Name = "txtnumerodoc";
            this.txtnumerodoc.Size = new System.Drawing.Size(121, 20);
            this.txtnumerodoc.TabIndex = 10;
            // 
            // txtapepat
            // 
            this.txtapepat.Location = new System.Drawing.Point(129, 198);
            this.txtapepat.Name = "txtapepat";
            this.txtapepat.Size = new System.Drawing.Size(121, 20);
            this.txtapepat.TabIndex = 11;
            // 
            // txtapemat
            // 
            this.txtapemat.Location = new System.Drawing.Point(129, 238);
            this.txtapemat.Name = "txtapemat";
            this.txtapemat.Size = new System.Drawing.Size(121, 20);
            this.txtapemat.TabIndex = 12;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(127, 272);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(123, 20);
            this.txtnombre.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(414, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ruc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Razon Social";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(412, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Domicilio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(412, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Departamento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(414, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Provincia";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(414, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Distrito";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(412, 275);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Telefono";
            // 
            // txtruc
            // 
            this.txtruc.Location = new System.Drawing.Point(522, 21);
            this.txtruc.Name = "txtruc";
            this.txtruc.Size = new System.Drawing.Size(140, 20);
            this.txtruc.TabIndex = 21;
            // 
            // txtrazon
            // 
            this.txtrazon.Location = new System.Drawing.Point(522, 64);
            this.txtrazon.Name = "txtrazon";
            this.txtrazon.Size = new System.Drawing.Size(140, 20);
            this.txtrazon.TabIndex = 22;
            // 
            // txtdomi
            // 
            this.txtdomi.Location = new System.Drawing.Point(523, 104);
            this.txtdomi.Name = "txtdomi";
            this.txtdomi.Size = new System.Drawing.Size(139, 20);
            this.txtdomi.TabIndex = 23;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Items.AddRange(new object[] {
            "Seleccione",
            "Amazonas",
            "Ancash",
            "Apurimac",
            "Arequipa",
            "Ayacucho",
            "Cajamarca",
            "Callao",
            "Cuzco",
            "Huancavelica",
            "Huanuco",
            "Ica",
            "Junin",
            "La libertad",
            "Lambayeque ",
            "Lima",
            "Loreto",
            "Madre de Dios",
            "Moquegua",
            "Pasco",
            "Piura",
            "Puno"});
            this.cboDepartamento.Location = new System.Drawing.Point(522, 149);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(137, 21);
            this.cboDepartamento.TabIndex = 24;
            // 
            // cboProvincia
            // 
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Items.AddRange(new object[] {
            "Seleccione",
            "Chachapoyas",
            "Huaraz\t",
            "Abancay",
            "Arequipa",
            "Huamanga",
            "Cajamarca",
            "Callao",
            "Acomayo",
            "Huanuco ",
            "Huancayo",
            "Trujillo",
            "Chiclayo ",
            "Lima ",
            "Iquitos"});
            this.cboProvincia.Location = new System.Drawing.Point(522, 197);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(140, 21);
            this.cboProvincia.TabIndex = 25;
            // 
            // cboDistrito
            // 
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Items.AddRange(new object[] {
            "Seleccione",
            "Lima",
            "San Martin",
            "El agustino",
            "Comas",
            "Los olivos",
            "Ancon",
            "Cercado de Lima",
            "Miraflores ",
            "Pueblo Libre"});
            this.cboDistrito.Location = new System.Drawing.Point(523, 238);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(139, 21);
            this.cboDistrito.TabIndex = 26;
            // 
            // txttele
            // 
            this.txttele.Location = new System.Drawing.Point(519, 276);
            this.txttele.Name = "txttele";
            this.txttele.Size = new System.Drawing.Size(143, 20);
            this.txttele.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(832, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "Contacto";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(832, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Correo";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(806, 116);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 13);
            this.label18.TabIndex = 30;
            this.label18.Text = "Banco Financiera";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(818, 160);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Nro. Cuenta";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(806, 212);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Nro. Interbancario";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(832, 257);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "Estado";
            // 
            // txtcontacto
            // 
            this.txtcontacto.Location = new System.Drawing.Point(925, 21);
            this.txtcontacto.Name = "txtcontacto";
            this.txtcontacto.Size = new System.Drawing.Size(148, 20);
            this.txtcontacto.TabIndex = 34;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(925, 56);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(148, 20);
            this.txtcorreo.TabIndex = 35;
            // 
            // txtbanco
            // 
            this.txtbanco.Location = new System.Drawing.Point(925, 113);
            this.txtbanco.Name = "txtbanco";
            this.txtbanco.Size = new System.Drawing.Size(148, 20);
            this.txtbanco.TabIndex = 36;
            // 
            // txtnumcuenta
            // 
            this.txtnumcuenta.Location = new System.Drawing.Point(925, 153);
            this.txtnumcuenta.Name = "txtnumcuenta";
            this.txtnumcuenta.Size = new System.Drawing.Size(148, 20);
            this.txtnumcuenta.TabIndex = 37;
            // 
            // txtnuminter
            // 
            this.txtnuminter.Location = new System.Drawing.Point(925, 205);
            this.txtnuminter.Name = "txtnuminter";
            this.txtnuminter.Size = new System.Drawing.Size(135, 20);
            this.txtnuminter.TabIndex = 38;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Seleccione",
            "Activo",
            "Desactivo"});
            this.cboEstado.Location = new System.Drawing.Point(925, 249);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(135, 21);
            this.cboEstado.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(81, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1024, 200);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(100, 586);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(198, 586);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(293, 586);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(389, 586);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(488, 586);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(587, 588);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 621);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FrmProveedor";
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapemat;
        private System.Windows.Forms.TextBox txtapepat;
        private System.Windows.Forms.TextBox txtnumerodoc;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.ComboBox cboTipoProve;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnumcuenta;
        private System.Windows.Forms.TextBox txtbanco;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtcontacto;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txttele;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.TextBox txtdomi;
        private System.Windows.Forms.TextBox txtrazon;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtnuminter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}