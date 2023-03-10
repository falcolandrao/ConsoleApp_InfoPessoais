using System;

namespace ConsoleApp_InfoPessoais
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("### Programa Informações Pessoais ###");

            var anoAtual = DateTime.Now.Year;

            var verificaCaractere = new String[] { "a", "e", "i", "o", "u", "@", ",", ".", ";", "'" };

            Console.Write("Inserir Nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.Write("Inserir Seu ano de nascimento com 4 dígitos: ");
            string anoNascimento = Console.ReadLine();

            foreach (var items in verificaCaractere)
            {
                anoNascimento = anoNascimento.Replace(items, string.Empty);
            }           

            int convertidoAnoNascimento = Convert.ToInt32(anoNascimento);

            int contaCaractere = nomeCompleto.Length;

            if (convertidoAnoNascimento > 4 && convertidoAnoNascimento <= 3)
            {
                Console.WriteLine("Você digitou mais que 4 dígitos ou menos que 4 dígitos");
            }
            else
            {
                int idadeAtual = anoAtual - convertidoAnoNascimento;

                Console.WriteLine("Seu nome " + nomeCompleto + " contém total de " + contaCaractere + " caracteres e Idade atual " + idadeAtual + " anos");
            }

            Console.ReadKey();
        }
    } 
}
