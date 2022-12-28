namespace Curso_DankiCode
{
    public class Trabalhador
    {
        public string nome;

        protected decimal salarioBase;


        public Trabalhador(string nome, decimal salarioBase)
        {
            this.nome = nome;
            this.salarioBase = salarioBase;
        }
        public virtual decimal CalcularPagamento()
        {
            return salarioBase;
        }


    }

    public class vendasTrabalhador : Trabalhador
    {
        private decimal bonusDeVendas;

        public vendasTrabalhador(string nome, decimal salarioBase, 
            decimal bonusDeVendas) : base(nome, salarioBase)
        {
            this.bonusDeVendas= bonusDeVendas;
        }
        public override decimal CalcularPagamento()
        {
            return salarioBase + bonusDeVendas;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var trabalhador1 = new vendasTrabalhador("Ana", 1000, 500);

            Console.WriteLine($"trabalhador1 {trabalhador1.nome} ganhou: {trabalhador1.CalcularPagamento()}");
        }
    }
}