using System;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o nome do Professor: ");
            String nome = Console.ReadLine();
            Console.Clear();
            Console.Write("Insira o sobrenome do Professor: ");
            String email = Console.ReadLine();
            Console.Clear();
            Console.Write("Insira o telefone do Professor: ");
            String Cidade = Console.ReadLine();
            Console.Clear();
            Aluno aluno = new Aluno(nome, email, Cidade);
        inicio:
            Console.WriteLine("Informações do Aluno: ");
            Console.WriteLine($"| Nome: {aluno.GetNome()} | email: {aluno.GetEmail()} | Cidade: {aluno.GetCidade()} | \n " +
                $"| Usa óculos? {aluno.GetStatus()}");
            Console.ReadKey();
        escolha:
            Console.WriteLine("Deseja alterar o uso de óculos? (1 = Sim, 2 = Não): ");
            int opcao = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            switch (opcao)
            {
                case 1:
                    Console.Write("Insira novo email do aluno: ");
                    email = Console.ReadLine();
                    if (email == null)
                    {
                        Console.WriteLine("O valor não pode ser nulo.");
                        goto case 1;
                    }
                    aluno.SetEmail(email);
                    Console.Clear();
                    Console.Write("Insira a nova cidade: ");
                    Cidade = Console.ReadLine();
                    if (Cidade == null || Cidade.Length < 5)
                    {
                        Console.WriteLine("A cidade não pode ser nula ou ter menos de 5 caracteres.");
                        goto case 1;
                    }
                    aluno.SetCidade(Cidade);
                    Console.Clear();
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
