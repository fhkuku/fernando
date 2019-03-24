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
    public partial class frm_empresa : Form
    {
        EmpresaBO objetEmpresa = new EmpresaBO();
        empresaDAO bd = new empresaDAO();
        private DataTable datos;
        private int response;
        public frm_empresa()
        {
            InitializeComponent();

            datos = bd.ValidarEmpresa();
            if (datos.Rows.Count > 0) {
                btninsertar.Visible = false;
                datos = bd.CountCajones();
                txtCajones.Text ="El número total de cajones es "+ datos.Rows[0]["cajones"].ToString();
                datos = bd.EmpresaDatos();
                objetEmpresa.id = Convert.ToInt32(datos.Rows[0]["id"]);
                txtNombre.Text = datos.Rows[0]["nombre"].ToString();
                txtDireccion.Text = datos.Rows[0]["direccion"].ToString();
                txtTelefono.Text = datos.Rows[0]["telefono"].ToString();


            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "")
                {
                    data();
                    response = bd.AgregarEmpresa(objetEmpresa);
                    if (response > 0)
                    {
                        msg_exito msg = new msg_exito("Se ha Agregado Correctamente la empresa", 48, 156);
                        msg.Show();
                        btninsertar.Visible = false;
                        datos = bd.MaximoEmpresa();
                        objetEmpresa.id = Convert.ToInt32(datos.Rows[0]["id"]);
                        EliminarTexto();
                    }
                    else
                    {
                        msg_error msg = new msg_error("Se ha generado un error intentelo de nuevo", 60, 156);
                        msg.Show();
                    }
                }
                else
                {
                    msg_info msg = new msg_info("No puedes dejar campos vacíos", 67, 156);
                    msg.Show();

                }
            }
            catch (Exception) { 

                msg_error msg = new msg_error("Se ha generado un error desconocido", 65, 156);
                msg.Show();

            }


        }

        public void data() {
            objetEmpresa.nombre = txtNombre.Text;
            objetEmpresa.direccion = txtDireccion.Text;
            objetEmpresa.telefono = txtTelefono.Text;
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "")
                {
                    data();
                    
                    response = bd.ModificarEmpresa(objetEmpresa);
                    if (response > 0){

                        msg_exito msg = new msg_exito("Se ha Actualizado Correctamente la empresa", 23, 156);
                        msg.Show();
                        EliminarTexto();
                    }
                    else{
                        msg_error msg = new msg_error("Se ha generado un error intentelo de nuevo", 60, 156);
                        msg.Show();
                    }
                }
                else{
                    msg_info msg = new msg_info("No puedes dejar campos vacíos", 60, 156);
                    msg.Show();

                }
            }
            catch (Exception) {
                msg_error msg = new msg_error("Se ha generado un error desconocido", 65, 156);
                msg.Show();
            }

        }

        public void EliminarTexto() {
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
        }
    }
}
