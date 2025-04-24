namespace MySQLLab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConexao = new Button();
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtSenha = new TextBox();
            btnCadatrar = new Button();
            btnDeletar = new Button();
            txtAtualizar = new Button();
            SuspendLayout();
            // 
            // btnConexao
            // 
            btnConexao.Location = new Point(621, 12);
            btnConexao.Name = "btnConexao";
            btnConexao.Size = new Size(167, 68);
            btnConexao.TabIndex = 0;
            btnConexao.Text = "CONEXÃO";
            btnConexao.UseVisualStyleBackColor = true;
            btnConexao.Click += btnConexao_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 1;
            label1.Text = "ID :";
            label1.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(79, 57);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 2;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome :";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(79, 109);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 1;
            label3.Text = "E-mail :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(79, 151);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 198);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 1;
            label4.Text = "Senha :";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(79, 198);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 2;
            // 
            // btnCadatrar
            // 
            btnCadatrar.Location = new Point(12, 262);
            btnCadatrar.Name = "btnCadatrar";
            btnCadatrar.Size = new Size(167, 23);
            btnCadatrar.TabIndex = 3;
            btnCadatrar.Text = "CADASTRAR";
            btnCadatrar.UseVisualStyleBackColor = true;
            btnCadatrar.Click += btnCadatrar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(12, 313);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(167, 23);
            btnDeletar.TabIndex = 4;
            btnDeletar.Text = "DELETAR";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // txtAtualizar
            // 
            txtAtualizar.Location = new Point(12, 358);
            txtAtualizar.Name = "txtAtualizar";
            txtAtualizar.Size = new Size(167, 23);
            txtAtualizar.TabIndex = 5;
            txtAtualizar.Text = "ATUALIZAR";
            txtAtualizar.UseVisualStyleBackColor = true;
            txtAtualizar.Click += txtAtualizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAtualizar);
            Controls.Add(btnDeletar);
            Controls.Add(btnCadatrar);
            Controls.Add(txtSenha);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnConexao);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConexao;
        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtSenha;
        private Button btnCadatrar;
        private Button btnDeletar;
        private Button txtAtualizar;
    }
}
