namespace DemoPatronProductorConsumidor.Pasteleria
{
    partial class DemostracionPatronPasteleria
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
            panel2 = new Panel();
            btnProcesar = new Button();
            dgvClientes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            txtDireccion = new TextBox();
            label3 = new Label();
            btnRegistrar = new Button();
            txtCorreo = new TextBox();
            label2 = new Label();
            txtNombres = new TextBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnProcesar);
            panel2.Controls.Add(dgvClientes);
            panel2.Location = new Point(23, 315);
            panel2.Name = "panel2";
            panel2.Size = new Size(717, 210);
            panel2.TabIndex = 3;
            // 
            // btnProcesar
            // 
            btnProcesar.BackColor = Color.FromArgb(128, 255, 255);
            btnProcesar.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnProcesar.Location = new Point(620, 16);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(94, 29);
            btnProcesar.TabIndex = 5;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = false;
            btnProcesar.Click += btnProcesar_Click_1;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Correo, Direccion, Fecha });
            dgvClientes.Location = new Point(0, 0);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(596, 210);
            dgvClientes.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 115;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 115;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            Direccion.Width = 115;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombres);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(23, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(538, 279);
            panel1.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(22, 230);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(395, 27);
            txtDireccion.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label3.Location = new Point(22, 203);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 5;
            label3.Text = "Direccion";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(128, 255, 255);
            btnRegistrar.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnRegistrar.Location = new Point(441, 230);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(22, 144);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(395, 27);
            txtCorreo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label2.Location = new Point(22, 107);
            label2.Name = "label2";
            label2.Size = new Size(158, 19);
            label2.TabIndex = 2;
            label2.Text = "Correo Electronico";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(22, 55);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(395, 27);
            txtNombres.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            label1.Location = new Point(22, 17);
            label1.Name = "label1";
            label1.Size = new Size(80, 19);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            // 
            // DemostracionPatronPasteleria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 554);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DemostracionPatronPasteleria";
            Text = "DemostracionPatronPasteleria";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnProcesar;
        private DataGridView dgvClientes;
        private Panel panel1;
        private Button btnRegistrar;
        private TextBox txtCorreo;
        private Label label2;
        private TextBox txtNombres;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Fecha;
        private TextBox txtDireccion;
        private Label label3;
    }
}