using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace CapaPresentacion
{
    public partial class FrmProveedor : Form

    {
        R_ProovedorBL or_proovedorBL = new R_ProovedorBL();



        public FrmProveedor()
        {
            InitializeComponent();
            dataGridView1.DataSource = or_proovedorBL.listarProovedor();

        }

        //VOID LIMPIAR 

        void LimpiarProveedor()
        {
            txtid.Clear();
            cboTipoProve.SelectedIndex = 0;
            cboTipoDoc.SelectedIndex = 0;
            txtnumerodoc.Clear();
            txtapepat.Clear();
            txtapemat.Clear();
            txtnombre.Clear();
            txtruc.Clear();
            txtrazon.Clear();
            txtdomi.Clear();
            cboDepartamento.SelectedIndex = 0;
            cboProvincia.SelectedIndex = 0;
            cboDistrito.SelectedIndex = 0;
            txttele.Clear();
            txtcontacto.Clear();
            txtcorreo.Clear();
            txtbanco.Clear();
            txtnumcuenta.Clear();
            txtnuminter.Clear();
            cboEstado.SelectedIndex = 0;
        }





        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = or_proovedorBL.listarProovedor();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarProveedor();
            cboTipoProve.Focus();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarProveedor();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string men;
            men = or_proovedorBL.agregarProovedor(new R_Proovedor(cboTipoProve.SelectedItem.ToString(), cboTipoDoc.SelectedItem.ToString(),
                txtnumerodoc.Text, txtapepat.Text, txtapemat.Text, txtnombre.Text, txtruc.Text, txtrazon.Text, txtdomi.Text, cboDepartamento.SelectedItem.ToString(),
                cboProvincia.SelectedItem.ToString(), cboDistrito.SelectedItem.ToString(), txttele.Text, txtcontacto.Text, txtcorreo.Text, txtbanco.Text, Int32.Parse(txtnumcuenta.Text), Int32.Parse(txtnuminter.Text),
                cboEstado.SelectedItem.ToString()));

            MessageBox.Show(men);
            dataGridView1.DataSource = or_proovedorBL.listarProovedor();
            LimpiarProveedor();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string men;
            men = or_proovedorBL.actualizarProovedor(new R_Proovedor(Int32.Parse(txtid.Text), cboTipoProve.SelectedItem.ToString(), cboTipoDoc.SelectedItem.ToString(),
                txtnumerodoc.Text, txtapepat.Text, txtapemat.Text, txtnombre.Text, txtruc.Text, txtrazon.Text, txtdomi.Text, cboDepartamento.SelectedItem.ToString(),
               cboProvincia.SelectedItem.ToString(), cboDistrito.SelectedItem.ToString(), txttele.Text, txtcontacto.Text, txtcorreo.Text, txtbanco.Text, Int32.Parse(txtnumcuenta.Text), Int32.Parse(txtnuminter.Text),
                cboEstado.SelectedItem.ToString()));

            dataGridView1.DataSource = or_proovedorBL.listarProovedor();
            LimpiarProveedor();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            R_Proovedor or_Proovedor = new R_Proovedor();

            Int32 id = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("Codigo a buscar"));
            or_Proovedor = or_proovedorBL.buscarProovedor(id);

            if (or_Proovedor == null)
            {
                MessageBox.Show("¿QUE CODIGO DESEA BUSCAR?");
                LimpiarProveedor();


            }
            else
            {
                txtid.Text = or_Proovedor.idProveedor.ToString();
                cboTipoProve.SelectedItem = or_Proovedor.tipopro;
                cboTipoDoc.SelectedItem = or_Proovedor.tipodoc;
                txtnumerodoc.Text = or_Proovedor.numerodoc;
                txtapepat.Text = or_Proovedor.apepat;
                txtapemat.Text = or_Proovedor.apemat;
                txtnombre.Text = or_Proovedor.nombre;
                txtruc.Text = or_Proovedor.ruc;
                txtrazon.Text = or_Proovedor.razon;
                txtdomi.Text = or_Proovedor.domicilio;
                cboDepartamento.SelectedItem = or_Proovedor.departamento;
                cboProvincia.SelectedItem = or_Proovedor.provincia;
                cboDistrito.SelectedItem = or_Proovedor.distrito;
                txttele.Text = or_Proovedor.telefono;
                txtcontacto.Text = or_Proovedor.contacto;
                txtcorreo.Text = or_Proovedor.correo;
                txtbanco.Text = or_Proovedor.banco;
                txtnumcuenta.Text = or_Proovedor.nrocuenta.ToString();
                txtnuminter.Text = or_Proovedor.nrointer.ToString();
                cboEstado.SelectedItem = or_Proovedor.estado;
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            string men;
            men = or_proovedorBL.eliminarProovedor(Int16.Parse(txtid.Text));
            MessageBox.Show(men);
            dataGridView1.DataSource = or_proovedorBL.listarProovedor();
            LimpiarProveedor();

        }

        private void cboTipoProve_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoProve.Text == "Persona Natural")
            {
                txtruc.Enabled = false;
                txtrazon.Enabled = false;
                cboTipoDoc.Enabled = true;
                txtnumerodoc.Enabled = true;
                txtapemat.Enabled = true;
                txtapemat.Enabled = true;

            }
            else if (cboTipoProve.Text == "Persona Juridica")
            {

                txtruc.Enabled = true;
                txtrazon.Enabled = true;
                cboTipoDoc.Enabled = false;
                txtnumerodoc.Enabled = false;
                txtapemat.Enabled = false;
                txtapemat.Enabled = false;

            }

        }

        private void cboTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoDoc.Text == "Dni")
            {
                txtruc.Enabled = false;
                txtrazon.Enabled = false;

            }
            else if (cboTipoDoc.Text == "Cedula")
            {

                txtruc.Enabled = false;
                txtrazon.Enabled = false;


            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
