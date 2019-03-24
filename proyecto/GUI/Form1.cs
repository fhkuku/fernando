using MaterialSkin;
using MaterialSkin.Controls;
using proyecto.alertas;
using proyecto.BO;
using proyecto.DAO;
using proyecto.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Form1 : MaterialForm
    {
        loginDAO bdLogin = new loginDAO();
        usuarioBO objeus = new usuarioBO();
        private DataTable count;
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue600, Primary.Blue700, Accent.Blue700, TextShade.WHITE);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtemail.Text != "" && txtpass.Text != "")
                {
                    objeus.email = txtemail.Text;
                    objeus.pass = txtpass.Text;
                    count = bdLogin.Login(objeus);

                    if (count.Rows.Count > 0)
                    {
                        int id = Convert.ToInt32(count.Rows[0]["id"]);
                        string nombre = count.Rows[0]["nombre"].ToString();
                        string apellidos = count.Rows[0]["apellidos"].ToString();
                        string turno = count.Rows[0]["turno"].ToString();
                        int idtipo = Convert.ToInt32(count.Rows[0]["idtipo"]);
                        string email = count.Rows[0]["email"].ToString();
                        frm_menu frm = new frm_menu(id, nombre, apellidos, turno, idtipo, email);
                        frm.Show();
                        string valor = "\"";
                        MessageBox.Show(valor);
                        this.Hide();
                    }
                    else
                    {
                        msg_error msg = new msg_error("Usuario o Contraseña incorrecta", 67, 157);
                        msg.Show();
                    }
                }
                else
                {
                    msg_info msg = new msg_info("No puedes dejar campos vacíos", 67, 157);
                    msg.Show();
                }
            }
            catch (Exception) {
                msg_error msg = new msg_error("Se ha generado un error desconocido", 65, 156);
                msg.Show();
            }


        }
    }
}
