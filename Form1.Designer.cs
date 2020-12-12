
namespace Curso_Ing_SW_Videojuegos2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.listaLibros = new System.Windows.Forms.ListView();
            this.nombreLibro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.isbn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.disponibilidadLibro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listaSocios = new System.Windows.Forms.ListView();
            this.idSocio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nombreSocio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.apellidoSocio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ejemplaresSocio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maxSocio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.vipSocio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listaPrestamos = new System.Windows.Forms.ListView();
            this.ejemplarPrestamo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.socioPrestamo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fechaPrestamo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addLibro = new System.Windows.Forms.Button();
            this.addEjemplar = new System.Windows.Forms.Button();
            this.addSocio = new System.Windows.Forms.Button();
            this.addPrestamo = new System.Windows.Forms.Button();
            this.remPrestamo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaLibros
            // 
            this.listaLibros.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listaLibros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombreLibro,
            this.isbn,
            this.autor,
            this.disponibilidadLibro});
            this.listaLibros.HideSelection = false;
            this.listaLibros.Location = new System.Drawing.Point(27, 44);
            this.listaLibros.MultiSelect = false;
            this.listaLibros.Name = "listaLibros";
            this.listaLibros.Size = new System.Drawing.Size(449, 119);
            this.listaLibros.TabIndex = 0;
            this.listaLibros.UseCompatibleStateImageBehavior = false;
            this.listaLibros.View = System.Windows.Forms.View.Details;
            this.listaLibros.SelectedIndexChanged += new System.EventHandler(this.listaLibros_SelectedIndexChanged_UsingItems);
            // 
            // nombreLibro
            // 
            this.nombreLibro.Text = "Nombre";
            this.nombreLibro.Width = 150;
            // 
            // isbn
            // 
            this.isbn.Text = "ISBN";
            this.isbn.Width = 100;
            // 
            // autor
            // 
            this.autor.Text = "Autor";
            this.autor.Width = 118;
            // 
            // disponibilidadLibro
            // 
            this.disponibilidadLibro.Text = "Ejemplares";
            this.disponibilidadLibro.Width = 76;
            // 
            // listaSocios
            // 
            this.listaSocios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idSocio,
            this.nombreSocio,
            this.apellidoSocio,
            this.ejemplaresSocio,
            this.maxSocio,
            this.vipSocio});
            this.listaSocios.HideSelection = false;
            this.listaSocios.Location = new System.Drawing.Point(27, 234);
            this.listaSocios.Name = "listaSocios";
            this.listaSocios.Size = new System.Drawing.Size(449, 120);
            this.listaSocios.TabIndex = 0;
            this.listaSocios.UseCompatibleStateImageBehavior = false;
            this.listaSocios.View = System.Windows.Forms.View.Details;
            // 
            // idSocio
            // 
            this.idSocio.Text = "id";
            // 
            // nombreSocio
            // 
            this.nombreSocio.Text = "Nombre";
            this.nombreSocio.Width = 100;
            // 
            // apellidoSocio
            // 
            this.apellidoSocio.Text = "Apellido";
            this.apellidoSocio.Width = 100;
            // 
            // ejemplaresSocio
            // 
            this.ejemplaresSocio.Text = "Libros";
            // 
            // maxSocio
            // 
            this.maxSocio.Text = "Max";
            // 
            // vipSocio
            // 
            this.vipSocio.Text = "Vip";
            // 
            // listaPrestamos
            // 
            this.listaPrestamos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ejemplarPrestamo,
            this.socioPrestamo,
            this.fechaPrestamo});
            this.listaPrestamos.HideSelection = false;
            this.listaPrestamos.Location = new System.Drawing.Point(27, 455);
            this.listaPrestamos.Name = "listaPrestamos";
            this.listaPrestamos.Size = new System.Drawing.Size(449, 124);
            this.listaPrestamos.TabIndex = 0;
            this.listaPrestamos.UseCompatibleStateImageBehavior = false;
            this.listaPrestamos.View = System.Windows.Forms.View.Details;
            this.listaPrestamos.SelectedIndexChanged += new System.EventHandler(this.listaPrestamos_SelectedIndexChanged_UsingItems);
            // 
            // ejemplarPrestamo
            // 
            this.ejemplarPrestamo.Text = "Ejemplar";
            this.ejemplarPrestamo.Width = 150;
            // 
            // socioPrestamo
            // 
            this.socioPrestamo.Text = "Socio";
            this.socioPrestamo.Width = 200;
            // 
            // fechaPrestamo
            // 
            this.fechaPrestamo.Text = "Fecha";
            this.fechaPrestamo.Width = 200;
            // 
            // addLibro
            // 
            this.addLibro.Location = new System.Drawing.Point(342, 169);
            this.addLibro.Name = "addLibro";
            this.addLibro.Size = new System.Drawing.Size(134, 33);
            this.addLibro.TabIndex = 1;
            this.addLibro.Text = "+ Registrar nuevo libro";
            this.addLibro.UseVisualStyleBackColor = true;
            this.addLibro.Click += new System.EventHandler(this.addLibro_Click);
            // 
            // addEjemplar
            // 
            this.addEjemplar.Enabled = false;
            this.addEjemplar.Location = new System.Drawing.Point(202, 169);
            this.addEjemplar.Name = "addEjemplar";
            this.addEjemplar.Size = new System.Drawing.Size(134, 33);
            this.addEjemplar.TabIndex = 1;
            this.addEjemplar.Text = "+ Agregar ejemplar";
            this.addEjemplar.UseVisualStyleBackColor = true;
            this.addEjemplar.Click += new System.EventHandler(this.addLibroEjemplar_Click);
            // 
            // addSocio
            // 
            this.addSocio.Location = new System.Drawing.Point(342, 360);
            this.addSocio.Name = "addSocio";
            this.addSocio.Size = new System.Drawing.Size(134, 33);
            this.addSocio.TabIndex = 1;
            this.addSocio.Text = "+ Agregar Socio";
            this.addSocio.UseVisualStyleBackColor = true;
            this.addSocio.Click += new System.EventHandler(this.addSocio_Click);
            // 
            // addPrestamo
            // 
            this.addPrestamo.Location = new System.Drawing.Point(342, 585);
            this.addPrestamo.Name = "addPrestamo";
            this.addPrestamo.Size = new System.Drawing.Size(134, 33);
            this.addPrestamo.TabIndex = 1;
            this.addPrestamo.Text = "+ Nuevo prestamo";
            this.addPrestamo.UseVisualStyleBackColor = true;
            this.addPrestamo.Click += new System.EventHandler(this.addPrestamo_Click);
            // 
            // remPrestamo
            // 
            this.remPrestamo.Enabled = false;
            this.remPrestamo.Location = new System.Drawing.Point(202, 585);
            this.remPrestamo.Name = "remPrestamo";
            this.remPrestamo.Size = new System.Drawing.Size(134, 33);
            this.remPrestamo.TabIndex = 1;
            this.remPrestamo.Text = "+ Efectuar Devolucion";
            this.remPrestamo.UseVisualStyleBackColor = true;
            this.remPrestamo.Click += new System.EventHandler(this.remPrestamo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Libros y Ejemplares";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Socios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Préstamos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 660);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addEjemplar);
            this.Controls.Add(this.remPrestamo);
            this.Controls.Add(this.addPrestamo);
            this.Controls.Add(this.addSocio);
            this.Controls.Add(this.addLibro);
            this.Controls.Add(this.listaPrestamos);
            this.Controls.Add(this.listaSocios);
            this.Controls.Add(this.listaLibros);
            this.Name = "Form1";
            this.Text = "Mi biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listaLibros;
        private System.Windows.Forms.ColumnHeader nombreLibro;
        private System.Windows.Forms.ColumnHeader isbn;
        private System.Windows.Forms.ColumnHeader autor;
        private System.Windows.Forms.ListView listaSocios;
        private System.Windows.Forms.ColumnHeader nombreSocio;
        private System.Windows.Forms.ListView listaPrestamos;
        private System.Windows.Forms.ColumnHeader ejemplarPrestamo;
        private System.Windows.Forms.ColumnHeader socioPrestamo;
        private System.Windows.Forms.ColumnHeader fechaPrestamo;
        private System.Windows.Forms.ColumnHeader idSocio;
        private System.Windows.Forms.ColumnHeader apellidoSocio;
        private System.Windows.Forms.ColumnHeader ejemplaresSocio;
        private System.Windows.Forms.ColumnHeader maxSocio;
        private System.Windows.Forms.ColumnHeader vipSocio;
        private System.Windows.Forms.ColumnHeader disponibilidadLibro;
        private System.Windows.Forms.Button addLibro;
        private System.Windows.Forms.Button addEjemplar;
        private System.Windows.Forms.Button addSocio;
        private System.Windows.Forms.Button addPrestamo;
        private System.Windows.Forms.Button remPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

