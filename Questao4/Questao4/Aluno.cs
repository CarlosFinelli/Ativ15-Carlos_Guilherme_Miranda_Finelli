using System;
using System.Collections.Generic;
using System.Text;

namespace Questao4
{
    class Aluno
    {
        private String Nome, Email, Cidade;
        private bool Status;

        public Aluno(String Nome, String Email, String Cidade)
        {
            this.Nome = Nome;
            this.Email = Email;
            this.Cidade = Cidade;
            this.Status = true;
        }

        public String GetNome()
        {
            return Nome;
        }

        public String GetEmail()
        {
            return Email;
        }

        public String GetCidade()
        {
            return Cidade;
        }

        public bool GetStatus()
        {
            return Status;
        }

        public void SetEmail(String Email)
        {
            this.Email = Email;
        }

        public void SetCidade(String Cidade)
        {
            this.Cidade = Cidade;
        }
    }
}
