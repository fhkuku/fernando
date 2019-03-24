using proyecto.alertas;
using proyecto.BO;
using proyecto.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto.GUI
{
    public partial class frm_configuracion : Form
    {

        usuarioDAO bdUser = new usuarioDAO();
        usuarioBO objeus = new usuarioBO();
        private int response;
        DataTable datos;
        public frm_configuracion()
        {
            InitializeComponent();
            txtIdTipoUsuario.Enabled = false;
            txtNombreTipoUsuario.Enabled = false;
            actualizar();
            btnAgregarTipoUsuario.Enabled = false;
            btnModificarTipoUsuario.Enabled = false;
            btnEliminarTipoUsuario.Enabled = false;
        }

        private void btnAgregarTipoUsuario_Click(object sender, EventArgs e)
        {

            if (txtNombreTipoUsuario.Text != "")
            {
                objeus.tipo = txtNombreTipoUsuario.Text.Trim();

                datos = bdUser.ValidarTipoUsuario(objeus);
                if (datos.Rows.Count <= 0)
                {
                    response = bdUser.AgregaTipoUsuario(objeus);
                    if (response > 0)
                    {
                        msg_exito msg = new msg_exito("Se ha agregado correctamente", 50, 156);
                        msg.Show();
                        actualizar();
                        txtNombreTipoUsuario.Enabled = false;
                        txtNombreTipoUsuario.Text = "";
                    }
                    else
                    {

                        msg_error msg = new msg_error("Se ha generado un error", 50, 156);
                        msg.Show();

                    }
                }
                else
                {
                    msg_info msg = new msg_info("Este tipo de usuario ya existe", 50, 156);
                    msg.Show();
                }
            }
            else {
                msg_info msg = new msg_info("No puedes dejar campos vacíos", 50, 156);
                msg.Show();

            }
          
        }

        private void txtModificarTipoUsuario_Click(object sender, EventArgs e)
        {

            if (txtNombreTipoUsuario.Text != "" && txtIdTipoUsuario.Text!="")
            {
                objeus.tipo = txtNombreTipoUsuario.Text.Trim();
                objeus.id = Convert.ToInt32(txtIdTipoUsuario.Text);
                    response = bdUser.ModificarTipoUsuario(objeus);
                    if (response > 0)
                    {
                        msg_exito msg = new msg_exito("Se ha Actualizado correctamente", 50, 156);
                        msg.Show();
                        actualizar();
                        txtNombreTipoUsuario.Enabled = false;
                        txtNombreTipoUsuario.Text = "";
                        txtIdTipoUsuario.Text = "";
                    btnEliminarTipoUsuario.Enabled = false;
                    btnModificarTipoUsuario.Enabled = false;
                }
                    else
                    {

                        msg_error msg = new msg_error("Se ha generado un error", 50, 156);
                        msg.Show();

                    }
                
              
            }
            else
            {
                msg_info msg = new msg_info("No puedes dejar campos vacíos", 50, 156);
                msg.Show();

            }

        }

        private void btnEliminarTipoUsuario_Click(object sender, EventArgs e)
        {
            if (txtNombreTipoUsuario.Text != "" && txtIdTipoUsuario.Text != "")
            {
                objeus.tipo = txtNombreTipoUsuario.Text.Trim();
                objeus.id = Convert.ToInt32(txtIdTipoUsuario.Text);
                response = bdUser.BorrarTipoUsuario(objeus);
                if (response > 0)
                {
                    msg_exito msg = new msg_exito("Se ha Eliminado correctamente", 50, 156);
                    msg.Show();
                    actualizar();
                    txtNombreTipoUsuario.Enabled = false;
                    txtNombreTipoUsuario.Text = "";
                    txtIdTipoUsuario.Text = "";
                    btnEliminarTipoUsuario.Enabled = false;
                    btnModificarTipoUsuario.Enabled = false;
                }
                else
                {

                    msg_error msg = new msg_error("Se ha generado un error", 50, 156);
                    msg.Show();

                }


            }
            else
            {
                msg_info msg = new msg_info("No puedes dejar campos vacíos", 50, 156);
                msg.Show();

            }
        }

        private void btnEditarTipoUsuario_Click(object sender, EventArgs e)
        {
            txtNombreTipoUsuario.Enabled = true;
            btnAgregarTipoUsuario.Enabled = true;
            

        }

        private void dgvTipoUsuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int fila = e.RowIndex;
                txtIdTipoUsuario.Text = Convert.ToString(dgvTipoUsuario.Rows[fila].Cells[0].Value);
                txtNombreTipoUsuario.Text = dgvTipoUsuario.Rows[fila].Cells[1].Value.ToString();
                btnModificarTipoUsuario.Enabled = true;
                btnEliminarTipoUsuario.Enabled = true;
            }
            catch (Exception) {

            }
            
        }

        public void actualizar()
        {
            dgvTipoUsuario.DataSource = bdUser.BuscarTipoUsuario();
        }
    }
}
