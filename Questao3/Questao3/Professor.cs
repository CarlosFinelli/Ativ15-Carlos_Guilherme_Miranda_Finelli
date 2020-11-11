using System;
using System.Collections.Generic;
using System.Text;

namespace Questao3
{
    class Professor
    {
        private String Nome, Sobrenome;
        private int Telefone;
        private bool Oculos;


        public Professor(String Nome, String Sobrenome, int Telefone)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Telefone = Telefone;
            this.Oculos = true;
        }
        public String GetNome()
        {
            return Nome;
        }
        public String GetSobrenome()
        {
            return Sobrenome;
        }

        public int GetTelefone()
        {
            return Telefone;
        }

        public bool GetOculos()
        {
            return Oculos;
        }

        public void SetTelefone(int Telefone)
        {
            this.Telefone = Telefone;
        }

        public void SetOculos(bool Oculos)
        {
            this.Oculos = Oculos;
        }
    }
}
