using System;

namespace primeiroprogramati48
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.labelval1 = new System.Windows.Forms.TextBox();
            this.labeval3 = new System.Windows.Forms.TextBox();
            this.btmsoma = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btnvezes = new System.Windows.Forms.Button();
            this.btndivisão = new System.Windows.Forms.Button();
            this.but1 = new System.Windows.Forms.Button();
            this.but2 = new System.Windows.Forms.Button();
            this.but3 = new System.Windows.Forms.Button();
            this.but4 = new System.Windows.Forms.Button();
            this.but5 = new System.Windows.Forms.Button();
            this.but6 = new System.Windows.Forms.Button();
            this.but7 = new System.Windows.Forms.Button();
            this.but8 = new System.Windows.Forms.Button();
            this.but9 = new System.Windows.Forms.Button();
            this.but0 = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calculadora";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelval1
            // 
            this.labelval1.Location = new System.Drawing.Point(24, 119);
            this.labelval1.Name = "labelval1";
            this.labelval1.Size = new System.Drawing.Size(350, 20);
            this.labelval1.TabIndex = 8;
            this.labelval1.TextChanged += new System.EventHandler(this.labelval1_TextChanged);
            // 
            // labeval3
            // 
            this.labeval3.Location = new System.Drawing.Point(24, 154);
            this.labeval3.Name = "labeval3";
            this.labeval3.Size = new System.Drawing.Size(350, 20);
            this.labeval3.TabIndex = 10;
            this.labeval3.TextChanged += new System.EventHandler(this.labeval3_TextChanged);
            // 
            // btmsoma
            // 
            this.btmsoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmsoma.Location = new System.Drawing.Point(12, 478);
            this.btmsoma.Name = "btmsoma";
            this.btmsoma.Size = new System.Drawing.Size(59, 48);
            this.btmsoma.TabIndex = 11;
            this.btmsoma.Text = "+";
            this.btmsoma.UseVisualStyleBackColor = true;
            this.btmsoma.Click += new System.EventHandler(this.btmsoma_Click);
            // 
            // btnmenos
            // 
            this.btnmenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmenos.Location = new System.Drawing.Point(92, 478);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(59, 48);
            this.btnmenos.TabIndex = 12;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // btnvezes
            // 
            this.btnvezes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvezes.Location = new System.Drawing.Point(242, 478);
            this.btnvezes.Name = "btnvezes";
            this.btnvezes.Size = new System.Drawing.Size(59, 48);
            this.btnvezes.TabIndex = 13;
            this.btnvezes.Text = "*";
            this.btnvezes.UseVisualStyleBackColor = true;
            this.btnvezes.Click += new System.EventHandler(this.btnvezes_Click);
            // 
            // btndivisão
            // 
            this.btndivisão.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivisão.Location = new System.Drawing.Point(168, 478);
            this.btndivisão.Name = "btndivisão";
            this.btndivisão.Size = new System.Drawing.Size(59, 48);
            this.btndivisão.TabIndex = 14;
            this.btndivisão.Text = "/";
            this.btndivisão.UseVisualStyleBackColor = true;
            this.btndivisão.Click += new System.EventHandler(this.btndivisão_Click);
            // 
            // but1
            // 
            this.but1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but1.Location = new System.Drawing.Point(92, 190);
            this.but1.Name = "but1";
            this.but1.Size = new System.Drawing.Size(59, 48);
            this.but1.TabIndex = 15;
            this.but1.Text = "1";
            this.but1.UseVisualStyleBackColor = true;
            this.but1.Click += new System.EventHandler(this.button2_Click);
            // 
            // but2
            // 
            this.but2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but2.Location = new System.Drawing.Point(168, 190);
            this.but2.Name = "but2";
            this.but2.Size = new System.Drawing.Size(59, 48);
            this.but2.TabIndex = 16;
            this.but2.Text = "2";
            this.but2.UseVisualStyleBackColor = true;
            // 
            // but3
            // 
            this.but3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but3.Location = new System.Drawing.Point(254, 190);
            this.but3.Name = "but3";
            this.but3.Size = new System.Drawing.Size(59, 48);
            this.but3.TabIndex = 17;
            this.but3.Text = "3";
            this.but3.UseVisualStyleBackColor = true;
            // 
            // but4
            // 
            this.but4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but4.Location = new System.Drawing.Point(92, 257);
            this.but4.Name = "but4";
            this.but4.Size = new System.Drawing.Size(59, 48);
            this.but4.TabIndex = 18;
            this.but4.Text = "4";
            this.but4.UseVisualStyleBackColor = true;
            // 
            // but5
            // 
            this.but5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but5.Location = new System.Drawing.Point(168, 257);
            this.but5.Name = "but5";
            this.but5.Size = new System.Drawing.Size(59, 48);
            this.but5.TabIndex = 19;
            this.but5.Text = "5";
            this.but5.UseVisualStyleBackColor = true;
            // 
            // but6
            // 
            this.but6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but6.Location = new System.Drawing.Point(254, 257);
            this.but6.Name = "but6";
            this.but6.Size = new System.Drawing.Size(59, 48);
            this.but6.TabIndex = 20;
            this.but6.Text = "6";
            this.but6.UseVisualStyleBackColor = true;
            // 
            // but7
            // 
            this.but7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but7.Location = new System.Drawing.Point(92, 328);
            this.but7.Name = "but7";
            this.but7.Size = new System.Drawing.Size(59, 48);
            this.but7.TabIndex = 21;
            this.but7.Text = "7";
            this.but7.UseVisualStyleBackColor = true;
            // 
            // but8
            // 
            this.but8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but8.Location = new System.Drawing.Point(168, 328);
            this.but8.Name = "but8";
            this.but8.Size = new System.Drawing.Size(59, 48);
            this.but8.TabIndex = 22;
            this.but8.Text = "8";
            this.but8.UseVisualStyleBackColor = true;
            // 
            // but9
            // 
            this.but9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but9.Location = new System.Drawing.Point(254, 328);
            this.but9.Name = "but9";
            this.but9.Size = new System.Drawing.Size(59, 48);
            this.but9.TabIndex = 23;
            this.but9.Text = "9";
            this.but9.UseVisualStyleBackColor = true;
            // 
            // but0
            // 
            this.but0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but0.Location = new System.Drawing.Point(168, 394);
            this.but0.Name = "but0";
            this.but0.Size = new System.Drawing.Size(59, 48);
            this.but0.TabIndex = 24;
            this.but0.Text = "0";
            this.but0.UseVisualStyleBackColor = true;
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(315, 478);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(59, 48);
            this.igual.TabIndex = 25;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(421, 576);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.but0);
            this.Controls.Add(this.but9);
            this.Controls.Add(this.but8);
            this.Controls.Add(this.but7);
            this.Controls.Add(this.but6);
            this.Controls.Add(this.but5);
            this.Controls.Add(this.but4);
            this.Controls.Add(this.but3);
            this.Controls.Add(this.but2);
            this.Controls.Add(this.but1);
            this.Controls.Add(this.btndivisão);
            this.Controls.Add(this.btnvezes);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btmsoma);
            this.Controls.Add(this.labeval3);
            this.Controls.Add(this.labelval1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox labelval1;
        private System.Windows.Forms.TextBox labeval3;
        private System.Windows.Forms.Button btmsoma;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btnvezes;
        private System.Windows.Forms.Button btndivisão;
        private System.Windows.Forms.Button but1;
        private System.Windows.Forms.Button but2;
        private System.Windows.Forms.Button but3;
        private System.Windows.Forms.Button but4;
        private System.Windows.Forms.Button but5;
        private System.Windows.Forms.Button but6;
        private System.Windows.Forms.Button but7;
        private System.Windows.Forms.Button but8;
        private System.Windows.Forms.Button but9;
        private System.Windows.Forms.Button but0;
        private System.Windows.Forms.Button igual;
    }
}

