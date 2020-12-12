
namespace Curso_Ing_SW_Videojuegos2
{
    partial class addNewSocio
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
            this.nombreSocio = new System.Windows.Forms.TextBox();
            this.apellidoSocio = new System.Windows.Forms.TextBox();
            this.isVip = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goAddSocio = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombreSocio
            // 
            this.nombreSocio.Location = new System.Drawing.Point(105, 51);
            this.nombreSocio.Name = "nombreSocio";
            this.nombreSocio.Size = new System.Drawing.Size(256, 20);
            this.nombreSocio.TabIndex = 0;
            // 
            // apellidoSocio
            // 
            this.apellidoSocio.Location = new System.Drawing.Point(105, 89);
            this.apellidoSocio.Name = "apellidoSocio";
            this.apellidoSocio.Size = new System.Drawing.Size(256, 20);
            this.apellidoSocio.TabIndex = 1;
            // 
            // isVip
            // 
            this.isVip.AutoSize = true;
            this.isVip.Location = new System.Drawing.Point(184, 135);
            this.isVip.Name = "isVip";
            this.isVip.Size = new System.Drawing.Size(71, 17);
            this.isVip.TabIndex = 2;
            this.isVip.Text = "Socio Vip";
            this.isVip.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido:";
            // 
            // goAddSocio
            // 
            this.goAddSocio.Location = new System.Drawing.Point(242, 175);
            this.goAddSocio.Name = "goAddSocio";
            this.goAddSocio.Size = new System.Drawing.Size(119, 40);
            this.goAddSocio.TabIndex = 3;
            this.goAddSocio.Text = "+ Agregar Socio";
            this.goAddSocio.UseVisualStyleBackColor = true;
            this.goAddSocio.Click += new System.EventHandler(this.goAddSocio_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(117, 175);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(119, 40);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // addNewSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 239);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.goAddSocio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.isVip);
            this.Controls.Add(this.apellidoSocio);
            this.Controls.Add(this.nombreSocio);
            this.Name = "addNewSocio";
            this.Text = "Agregar Nuevo Socio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nombreSocio;
        private System.Windows.Forms.TextBox apellidoSocio;
        private System.Windows.Forms.CheckBox isVip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goAddSocio;
        private System.Windows.Forms.Button cancel;
    }
}