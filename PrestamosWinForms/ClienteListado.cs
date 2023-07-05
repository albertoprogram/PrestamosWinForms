using PrestamosWinForms.Entidades;
using PrestamosWinForms.Servicios;

namespace PrestamosWinForms
{
    public partial class ClienteListado : Form
    {
        int pagina;
        int registros;

        public ClienteListado()
        {
            InitializeComponent();
        }

        private void ClienteListado_Load(object sender, EventArgs e)
        {
            if (txtPagina.Text == "1")
            {
                linkLblInicio.Enabled = false;
                linkLblAnterior.Enabled = false;
            }

            ServiciosCliente serviciosCliente = new ServiciosCliente();

            lblTotalRegistrosValue.Text = serviciosCliente.CantidadTotalClientes().ToString();

            int resto = Convert.ToInt32(lblTotalRegistrosValue.Text) %
                Convert.ToInt32(cbRegistrosXPagina.Text);

            lblTotalPaginasValue.Text = resto == 0 ?
                (Convert.ToInt32(lblTotalRegistrosValue.Text) /
                Convert.ToInt32(cbRegistrosXPagina.Text)).ToString() :
                ((Convert.ToInt32(lblTotalRegistrosValue.Text) /
                Convert.ToInt32(cbRegistrosXPagina.Text)) + 1).ToString();

            pagina = Convert.ToInt32(txtPagina.Text);

            registros = Convert.ToInt32(cbRegistrosXPagina.Text);

            List<Cliente> clientes = serviciosCliente.ObtenerClientes(pagina, registros);

            if (clientes.Count > 0)
            {
                foreach (Cliente cliente in clientes)
                {
                    dgvClientes.Rows.Add(
                        cliente.Id,
                        cliente.NombreCompleto,
                        cliente.NumeroTelefono,
                        cliente.Email,
                        cliente.Direccion);
                }
            }
        }

        private void linkLblSiguiente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ServiciosCliente serviciosCliente = new ServiciosCliente();

            pagina = Convert.ToInt32(txtPagina.Text) + 1;

            txtPagina.Text = pagina.ToString();

            if (Convert.ToInt32(txtPagina.Text) > 1)
            {
                linkLblInicio.Enabled = true;
                linkLblAnterior.Enabled = true;
            }

            registros = Convert.ToInt32(cbRegistrosXPagina.Text);

            List<Cliente> clientes = serviciosCliente.ObtenerClientes(pagina, registros);

            if (clientes.Count > 0)
            {
                dgvClientes.Rows.Clear();

                foreach (Cliente cliente in clientes)
                {
                    dgvClientes.Rows.Add(
                        cliente.Id,
                        cliente.NombreCompleto,
                        cliente.NumeroTelefono,
                        cliente.Email,
                        cliente.Direccion);
                }
            }

            if (txtPagina.Text == lblTotalPaginasValue.Text)
            {
                linkLblSiguiente.Enabled = false;
                linkLblFinal.Enabled = false;
            }
        }

        private void linkLblInicio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ServiciosCliente serviciosCliente = new ServiciosCliente();

            pagina = 1;

            txtPagina.Text = pagina.ToString();

            if (Convert.ToInt32(txtPagina.Text) == 1)
            {
                linkLblInicio.Enabled = false;
                linkLblAnterior.Enabled = false;

                linkLblSiguiente.Enabled = true;
                linkLblFinal.Enabled = true;
            }

            registros = Convert.ToInt32(cbRegistrosXPagina.Text);

            List<Cliente> clientes = serviciosCliente.ObtenerClientes(pagina, registros);

