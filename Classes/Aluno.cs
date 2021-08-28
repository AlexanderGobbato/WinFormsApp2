using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Classes
{
    class Aluno : Pessoa
    {
        private String rgm;

        public Aluno() : base()
        {
            rgm = "";
        }

        public Aluno(string cpf, string nome, string rgm) : base(cpf, nome)
        {
            this.rgm = rgm;
        }

        public string Rgm { get => rgm; set => rgm = value; }
    }
}
