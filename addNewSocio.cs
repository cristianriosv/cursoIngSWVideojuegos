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
    public partial class addNewSocio : Form
    {
        public Form1 mainForm { get; set; }
        public addNewSocio(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goAddSocio_Click(object sender, EventArgs e)
        {
            if(this.nombreSocio.Text != "" && this.apellidoSocio.Text != "")
            {
                if (this.isVip.Checked)
                {
                    SocioVip newSocio = new SocioVip(this.nombreSocio.Text, this.apellidoSocio.Text, DateTime.Now.ToString().GetHashCode().ToString("x"));
                    mainForm.biblioteca.agregarSocio(newSocio);
                } else
                {
                    Socio newSocio = new Socio(this.nombreSocio.Text, this.apellidoSocio.Text, DateTime.Now.ToString().GetHashCode().ToString("x"));
                    mainForm.biblioteca.agregarSocio(newSocio);
                }
                mainForm.updateListas();
                this.Close();
            } else
            {
                MessageBox.Show(
                  "Se debe especificar el nombre y el apellido",
                  "Error",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
                );
            }
        }
    }
}
