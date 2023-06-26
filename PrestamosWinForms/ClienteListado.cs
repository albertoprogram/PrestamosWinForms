using PrestamosWinForms.Entidades;
using PrestamosWinForms.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrestamosWinForms
{
    public partial class ClienteListado : Form
    {
        public ClienteListado()
        {
            InitializeComponent();
        }

        private void ClienteListado_Load(object sender, EventArgs e)
        {
            ServiciosCliente serviciosCliente = new ServiciosCliente();

            List<Cliente> clientes = serviciosCliente.ObtenerClientes();

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
    }
}
