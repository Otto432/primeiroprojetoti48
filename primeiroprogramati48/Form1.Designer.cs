using System;

namespace primeiroprogramati48
{
    partial class Qual
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
            this.btnverificar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.pergunta = new System.Windows.Forms.Label();
            this.caixa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelval1 = new System.Windows.Forms.TextBox();
            this.labelval2 = new System.Windows.Forms.TextBox();
            this.labeval3 = new System.Windows.Forms.TextBox();
            this.btmsoma = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btnvezes = new System.Windows.Forms.Button();
            this.btndivisão = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnverificar
            // 
            this.btnverificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnverificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverificar.Location = new System.Drawing.Point(129, 358);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(115, 56);
            this.btnverificar.TabIndex = 2;
            this.btnverificar.Text = "Virificar";
            this.btnverificar.UseVisualStyleBackColor = false;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(120, 74);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(290, 50);
            this.titulo.TabIndex = 3;
            this.titulo.Text = "Quiz de Sigma";
            this.titulo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pergunta
            // 
            this.pergunta.AutoSize = true;
            this.pergunta.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pergunta.Location = new System.Drawing.Point(123, 209);
            this.pergunta.Name = "pergunta";
            this.pergunta.Size = new System.Drawing.Size(271, 36);
            this.pergunta.TabIndex = 4;
            this.pergunta.Text = "Qual é seu nome??";
            this.pergunta.Click += new System.EventHandler(this.label2_Click);
            // 
            // caixa
            // 
            this.caixa.Location = new System.Drawing.Point(129, 260);
            this.caixa.Name = "caixa";
            this.caixa.Size = new System.Drawing.Size(292, 20);
            this.caixa.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(729, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calculadora";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelval1
            // 
            this.labelval1.Location = new System.Drawing.Point(660, 166);
            this.labelval1.Name = "labelval1";
            this.labelval1.Size = new System.Drawing.Size(159, 20);
            this.labelval1.TabIndex = 8;
            // 
            // labelval2
            // 
            this.labelval2.Location = new System.Drawing.Point(851, 166);
            this.labelval2.Name = "labelval2";
            this.labelval2.Size = new System.Drawing.Size(159, 20);
            this.labelval2.TabIndex = 9;
            // 
            // labeval3
            // 
            this.labeval3.Location = new System.Drawing.Point(660, 209);
            this.labeval3.Name = "labeval3";
            this.labeval3.Size = new System.Drawing.Size(350, 20);
            this.labeval3.TabIndex = 10;
            // 
            // btmsoma
            // 
            this.btmsoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmsoma.Location = new System.Drawing.Point(660, 260);
            this.btmsoma.Name = "btmsoma";
            this.btmsoma.Size = new System.Drawing.Size(59, 48);
            this.btmsoma.TabIndex = 11;
            this.btmsoma.Text = "+";
            this.btmsoma.UseVisualStyleBackColor = true;
            // 
            // btnmenos
            // 
            this.btnmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenos.Location = new System.Drawing.Point(736, 260);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(59, 48);
            this.btnmenos.TabIndex = 12;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            // 
            // btnvezes
            // 
            this.btnvezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvezes.Location = new System.Drawing.Point(822, 260);
            this.btnvezes.Name = "btnvezes";
            this.btnvezes.Size = new System.Drawing.Size(59, 48);
            this.btnvezes.TabIndex = 13;
            this.btnvezes.Text = "*";
            this.btnvezes.UseVisualStyleBackColor = true;
            // 
            // btndivisão
            // 
            this.btndivisão.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivisão.Location = new System.Drawing.Point(902, 260);
            this.btndivisão.Name = "btndivisão";
            this.btndivisão.Size = new System.Drawing.Size(59, 48);
            this.btndivisão.TabIndex = 14;
            this.btndivisão.Text = "/";
            this.btndivisão.UseVisualStyleBackColor = true;
            // 
            // Qual
            // 
            this.ClientSize = new System.Drawing.Size(1091, 780);
            this.Controls.Add(this.btndivisão);
            this.Controls.Add(this.btnvezes);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btmsoma);
            this.Controls.Add(this.labeval3);
            this.Controls.Add(this.labelval2);
            this.Controls.Add(this.labelval1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.caixa);
            this.Controls.Add(this.pergunta);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.btnverificar);
            this.Name = "Qual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label pergunta;
        private System.Windows.Forms.TextBox caixa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox labelval1;
        private System.Windows.Forms.TextBox labelval2;
        private System.Windows.Forms.TextBox labeval3;
        private System.Windows.Forms.Button btmsoma;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btnvezes;
        private System.Windows.Forms.Button btndivisão;
    }
}

