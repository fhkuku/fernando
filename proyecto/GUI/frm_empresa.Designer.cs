namespace proyecto.GUI
{
    partial class frm_empresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnactualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtNombre = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDireccion = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTelefono = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btneditar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtCajones = new MaterialSkin.Controls.MaterialLabel();
            this.btninsertar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(51, 60);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Nombre";
            // 
            // btnactualizar
            // 
            this.btnactualizar.Depth = 0;
            this.btnactualizar.Location = new System.Drawing.Point(431, 291);
            this.btnactualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Primary = true;
            this.btnactualizar.Size = new System.Drawing.Size(121, 56);
            this.btnactualizar.TabIndex = 1;
            this.btnactualizar.Text = "Actualizar";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Depth = 0;
            this.txtNombre.Enabled = false;
            this.txtNombre.Hint = "";
            this.txtNombre.Location = new System.Drawing.Point(55, 83);
            this.txtNombre.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.Size = new System.Drawing.Size(488, 23);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Depth = 0;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Hint = "";
            this.txtDireccion.Location = new System.Drawing.Point(55, 165);
            this.txtDireccion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.PasswordChar = '\0';
            this.txtDireccion.SelectedText = "";
            this.txtDireccion.SelectionLength = 0;
            this.txtDireccion.SelectionStart = 0;
            this.txtDireccion.Size = new System.Drawing.Size(488, 23);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(51, 142);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(73, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Dirección";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Depth = 0;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Hint = "";
            this.txtTelefono.Location = new System.Drawing.Point(55, 249);
            this.txtTelefono.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.PasswordChar = '\0';
            this.txtTelefono.SelectedText = "";
            this.txtTelefono.SelectionLength = 0;
            this.txtTelefono.SelectionStart = 0;
            this.txtTelefono.Size = new System.Drawing.Size(488, 23);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(51, 227);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(69, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Telefono";
            // 
            // btneditar
            // 
            this.btneditar.Depth = 0;
            this.btneditar.Location = new System.Drawing.Point(464, 34);
            this.btneditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btneditar.Name = "btneditar";
            this.btneditar.Primary = true;
            this.btneditar.Size = new System.Drawing.Size(79, 20);
            this.btneditar.TabIndex = 7;
            this.btneditar.Text = "Modificar";
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // txtCajones
            // 
            this.txtCajones.AutoSize = true;
            this.txtCajones.Depth = 0;
            this.txtCajones.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtCajones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCajones.Location = new System.Drawing.Point(51, 309);
            this.txtCajones.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCajones.Name = "txtCajones";
            this.txtCajones.Size = new System.Drawing.Size(64, 19);
            this.txtCajones.TabIndex = 8;
            this.txtCajones.Text = "Cajones";
            // 
            // btninsertar
            // 
            this.btninsertar.Depth = 0;
            this.btninsertar.Location = new System.Drawing.Point(283, 291);
            this.btninsertar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Primary = true;
            this.btninsertar.Size = new System.Drawing.Size(121, 56);
            this.btninsertar.TabIndex = 9;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // frm_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 472);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.txtCajones);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.materialLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_empresa";
            this.Text = "frm_empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnactualizar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombre;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefono;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton btneditar;
        private MaterialSkin.Controls.MaterialLabel txtCajones;
        private MaterialSkin.Controls.MaterialRaisedButton btninsertar;
    }
}