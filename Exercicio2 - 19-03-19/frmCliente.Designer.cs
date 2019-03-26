namespace Exercicio2___19_03_19
{
    partial class frmCliente
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.maskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskCelular = new System.Windows.Forms.MaskedTextBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.gbxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.rdbSolteiro = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbVegetariano = new System.Windows.Forms.CheckBox();
            this.ckbVegano = new System.Windows.Forms.CheckBox();
            this.ckbLactose = new System.Windows.Forms.CheckBox();
            this.ckbDiabetico = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gbxEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Celular:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(179, 20);
            this.txtNome.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(256, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(202, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // maskTelefone
            // 
            this.maskTelefone.Location = new System.Drawing.Point(15, 107);
            this.maskTelefone.Mask = "(99) 00000-0000";
            this.maskTelefone.Name = "maskTelefone";
            this.maskTelefone.Size = new System.Drawing.Size(100, 20);
            this.maskTelefone.TabIndex = 8;
            // 
            // maskCelular
            // 
            this.maskCelular.Location = new System.Drawing.Point(135, 107);
            this.maskCelular.Mask = "(99) 00000-0000";
            this.maskCelular.Name = "maskCelular";
            this.maskCelular.Size = new System.Drawing.Size(100, 20);
            this.maskCelular.TabIndex = 9;
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(15, 161);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(139, 21);
            this.cmbCidade.TabIndex = 10;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(181, 161);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(54, 21);
            this.cmbEstado.TabIndex = 11;
            // 
            // gbxEstadoCivil
            // 
            this.gbxEstadoCivil.Controls.Add(this.rdbCasado);
            this.gbxEstadoCivil.Controls.Add(this.rdbSolteiro);
            this.gbxEstadoCivil.Location = new System.Drawing.Point(15, 202);
            this.gbxEstadoCivil.Name = "gbxEstadoCivil";
            this.gbxEstadoCivil.Size = new System.Drawing.Size(220, 56);
            this.gbxEstadoCivil.TabIndex = 12;
            this.gbxEstadoCivil.TabStop = false;
            this.gbxEstadoCivil.Text = "Estado Civil:";
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(94, 19);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(61, 17);
            this.rdbCasado.TabIndex = 1;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // rdbSolteiro
            // 
            this.rdbSolteiro.AutoSize = true;
            this.rdbSolteiro.Location = new System.Drawing.Point(6, 19);
            this.rdbSolteiro.Name = "rdbSolteiro";
            this.rdbSolteiro.Size = new System.Drawing.Size(60, 17);
            this.rdbSolteiro.TabIndex = 0;
            this.rdbSolteiro.TabStop = true;
            this.rdbSolteiro.Text = "Solteiro";
            this.rdbSolteiro.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(253, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Preferências:";
            // 
            // ckbVegetariano
            // 
            this.ckbVegetariano.AutoSize = true;
            this.ckbVegetariano.Location = new System.Drawing.Point(256, 83);
            this.ckbVegetariano.Name = "ckbVegetariano";
            this.ckbVegetariano.Size = new System.Drawing.Size(86, 17);
            this.ckbVegetariano.TabIndex = 14;
            this.ckbVegetariano.Text = "Vegetariano:";
            this.ckbVegetariano.UseVisualStyleBackColor = true;
            // 
            // ckbVegano
            // 
            this.ckbVegano.AutoSize = true;
            this.ckbVegano.Location = new System.Drawing.Point(256, 107);
            this.ckbVegano.Name = "ckbVegano";
            this.ckbVegano.Size = new System.Drawing.Size(63, 17);
            this.ckbVegano.TabIndex = 15;
            this.ckbVegano.Text = "Vegano";
            this.ckbVegano.UseVisualStyleBackColor = true;
            // 
            // ckbLactose
            // 
            this.ckbLactose.AutoSize = true;
            this.ckbLactose.Location = new System.Drawing.Point(256, 130);
            this.ckbLactose.Name = "ckbLactose";
            this.ckbLactose.Size = new System.Drawing.Size(122, 17);
            this.ckbLactose.TabIndex = 16;
            this.ckbLactose.Text = "Intolerante a lactose";
            this.ckbLactose.UseVisualStyleBackColor = true;
            // 
            // ckbDiabetico
            // 
            this.ckbDiabetico.AutoSize = true;
            this.ckbDiabetico.Location = new System.Drawing.Point(256, 153);
            this.ckbDiabetico.Name = "ckbDiabetico";
            this.ckbDiabetico.Size = new System.Drawing.Size(71, 17);
            this.ckbDiabetico.TabIndex = 17;
            this.ckbDiabetico.Text = "Diabético";
            this.ckbDiabetico.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(256, 195);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(202, 43);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 274);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.ckbDiabetico);
            this.Controls.Add(this.ckbLactose);
            this.Controls.Add(this.ckbVegano);
            this.Controls.Add(this.ckbVegetariano);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbxEstadoCivil);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.cmbCidade);
            this.Controls.Add(this.maskCelular);
            this.Controls.Add(this.maskTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.gbxEstadoCivil.ResumeLayout(false);
            this.gbxEstadoCivil.PerformLayout();
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
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox maskTelefone;
        private System.Windows.Forms.MaskedTextBox maskCelular;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.GroupBox gbxEstadoCivil;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbSolteiro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbVegetariano;
        private System.Windows.Forms.CheckBox ckbVegano;
        private System.Windows.Forms.CheckBox ckbLactose;
        private System.Windows.Forms.CheckBox ckbDiabetico;
        private System.Windows.Forms.Button btnCadastrar;
    }
}