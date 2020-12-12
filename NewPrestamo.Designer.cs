
namespace Curso_Ing_SW_Videojuegos2
{
    partial class NewPrestamo
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
            this.socioSelect = new System.Windows.Forms.ComboBox();
            this.ejemplarSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prestar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // socioSelect
            // 
            this.socioSelect.FormattingEnabled = true;
            this.socioSelect.Location = new System.Drawing.Point(30, 53);
            this.socioSelect.Name = "socioSelect";
            this.socioSelect.Size = new System.Drawing.Size(372, 21);
            this.socioSelect.TabIndex = 0;
            // 
            // ejemplarSelect
            // 
            this.ejemplarSelect.FormattingEnabled = true;
            this.ejemplarSelect.Location = new System.Drawing.Point(30, 114);
            this.ejemplarSelect.Name = "ejemplarSelect";
            this.ejemplarSelect.Size = new System.Drawing.Size(372, 21);
            this.ejemplarSelect.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Socio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ejemplar:";
            // 
            // prestar
            // 
            this.prestar.Location = new System.Drawing.Point(277, 174);
            this.prestar.Name = "prestar";
            this.prestar.Size = new System.Drawing.Size(125, 33);
            this.prestar.TabIndex = 2;
            this.prestar.Text = "+ Prestar";
            this.prestar.UseVisualStyleBackColor = true;
            this.prestar.Click += new System.EventHandler(this.prestar_Click);
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(137, 174);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(125, 33);
            this.cancelar.TabIndex = 2;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // NewPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 235);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.prestar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ejemplarSelect);
            this.Controls.Add(this.socioSelect);
            this.Name = "NewPrestamo";
            this.Text = "Nuevo Prestamo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox socioSelect;
        private System.Windows.Forms.ComboBox ejemplarSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button prestar;
        private System.Windows.Forms.Button cancelar;
    }
}