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
    }
}
