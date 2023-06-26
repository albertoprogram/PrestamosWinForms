namespace PrestamosWinForms
{
    partial class ClienteListado
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
            dgvClientes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            NumeroTelefono = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Id, NombreCompleto, NumeroTelefono, Email, Direccion });
            dgvClientes.Location = new Point(55, 101);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowTemplate.Height = 29;
            dgvClientes.Size = new Size(1185, 396);
            dgvClientes.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // NombreCompleto
            // 
            NombreCompleto.HeaderText = "NombreCompleto";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 125;
            // 
            // NumeroTelefono
            // 
            NumeroTelefono.HeaderText = "NumeroTelefono";
            NumeroTelefono.MinimumWidth = 6;
            NumeroTelefono.Name = "NumeroTelefono";
            NumeroTelefono.ReadOnly = true;
            NumeroTelefono.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 125;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            Direccion.Width = 125;
            // 
            // ClienteListado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 568);
            Controls.Add(dgvClientes);
            Name = "ClienteListado";
            Text = "ClienteListado";
            Load += ClienteListado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn NumeroTelefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Direccion;
    }
}