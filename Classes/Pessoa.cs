using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Classes
{
    class Pessoa
    {
        private string cpf;
        private string nome;

        public Pessoa()
        {
            cpf = "";
            nome = "";
        }

        public Pessoa(string cpf, string nome)
        {
            this.cpf = cpf;
            this.nome = nome;
        }

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
    }
}
