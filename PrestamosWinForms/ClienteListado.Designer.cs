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
            cbRegistrosXPagina = new ComboBox();
            lblRegistrosXPagina = new Label();
            lblPagina = new Label();
            txtPagina = new TextBox();
            linkLblInicio = new LinkLabel();
            linkLblFinal = new LinkLabel();
            linkLblAnterior = new LinkLabel();
            linkLblSiguiente = new LinkLabel();
            lblTotalRegistros = new Label();
            lblTotalRegistrosValue = new Label();
            lblTotalPaginas = new Label();
            lblTotalPaginasValue = new Label();
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
            // cbRegistrosXPagina
            // 
            cbRegistrosXPagina.FormattingEnabled = true;
            cbRegistrosXPagina.Items.AddRange(new object[] { "2", "3", "5" });
            cbRegistrosXPagina.Location = new Point(201, 503);
            cbRegistrosXPagina.Name = "cbRegistrosXPagina";
            cbRegistrosXPagina.Size = new Size(67, 28);
            cbRegistrosXPagina.TabIndex = 1;
            cbRegistrosXPagina.Text = "2";
            cbRegistrosXPagina.SelectedIndexChanged += cbRegistrosXPagina_SelectedIndexChanged;
            // 
            // lblRegistrosXPagina
            // 
            lblRegistrosXPagina.AutoSize = true;
            lblRegistrosXPagina.Location = new Point(55, 506);
            lblRegistrosXPagina.Name = "lblRegistrosXPagina";
            lblRegistrosXPagina.Size = new Size(140, 20);
            lblRegistrosXPagina.TabIndex = 2;
            lblRegistrosXPagina.Text = "lblRegistrosXPagina";
            // 
            // lblPagina
            // 
            lblPagina.AutoSize = true;
            lblPagina.Location = new Point(274, 506);
            lblPagina.Name = "lblPagina";
            lblPagina.Size = new Size(70, 20);
            lblPagina.TabIndex = 3;
            lblPagina.Text = "lblPagina";
            // 
            // txtPagina
            // 
            txtPagina.Location = new Point(350, 503);
            txtPagina.Name = "txtPagina";
            txtPagina.Size = new Size(53, 27);
            txtPagina.TabIndex = 4;
            txtPagina.Text = "1";
            txtPagina.Click += txtPagina_Click;
            txtPagina.Enter += txtPagina_Enter;
            txtPagina.KeyDown += txtPagina_KeyDown;
            // 
            // linkLblInicio
            // 
            linkLblInicio.AutoSize = true;
            linkLblInicio.Location = new Point(778, 500);
            linkLblInicio.Name = "linkLblInicio";
            linkLblInicio.Size = new Size(88, 20);
            linkLblInicio.TabIndex = 5;
            linkLblInicio.TabStop = true;
            linkLblInicio.Text = "linkLblInicio";
            linkLblInicio.LinkClicked += linkLblInicio_LinkClicked;
            // 
            // linkLblFinal
            // 
            linkLblFinal.AutoSize = true;
            linkLblFinal.Location = new Point(1157, 500);
            linkLblFinal.Name = "linkLblFinal";
            linkLblFinal.Size = new Size(83, 20);
            linkLblFinal.TabIndex = 6;
            linkLblFinal.TabStop = true;
            linkLblFinal.Text = "linkLblFinal";
            linkLblFinal.LinkClicked += linkLblFinal_LinkClicked;
            // 
            // linkLblAnterior
            // 
            linkLblAnterior.AutoSize = true;
            linkLblAnterior.Location = new Point(907, 500);
            linkLblAnterior.Name = "linkLblAnterior";
            linkLblAnterior.Size = new Size(106, 20);
            linkLblAnterior.TabIndex = 7;
            linkLblAnterior.TabStop = true;
            linkLblAnterior.Text = "linkLblAnterior";
            linkLblAnterior.LinkClicked += linkLblAnterior_LinkClicked;
            // 
            // linkLblSiguiente
            // 
            linkLblSiguiente.AutoSize = true;
            linkLblSiguiente.Location = new Point(1019, 500);
            linkLblSiguiente.Name = "linkLblSiguiente";
            linkLblSiguiente.Size = new Size(114, 20);
            linkLblSiguiente.TabIndex = 8;
            linkLblSiguiente.TabStop = true;
            linkLblSiguiente.Text = "linkLblSiguiente";
            linkLblSiguiente.LinkClicked += linkLblSiguiente_LinkClicked;
            // 
            // lblTotalRegistros
            // 
            lblTotalRegistros.AutoSize = true;
            lblTotalRegistros.Location = new Point(409, 506);
            lblTotalRegistros.Name = "lblTotalRegistros";
            lblTotalRegistros.Size = new Size(120, 20);
            lblTotalRegistros.TabIndex = 9;
            lblTotalRegistros.Text = "lblTotalRegistros";
            // 
            // lblTotalRegistrosValue
            // 
            lblTotalRegistrosValue.AutoSize = true;
            lblTotalRegistrosValue.Location = new Point(535, 506);
            lblTotalRegistrosValue.Name = "lblTotalRegistrosValue";
            lblTotalRegistrosValue.Size = new Size(156, 20);
            lblTotalRegistrosValue.TabIndex = 10;
            lblTotalRegistrosValue.Text = "lblTotalRegistrosValue";
            // 
            // lblTotalPaginas
            // 
            lblTotalPaginas.AutoSize = true;
            lblTotalPaginas.Location = new Point(409, 536);
            lblTotalPaginas.Name = "lblTotalPaginas";
            lblTotalPaginas.Size = new Size(109, 20);
            lblTotalPaginas.TabIndex = 11;
            lblTotalPaginas.Text = "lblTotalPaginas";
            // 
            // lblTotalPaginasValue
            // 
            lblTotalPaginasValue.AutoSize = true;
            lblTotalPaginasValue.Location = new Point(535, 536);
            lblTotalPaginasValue.Name = "lblTotalPaginasValue";
            lblTotalPaginasValue.Size = new Size(145, 20);
            lblTotalPaginasValue.TabIndex = 12;
            lblTotalPaginasValue.Text = "lblTotalPaginasValue";
            // 
            // ClienteListado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1317, 630);
            Controls.Add(lblTotalPaginasValue);
            Controls.Add(lblTotalPaginas);
            Controls.Add(lblTotalRegistrosValue);
            Controls.Add(lblTotalRegistros);
            Controls.Add(linkLblSiguiente);
            Controls.Add(linkLblAnterior);
            Controls.Add(linkLblFinal);
            Controls.Add(linkLblInicio);
            Controls.Add(txtPagina);
            Controls.Add(lblPagina);
            Controls.Add(lblRegistrosXPagina);
            Controls.Add(cbRegistrosXPagina);
            Controls.Add(dgvClientes);
            Name = "ClienteListado";
            Text = "ClienteListado";
            Load += ClienteListado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn NumeroTelefono;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Direccion;
        private ComboBox cbRegistrosXPagina;
        private Label lblRegistrosXPagina;
        private Label lblPagina;
        private TextBox txtPagina;
        private LinkLabel linkLblInicio;
        private LinkLabel linkLblFinal;
        private LinkLabel linkLblAnterior;
        private LinkLabel linkLblSiguiente;
        private Label lblTotalRegistros;
        private Label lblTotalRegistrosValue;
        private Label lblTotalPaginas;
        private Label lblTotalPaginasValue;
    }
}