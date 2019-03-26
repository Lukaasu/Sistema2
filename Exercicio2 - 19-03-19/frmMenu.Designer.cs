namespace Exercicio2___19_03_19
{
    partial class frmMenu
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
            this.btnCasdastroClientes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastroFuncionarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCasdastroClientes
            // 
            this.btnCasdastroClientes.Location = new System.Drawing.Point(76, 37);
            this.btnCasdastroClientes.Name = "btnCasdastroClientes";
            this.btnCasdastroClientes.Size = new System.Drawing.Size(211, 76);
            this.btnCasdastroClientes.TabIndex = 0;
            this.btnCasdastroClientes.Text = "Cadastro de Clientes";
            this.btnCasdastroClientes.UseVisualStyleBackColor = true;
            this.btnCasdastroClientes.Click += new System.EventHandler(this.btnCasdastroClientes_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 76);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cadastro de Produtos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(380, 139);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(130, 65);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastroFuncionarios
            // 
            this.btnCadastroFuncionarios.Location = new System.Drawing.Point(293, 37);
            this.btnCadastroFuncionarios.Name = "btnCadastroFuncionarios";
            this.btnCadastroFuncionarios.Size = new System.Drawing.Size(217, 76);
            this.btnCadastroFuncionarios.TabIndex = 3;
            this.btnCadastroFuncionarios.Text = "Cadastro de Funcionários";
            this.btnCadastroFuncionarios.UseVisualStyleBackColor = true;
            this.btnCadastroFuncionarios.Click += new System.EventHandler(this.btnCadastroFuncionarios_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 333);
            this.Controls.Add(this.btnCadastroFuncionarios);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCasdastroClientes);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCasdastroClientes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastroFuncionarios;
    }
}