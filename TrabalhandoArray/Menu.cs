using System;
using System.Windows.Forms;

namespace TrabalhandoArray
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();

            // this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaArrayParams TelaParams = new TelaArrayParams();
            TelaParams.Show();
        }
    }
}
