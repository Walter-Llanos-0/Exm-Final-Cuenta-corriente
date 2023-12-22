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
    public partial class FrmLogin : Form
    {
        string Usuario = "hola";
        string Contrasenia = "hola";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtusuario.Text != Usuario && txtcontrasenia.Text != Contrasenia)
            {
                if(txtusuario.Text != Usuario)
                {
                    MessageBox.Show("Usuario Incorrecto");
                    txtusuario.Clear();
                    //Cambios de Prueba
                    txtcontrasenia.Clear();

                    txtusuario.Focus();
                    return; 
                }
                if(txtcontrasenia.Text != Contrasenia)
                {

                    MessageBox.Show("Contraseña Incorrecto");
                    txtcontrasenia.Clear();
                    txtcontrasenia.Focus();
                    return;
                }
            }
            else
            {
                txtusuario.Clear() ;
                txtcontrasenia.Clear() ;
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
