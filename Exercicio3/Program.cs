using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(aluno.NotaFinal() >= 60)
            {
                Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("REPROVADO");
                double pontosFaltantes = (aluno.NotaFinal() - 60) * (-1);
                Console.WriteLine($"FALTARAM {pontosFaltantes.ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}