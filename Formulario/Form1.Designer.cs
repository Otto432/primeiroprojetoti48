namespace Formulario
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
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.dataResgistro = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Adicionar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnMostrarDados = new System.Windows.Forms.Button();
            this.Dg = new System.Windows.Forms.DataGridView();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(13, 50);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(27, 24);
            this.id.TabIndex = 0;
            this.id.Text = "ID";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(12, 154);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(63, 24);
            this.email.TabIndex = 2;
            this.email.Text = "E-mail";
            // 
            // telefone
            // 
            this.telefone.AutoSize = true;
            this.telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefone.Location = new System.Drawing.Point(12, 116);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(85, 24);
            this.telefone.TabIndex = 3;
            this.telefone.Text = "Telefone";
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(13, 80);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(62, 24);
            this.nome.TabIndex = 4;
            this.nome.Text = "Nome";
            // 
            // dataResgistro
            // 
            this.dataResgistro.AutoSize = true;
            this.dataResgistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataResgistro.Location = new System.Drawing.Point(12, 193);
            this.dataResgistro.Name = "dataResgistro";
            this.dataResgistro.Size = new System.Drawing.Size(141, 24);
            this.dataResgistro.TabIndex = 5;
            this.dataResgistro.Text = "Data de registro";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(81, 54);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 20;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(81, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(103, 121);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(178, 20);
            this.txtTelefone.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(81, 158);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(15, 404);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(75, 43);
            this.Adicionar.TabIndex = 12;
            this.Adicionar.Text = "Adicionar";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(106, 404);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 43);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(199, 404);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 43);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(290, 404);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 43);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnMostrarDados
            // 
            this.btnMostrarDados.Location = new System.Drawing.Point(15, 470);
            this.btnMostrarDados.Name = "btnMostrarDados";
            this.btnMostrarDados.Size = new System.Drawing.Size(75, 43);
            this.btnMostrarDados.TabIndex = 16;
            this.btnMostrarDados.Text = "Mostrar dados";
            this.btnMostrarDados.UseVisualStyleBackColor = true;
            // 
            // Dg
            // 
            this.Dg.Location = new System.Drawing.Point(17, 232);
            this.Dg.Name = "Dg";
            this.Dg.Size = new System.Drawing.Size(357, 150);
            this.Dg.TabIndex = 19;
            this.Dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_CellClick);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(159, 197);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(215, 20);
            this.txtData.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 599);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.Dg);
            this.Controls.Add(this.btnMostrarDados);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.Adicionar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataResgistro);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label dataResgistro;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnMostrarDados;
        private System.Windows.Forms.DataGridView Dg;
        private System.Windows.Forms.DateTimePicker txtData;
    }
}

