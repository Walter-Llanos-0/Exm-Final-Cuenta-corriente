namespace CapaPresentacion
{
    partial class FrmMoviCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMoviCliente));
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtidm = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtconcepto = new System.Windows.Forms.TextBox();
            this.txtnota = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cboTipomon = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cboTipomov = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.label29 = new System.Windows.Forms.Label();
            this.btnexportar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.Location = new System.Drawing.Point(990, 706);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(116, 49);
            this.btnlimpiar.TabIndex = 84;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(856, 706);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(100, 49);
            this.btneliminar.TabIndex = 83;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(698, 706);
            this.btnactualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(115, 49);
            this.btnactualizar.TabIndex = 82;
            this.btnactualizar.Text = "ACTUALIZAR";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(549, 706);
            this.btnbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(100, 49);
            this.btnbuscar.TabIndex = 81;
            this.btnbuscar.Text = "BUSCAR";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(402, 706);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(100, 49);
            this.btnagregar.TabIndex = 80;
            this.btnagregar.Text = "AGREGAR";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(240, 706);
            this.btnnuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(100, 49);
            this.btnnuevo.TabIndex = 79;
            this.btnnuevo.Text = "NUEVO";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.txtidcliente);
            this.panel2.Controls.Add(this.txtidm);
            this.panel2.Controls.Add(this.label28);
            this.panel2.Controls.Add(this.txtconcepto);
            this.panel2.Controls.Add(this.txtnota);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label27);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.cboTipomon);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.cboTipomov);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.txtimporte);
            this.panel2.Controls.Add(this.txtfecha);
            this.panel2.Location = new System.Drawing.Point(95, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1056, 339);
            this.panel2.TabIndex = 78;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(232, 60);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(216, 22);
            this.txtidcliente.TabIndex = 46;
            // 
            // txtidm
            // 
            this.txtidm.Location = new System.Drawing.Point(228, 20);
            this.txtidm.Margin = new System.Windows.Forms.Padding(4);
            this.txtidm.Name = "txtidm";
            this.txtidm.Size = new System.Drawing.Size(220, 22);
            this.txtidm.TabIndex = 45;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(59, 23);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(88, 16);
            this.label28.TabIndex = 44;
            this.label28.Text = "IdMoviCliente";
            // 
            // txtconcepto
            // 
            this.txtconcepto.Location = new System.Drawing.Point(233, 158);
            this.txtconcepto.Margin = new System.Windows.Forms.Padding(4);
            this.txtconcepto.Name = "txtconcepto";
            this.txtconcepto.Size = new System.Drawing.Size(215, 22);
            this.txtconcepto.TabIndex = 36;
            // 
            // txtnota
            // 
            this.txtnota.Location = new System.Drawing.Point(202, 216);
            this.txtnota.Margin = new System.Windows.Forms.Padding(4);
            this.txtnota.Multiline = true;
            this.txtnota.Name = "txtnota";
            this.txtnota.Size = new System.Drawing.Size(770, 99);
            this.txtnota.TabIndex = 37;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(72, 234);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 16);
            this.label22.TabIndex = 33;
            this.label22.Text = "Nota";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(59, 116);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 16);
            this.label27.TabIndex = 28;
            this.label27.Text = "Fecha";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(56, 66);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 16);
            this.label21.TabIndex = 42;
            this.label21.Text = "IdCliente";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(58, 155);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 16);
            this.label26.TabIndex = 29;
            this.label26.Text = "Concepto";
            // 
            // cboTipomon
            // 
            this.cboTipomon.FormattingEnabled = true;
            this.cboTipomon.Items.AddRange(new object[] {
            "Seleccione",
            "Soles",
            "Dolares"});
            this.cboTipomon.Location = new System.Drawing.Point(809, 100);
            this.cboTipomon.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipomon.Name = "cboTipomon";
            this.cboTipomon.Size = new System.Drawing.Size(181, 24);
            this.cboTipomon.TabIndex = 41;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(601, 39);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 16);
            this.label25.TabIndex = 30;
            this.label25.Text = "Tipo Movimiento";
            // 
            // cboTipomov
            // 
            this.cboTipomov.FormattingEnabled = true;
            this.cboTipomov.Items.AddRange(new object[] {
            "Seleccione ",
            "Cargo",
            "Abono"});
            this.cboTipomov.Location = new System.Drawing.Point(809, 39);
            this.cboTipomov.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipomov.Name = "cboTipomov";
            this.cboTipomov.Size = new System.Drawing.Size(184, 24);
            this.cboTipomov.TabIndex = 40;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(601, 100);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 16);
            this.label24.TabIndex = 31;
            this.label24.Text = "Tipo Moneda";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(601, 155);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(52, 16);
            this.label23.TabIndex = 32;
            this.label23.Text = "Importe";
            // 
            // txtimporte
            // 
            this.txtimporte.Location = new System.Drawing.Point(810, 155);
            this.txtimporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(180, 22);
            this.txtimporte.TabIndex = 38;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(232, 111);
            this.txtfecha.Margin = new System.Windows.Forms.Padding(4);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(216, 22);
            this.txtfecha.TabIndex = 35;
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(95, 424);
            this.tabla.Margin = new System.Windows.Forms.Padding(4);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersWidth = 51;
            this.tabla.Size = new System.Drawing.Size(1056, 249);
            this.tabla.TabIndex = 77;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(486, 29);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(249, 25);
            this.label29.TabIndex = 76;
            this.label29.Text = "MOVIMIENTO CLIENTE";
            // 
            // btnexportar
            // 
            this.btnexportar.Location = new System.Drawing.Point(95, 706);
            this.btnexportar.Name = "btnexportar";
            this.btnexportar.Size = new System.Drawing.Size(104, 49);
            this.btnexportar.TabIndex = 85;
            this.btnexportar.Text = "EXPORTAR";
            this.btnexportar.UseVisualStyleBackColor = true;
            this.btnexportar.Click += new System.EventHandler(this.btnexportar_Click);
            // 
            // FrmMoviCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 775);
            this.Controls.Add(this.btnexportar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.label29);
            this.Name = "FrmMoviCliente";
            this.Text = "FrmMoviCliente";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtidm;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtconcepto;
        private System.Windows.Forms.TextBox txtnota;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label27;
        protected internal System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cboTipomon;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cboTipomov;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button btnexportar;
    }
}