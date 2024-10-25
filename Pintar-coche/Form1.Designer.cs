namespace JuegoPintarCoches
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxCoche;
        private System.Windows.Forms.ComboBox comboBoxColores;
        private System.Windows.Forms.Button btnAgregarCoche;
        private System.Windows.Forms.Button btnPintarCoche;
        private System.Windows.Forms.ListBox listBoxCola;
        private System.Windows.Forms.ListBox listBoxPintados;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pictureBoxCoche = new System.Windows.Forms.PictureBox();
            this.comboBoxColores = new System.Windows.Forms.ComboBox();
            this.btnAgregarCoche = new System.Windows.Forms.Button();
            this.btnPintarCoche = new System.Windows.Forms.Button();
            this.listBoxCola = new System.Windows.Forms.ListBox();
            this.listBoxPintados = new System.Windows.Forms.ListBox();

            // PictureBox
            this.pictureBoxCoche.Location = new System.Drawing.Point(300, 20);
            this.pictureBoxCoche.Name = "pictureBoxCoche";
            this.pictureBoxCoche.Size = new System.Drawing.Size(200, 100);
            this.pictureBoxCoche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCoche.TabIndex = 0;
            this.pictureBoxCoche.TabStop = false;

            // ComboBox
            this.comboBoxColores.FormattingEnabled = true;
            this.comboBoxColores.Location = new System.Drawing.Point(30, 20);
            this.comboBoxColores.Name = "comboBoxColores";
            this.comboBoxColores.Size = new System.Drawing.Size(150, 24);
            this.comboBoxColores.TabIndex = 1;

            // Agregar Coche Button
            this.btnAgregarCoche.Location = new System.Drawing.Point(30, 60);
            this.btnAgregarCoche.Name = "btnAgregarCoche";
            this.btnAgregarCoche.Size = new System.Drawing.Size(150, 30);
            this.btnAgregarCoche.TabIndex = 2;
            this.btnAgregarCoche.Text = "Agregar Coche";
            this.btnAgregarCoche.UseVisualStyleBackColor = true;
            this.btnAgregarCoche.Click += new System.EventHandler(this.btnAgregarCoche_Click);

            // Pintar Coche Button
            this.btnPintarCoche.Location = new System.Drawing.Point(30, 100);
            this.btnPintarCoche.Name = "btnPintarCoche";
            this.btnPintarCoche.Size = new System.Drawing.Size(150, 30);
            this.btnPintarCoche.TabIndex = 3;
            this.btnPintarCoche.Text = "Pintar Coche";
            this.btnPintarCoche.UseVisualStyleBackColor = true;
            this.btnPintarCoche.Click += new System.EventHandler(this.btnPintarCoche_Click);

            // ListBox Cola
            this.listBoxCola.FormattingEnabled = true;
            this.listBoxCola.ItemHeight = 16;
            this.listBoxCola.Location = new System.Drawing.Point(30, 150);
            this.listBoxCola.Name = "listBoxCola";
            this.listBoxCola.Size = new System.Drawing.Size(150, 100);
            this.listBoxCola.TabIndex = 4;

            // ListBox Pintados
            this.listBoxPintados.FormattingEnabled = true;
            this.listBoxPintados.ItemHeight = 16;
            this.listBoxPintados.Location = new System.Drawing.Point(200, 150);
            this.listBoxPintados.Name = "listBoxPintados";
            this.listBoxPintados.Size = new System.Drawing.Size(300, 100);
            this.listBoxPintados.TabIndex = 5;

            // Form1
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.pictureBoxCoche);
            this.Controls.Add(this.comboBoxColores);
            this.Controls.Add(this.btnAgregarCoche);
            this.Controls.Add(this.btnPintarCoche);
            this.Controls.Add(this.listBoxCola);
            this.Controls.Add(this.listBoxPintados);
            this.Name = "Form1";
            this.Text = "Juego Pintar Coches";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoche)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
