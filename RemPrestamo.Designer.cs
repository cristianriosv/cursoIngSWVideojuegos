﻿
namespace Curso_Ing_SW_Videojuegos2
{
    partial class RemPrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.ejemplarData = new System.Windows.Forms.TextBox();
            this.socioData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goRemPrestamo = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.fechaData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Está seguro de efectuar la siguiente devolución?";
            // 
            // ejemplarData
            // 
            this.ejemplarData.Enabled = false;
            this.ejemplarData.Location = new System.Drawing.Point(50, 81);
            this.ejemplarData.Name = "ejemplarData";
            this.ejemplarData.Size = new System.Drawing.Size(411, 20);
            this.ejemplarData.TabIndex = 1;
            // 
            // socioData
            // 
            this.socioData.Enabled = false;
            this.socioData.Location = new System.Drawing.Point(50, 135);
            this.socioData.Name = "socioData";
            this.socioData.Size = new System.Drawing.Size(411, 20);
            this.socioData.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ejemplar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Socio";
            // 
            // goRemPrestamo
            // 
            this.goRemPrestamo.Location = new System.Drawing.Point(334, 233);
            this.goRemPrestamo.Name = "goRemPrestamo";
            this.goRemPrestamo.Size = new System.Drawing.Size(127, 35);
            this.goRemPrestamo.TabIndex = 3;
            this.goRemPrestamo.Text = "+ Devolver";
            this.goRemPrestamo.UseVisualStyleBackColor = true;
            this.goRemPrestamo.Click += new System.EventHandler(this.goRemPrestamo_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(201, 233);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(127, 35);
            this.cancelar.TabIndex = 3;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // fechaData
            // 
            this.fechaData.Enabled = false;
            this.fechaData.Location = new System.Drawing.Point(50, 184);
            this.fechaData.Name = "fechaData";
            this.fechaData.Size = new System.Drawing.Size(411, 20);
            this.fechaData.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fecha prestamo";
            // 
            // RemPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 280);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.goRemPrestamo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaData);
            this.Controls.Add(this.socioData);
            this.Controls.Add(this.ejemplarData);
            this.Controls.Add(this.label1);
            this.Name = "RemPrestamo";
            this.Text = "Devolver Ejemplar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ejemplarData;
        private System.Windows.Forms.TextBox socioData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button goRemPrestamo;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.TextBox fechaData;
        private System.Windows.Forms.Label label4;
    }
}