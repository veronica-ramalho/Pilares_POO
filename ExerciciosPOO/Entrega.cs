namespace ExerciciosPOO
{
    public abstract class Entrega
    {
        public double Distancia { get; set; }
        public double PrecoProduto { get; set; }

        public Entrega(double distancia, double precoProduto)
        {
            Distancia = distancia;
            PrecoProduto = precoProduto;
        }
        
        public abstract void CalcularFrete();
    }
}