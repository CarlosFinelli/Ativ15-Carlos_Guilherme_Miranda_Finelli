using System;

namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o nome do produto: ");
            String nome = Console.ReadLine();
            Console.Clear();
            Console.Write("Insira o preço do produto: ");
            double Preco = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira a quantidade do produto: ");
            int Quantidade = Convert.ToInt16(Console.ReadLine());
            Produto produto = new Produto(nome, Preco, Quantidade);
        inicio:
            Console.Clear();
            Console.WriteLine($"Nome do produto: {nome} | Valor total em estoque: {produto.ValorTotalEmEstoque()}");
            Console.ReadKey();
            escolha:
            Console.WriteLine("Deseja alterar alguma informação do produto? (1 = Sim, 2 = Não): ");
            int opcao = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("1 - Adicionar produto.");
                    Console.WriteLine("2 - Remover produto.");
                    Console.WriteLine();
                    Console.WriteLine("Opção: ");
                    int decisao = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    if (decisao == 1)
                    {
                        Console.Write("Insira a quantidade que deseja adicionar ao produto: ");
                        Quantidade = Convert.ToInt16(Console.ReadLine());
                        Console.Clear();
                        produto.AdicionarProdutos(Quantidade);
                        goto inicio;
                    } else if (decisao == 2)
                    {
                        Console.Write("Insira a quantidade que deseja remover do produto: ");
                        Quantidade = Convert.ToInt16(Console.ReadLine());
                        Console.Clear();
                        produto.RemoverProdutos(Quantidade);
                    }
                    goto inicio;

                case 2:
                    Console.WriteLine("Obrigado por utilizar nossos serviços.");
                    Console.ReadKey();
                    break;
            }
            if (opcao != 1 && opcao != 2)
            {
                Console.WriteLine("Opção inválida.");
                Console.ReadKey();
                goto escolha;
            }
        }
    }
}
