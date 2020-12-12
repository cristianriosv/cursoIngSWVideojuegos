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
    public partial class NewPrestamo : Form
    {
        public Form1 mainForm { get; set; }
        public List<Libro> libros { get; set; }
        public List<Socio> socios { get; set; }
        public NewPrestamo(Form1 mainForm, List<Libro> libros, List<Socio> socios)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.libros = libros;
            this.socios = socios;
            populateCombos();
        }
        private void populateCombos()
        {
            foreach (Libro libro in libros)
            {
                this.ejemplarSelect.Items.Add($"{libro.isbn} {libro.nombre} Disponible: {libro.lista.Count}");
            }
            foreach (Socio socio in socios)
            {
                this.socioSelect.Items.Add($"{socio.id} {socio.nombre} {socio.apellido} Limite: {socio.listaRetirados.Count} de {socio.max}");
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void prestar_Click(object sender, EventArgs e)
        {
            if(this.socioSelect.SelectedIndex != -1 && this.ejemplarSelect.SelectedIndex != -1)
            {
                Socio selectedSocio = socios[this.socioSelect.SelectedIndex];
                Libro selectedLibro = libros[this.ejemplarSelect.SelectedIndex];
                if (selectedSocio.listaRetirados.Count < selectedSocio.max
                && selectedLibro.ejemplaresDisponibles())
                {
                    Ejemplar ejemplarPrestamo = selectedLibro.prestarEjemplar(this.ejemplarSelect.SelectedIndex);
                    selectedSocio.agregarEjemplar(ejemplarPrestamo);
                    Prestamo prestamo = new Prestamo(ejemplarPrestamo, selectedSocio);
                    mainForm.biblioteca.agregarPrestamo(prestamo);
                    mainForm.updateListas();
                    this.Close();
                } else
                {
                    MessageBox.Show(
                        "Especificar un ejemplar disponible y un socio que no exceda su limite",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            } else
            {
                MessageBox.Show(
                  "Se deben seleccionar ejemplar y socio",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
            }
        }
    }
}
