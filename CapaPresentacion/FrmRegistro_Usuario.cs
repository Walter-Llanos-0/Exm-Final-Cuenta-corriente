using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmRegistro_Usuario : Form
    {
        R_UsuarioBL or_usuarioBL = new R_UsuarioBL();

        String ruta = "";


        // GUARDAR PERSONAL PARA EL BOTONO  : AGREGAR 

        SqlConnection cn = new SqlConnection("Data Source=DESKTOP-2T10M4M;Initial Catalog=Grupo_5;Persist Security Info=True;User ID=sa;Password=74994175");
        void GuardarPersonal(string usu, string cont, string apepa, string apema, string nom, string perf, string esta, string fotos)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                FileStream fs = new FileStream(fotos, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                ms.SetLength(fs.Length);
                fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
                byte[] arrImg = ms.GetBuffer();
                ms.Flush();
                fs.Close();

                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_InsertarRegistro_Usuario";
                    cmd.Parameters.AddWithValue("@p_usuario", usu);
                    cmd.Parameters.AddWithValue("@p_contrasenia", cont);
                    cmd.Parameters.AddWithValue("@p_apepaterno", apepa);
                    cmd.Parameters.AddWithValue("@p_apematerno", apema);
                    cmd.Parameters.AddWithValue("@p_nombre", nom);
                    cmd.Parameters.AddWithValue("@p_perfil", perf);
                    cmd.Parameters.AddWithValue("@p_estado", esta);
                    cmd.Parameters.Add("@p_FotoUsuario", SqlDbType.VarBinary).Value = arrImg;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarUsuario();
            txtUsuario1.Focus();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (pbFoto.Image == null || ruta == "")
            {
                MessageBox.Show("Falta seleccionar la foto", "Atencion");
            }
            else
            {
                try
                {
                    GuardarPersonal(txtUsuario1.Text, txtContrasenia1.Text, txtApePaterno.Text, txtApeMaterno.Text, txtNombre.Text, cboPerfil.SelectedItem.ToString(), cboEstado.SelectedItem.ToString(), ruta);
                    MessageBox.Show("Se guardo satisfactoriamente", "Atencion");
                    tblRegistro_Usuario.DataSource = or_usuarioBL.listarUsuario();
                    cboEstado.ResetText();
                    cboPerfil.ResetText();
                    txtNombre.ResetText();
                    txtApeMaterno.ResetText();
                    txtApePaterno.ResetText();
                    txtContrasenia1.ResetText();
                    txtUsuario1.ResetText();
                    pbFoto.Image = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Int16 idusuario = Int16.Parse(Microsoft.VisualBasic.Interaction.InputBox("Codigo a buscar"));

            try
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_BuscarRegistro_Usuario";
                    cmd.Parameters.AddWithValue("@p_idusuario", idusuario);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        txtUsuario1.Text = dr.GetString(1);
                        txtContrasenia1.Text = dr.GetString(2);
                        txtApePaterno.Text = dr.GetString(3);
                        txtApeMaterno.Text = dr.GetString(4);
                        txtNombre.Text = dr.GetString(5);
                        cboPerfil.Text = dr.GetString(6);
                        cboEstado.Text = dr.GetString(7);
                        byte[] arrImg = (byte[])dr.GetSqlBinary(8);
                        MemoryStream ms = new MemoryStream(arrImg);
                        Image img = Image.FromStream(ms);
                        pbFoto.Image = img;
                        pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("Usuario no EXISTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    dr.Close();
                    cn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string men;
            men = or_usuarioBL.actualizarUsuario(new R_Usuario(Int16.Parse(txtIdUsuario.Text), txtUsuario1.Text, txtContrasenia1.Text, txtApePaterno.Text, txtApeMaterno.Text, txtNombre.Text, cboPerfil.SelectedItem.ToString(), cboEstado.SelectedItem.ToString(), ruta));

            MessageBox.Show(men);
            tblRegistro_Usuario.DataSource = or_usuarioBL.listarUsuario();
            LimpiarUsuario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string men;
            men = or_usuarioBL.eliminarUsuario(Int16.Parse(txtIdUsuario.Text));
            MessageBox.Show(men);
            tblRegistro_Usuario.DataSource = or_usuarioBL.listarUsuario();
            LimpiarUsuario();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarUsuario();

        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAbrir = new OpenFileDialog();
            ofdAbrir.Filter = "*.bmp;*.gif;*.jpg;*.png|*.bmp;*.gif;*.jpg;*.png";
            ofdAbrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofdAbrir.Title = "Seleccionar la imagen";
            ofdAbrir.RestoreDirectory = true;

            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                ruta = ofdAbrir.FileName;

                pbFoto.Image = Image.FromFile(ruta);
                pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                ruta = "";
                pbFoto.Image = null;
            }
        }
    }
}
