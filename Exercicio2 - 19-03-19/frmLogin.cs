﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2___19_03_19
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (VerificaSenha(txtUsuario.Text , txtSenha.Text) == true)
            {
                frmMenu fMenu = new frmMenu();
                fMenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário/senha inválidos. Tente novamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Text = "";
                txtUsuario.Focus();
            }
  
        }
        private bool VerificaSenha(string usuario, string senha)
        {
            if(usuario == "chico" && senha == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
