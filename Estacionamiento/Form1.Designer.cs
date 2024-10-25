namespace EstacionamientoApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelPlacas;
        private System.Windows.Forms.TextBox textBoxPlacas;
        private System.Windows.Forms.Label labelPropietario;
        private System.Windows.Forms.TextBox textBoxPropietario;
        private System.Windows.Forms.Button buttonEntrada;
        private System.Windows.Forms.Button buttonSalida;
        private System.Windows.Forms.ListBox listBoxAutos;
        private System.Windows.Forms.Label labelAutos;

        // Limpiar recursos
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelPlacas = new System.Windows.Forms.Label();
            this.textBoxPlacas = new System.Windows.Forms.TextBox();
            this.labelPropietario = new System.Windows.Forms.Label();
            this.textBoxPropietario = new System.Windows.Forms.TextBox();
            this.buttonEntrada = new System.Windows.Forms.Button();
            this.buttonSalida = new System.Windows.Forms.Button();
            this.listBoxAutos = new System.Windows.Forms.ListBox();
            this.labelAutos = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Label Placas
            this.labelPlacas.AutoSize = true;
            this.labelPlacas.Location = new System.Drawing.Point(30, 30);
            this.labelPlacas.Name = "labelPlacas";
            this.labelPlacas.Size = new System.Drawing.Size(92, 17);
            this.labelPlacas.TabIndex = 0;
            this.labelPlacas.Text = "Placas del auto";

            // TextBox Placas
            this.textBoxPlacas.Location = new System.Drawing.Point(150, 30);
            this.textBoxPlacas.Name = "textBoxPlacas";
            this.textBoxPlacas.Size = new System.Drawing.Size(200, 22);
            this.textBoxPlacas.TabIndex = 1;

            // Label Propietario
            this.labelPropietario.AutoSize = true;
            this.labelPropietario.Location = new System.Drawing.Point(30, 70);
            this.labelPropietario.Name = "labelPropietario";
            this.labelPropietario.Size = new System.Drawing.Size(112, 17);
            this.labelPropietario.TabIndex = 2;
            this.labelPropietario.Text = "Nombre propietario";

            // TextBox Propietario (Más grande para que no esté "achocado")
            this.textBoxPropietario.Location = new System.Drawing.Point(150, 70);
            this.textBoxPropietario.Name = "textBoxPropietario";
            this.textBoxPropietario.Size = new System.Drawing.Size(200, 22);  // Ajustar tamaño más ancho
            this.textBoxPropietario.TabIndex = 3;

            // Button Entrada
            this.buttonEntrada.Location = new System.Drawing.Point(50, 120);
            this.buttonEntrada.Name = "buttonEntrada";
            this.buttonEntrada.Size = new System.Drawing.Size(120, 30);
            this.buttonEntrada.TabIndex = 4;
            this.buttonEntrada.Text = "Entrada Auto";
            this.buttonEntrada.UseVisualStyleBackColor = true;
            this.buttonEntrada.Click += new System.EventHandler(this.buttonEntrada_Click);

            // Button Salida
            this.buttonSalida.Location = new System.Drawing.Point(200, 120);
            this.buttonSalida.Name = "buttonSalida";
            this.buttonSalida.Size = new System.Drawing.Size(120, 30);
            this.buttonSalida.TabIndex = 5;
            this.buttonSalida.Text = "Salida Auto";
            this.buttonSalida.UseVisualStyleBackColor = true;
            this.buttonSalida.Click += new System.EventHandler(this.buttonSalida_Click);

            // ListBox Autos (Más grande para mostrar más autos)
            this.listBoxAutos.FormattingEnabled = true;
            this.listBoxAutos.ItemHeight = 16;
            this.listBoxAutos.Location = new System.Drawing.Point(50, 180);
            this.listBoxAutos.Name = "listBoxAutos";
            this.listBoxAutos.Size = new System.Drawing.Size(300, 150);  // Ajustar tamaño más alto y ancho
            this.listBoxAutos.TabIndex = 6;

            // Label Autos
            this.labelAutos.AutoSize = true;
            this.labelAutos.Location = new System.Drawing.Point(50, 160);
            this.labelAutos.Name = "labelAutos";
            this.labelAutos.Size = new System.Drawing.Size(99, 17);
            this.labelAutos.TabIndex = 7;
            this.labelAutos.Text = "Autos en lista:";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 370);  // Ajustar tamaño general del formulario
            this.Controls.Add(this.labelAutos);
            this.Controls.Add(this.listBoxAutos);
            this.Controls.Add(this.buttonSalida);
            this.Controls.Add(this.buttonEntrada);
            this.Controls.Add(this.textBoxPropietario);
            this.Controls.Add(this.labelPropietario);
            this.Controls.Add(this.textBoxPlacas);
            this.Controls.Add(this.labelPlacas);
            this.Name = "Form1";
            this.Text = "Estacionamiento Autos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
