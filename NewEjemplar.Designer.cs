
namespace Curso_Ing_SW_Videojuegos2
{
    partial class NewEjemplar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.libroDatos = new System.Windows.Forms.TextBox();
            this.edicion = new System.Windows.Forms.TextBox();
            this.ubicacion = new System.Windows.Forms.TextBox();
            this.goAddNewEjemplar = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.cantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // libroDatos
            // 
            this.libroDatos.Enabled = false;
            this.libroDatos.Location = new System.Drawing.Point(41, 34);
            this.libroDatos.Name = "libroDatos";
            this.libroDatos.Size = new System.Drawing.Size(323, 20);
            this.libroDatos.TabIndex = 0;
            // 
            // edicion
            // 
            this.edicion.Location = new System.Drawing.Point(137, 80);
            this.edicion.Name = "edicion";
            this.edicion.Size = new System.Drawing.Size(227, 20);
            this.edicion.TabIndex = 1;
            // 
            // ubicacion
            // 
            this.ubicacion.Location = new System.Drawing.Point(137, 127);
            this.ubicacion.Name = "ubicacion";
            this.ubicacion.Size = new System.Drawing.Size(227, 20);
            this.ubicacion.TabIndex = 2;
            // 
            // goAddNewEjemplar
            // 
            this.goAddNewEjemplar.Location = new System.Drawing.Point(233, 226);
            this.goAddNewEjemplar.Name = "goAddNewEjemplar";
            this.goAddNewEjemplar.Size = new System.Drawing.Size(131, 33);
            this.goAddNewEjemplar.TabIndex = 4;
            this.goAddNewEjemplar.Text = "+ Agregar ejemplares";
            this.goAddNewEjemplar.UseVisualStyleBackColor = true;
            this.goAddNewEjemplar.Click += new System.EventHandler(this.goAddNewEjemplar_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(87, 226);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(131, 33);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(244, 171);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(120, 20);
            this.cantidad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Edición:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ubicación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad:";
            // 
            // NewEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 285);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.goAddNewEjemplar);
            this.Controls.Add(this.ubicacion);
            this.Controls.Add(this.edicion);
            this.Controls.Add(this.libroDatos);
            this.Name = "NewEjemplar";
            this.Text = "Agregar ejemplares";
            ((System.ComponentModel.ISupportInitialize)(this.cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox libroDatos;
        private System.Windows.Forms.TextBox edicion;
        private System.Windows.Forms.TextBox ubicacion;
        private System.Windows.Forms.Button goAddNewEjemplar;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.NumericUpDown cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}