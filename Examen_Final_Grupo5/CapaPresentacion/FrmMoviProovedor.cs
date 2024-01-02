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

        //void limpiar

        void LimpiarMovi()
        {
            txtidm.Clear();
            txtfecha.Clear();
            txtconcepto.Clear();
            txtimporte.Clear();
            txtnota.Clear();
            cboTipomon.SelectedIndex = 0;
            cboTipomov.SelectedIndex = 0;
            cboIdProveedor.SelectedIndex = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarMovi();
            txtfecha.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarMovi();
        }

        private void FrmMoviProovedor_Load(object sender, EventArgs e)
        {
            tabla.DataSource = or_moviBL.listarMovi();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string men;
            men = or_moviBL.agregarmovi(new MoviProovedor(txtfecha.Text, txtconcepto.Text, txtnota.Text, cboTipomov.SelectedItem.ToString(),
                cboTipomon.SelectedItem.ToString(), txtimporte.Text, cboIdProveedor.SelectedItem.ToString()));
            MessageBox.Show(men);
            tabla.DataSource = or_moviBL.listarMovi();
            LimpiarMovi();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string men;
            men = or_moviBL.actualizarmovi(new MoviProovedor(Int32.Parse(txtidm.Text), txtfecha.Text, txtconcepto.Text, txtnota.Text,
                cboTipomov.SelectedItem.ToString(), cboTipomon.SelectedItem.ToString(), txtimporte.Text, cboIdProveedor.SelectedItem.ToString()));
            MessageBox.Show(men);
            tabla.DataSource = or_moviBL.listarMovi();
            LimpiarMovi();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MoviProovedor or_Movi = new MoviProovedor();
            Int32 id = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("CODIGO A BUSCAR"));

            or_Movi = or_moviBL.buscarmovi(id);


            if (or_Movi == null)
            {
                MessageBox.Show("¿Codigo a buscar?");
                LimpiarMovi();


            }
            else
            {
                txtidm.Text = or_Movi.IdmProovedor.ToString();
                txtfecha.Text = or_Movi.fecha;
                txtconcepto.Text = or_Movi.concepto;
                txtnota.Text = or_Movi.nota;
                cboTipomov.SelectedItem = or_Movi.tipomovimiento;
                cboTipomon.SelectedItem = or_Movi.tipomoneda;
                txtimporte.Text = or_Movi.importe;
                cboIdProveedor.SelectedItem = or_Movi.idProoveedor;

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string men;
            men = or_moviBL.eliminarmovi(Int16.Parse(txtidm.Text));
            MessageBox.Show(men);
            tabla.DataSource = or_moviBL.listarMovi();
            LimpiarMovi();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;
            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {
                IndeceFila++;
                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;
        }
    }//fin de clase
}//fin de capa presentacion
