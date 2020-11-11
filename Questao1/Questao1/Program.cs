using System;

namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a Largura do retângulo: ");
            double Largura = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira a Altura do retângulo: ");
            double Altura = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Retangulo retangulo = new Retangulo(Largura, Altura);
        inicio:
            retangulo = new Retangulo(retangulo.GetLargura(), retangulo.GetAltura());
            retangulo.SetAreaRetangulo(retangulo.GetLargura(), retangulo.GetAltura());
            retangulo.SetDiagonal(retangulo.GetLargura(), retangulo.GetAltura());
            retangulo.SetPerimetro(retangulo.GetLargura(), retangulo.GetAltura());
            Console.WriteLine($"Dados do retângulo: \n\n | Altura: {retangulo.GetAltura()} | Largura: {retangulo.GetLargura()} |");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Área: {retangulo.GetAreaRetangulo()} \n Perimetro: {retangulo.GetPerimetro()} \n Diagonal: {retangulo.GetDiagonal()}");
            Console.WriteLine();
            Console.ReadKey();
            escolha:
            Console.WriteLine("Deseja alterar alguma informação do retângulo? (1 = Sim, 2 = Não): ");
            int opcao = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            switch(opcao)
            {
                case 1:
                    Console.Write("Insira a nova Largura do seu retângulo: ");
                    Largura = Convert.ToDouble(Console.ReadLine());
                    retangulo.SetLargura(Largura);
                    Console.Clear();
                    Console.Write("Insira a nova Altura do seu retângulo: ");
                    Altura = Convert.ToDouble(Console.ReadLine());
                    retangulo.SetAltura(Altura);
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
