using System;
using System.Collections.Generic;
using System.Text;

namespace Questao2
{
    class Produto
    {
        private String Nome;
        private double Preco, ValorTotal;
        private int Quantidade;

        public Produto(String Nome, double Preco, int Quantidade)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Quantidade = Quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            Total();
            return ValorTotal;
        }

        public void AdicionarProdutos(int Quantidade)
        {
            this.Quantidade += Quantidade;
        }

        public void RemoverProdutos(int Quantidade)
        {
            this.Quantidade -= Quantidade;
        }

        public void Total()
        {
            this.ValorTotal = Quantidade * Preco;
        }
    }
}
