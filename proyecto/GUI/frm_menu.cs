using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class frm_menu : MaterialForm
    {
        public frm_menu(int id, string nombre, string apellidos,string turno, int idtipo, string email)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue600, Primary.Blue700, Accent.Blue700, TextShade.WHITE);
            pnlMenu.Width = 187;
            pnlContainer.Controls.Clear();
            txtName.ForeColor = Color.White;
            txtName.Text = nombre + " " + apellidos;
            if (idtipo == 1) {
                txtTipo.Text = "Administrador";
            }
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 187){
                pnlMenu.Width = 48;
            }
            else {
                pnlMenu.Width = 187;
            }
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            frm_empresa frm = new frm_empresa();
            frm.TopLevel = false;
            pnlContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            frm_configuracion frm = new frm_configuracion();
            frm.TopLevel = false;
            pnlContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();

        }
    }
}
