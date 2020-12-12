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
    public partial class Form1 : Form
    {
        public Biblioteca biblioteca { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            initData();
            updateListas();
        }

        private void initData()
        {
            biblioteca = new Biblioteca();
            biblioteca.agregarLibro(new Libro("Cuentos infantiles", "ISBN23452345", "Hans Christian Andersen"));
            biblioteca.libros[0].agregarEjemplar("Latinoamerica", "Pasillo 1 Estante 13");
            biblioteca.agregarLibro(new Libro("Divina Comedia", "ISBN2345456767", "Dante Alighieri"));
            biblioteca.agregarLibro(new Libro("Orgullo y prejuicio", "ISBN5678678678", "Jane Austen"));

            biblioteca.agregarSocio(new Socio("Jorge", "Ramirez", $"{DateTime.Now.ToString().GetHashCode().ToString("x")}1"));
            biblioteca.agregarSocio(new Socio("Ana", "Noriega", $"{DateTime.Now.ToString().GetHashCode().ToString("x")}2"));
            biblioteca.agregarSocio(new SocioVip("Victoria", "Gutierrez", $"{DateTime.Now.ToString().GetHashCode().ToString("x")}3"));
        }
        public void updateListas()
        {
            updateLibros();
            updateSocios();
            updatePrestamos();
        }

        private void updateLibros()
        {
            this.listaLibros.Items.Clear();
            foreach (Libro libro in biblioteca.libros)
            {
                string[] libroData = { 
                    libro.nombre, 
                    libro.isbn, 
                    libro.autor, 
                    libro.ejemplaresDisponibles() ? libro.lista.Count.ToString() : "No disponible" 
                };
                ListViewItem item = new ListViewItem(libroData);
                this.listaLibros.Items.Add(item);
            }
            
        }

        private void updateSocios()
        {
            this.listaSocios.Items.Clear();
            foreach (Socio socio in biblioteca.socios)
            {
                string[] socioData = { 
                    socio.id, 
                    socio.nombre, 
                    socio.apellido, 
                    socio.listaRetirados.Count.ToString(), 
                    socio.max.ToString(),
                    socio.cuota > 0 ? "SI" : "NO"
                };
                ListViewItem item = new ListViewItem(socioData);
                this.listaSocios.Items.Add(item);
            }

        }

        private void updatePrestamos()
        {
            this.listaPrestamos.Items.Clear();
            foreach (Prestamo prestamo in biblioteca.prestamos)
            {
                string[] prestamoData = {
                    $"{prestamo.ejemplar.libro.isbn} {prestamo.ejemplar.libro.nombre}",
                    $"{prestamo.socio.id} {prestamo.socio.nombre} {prestamo.socio.apellido}",
                    prestamo.fecha.ToString()
                };
                ListViewItem item = new ListViewItem(prestamoData);
                this.listaPrestamos.Items.Add(item);
            }

        }

        private void addLibro_Click(object sender, EventArgs e)
        {
            NewLibro newLibro = new NewLibro();
            newLibro.mainForm = this;
            newLibro.Show();
        }
        
        private void addLibroEjemplar_Click(object sender, EventArgs e)
        {
            int libroSelected = this.listaLibros.SelectedIndices[0];
            NewEjemplar newEjemplar = new NewEjemplar(this, this.biblioteca.libros[libroSelected]);
            newEjemplar.Show();
        }
        private void listaLibros_SelectedIndexChanged_UsingItems(object sender, System.EventArgs e)
        {
            ListView.SelectedListViewItemCollection libro = this.listaLibros.SelectedItems;
            if (libro.Count > 0) this.addEjemplar.Enabled = true;
            else this.addEjemplar.Enabled = false;
        }

        private void addSocio_Click(object sender, EventArgs e)
        {
            addNewSocio newSocio = new addNewSocio(this);
            newSocio.Show();
        }
        private void addPrestamo_Click(object sender, EventArgs e)
        {
            NewPrestamo newPrestamo = new NewPrestamo(this, biblioteca.libros, biblioteca.socios);
            newPrestamo.Show();
        }
        private void listaPrestamos_SelectedIndexChanged_UsingItems(object sender, System.EventArgs e)
        {
            ListView.SelectedListViewItemCollection prestamo = this.listaPrestamos.SelectedItems;
            if (prestamo.Count > 0) this.remPrestamo.Enabled = true;
            else this.remPrestamo.Enabled = false;
        }
        private void remPrestamo_Click(object sender, EventArgs e)
        {
            int prestamoSelected = this.listaPrestamos.SelectedIndices[0];
            RemPrestamo remPrestamo = new RemPrestamo(this, biblioteca.prestamos, prestamoSelected);
            remPrestamo.Show();
        }
    }
}
