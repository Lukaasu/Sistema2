using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2___19_03_19
{
    public partial class frmFuncionario : Form
    {
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string estadoCivil, escolaridade, nome, email, telefone, celular, cidade, estado;
            nome = txtNome.Text;
            email = txtEmail.Text;
            telefone = maskTelefone.Text;
            celular = maskCelular.Text;
            cidade = cmbCidade.Items[cmbCidade.SelectedIndex].ToString();
            estado = cmbEstado.Items[cmbEstado.SelectedIndex].ToString();
            if(rbdCasado.Checked == true)
            {
                estadoCivil = "casado";
            }
            else
            {
                estadoCivil = "solteiro";
            }

            if(rdbFundamental.Checked == true)
            {
                escolaridade = "Ensino Fundamental";
            }else if(rdbMedio.Checked == true)
            {
                escolaridade = "Ensino Médio";
            }
            else
            {
                escolaridade = "Ensino Superior";
            }

            GravarFuncionario(nome, email, telefone, celular, cidade, estado, estadoCivil, escolaridade);
        }
        
        private void GravarFuncionario(string nome, string email, string telefone, string celular, string cidade, string estado, string estadoCivil, string escolaridade)
        {
            StreamWriter arquivo;
            string caminho = "C:\\sistema\\funcionarios.txt";

            arquivo = File.AppendText(caminho);
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("E-mail: " + email);
            arquivo.WriteLine("Telefone(s): " + telefone + " " + celular);
            arquivo.WriteLine("Local: " + cidade + " (" + estado + ")");
            arquivo.WriteLine("Estado Civil: " + estadoCivil);
            arquivo.WriteLine("Escolaridade? " + escolaridade);
            arquivo.WriteLine("============================================================");
            arquivo.WriteLine();
            arquivo.WriteLine();
            arquivo.Close();
        }
    }
}
