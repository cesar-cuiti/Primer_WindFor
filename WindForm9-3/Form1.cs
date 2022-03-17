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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje agregado");
            string elemento = txtNombre.Text;
            listElementos.Items.Add(elemento);
        }

        private void listElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Azul");
            comboBox1.Items.Add("Rojo");
            comboBox1.Items.Add("Verde");
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtColorFavorito.Value;
            string edad = ckbMayor.Checked == true ? " Mayor de edad " : " Menor de edad ";
            string tipo;
            if (rbtnCasado.Checked)
                tipo = " Casado ";
            else if (rbtnSoltero.Checked)
                tipo = " Soltero ";
            else
                tipo = " Elegir opcion ";
            string colorFavorito = comboBox1.SelectedItem.ToString();
            string mensaje = " Color Favorito " + colorFavorito + " estado civil " + tipo;
            MessageBox.Show("Nombre " + nombre + "fecha nac " + fecha + " edad " + edad + mensaje );

        }
    }
}
