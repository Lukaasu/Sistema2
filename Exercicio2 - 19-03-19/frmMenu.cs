using System;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnCasdastroClientes_Click(object sender, EventArgs e)
        {
            frmCliente fCliente = new frmCliente();
            fCliente.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastroFuncionarios_Click(object sender, EventArgs e)
        {
            frmFuncionario fFuncionario = new frmFuncionario();
            fFuncionario.ShowDialog();
        }
    }
}
