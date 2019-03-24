using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto.BO;
using proyecto.DAO;

namespace proyecto.GUI
{
    public partial class EstacionamientoFrm : Form
    {
        estacionamientoBO odo = new estacionamientoBO(); estacionamientoDAO oda = new estacionamientoDAO();
        public EstacionamientoFrm()
        {
            InitializeComponent();
            dgvEstacionamiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstacionamiento.ReadOnly = true;
            dgvEstacionamiento.AllowUserToAddRows = false;
            dgvEstacionamiento.DataSource = oda.BuscarESTACIONAMIENTO();
            cboEmpresa.DataSource = oda.RecuperarEmpresa();
            cboEmpresa.DisplayMember = "nombre";
            cboEmpresa.ValueMember = "id";
            cboEmpresa.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
