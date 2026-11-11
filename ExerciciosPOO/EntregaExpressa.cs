namespace ExerciciosPOO
{
    public class EntregaExpressa : Entrega
    {
        public double resultado;

        public EntregaExpressa(double distancia, double precoProduto) : base(distancia, precoProduto)
        {
        }

        public override void CalcularFrete()
        {
            Console.WriteLine("====== ENTREGA EXPRESSA ======");
            Console.WriteLine($"Valor do frete: {Distancia * 0.10 == resultado}");
            Console.WriteLine($"Valor total a ser pago: {PrecoProduto + resultado}");
        }
    }
}