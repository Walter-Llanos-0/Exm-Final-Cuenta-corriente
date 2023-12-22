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
using Entidades;
namespace CapaPresentacion
{
    public partial class FrmMoviProovedor : Form
    {
        MoviProovedorBL or_moviBL = new MoviProovedorBL();  


        public FrmMoviProovedor()
        {
            InitializeComponent();
            tabla.DataSource = or_moviBL.listarMovi();
        }
        //void para limpiar

        void LimpiarMovi()
        {
            txtidm.Clear();
            txtfecha.Clear();
            txtconcepto.Clear();
            txtimporte.Clear();
            txtnota.Clear();
            cboTipomon.SelectedIndex = 0;
            cboTipomov.SelectedIndex = 0;
        }




        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarMovi();
            txtidm.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarMovi();
        }

        private void txtimporte_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMoviProovedor_Load(object sender, EventArgs e)
        {
            tabla.DataSource = or_moviBL.listarMovi();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string men;
            men = or_moviBL.agregarmovi(new MoviProovedor(txtfecha.Text, txtconcepto.Text, txtnota.Text, cboTipomov.SelectedItem.ToString(),
                cboTipomon.SelectedItem.ToString(), double.Parse(txtimporte.Text)));
            MessageBox.Show(men);
            tabla.DataSource = or_moviBL.listarMovi();
            LimpiarMovi();

        }
    }
}
