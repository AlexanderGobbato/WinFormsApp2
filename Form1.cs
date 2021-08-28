using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Classes;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        Pessoa pessoa;
        Aluno aluno;
        public Form1()
        {
            InitializeComponent();
            pessoa = new Pessoa("123456789-0", "Nome Pessoa");

            aluno = new Aluno("123456", "Gabriel Ferreira", "RGM 123456");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(pessoa.Cpf);
            //MessageBox.Show(pessoa.Nome);

            //pessoa.Nome = "Alexander Gobbato";

            //txtNome.Text = pessoa.Nome;

            MessageBox.Show("Aluno:" + aluno.Nome);
            MessageBox.Show("Pessoa: " + pessoa.Nome);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
