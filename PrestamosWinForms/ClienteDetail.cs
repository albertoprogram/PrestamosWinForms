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
    public partial class ClienteDetail : Form
    {
        public ClienteDetail()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Id = txtClienteId.Text;
            cliente.NombreCompleto = txtClienteNombreCompleto.Text;
            cliente.NumeroTelefono = txtClienteNumeroTelefono.Text;
            cliente.Email = txtClienteEmail.Text;
            cliente.Direccion = txtClienteDireccion.Text;

            ServiciosCliente serviciosCliente = new ServiciosCliente();

            try
            {
                serviciosCliente.InsertarCliente(cliente);

                MessageBox.Show("El registro ha sido insertado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClientesListado_Click(object sender, EventArgs e)
        {
            ClienteListado clienteListado = new ClienteListado();

            clienteListado.Show();
        }
    }
}
