using PrestamosWinForms.Entidades;
using PrestamosWinForms.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (txtPagina.Text == "1") linkLblInicio.Enabled = false;

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

            if (Convert.ToInt32(txtPagina.Text) > 1) linkLblInicio.Enabled = true;

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
    }
}
