using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curso_Ing_SW_Videojuegos2
{
    public partial class NewEjemplar : Form
    {
        public Form1 mainForm { get; set; }
        public Libro libro { get; set; }
        public NewEjemplar(Form1 mainForm, Libro libro)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.libro = libro;
            this.libroDatos.Text = $"{this.libro.isbn} {this.libro.nombre} ";
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goAddNewEjemplar_Click(object sender, EventArgs e)
        {
            if (this.edicion.Text != "" && this.ubicacion.Text != "" && this.cantidad.Value > 0)
            {
                for(int ej = 0; ej < this.cantidad.Value; ej++)
                {
                    this.libro.agregarEjemplar(this.edicion.Text, this.ubicacion.Text);
                }
                mainForm.updateListas();
                this.Close();
            }
            else
            {
                MessageBox.Show(
                  "Se deben especificar todos los campos",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
            }
        }
    }
}
