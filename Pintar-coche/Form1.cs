using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JuegoPintarCoches
{
    public partial class Form1 : Form
    {
        // Lista para almacenar los coches en cola
        List<string> cochesEnCola = new List<string>();

        public Form1()
        {
            InitializeComponent();
            // Agregar colores al ComboBox
            comboBoxColores.Items.Add("Naranja");
            comboBoxColores.Items.Add("Rojo");
            comboBoxColores.Items.Add("Verde");
            comboBoxColores.Items.Add("Amarillo");
            comboBoxColores.SelectedIndex = 0;

            // Mostrar imagen del coche base al iniciar
            pictureBoxCoche.Image = new Bitmap(@"Resources/carro.png");
        }

        // Método para agregar coches a la cola
        private void btnAgregarCoche_Click(object sender, EventArgs e)
        {
            string colorSeleccionado = comboBoxColores.SelectedItem.ToString();
            cochesEnCola.Add(colorSeleccionado);
            listBoxCola.Items.Add($"Coche - {colorSeleccionado}");

            // Mostrar la imagen del coche sin pintar
            pictureBoxCoche.Image = new Bitmap(@"Resources/carro.png");
        }

        // Método para pintar el coche
        private void btnPintarCoche_Click(object sender, EventArgs e)
        {
            if (cochesEnCola.Count > 0)
            {
                string colorCoche = cochesEnCola[0]; // Selecciona el primero en la cola
                cochesEnCola.RemoveAt(0); // Elimina el coche de la cola
                listBoxCola.Items.RemoveAt(0); // Actualiza la lista de la UI

                // Actualiza la lista de coches pintados
                listBoxPintados.Items.Add($"Coche {listBoxPintados.Items.Count + 1} - {colorCoche} - Pintado");

                // Muestra el coche pintado en el PictureBox con el color seleccionado
                pictureBoxCoche.Image = PintarCoche(colorCoche);
            }
            else
            {
                MessageBox.Show("No hay coches en cola para pintar.");
            }
        }

        // Método para cambiar el color del coche
        private Image PintarCoche(string color)
        {
            // Carga la imagen original del coche
            Bitmap original = new Bitmap(@"Resources/carro.png");

            // Crear un nuevo Bitmap con formato ARGB (32 bits) para poder usar SetPixel
            Bitmap coche = new Bitmap(original.Width, original.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            // Copiar los píxeles de la imagen original al nuevo bitmap
            using (Graphics g = Graphics.FromImage(coche))
            {
                g.DrawImage(original, 0, 0);
            }

            // Determina el filtro de color dependiendo del color seleccionado
            Color colorFiltro = Color.White;

            switch (color)
            {
                case "Naranja":
                    colorFiltro = Color.Orange;
                    break;
                case "Rojo":
                    colorFiltro = Color.Red;
                    break;
                case "Verde":
                    colorFiltro = Color.Green;
                    break;
                case "Amarillo":
                    colorFiltro = Color.Yellow;
                    break;
            }

            // Cambiar el color de los píxeles en la imagen
            for (int y = 0; y < coche.Height; y++)
            {
                for (int x = 0; x < coche.Width; x++)
                {
                    Color pixelColor = coche.GetPixel(x, y);
                    if (pixelColor.A != 0) // Solo cambia los píxeles no transparentes
                    {
                        coche.SetPixel(x, y, colorFiltro);
                    }
                }
            }

            return coche;
        }
    }
}
