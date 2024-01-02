using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMenu_Principal : Form
    {
        public FrmMenu_Principal()
        {
            InitializeComponent();
        }

        private void registroUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistro_Usuario registro_usuario = new FrmRegistro_Usuario();
            registro_usuario.ShowDialog();
        }

        private void registroProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedor registro_proovedor = new FrmProveedor();
            registro_proovedor.ShowDialog();
        }

        private void movimientoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMoviProovedor registromovi = new FrmMoviProovedor();
            registromovi.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente registro_cliente = new FrmCliente();
            registro_cliente.ShowDialog();
        }
    }
}
