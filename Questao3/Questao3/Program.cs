using System;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o nome do Professor: ");
            String nome = Console.ReadLine();
            Console.Clear();
            Console.Write("Insira o sobrenome do Professor: ");
            String sobrenome = Console.ReadLine();
            Console.Clear();
            Console.Write("Insira o telefone do Professor: ");
            int Telefone = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            Professor professor = new Professor(nome, sobrenome, Telefone);
        inicio:
            Console.WriteLine("Informações do Professor: ");
            Console.WriteLine($"| Nome: {professor.GetNome()} | Sobrenome: {professor.GetSobrenome()} | Telefone: {professor.GetTelefone()} | \n " +
                $"| Usa óculos? {professor.GetOculos()}");
            Console.ReadKey();
            escolha:
            Console.WriteLine("Deseja alterar o uso de óculos? (1 = Sim, 2 = Não): ");
            int opcao = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            switch (opcao)
            {
                case 1:
                    Console.Write("Insira o uso de óculos (true = Sim, false = Não): ");
                    bool Oculos = Convert.ToBoolean(Console.ReadLine());
                    professor.SetOculos(Oculos);
                    Console.Clear();
                    Console.Write("Insira o novo telefone: ");
                    Telefone = Convert.ToInt16(Console.ReadLine());
                    professor.SetTelefone(Telefone);
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
