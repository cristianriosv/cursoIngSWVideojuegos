
namespace Curso_Ing_SW_Videojuegos2
{
    partial class NewLibro
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
            this.nombreLibro = new System.Windows.Forms.TextBox();
            this.isbnLibro = new System.Windows.Forms.TextBox();
            this.autorLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.goAddNew = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreLibro
            // 
            this.nombreLibro.Location = new System.Drawing.Point(119, 43);
            this.nombreLibro.Name = "nombreLibro";
            this.nombreLibro.Size = new System.Drawing.Size(314, 20);
            this.nombreLibro.TabIndex = 0;
            // 
            // isbnLibro
            // 
            this.isbnLibro.Location = new System.Drawing.Point(119, 87);
            this.isbnLibro.Name = "isbnLibro";
            this.isbnLibro.Size = new System.Drawing.Size(314, 20);
            this.isbnLibro.TabIndex = 1;
            // 
            // autorLibro
            // 
            this.autorLibro.Location = new System.Drawing.Point(119, 131);
            this.autorLibro.Name = "autorLibro";
            this.autorLibro.Size = new System.Drawing.Size(314, 20);
            this.autorLibro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre libro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ISBN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Autor:";
            // 
            // goAddNew
            // 
            this.goAddNew.Location = new System.Drawing.Point(320, 172);
            this.goAddNew.Name = "goAddNew";
            this.goAddNew.Size = new System.Drawing.Size(113, 41);
            this.goAddNew.TabIndex = 3;
            this.goAddNew.Text = "Agregar registro";
            this.goAddNew.UseVisualStyleBackColor = true;
            this.goAddNew.Click += new System.EventHandler(this.goAddNew_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(201, 172);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(113, 41);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // NewLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 253);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.goAddNew);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autorLibro);
            this.Controls.Add(this.isbnLibro);
            this.Controls.Add(this.nombreLibro);
            this.Name = "NewLibro";
            this.Text = "Regitrar nuevo libro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreLibro;
        private System.Windows.Forms.TextBox isbnLibro;
        private System.Windows.Forms.TextBox autorLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button goAddNew;
        private System.Windows.Forms.Button cancel;
    }
}