using System;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            //jogo de perguntas
            //Console.WriteLine - imprimir as perguntas na tela
            //Recolher os dados
            //Atribuir esses dados a algumas variaveis
            //Mostrar uma pontuação para o usuário

            int pontuacao = 0;
           
            
          
          
            //Pergunta 1
            Console.WriteLine("Quanto é 5 + 5?\nEscreva sua resposta abaixo:");
            int resposta_1 = Convert.ToInt32(Console.ReadLine());

            if (resposta_1 == 10)
            {
                pontuacao++;
            } 
            

            Console.WriteLine("Quanto é 10 + 5?\nEscreva sua resposta abaixo:");
            int resposta_2 = Convert.ToInt32(Console.ReadLine());

            if (resposta_2 == 15)
            {
                pontuacao++;
            }
           

            Console.WriteLine("Quem é o CEO da Danki Code?\nEscreva sua resposta abaixo:");
            string resposta_3 = Console.ReadLine();

            if (resposta_3 == "Guilherme")
            {
                pontuacao++;
            }
            

            Console.WriteLine("Quem é o insrutor do C# da Danki Code?\nEscreva sua resposta abaixo:");
            string resposta_4 = Console.ReadLine();

            if (resposta_4 == "Moises")
            {
                pontuacao++;
            }

            Console.WriteLine("Quanto é 12.5 + 2? \nEscreva sua resposta abaixo:");
            float resposta_5 = float.Parse(Console.ReadLine());


            if (resposta_5 == 14.5f)
            {
                pontuacao++;
            }


            //Pontuação total
            Console.WriteLine("O seu total de pontos foi:\n" + pontuacao);
        }
    }
}
