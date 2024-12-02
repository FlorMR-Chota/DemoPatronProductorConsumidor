namespace DemoPatronProductorConsumidor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnRegistrar = new Button();
            txtCorreo = new TextBox();
            label2 = new Label();
            txtNombres = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnProcesar = new Button();
            dgvUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombres);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 279);
            panel1.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(128, 255, 255);
            btnRegistrar.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnRegistrar.Location = new Point(323, 229);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(22, 157);
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
            // panel2
            // 
            panel2.Controls.Add(btnProcesar);
            panel2.Controls.Add(dgvUsuarios);
            panel2.Location = new Point(12, 315);
            panel2.Name = "panel2";
            panel2.Size = new Size(575, 210);
            panel2.TabIndex = 1;
            // 
            // btnProcesar
            // 
            btnProcesar.BackColor = Color.FromArgb(128, 255, 255);
            btnProcesar.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            btnProcesar.Location = new Point(478, 13);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(94, 29);
            btnProcesar.TabIndex = 5;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = false;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Correo, Fecha });
            dgvUsuarios.Location = new Point(0, 0);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(472, 210);
            dgvUsuarios.TabIndex = 0;
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
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 115;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 537);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Demostracion patron Productor-Consumidor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnRegistrar;
        private TextBox txtCorreo;
        private Label label2;
        private TextBox txtNombres;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvUsuarios;
        private Button btnProcesar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Fecha;
    }
}
