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
    public partial class NewLibro : Form
    {
        public Form1 mainForm { get; set; }
        public NewLibro()
        {
            InitializeComponent();
        }

        private void goAddNew_Click(object sender, EventArgs e)
        {
            if(this.nombreLibro.Text != "" && this.isbnLibro.Text != "" && this.autorLibro.Text != "")
            {
                mainForm.biblioteca.agregarLibro(new Libro(this.nombreLibro.Text, this.isbnLibro.Text, this.autorLibro.Text));
                mainForm.updateListas();
                this.Close();
            } else
            {
                MessageBox.Show(
                  "Se deben especificar todos los campos",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
