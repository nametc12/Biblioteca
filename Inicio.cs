using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            btnPrestamo.Enabled = false;
        }

        private void controlBotones()
        {
            if(Usuario.Text.Trim() != string.Empty && Usuario.Text.All(Char.IsLetter))
            {
                btnPrestamo.Enabled = true;
                errorProvider1.SetError(Usuario, "");
            }
            else
            {
                if (!(Usuario.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(Usuario, "El usuario debe contener caracteres");
                }
                else
                {
                    errorProvider1.SetError(Usuario, "Introduzca su usuario");
                }
                btnPrestamo.Enabled = false;
                Usuario.Focus();
            }
        }


        private void Usuario_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void btnPrestamo_Click(object sender, EventArgs e)
        {
            using (Prestamo vetanaPrestamo = new Prestamo(Usuario.Text))
                vetanaPrestamo.ShowDialog();
        }
    }
}
