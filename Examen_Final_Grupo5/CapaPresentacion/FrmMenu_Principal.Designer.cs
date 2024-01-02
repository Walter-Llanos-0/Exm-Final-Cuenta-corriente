namespace CapaPresentacion
{
    partial class FrmMenu_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.proveedorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroUsuarioToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // registroUsuarioToolStripMenuItem
            // 
            this.registroUsuarioToolStripMenuItem.Name = "registroUsuarioToolStripMenuItem";
            this.registroUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroUsuarioToolStripMenuItem.Text = "Registro Usuario";
            this.registroUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registroUsuarioToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroClienteToolStripMenuItem,
            this.movimientoClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // registroClienteToolStripMenuItem
            // 
            this.registroClienteToolStripMenuItem.Name = "registroClienteToolStripMenuItem";
            this.registroClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registroClienteToolStripMenuItem.Text = "Registro Cliente";
            // 
            // movimientoClienteToolStripMenuItem
            // 
            this.movimientoClienteToolStripMenuItem.Name = "movimientoClienteToolStripMenuItem";
            this.movimientoClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.movimientoClienteToolStripMenuItem.Text = "Movimiento Cliente";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroProveedorToolStripMenuItem,
            this.movimientoProveedorToolStripMenuItem});
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // registroProveedorToolStripMenuItem
            // 
            this.registroProveedorToolStripMenuItem.Name = "registroProveedorToolStripMenuItem";
            this.registroProveedorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.registroProveedorToolStripMenuItem.Text = "Registro Proveedor";
            // 
            // movimientoProveedorToolStripMenuItem
            // 
            this.movimientoProveedorToolStripMenuItem.Name = "movimientoProveedorToolStripMenuItem";
            this.movimientoProveedorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.movimientoProveedorToolStripMenuItem.Text = "Movimiento Proveedor";
            // 
            // FrmMenu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 620);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu_Principal";
            this.Text = "FrmMenu_Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoProveedorToolStripMenuItem;
    }
}