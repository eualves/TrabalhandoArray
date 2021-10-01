using System.Windows.Forms;

namespace TrabalhandoArray
{
    public partial class TelaArrayParams : Form
    {
        public TelaArrayParams()
        {
            InitializeComponent();
        }

        private decimal UsandoArrayParams(params decimal[] numeros)
        {
            decimal soma = 0;

            for (int i = 0; i <= numeros.GetLength(0) - 1; i++)
            {
                soma += numeros[i];
            }

            return soma / numeros.Length;
        }

        private void TelaArrayParams_Load(object sender, System.EventArgs e)
        {

        }

        private void btnExecutar_Click(object sender, System.EventArgs e)
        {
            lblResul.Items.Add("Média dos Valores 25,45,78,15,18 é " + UsandoArrayParams(25, 45, 78, 15, 18));
        }
    }
}
