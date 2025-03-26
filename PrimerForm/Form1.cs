namespace PrimerForm
{
    public partial class frmPrimerProyecto : Form
    {
        public frmPrimerProyecto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCuadro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Seguro que deseas salir del programa?", "ATENCIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            string texto;
            texto = Microsoft.VisualBasic.Interaction.InputBox("Ingresa tu nombre por favor", "Bienvenido", "Ingresa aquí tu nombre");
            txtNombre.Text = texto;
        }

        private void btnDesdeTxtACuadro_Click(object sender, EventArgs e)
        {
            string nombre=txtNombre.Text;
            MessageBox.Show(nombre,$"BIENVENIDO/A {nombre}",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
