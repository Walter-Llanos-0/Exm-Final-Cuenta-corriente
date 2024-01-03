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
    public partial class FrmMoviCliente : Form
    {
        MoviClienteBL or_moviBL = new MoviClienteBL();

        public FrmMoviCliente()
        {
            InitializeComponent();
            tabla.DataSource = or_moviBL.listarMovi();

        }

        void LimpiarMovi()
        {
            txtidm.Clear();
            txtfecha.Clear();
            txtconcepto.Clear();
            txtimporte.Clear();
            txtnota.Clear();
            cboTipomon.SelectedIndex = 0;
            cboTipomov.SelectedIndex = 0;
            txtidcliente.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LimpiarMovi();
            txtidcliente.Focus();
            txtidm.Enabled = false;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpiarMovi();

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

            string men;
            men = or_moviBL.agregarmovi(new MoviCliente(txtfecha.Text, txtconcepto.Text,  cboTipomov.SelectedItem.ToString(),
                cboTipomon.SelectedItem.ToString(), Int32.Parse(txtimporte.Text), txtnota.Text, Int32.Parse(txtidcliente.Text)));
            MessageBox.Show(men);
            tabla.DataSource = or_moviBL.listarMovi();
            LimpiarMovi();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            MoviCliente or_Movi = new MoviCliente();
            Int32 id = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("CODIGO A BUSCAR"));

            or_Movi = or_moviBL.buscarmovi(id);


            if (or_Movi == null)
            {
                MessageBox.Show("¿Codigo a buscar?");
                LimpiarMovi();


            }
            else
            {
                txtidm.Text = or_Movi.IdMoviCliente.ToString();
                txtfecha.Text = or_Movi.Fecha;
                txtconcepto.Text = or_Movi.Concepto;
                txtnota.Text = or_Movi.Nota;
                cboTipomov.SelectedItem = or_Movi.Tipomovimiento;
                cboTipomon.SelectedItem = or_Movi.Tipomoneda;
                txtimporte.Text = or_Movi.Importe.ToString(); ;
                txtidcliente.Text = or_Movi.IdCliente.ToString(); ;

            }
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

            string men;
            men = or_moviBL.actualizarmovi(new MoviCliente(Int32.Parse(txtidm.Text), txtfecha.Text, txtconcepto.Text,
                cboTipomov.SelectedItem.ToString(), cboTipomon.SelectedItem.ToString(), Int32.Parse(txtimporte.Text), txtnota.Text, Int32.Parse(txtidcliente.Text)));
            MessageBox.Show(men);
            tabla.DataSource = or_moviBL.listarMovi();
            LimpiarMovi();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            string men;
            men = or_moviBL.eliminarmovi(Int16.Parse(txtidm.Text));
            MessageBox.Show(men);
            tabla.DataSource = or_moviBL.listarMovi();
            LimpiarMovi();
        }

        private void btnexportar_Click(object sender, EventArgs e)
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
    }
}