            if (clientes.Count > 0)
            {
                dgvClientes.Rows.Clear();

                foreach (Cliente cliente in clientes)
                {
                    dgvClientes.Rows.Add(
                        cliente.Id,
                        cliente.NombreCompleto,
                        cliente.NumeroTelefono,
                        cliente.Email,
                        cliente.Direccion);
                }
            }
        }

        private void linkLblAnterior_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ServiciosCliente serviciosCliente = new ServiciosCliente();

            pagina = Convert.ToInt32(txtPagina.Text) - 1;

            txtPagina.Text = pagina.ToString();

            if (Convert.ToInt32(txtPagina.Text) > 1)
            {
                linkLblInicio.Enabled = true;
                linkLblAnterior.Enabled = true;
            }
            else if (Convert.ToInt32(txtPagina.Text) == 1)
            {
                linkLblInicio.Enabled = false;
                linkLblAnterior.Enabled = false;

                linkLblSiguiente.Enabled = true;
                linkLblFinal.Enabled = true;
            }

            registros = Convert.ToInt32(cbRegistrosXPagina.Text);

            List<Cliente> clientes = serviciosCliente.ObtenerClientes(pagina, registros);

            if (clientes.Count > 0)
            {
                dgvClientes.Rows.Clear();

                foreach (Cliente cliente in clientes)
                {
                    dgvClientes.Rows.Add(
                        cliente.Id,
                        cliente.NombreCompleto,
                        cliente.NumeroTelefono,
                        cliente.Email,
                        cliente.Direccion);
                }
            }

            if (txtPagina.Text != lblTotalPaginasValue.Text)
            {
                linkLblSiguiente.Enabled = true;
                linkLblFinal.Enabled = true;
            }
        }

        private void linkLblFinal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ServiciosCliente serviciosCliente = new ServiciosCliente();

            pagina = Convert.ToInt32(lblTotalPaginasValue.Text);

            txtPagina.Text = pagina.ToString();

            if (Convert.ToInt32(txtPagina.Text) > 1)
            {
                linkLblInicio.Enabled = true;
                linkLblAnterior.Enabled = true;
            }

            registros = Convert.ToInt32(cbRegistrosXPagina.Text);

            List<Cliente> clientes = serviciosCliente.ObtenerClientes(pagina, registros);

            if (clientes.Count > 0)
            {
                dgvClientes.Rows.Clear();

                foreach (Cliente cliente in clientes)
                {
                    dgvClientes.Rows.Add(
                        cliente.Id,
                        cliente.NombreCompleto,
                        cliente.NumeroTelefono,
                        cliente.Email,
                        cliente.Direccion);
                }
            }

            if (txtPagina.Text == lblTotalPaginasValue.Text)
            {
                linkLblSiguiente.Enabled = false;
                linkLblFinal.Enabled = false;
            }
        }

        private void cbRegistrosXPagina_SelectedIndexChanged(object sender, EventArgs e)
        {
            ServiciosCliente serviciosCliente = new ServiciosCliente();

            lblTotalRegistrosValue.Text = serviciosCliente.CantidadTotalClientes().ToString();

            int resto = Convert.ToInt32(lblTotalRegistrosValue.Text) %
                Convert.ToInt32(cbRegistrosXPagina.Text);

            lblTotalPaginasValue.Text = resto == 0 ?
                (Convert.ToInt32(lblTotalRegistrosValue.Text) /
                Convert.ToInt32(cbRegistrosXPagina.Text)).ToString() :
                ((Convert.ToInt32(lblTotalRegistrosValue.Text) /
                Convert.ToInt32(cbRegistrosXPagina.Text)) + 1).ToString();

            pagina = 1;

            txtPagina.Text = pagina.ToString();

            registros = Convert.ToInt32(cbRegistrosXPagina.Text);

            List<Cliente> clientes = serviciosCliente.ObtenerClientes(pagina, registros);

            if (clientes.Count > 0)
            {
                dgvClientes.Rows.Clear();

                foreach (Cliente cliente in clientes)
                {
                    dgvClientes.Rows.Add(
                        cliente.Id,
                        cliente.NombreCompleto,
                        cliente.NumeroTelefono,
                        cliente.Email,
                        cliente.Direccion);
                }
            }

            if (txtPagina.Text == "1")
            {
                linkLblInicio.Enabled = false;
                linkLblAnterior.Enabled = false;

                linkLblSiguiente.Enabled = true;
                linkLblFinal.Enabled = true;
            }
        }

        private void txtPagina_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (Convert.ToInt32(txtPagina.Text) <= Convert.ToInt32(lblTotalPaginasValue.Text))
                {
                    ServiciosCliente serviciosCliente = new ServiciosCliente();

                    if (Convert.ToInt32(txtPagina.Text) > 1)
                    {
                        linkLblInicio.Enabled = true;
                        linkLblAnterior.Enabled = true;
                    }

                    if (Convert.ToInt32(txtPagina.Text) == 1)
                    {
                        linkLblInicio.Enabled = false;
                        linkLblAnterior.Enabled = false;

                        linkLblSiguiente.Enabled = true;
                        linkLblFinal.Enabled = true;
                    }

                    pagina = Convert.ToInt32(txtPagina.Text);
                    registros = Convert.ToInt32(cbRegistrosXPagina.Text);

                    List<Cliente> clientes = serviciosCliente.ObtenerClientes(pagina, registros);

                    if (clientes.Count > 0)
                    {
                        dgvClientes.Rows.Clear();

                        foreach (Cliente cliente in clientes)
                        {
                            dgvClientes.Rows.Add(
                                cliente.Id,
                                cliente.NombreCompleto,
                                cliente.NumeroTelefono,
                                cliente.Email,
                                cliente.Direccion);
                        }
                    }

                    if (txtPagina.Text == lblTotalPaginasValue.Text)
                    {
                        linkLblSiguiente.Enabled = false;
                        linkLblFinal.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una página no mayor a la cantidad total de páginas", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    ServiciosCliente serviciosCliente = new ServiciosCliente();

                    pagina = 1;

                    txtPagina.Text = pagina.ToString();

                    if (Convert.ToInt32(txtPagina.Text) == 1)
                    {
                        linkLblInicio.Enabled = false;
                        linkLblAnterior.Enabled = false;

                        linkLblSiguiente.Enabled = true;
                        linkLblFinal.Enabled = true;
                    }

                    registros = Convert.ToInt32(cbRegistrosXPagina.Text);

                    List<Cliente> clientes = serviciosCliente.ObtenerClientes(pagina, registros);

                    if (clientes.Count > 0)
                    {
                        dgvClientes.Rows.Clear();

                        foreach (Cliente cliente in clientes)
                        {
                            dgvClientes.Rows.Add(
                                cliente.Id,
                                cliente.NombreCompleto,
                                cliente.NumeroTelefono,
                                cliente.Email,
                                cliente.Direccion);
                        }
                    }
                }
            }
        }

        private void txtPagina_Enter(object sender, EventArgs e)
        {
            txtPagina.SelectAll();
        }

        private void txtPagina_Click(object sender, EventArgs e)
        {
            txtPagina.SelectAll();
        }
    }
}
