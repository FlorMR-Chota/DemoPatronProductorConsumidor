namespace DemoPatronProductorConsumidor
{
    public partial class Form1 : Form
    {
        private int contadorId = 1;
        private Cola<Usuario> colaUsuarios;
        private Productor productor;
        private Consumidor consumidor;
        public Form1()
        {
            InitializeComponent();
            colaUsuarios = new Cola<Usuario>(10);
            productor = new Productor(colaUsuarios);
            consumidor = new Consumidor(colaUsuarios);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario(
                contadorId++,
                txtNombres.Text,
                txtCorreo.Text
                );
            ThreadPool.QueueUserWorkItem(
                state =>
                {
                    colaUsuarios.Agregar(nuevoUsuario);
                }
                );
            txtNombres.Clear();
            txtCorreo.Clear();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            Thread hiloConsumidor = new Thread(ProcesarUsuario);
            hiloConsumidor.Start();
        }

        private void ProcesarUsuario()
        {
            Usuario usuario=colaUsuarios.Extraer();
            AgregarUsuarioADataGrid(usuario);
        }
        private void AgregarUsuarioADataGrid(Usuario usuario)
        {
            if (dgvUsuarios.InvokeRequired)
            {
                dgvUsuarios.Invoke(new Action(() =>
                {
                    dgvUsuarios.Rows.Add(
                        usuario.Id,usuario.Nombre,
                        usuario.CorreoElectronico,
                        usuario.FechaCreacion
                        );
                })
                 );
            }
            else
            {
                dgvUsuarios.Rows.Add(
                   usuario.Id, usuario.Nombre,
                   usuario.CorreoElectronico,
                   usuario.FechaCreacion
                    );
            }
        }
    }
}
