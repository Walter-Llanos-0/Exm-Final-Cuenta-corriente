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
    public partial class FormClientes : Form
    {
        R_ClienteBL orClienteBL = new R_ClienteBL();
        public FormClientes()
        {
            InitializeComponent();
            dgvtabla.DataSource = orClienteBL.listarCliente();
        }


        void LimpiarCliente()
        {
            txtid.Clear();
            cbotipocliente.SelectedIndex = (0);
            cbotipodocumento.SelectedIndex = (0);
            txtdocumento.Clear();
            txtpaterno.Clear();
            txtmaterno.Clear();
            txtnombre.Clear();
            txtruc.Clear();
            txtrazonsocial.Clear();
            txtdomicilio.Clear();
            txtdepartamento.Clear();
            txtprovincia.Clear();
            txtdistrito.Clear();
            txttelefono.Clear();
            txtcelular.Clear();
            txtcorreo.Clear();
            txtmoroso.Clear();
            txtestado.Clear();

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            dgvtabla.DataSource = orClienteBL.listarCliente();

        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            LimpiarCliente();
            txtid.Focus();
            txtid.Enabled = false;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCliente();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            R_Cliente or_Cliente = new R_Cliente();

            Int32 id = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("Codigo a buscar"));
            or_Cliente = orClienteBL.buscarCliente(id);

            if (or_Cliente == null)
            {
                MessageBox.Show("Codigo no existe");
                LimpiarCliente();


            }
            else
            {
                txtid.Text = or_Cliente.IdCliente.ToString();
                cbotipocliente.SelectedItem = or_Cliente.Tipocliente;
                cbotipodocumento.SelectedItem = or_Cliente.Tipodocumento;
                txtdocumento.Text = or_Cliente.Numerodocumento;
                txtpaterno.Text = or_Cliente.ApellidoPaterno;
                txtmaterno.Text = or_Cliente.ApellidoMaterno;
                txtnombre.Text = or_Cliente.Nombre;
                txtruc.Text = or_Cliente.Ruc;
                txtrazonsocial.Text = or_Cliente.RazonSocial;
                txtdomicilio.Text = or_Cliente.Domicilio;
                txtdepartamento.Text = or_Cliente.Departamento;
                txtprovincia.Text = or_Cliente.Provincia;
                txtdistrito.Text = or_Cliente.Distrito;
                txttelefono.Text = or_Cliente.Telefono1;
                txtcelular.Text = or_Cliente.Celular;
                txtcorreo.Text = or_Cliente.Correo;
                txtmoroso.Text = or_Cliente.Moroso;
                txtestado.Text = or_Cliente.Estado;
               
            }

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string men;
            men = orClienteBL.agregarCliente(new R_Cliente(cbotipocliente.SelectedItem.ToString(), cbotipodocumento.SelectedItem.ToString(), txtdocumento.Text, txtpaterno.Text, txtmaterno.Text, txtnombre.Text, txtruc.Text, txtrazonsocial.Text, txtdomicilio.Text, txtdepartamento.Text, txtprovincia.Text, txtdistrito.Text, txttelefono.Text, txtcelular.Text, txtcorreo.Text, txtmoroso.Text, txtestado.Text));

            MessageBox.Show(men);
            dgvtabla.DataSource = orClienteBL.listarCliente();
            LimpiarCliente();

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            string men;
            men = orClienteBL.actualizarCliente(new R_Cliente(Int16.Parse(txtid.Text),cbotipocliente.SelectedItem.ToString(), cbotipodocumento.SelectedItem.ToString(), txtdocumento.Text, txtpaterno.Text, txtmaterno.Text, txtnombre.Text, txtruc.Text, txtrazonsocial.Text, txtdomicilio.Text, txtdepartamento.Text, txtprovincia.Text, txtdistrito.Text, txttelefono.Text, txtcelular.Text, txtcorreo.Text, txtmoroso.Text, txtestado.Text));

            MessageBox.Show(men);

            dgvtabla.DataSource = orClienteBL.listarCliente();
            LimpiarCliente();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string men;
            men = orClienteBL.eliminarCliente(Int32.Parse(txtid.Text));
            MessageBox.Show(men);
            dgvtabla.DataSource = orClienteBL.listarCliente();
            LimpiarCliente();

        }
    }
}
