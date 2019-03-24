namespace proyecto.GUI
{
    partial class frm_configuracion
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
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dgvTipoUsuario = new System.Windows.Forms.DataGridView();
            this.btnAgregarTipoUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnModificarTipoUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEliminarTipoUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditarTipoUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtIdTipoUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreTipoUsuario = new System.Windows.Forms.TextBox();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(15, 48);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(690, 23);
            this.materialTabSelector1.TabIndex = 0;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(15, 77);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(708, 431);
            this.materialTabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtNombreTipoUsuario);
            this.tabPage1.Controls.Add(this.txtIdTipoUsuario);
            this.tabPage1.Controls.Add(this.btnEditarTipoUsuario);
            this.tabPage1.Controls.Add(this.btnEliminarTipoUsuario);
            this.tabPage1.Controls.Add(this.btnModificarTipoUsuario);
            this.tabPage1.Controls.Add(this.btnAgregarTipoUsuario);
            this.tabPage1.Controls.Add(this.dgvTipoUsuario);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(700, 405);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tipos de Uusario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(700, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(47, 49);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(23, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ID";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(47, 115);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(187, 19);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Nombre de tipo de usuario";
            // 
            // dgvTipoUsuario
            // 
            this.dgvTipoUsuario.AllowUserToAddRows = false;
            this.dgvTipoUsuario.AllowUserToDeleteRows = false;
            this.dgvTipoUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTipoUsuario.BackgroundColor = System.Drawing.Color.White;
            this.dgvTipoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTipoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoUsuario.Location = new System.Drawing.Point(51, 166);
            this.dgvTipoUsuario.Name = "dgvTipoUsuario";
            this.dgvTipoUsuario.ReadOnly = true;
            this.dgvTipoUsuario.Size = new System.Drawing.Size(623, 168);
            this.dgvTipoUsuario.TabIndex = 9;
            this.dgvTipoUsuario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTipoUsuario_CellMouseClick);
            // 
            // btnAgregarTipoUsuario
            // 
            this.btnAgregarTipoUsuario.Depth = 0;
            this.btnAgregarTipoUsuario.Location = new System.Drawing.Point(572, 354);
            this.btnAgregarTipoUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarTipoUsuario.Name = "btnAgregarTipoUsuario";
            this.btnAgregarTipoUsuario.Primary = true;
            this.btnAgregarTipoUsuario.Size = new System.Drawing.Size(102, 26);
            this.btnAgregarTipoUsuario.TabIndex = 10;
            this.btnAgregarTipoUsuario.Text = "Agregar";
            this.btnAgregarTipoUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarTipoUsuario.Click += new System.EventHandler(this.btnAgregarTipoUsuario_Click);
            // 
            // btnModificarTipoUsuario
            // 
            this.btnModificarTipoUsuario.Depth = 0;
            this.btnModificarTipoUsuario.Location = new System.Drawing.Point(451, 354);
            this.btnModificarTipoUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarTipoUsuario.Name = "btnModificarTipoUsuario";
            this.btnModificarTipoUsuario.Primary = true;
            this.btnModificarTipoUsuario.Size = new System.Drawing.Size(102, 26);
            this.btnModificarTipoUsuario.TabIndex = 11;
            this.btnModificarTipoUsuario.Text = "Modificar";
            this.btnModificarTipoUsuario.UseVisualStyleBackColor = true;
            this.btnModificarTipoUsuario.Click += new System.EventHandler(this.txtModificarTipoUsuario_Click);
            // 
            // btnEliminarTipoUsuario
            // 
            this.btnEliminarTipoUsuario.Depth = 0;
            this.btnEliminarTipoUsuario.Location = new System.Drawing.Point(328, 354);
            this.btnEliminarTipoUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarTipoUsuario.Name = "btnEliminarTipoUsuario";
            this.btnEliminarTipoUsuario.Primary = true;
            this.btnEliminarTipoUsuario.Size = new System.Drawing.Size(102, 26);
            this.btnEliminarTipoUsuario.TabIndex = 12;
            this.btnEliminarTipoUsuario.Text = "Eliminar";
            this.btnEliminarTipoUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarTipoUsuario.Click += new System.EventHandler(this.btnEliminarTipoUsuario_Click);
            // 
            // btnEditarTipoUsuario
            // 
            this.btnEditarTipoUsuario.Depth = 0;
            this.btnEditarTipoUsuario.Location = new System.Drawing.Point(584, 21);
            this.btnEditarTipoUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarTipoUsuario.Name = "btnEditarTipoUsuario";
            this.btnEditarTipoUsuario.Primary = true;
            this.btnEditarTipoUsuario.Size = new System.Drawing.Size(102, 26);
            this.btnEditarTipoUsuario.TabIndex = 13;
            this.btnEditarTipoUsuario.Text = "Editar";
            this.btnEditarTipoUsuario.UseVisualStyleBackColor = true;
            this.btnEditarTipoUsuario.Click += new System.EventHandler(this.btnEditarTipoUsuario_Click);
            // 
            // txtIdTipoUsuario
            // 
            this.txtIdTipoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdTipoUsuario.Location = new System.Drawing.Point(51, 83);
            this.txtIdTipoUsuario.Name = "txtIdTipoUsuario";
            this.txtIdTipoUsuario.Size = new System.Drawing.Size(234, 13);
            this.txtIdTipoUsuario.TabIndex = 14;
            // 
            // txtNombreTipoUsuario
            // 
            this.txtNombreTipoUsuario.Location = new System.Drawing.Point(51, 140);
            this.txtNombreTipoUsuario.Name = "txtNombreTipoUsuario";
            this.txtNombreTipoUsuario.Size = new System.Drawing.Size(234, 20);
            this.txtNombreTipoUsuario.TabIndex = 15;
            // 
            // frm_configuracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(741, 575);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.materialTabSelector1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_configuracion";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.DataGridView dgvTipoUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnAgregarTipoUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditarTipoUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnEliminarTipoUsuario;
        private MaterialSkin.Controls.MaterialRaisedButton btnModificarTipoUsuario;
        private System.Windows.Forms.TextBox txtNombreTipoUsuario;
        private System.Windows.Forms.TextBox txtIdTipoUsuario;
    }
}