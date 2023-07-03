using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Prestamo : Form
    {

        string Usuario_Cliente;
        string[] Raza_Disponible = { "Negro", "Blanco" };
        int[] Cuotas_Disponibles = { 12, 24, 36, 60, 120, 180, 240 };
        string[] Lugare_Disponibles;
        Dictionary<int, double> Intereses_base;


        public Prestamo(string Cliente)
        {
            InitializeComponent();
            Usuario_Cliente = Cliente;

            string Listado_Ciudad = Properties.Resources.lugares.ToString();
            Lugare_Disponibles = Listado_Ciudad.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            Intereses_base = new Dictionary<int, double>();
            int i;
            double intereses;
            for(i = 0, intereses = 3.0; i < Cuotas_Disponibles.Length; i++, intereses += 0.5)
            {
                Intereses_base[Cuotas_Disponibles[i]] = intereses;
            }
        }

        private void Prestamo_Load(object sender, EventArgs e)
        {
            popularCuota();
            popularRaza();
            popularCiudad();
            Bienvenida.Text += Usuario_Cliente;
        }

        void popularCuota()
        {
            for(int i = 0; i <Cuotas_Disponibles.Length; i++)
            {
                Cuota.Items.Add(Cuotas_Disponibles[i]);
            }
        }

        void popularRaza()
        {
            for (int i = 0; i < Raza_Disponible.Length; i++)
            {
                Raza.Items.Add(Raza_Disponible[i]);
            }
        }

        void popularCiudad()
        {
            for (int i = 0; i < Lugare_Disponibles.Length; i++)
            {
                Lugar.Items.Add(Lugare_Disponibles[i]);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        double CalcularInteres()
        {
            int cuotas_pedidas = (int)Cuota.SelectedItem;
            string Raza_Seleccionada = Raza.SelectedItem.ToString().ToLower();
            string Lugar_Seleccionada = Lugar.SelectedItem.ToString().ToLower();
            double intereses = Intereses_base[cuotas_pedidas];
            if (new[] { "Negro" }.Contains(Raza_Seleccionada))
            {
                intereses += 0.3;
            }
            if (new[] { "Suiza","Noruega", "Islandia","Luxemburgo" }.Contains(Lugar_Seleccionada))
            {
                intereses -= 0.3;
            }
            return intereses;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (validacion())
            {
                case 0:
                    {
                        errorProvider1.SetError(DTPersonales, "");
                        errorProvider1.SetError(DDPrestamo, "");
                        double interes_Mensual = CalcularInteres();
                        double monto_Pedido = double.Parse(MTPrestamo.Text);
                        int cuotas_pedidas = (int)Cuota.SelectedItem;
                        double interes_Total = monto_Pedido * (interes_Mensual / 100) * cuotas_pedidas;
                        double monto_a_pagar = monto_Pedido + interes_Total;
                        string mensaje = "Su Prestamo Por" + monto_Pedido + " en " + cuotas_pedidas + " cuotas se considera con un interes del " + interes_Mensual + "% mensual\nEl monton total es de " + monto_a_pagar;
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(mensaje, "calculo de intereses", buttons);
                        break;
                    }
                case 1:
                    {
                        errorProvider1.SetError(DTPersonales, "Debe completar los datos");
                        errorProvider1.SetError(DTPersonales, "");
                        break;
                    }
                case 2:
                    {
                        errorProvider1.SetError(DTPersonales, "Debe ingresar monto correcto");
                        errorProvider1.SetError(DTPersonales, "");
                        break;
                    }
            }

        }
        int validacion()
        {
            if((Raza.SelectedIndex <= -1) || (Lugar.SelectedIndex <= -1))
            {
                return 1;
            }
            else
            {
                if (!(MTPrestamo.Text.All(Char.IsDigit)) || (MTPrestamo.Text == "") || (Cuota.SelectedIndex <= -1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

