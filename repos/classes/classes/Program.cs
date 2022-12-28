

namespace Curso_DankiCode
{
    public class Aluno
    {
        public string nome = "Moises";
        public int nota_anual = 10;
        public int cpf = 99810;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.WriteLine(aluno.nome);
        }
    }
}