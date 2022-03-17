using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindForm9_3
{
    public partial class ForPrincipal : Form
    {
        public ForPrincipal()
        {
            InitializeComponent();
        }

        private void cargarPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }

        private void ForPrincipal_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola");
        }
    }
}
