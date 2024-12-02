using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoPatronProductorConsumidor.Pasteleria
{
    public partial class DemostracionPatronPasteleria : Form
    {
        private int contadorId = 1;
        private ColaPst<Cliente> colaCliente;
        private ProductorPast productor;
        private ConsumidorPst consumidor;
        public DemostracionPatronPasteleria()
        {
            InitializeComponent();
            colaCliente = new ColaPst<Cliente>(10);
            productor = new ProductorPast(colaCliente);
            consumidor = new ConsumidorPst(colaCliente);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente(
                contadorId++,
                txtNombres.Text,
                txtCorreo.Text,
                txtDireccion.Text
                );
            ThreadPool.QueueUserWorkItem(
                state =>
                {
                    colaCliente.Agregar(nuevoCliente);
                }
                );
            txtNombres.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
        }


        private void btnProcesar_Click_1(object sender, EventArgs e)
        {

            Thread hiloConsumidor = new Thread(ProcesarCliente);
            hiloConsumidor.Start();
        }

        private void ProcesarCliente()
        {
            Cliente cliente = colaCliente.Extraer();
            AgregarClienteADataGrid(cliente);
        }
        private void AgregarClienteADataGrid(Cliente cliente)
        {
            if (dgvClientes.InvokeRequired)
            {
                dgvClientes.Invoke(new Action(() =>
                {
                    dgvClientes.Rows.Add(
                        cliente.Id_Cliente, cliente.Nombre,
                        cliente.CorreoElectronico,
                        cliente.Direccion,
                        cliente.FechaFabricacion
                        );
                })
                 );
            }
            else
            {
                dgvClientes.Rows.Add(
                       cliente.Id_Cliente, cliente.Nombre,
                       cliente.CorreoElectronico,
                       cliente.Direccion,
                       cliente.FechaFabricacion
                       );
            }
        }


    }
}

            

