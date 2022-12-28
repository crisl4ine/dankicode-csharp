namespace Curso_DankiCode
{

    public class Aluno
    {
        public Aluno(string nome)
        {
            nomeDoAluno = nome;
        }
        public string nomeDoAluno { get; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Moises");
            Aluno aluno2 = new Aluno("Guilherme");
            Console.WriteLine(aluno1.nomeDoAluno);
            Console.WriteLine(aluno2.nomeDoAluno);
        }
    }
}