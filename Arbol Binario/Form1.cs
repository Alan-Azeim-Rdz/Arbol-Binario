namespace Arbol_Binario
{
    public partial class Form1 : Form
    {
        Binary_Tree binTree;
        public Form1()
        {
            InitializeComponent();
            binTree = new Binary_Tree();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                binTree.Insertar(valor);
                ActualizarLista();
                MessageBox.Show($"Valor {valor} insertado.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
            txtValor.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                bool encontrado = binTree.Buscar(valor);
                MessageBox.Show(encontrado ? $"Valor {valor} encontrado." : $"Valor {valor} no encontrado.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
            txtValor.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                binTree.Eliminar(valor);
                ActualizarLista();
                MessageBox.Show($"Valor {valor} eliminado (si existía).");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
            txtValor.Clear();
        }
        private void ActualizarLista()
        {
            binTree.ImprimirComoPiramide(lstValores);
        }
    }
}
