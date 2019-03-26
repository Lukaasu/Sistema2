namespace Exercicio2___19_03_19
{
    partial class frmFuncionario
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.maskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskCelular = new System.Windows.Forms.MaskedTextBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbdCasado = new System.Windows.Forms.RadioButton();
            this.rbdSolteiro = new System.Windows.Forms.RadioButton();
            this.gbxEscolaridade = new System.Windows.Forms.GroupBox();
            this.rdbFundamental = new System.Windows.Forms.RadioButton();
            this.rdbMedio = new System.Windows.Forms.RadioButton();
            this.rdbSuperior = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gbxEstadoCivil.SuspendLayout();
            this.gbxEscolaridade.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE FUNCIONÁRIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(48, 104);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(201, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(255, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // maskTelefone
            // 
            this.maskTelefone.Location = new System.Drawing.Point(48, 143);
            this.maskTelefone.Mask = "(99) 00000-0000";
            this.maskTelefone.Name = "maskTelefone";
            this.maskTelefone.Size = new System.Drawing.Size(100, 20);
            this.maskTelefone.TabIndex = 9;
            // 
            // maskCelular
            // 
            this.maskCelular.Location = new System.Drawing.Point(154, 143);
            this.maskCelular.Mask = "(99) 00000-0000";
            this.maskCelular.Name = "maskCelular";
            this.maskCelular.Size = new System.Drawing.Size(100, 20);
            this.maskCelular.TabIndex = 10;
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(48, 188);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(121, 21);
            this.cmbCidade.TabIndex = 11;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(179, 188);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(48, 21);
            this.cmbEstado.TabIndex = 12;
            // 
            // gbxEstadoCivil
            // 
            this.gbxEstadoCivil.Controls.Add(this.rbdCasado);
            this.gbxEstadoCivil.Controls.Add(this.rbdSolteiro);
            this.gbxEstadoCivil.Location = new System.Drawing.Point(48, 215);
            this.gbxEstadoCivil.Name = "gbxEstadoCivil";
            this.gbxEstadoCivil.Size = new System.Drawing.Size(200, 39);
            this.gbxEstadoCivil.TabIndex = 13;
            this.gbxEstadoCivil.TabStop = false;
            this.gbxEstadoCivil.Text = "Estado Civil:";
            // 
            // rbdCasado
            // 
            this.rbdCasado.AutoSize = true;
            this.rbdCasado.Location = new System.Drawing.Point(94, 16);
            this.rbdCasado.Name = "rbdCasado";
            this.rbdCasado.Size = new System.Drawing.Size(61, 17);
            this.rbdCasado.TabIndex = 1;
            this.rbdCasado.TabStop = true;
            this.rbdCasado.Text = "Casado";
            this.rbdCasado.UseVisualStyleBackColor = true;
            // 
            // rbdSolteiro
            // 
            this.rbdSolteiro.AutoSize = true;
            this.rbdSolteiro.Location = new System.Drawing.Point(15, 16);
            this.rbdSolteiro.Name = "rbdSolteiro";
            this.rbdSolteiro.Size = new System.Drawing.Size(60, 17);
            this.rbdSolteiro.TabIndex = 0;
            this.rbdSolteiro.TabStop = true;
            this.rbdSolteiro.Text = "Solteiro";
            this.rbdSolteiro.UseVisualStyleBackColor = true;
            // 
            // gbxEscolaridade
            // 
            this.gbxEscolaridade.Controls.Add(this.rdbFundamental);
            this.gbxEscolaridade.Controls.Add(this.rdbMedio);
            this.gbxEscolaridade.Controls.Add(this.rdbSuperior);
            this.gbxEscolaridade.Location = new System.Drawing.Point(265, 127);
            this.gbxEscolaridade.Name = "gbxEscolaridade";
            this.gbxEscolaridade.Size = new System.Drawing.Size(136, 82);
            this.gbxEscolaridade.TabIndex = 14;
            this.gbxEscolaridade.TabStop = false;
            this.gbxEscolaridade.Text = "Escolaridade:";
            // 
            // rdbFundamental
            // 
            this.rdbFundamental.AutoSize = true;
            this.rdbFundamental.Location = new System.Drawing.Point(6, 65);
            this.rdbFundamental.Name = "rdbFundamental";
            this.rdbFundamental.Size = new System.Drawing.Size(121, 17);
            this.rdbFundamental.TabIndex = 3;
            this.rdbFundamental.TabStop = true;
            this.rdbFundamental.Text = "Ensino Fundamental";
            this.rdbFundamental.UseVisualStyleBackColor = true;
            // 
            // rdbMedio
            // 
            this.rdbMedio.AutoSize = true;
            this.rdbMedio.Location = new System.Drawing.Point(6, 40);
            this.rdbMedio.Name = "rdbMedio";
            this.rdbMedio.Size = new System.Drawing.Size(89, 17);
            this.rdbMedio.TabIndex = 2;
            this.rdbMedio.TabStop = true;
            this.rdbMedio.Text = "Ensino Médio";
            this.rdbMedio.UseVisualStyleBackColor = true;
            // 
            // rdbSuperior
            // 
            this.rdbSuperior.AutoSize = true;
            this.rdbSuperior.Location = new System.Drawing.Point(6, 17);
            this.rdbSuperior.Name = "rdbSuperior";
            this.rdbSuperior.Size = new System.Drawing.Size(99, 17);
            this.rdbSuperior.TabIndex = 1;
            this.rdbSuperior.TabStop = true;
            this.rdbSuperior.Text = "Ensino Superior";
            this.rdbSuperior.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Salário:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "R$";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(363, 209);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(82, 20);
            this.txtSalario.TabIndex = 18;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(267, 232);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(178, 23);
            this.btnCadastrar.TabIndex = 19;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 311);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gbxEscolaridade);
            this.Controls.Add(this.gbxEstadoCivil);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbCidade);
            this.Controls.Add(this.maskCelular);
            this.Controls.Add(this.maskTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFuncionario";
            this.Text = "frmFuncionario";
            this.gbxEstadoCivil.ResumeLayout(false);
            this.gbxEstadoCivil.PerformLayout();
            this.gbxEscolaridade.ResumeLayout(false);
            this.gbxEscolaridade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox maskTelefone;
        private System.Windows.Forms.MaskedTextBox maskCelular;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.GroupBox gbxEstadoCivil;
        private System.Windows.Forms.RadioButton rbdCasado;
        private System.Windows.Forms.RadioButton rbdSolteiro;
        private System.Windows.Forms.GroupBox gbxEscolaridade;
        private System.Windows.Forms.RadioButton rdbFundamental;
        private System.Windows.Forms.RadioButton rdbMedio;
        private System.Windows.Forms.RadioButton rdbSuperior;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnCadastrar;
    }
}