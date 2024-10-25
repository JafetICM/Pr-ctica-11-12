using System;
using System.Windows.Forms;

namespace EstacionamientoApp
{
    public partial class Form1 : Form
    {
        Estacionamiento estacionamiento = new Estacionamiento(); // Instancia de la clase Estacionamiento

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEntrada_Click(object sender, EventArgs e)
        {
            string placas = textBoxPlacas.Text;
            string propietario = textBoxPropietario.Text;

            if (!string.IsNullOrEmpty(placas) && !string.IsNullOrEmpty(propietario))
            {
                estacionamiento.IngresarAuto(placas, propietario);
                listBoxAutos.Items.Add($"Placas: {placas}, Propietario: {propietario}");
                textBoxPlacas.Clear();
                textBoxPropietario.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese las placas y el nombre del propietario.");
            }
        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {
            if (estacionamiento.EstaVacio())
            {
                MessageBox.Show("El estacionamiento está vacío.");
            }
            else
            {
                estacionamiento.SalidaAuto();
                if (listBoxAutos.Items.Count > 0)
                {
                    listBoxAutos.Items.RemoveAt(0); // Elimina el primer auto en la lista visual
                }
            }
        }
    }
}
