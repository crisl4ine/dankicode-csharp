
namespace Curso_DankiCode
{
    abstract class Motocicleta
    {
        //public qualquer um consegue chamar o methodo
        public void LigarMoto() { }

        //somente classes derivadas conseguem chamar
        protected void AdicionarGasolina (int galoes) { }

        public abstract double ChegarnaVelocidadeX();

        public virtual int Drive (int quilometros, int velocidade) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}