namespace PilaresPOO
{
    public class Veiculo
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }

        public virtual void ExibirInformações()
        {
            Console.WriteLine($"Marca do veiculo: {Marca} \nModelo do veiculo: {Modelo}");
        }
    }
}