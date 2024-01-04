using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;



namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {

        R_UsuarioBL or_usuariobl = new R_UsuarioBL();

        string Usuario1 = "adrian";
        string Usuario2 = "kevin";
        string Usuario3 = "walter";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == Usuario1 && txtusuario.Text == Usuario2 && txtusuario.Text == Usuario3)
            {
                txtusuario.Clear();
                txtcontraseña.Clear();
                FrmMenu_Principal menu = new FrmMenu_Principal();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto", "Atencion");
            }
        }
    }
}
