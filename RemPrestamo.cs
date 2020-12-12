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
    public partial class RemPrestamo : Form
    {
        public Form1 mainForm { get; set; }
        public List<Prestamo> prestamos { get; set; }
        public int selectedPrestamo { get; set; }
        public RemPrestamo(Form1 mainForm, List<Prestamo> prestamos, int selectedPrestamo)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.prestamos = prestamos;
            this.selectedPrestamo = selectedPrestamo;
            Ejemplar ejemplar = this.prestamos[this.selectedPrestamo].ejemplar;
            Socio socio = this.prestamos[this.selectedPrestamo].socio;
            this.ejemplarData.Text = $"{ejemplar.libro.isbn} {ejemplar.libro.nombre}";
            this.socioData.Text = $"{socio.id} {socio.nombre} {socio.apellido}";
            this.fechaData.Text = $"{this.prestamos[this.selectedPrestamo].fecha}";
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goRemPrestamo_Click(object sender, EventArgs e)
        {
            int posSocioEjemplar = prestamos[selectedPrestamo].socio.listaRetirados.FindIndex(prestamos[selectedPrestamo].ejemplar.Equals);
            if(posSocioEjemplar != -1)
            {
                Ejemplar ejemplarDevuelto = prestamos[selectedPrestamo].socio.devolverEjemplar(posSocioEjemplar);
                prestamos[selectedPrestamo].ejemplar.libro.lista.Add(ejemplarDevuelto);
                prestamos.RemoveAt(selectedPrestamo);
                mainForm.updateListas();
                this.Close();
            } else
            {
                {
                    MessageBox.Show(
                      "Ha ocurrido un error, seleccione un prestamo válido",
                      "Error",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                    );
                }
            }            
        }
    }
}
