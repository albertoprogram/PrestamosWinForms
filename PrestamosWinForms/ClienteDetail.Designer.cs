namespace PrestamosWinForms
{
    partial class ClienteDetail
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
            lblClienteId = new Label();
            lblClienteNombreCompleto = new Label();
            lblClienteNumeroTelefono = new Label();
            lblClienteEmail = new Label();
            lblClienteDireccion = new Label();
            txtClienteId = new TextBox();
            txtClienteNombreCompleto = new TextBox();
            txtClienteNumeroTelefono = new TextBox();
            txtClienteEmail = new TextBox();
            txtClienteDireccion = new TextBox();
            btnClienteGuardar = new Button();
            btnClientesListado = new Button();
            SuspendLayout();
            // 
            // lblClienteId
            // 
            lblClienteId.AutoSize = true;
            lblClienteId.Location = new Point(74, 81);
            lblClienteId.Name = "lblClienteId";
            lblClienteId.Size = new Size(85, 20);
            lblClienteId.TabIndex = 0;
            lblClienteId.Text = "lblClienteId";
            // 
            // lblClienteNombreCompleto
            // 
            lblClienteNombreCompleto.AutoSize = true;
            lblClienteNombreCompleto.Location = new Point(74, 130);
            lblClienteNombreCompleto.Name = "lblClienteNombreCompleto";
            lblClienteNombreCompleto.Size = new Size(193, 20);
            lblClienteNombreCompleto.TabIndex = 1;
            lblClienteNombreCompleto.Text = "lblClienteNombreCompleto";
            // 
            // lblClienteNumeroTelefono
            // 
            lblClienteNumeroTelefono.AutoSize = true;
            lblClienteNumeroTelefono.Location = new Point(74, 185);
            lblClienteNumeroTelefono.Name = "lblClienteNumeroTelefono";
            lblClienteNumeroTelefono.Size = new Size(184, 20);
            lblClienteNumeroTelefono.TabIndex = 2;
            lblClienteNumeroTelefono.Text = "lblClienteNumeroTelefono";
            // 
            // lblClienteEmail
            // 
            lblClienteEmail.AutoSize = true;
            lblClienteEmail.Location = new Point(74, 231);
            lblClienteEmail.Name = "lblClienteEmail";
            lblClienteEmail.Size = new Size(109, 20);
            lblClienteEmail.TabIndex = 3;
            lblClienteEmail.Text = "lblClienteEmail";
            // 
            // lblClienteDireccion
            // 
            lblClienteDireccion.AutoSize = true;
            lblClienteDireccion.Location = new Point(74, 278);
            lblClienteDireccion.Name = "lblClienteDireccion";
            lblClienteDireccion.Size = new Size(135, 20);
            lblClienteDireccion.TabIndex = 4;
            lblClienteDireccion.Text = "lblClienteDireccion";
            // 
            // txtClienteId
            // 
            txtClienteId.Location = new Point(354, 78);
            txtClienteId.Name = "txtClienteId";
            txtClienteId.Size = new Size(239, 27);
            txtClienteId.TabIndex = 5;
            // 
            // txtClienteNombreCompleto
            // 
            txtClienteNombreCompleto.Location = new Point(354, 127);
            txtClienteNombreCompleto.Name = "txtClienteNombreCompleto";
            txtClienteNombreCompleto.Size = new Size(239, 27);
            txtClienteNombreCompleto.TabIndex = 6;
            // 
            // txtClienteNumeroTelefono
            // 
            txtClienteNumeroTelefono.Location = new Point(354, 182);
            txtClienteNumeroTelefono.Name = "txtClienteNumeroTelefono";
            txtClienteNumeroTelefono.Size = new Size(239, 27);
            txtClienteNumeroTelefono.TabIndex = 7;
            // 
            // txtClienteEmail
            // 
            txtClienteEmail.Location = new Point(354, 228);
            txtClienteEmail.Name = "txtClienteEmail";
            txtClienteEmail.Size = new Size(239, 27);
            txtClienteEmail.TabIndex = 8;
            // 
            // txtClienteDireccion
            // 
            txtClienteDireccion.Location = new Point(354, 275);
            txtClienteDireccion.Name = "txtClienteDireccion";
            txtClienteDireccion.Size = new Size(239, 27);
            txtClienteDireccion.TabIndex = 9;
            // 
            // btnClienteGuardar
            // 
            btnClienteGuardar.Location = new Point(499, 373);
            btnClienteGuardar.Name = "btnClienteGuardar";
            btnClienteGuardar.Size = new Size(177, 29);
            btnClienteGuardar.TabIndex = 10;
            btnClienteGuardar.Text = "btnClienteGuardar";
            btnClienteGuardar.UseVisualStyleBackColor = true;
            btnClienteGuardar.Click += btnGuardar_Click;
            // 
            // btnClientesListado
            // 
            btnClientesListado.Location = new Point(305, 373);
            btnClientesListado.Name = "btnClientesListado";
            btnClientesListado.Size = new Size(169, 29);
            btnClientesListado.TabIndex = 11;
            btnClientesListado.Text = "btnClientesListado";
            btnClientesListado.UseVisualStyleBackColor = true;
            btnClientesListado.Click += btnClientesListado_Click;
            // 
            // ClienteDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClientesListado);
            Controls.Add(btnClienteGuardar);
            Controls.Add(txtClienteDireccion);
            Controls.Add(txtClienteEmail);
            Controls.Add(txtClienteNumeroTelefono);
            Controls.Add(txtClienteNombreCompleto);
            Controls.Add(txtClienteId);
            Controls.Add(lblClienteDireccion);
            Controls.Add(lblClienteEmail);
            Controls.Add(lblClienteNumeroTelefono);
            Controls.Add(lblClienteNombreCompleto);
            Controls.Add(lblClienteId);
            Name = "ClienteDetail";
            Text = "ClienteDetail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClienteId;
        private Label lblClienteNombreCompleto;
        private Label lblClienteNumeroTelefono;
        private Label lblClienteEmail;
        private Label lblClienteDireccion;
        private TextBox txtClienteId;
        private TextBox txtClienteNombreCompleto;
        private TextBox txtClienteNumeroTelefono;
        private TextBox txtClienteEmail;
        private TextBox txtClienteDireccion;
        private Button btnClienteGuardar;
        private Button btnClientesListado;
    }
}