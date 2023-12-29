using CapaNegocio;
using Entidades;
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
    public partial class FrmRegistro_Usuario : Form
    {
        R_UsuarioBL or_usuarioBL = new R_UsuarioBL();
        public FrmRegistro_Usuario()
        {
            InitializeComponent();
            tblRegistro_Usuario.DataSource = or_usuarioBL.listarUsuario();

        }

        void LimpiarUsuario()
        {
            txtIdUsuario.Clear();
            txtUsuario1.Clear();
            txtContrasenia1.Clear();
            txtApePaterno.Clear();
            txtApeMaterno.Clear();
            txtNombre.Clear();
            cboPerfil.SelectedIndex = (0);
            cboEstado.SelectedIndex = (0);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarUsuario();
        }

        private void FrmRegistro_Usuario_Load(object sender, EventArgs e)
        {
            tblRegistro_Usuario.DataSource = or_usuarioBL.listarUsuario();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarUsuario();

            txtUsuario1.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string men;

            men = or_usuarioBL.agregarUsuario(new R_Usuario(txtUsuario1.Text, txtContrasenia1.Text, txtApePaterno.Text, txtApeMaterno.Text, txtNombre.Text, cboPerfil.SelectedItem.ToString(), cboEstado.SelectedItem.ToString()));

            MessageBox.Show(men);

            tblRegistro_Usuario.DataSource = or_usuarioBL.listarUsuario();

            LimpiarUsuario();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string men;
            men = or_usuarioBL.actualizarUsuario(new R_Usuario(Int16.Parse(txtIdUsuario.Text), txtUsuario1.Text, txtContrasenia1.Text, txtApePaterno.Text, txtApeMaterno.Text, txtNombre.Text, cboPerfil.SelectedItem.ToString(), cboEstado.SelectedItem.ToString()));
           
            MessageBox.Show(men);
            tblRegistro_Usuario.DataSource = or_usuarioBL.listarUsuario();
            LimpiarUsuario();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            R_Usuario or_Usuario = new R_Usuario();

            Int16 cod = Int16.Parse(Microsoft.VisualBasic.Interaction.InputBox("Codigo a buscar"));

            or_Usuario = or_usuarioBL.buscarUsuario(cod);

            if (or_Usuario == null)
            {

                MessageBox.Show("CODIGO NO EXISTE");

                LimpiarUsuario();
            }
            else
            {
                txtIdUsuario.Text = or_Usuario.idusuario.ToString();
                txtUsuario1.Text = or_Usuario.usuario;
                txtContrasenia1.Text = or_Usuario.contrasenia;
                txtApePaterno.Text = or_Usuario.apepaterno;
                txtApeMaterno.Text = or_Usuario.apematerno;
                txtNombre.Text = or_Usuario.nombre;
                cboPerfil.SelectedItem = or_Usuario.perfil; 
                cboEstado.SelectedItem = or_Usuario.estado;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string men;
            men = or_usuarioBL.eliminarUsuario(Int16.Parse(txtIdUsuario.Text));
            MessageBox.Show(men);
            tblRegistro_Usuario.DataSource = or_usuarioBL.listarUsuario();
            LimpiarUsuario();
        }

        private void tblRegistro_Usuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
