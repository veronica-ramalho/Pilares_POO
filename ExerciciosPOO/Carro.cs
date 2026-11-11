namespace PilaresPOO
{
    public class Carro : Veiculo
    {
        public int QuantidadePortas { get; set; }

        public override void ExibirInformações()
    {
        Console.WriteLine($"Marca do veiculo: {Marca} \nModelo do veiculo: {Modelo} \nQuantidade de portas: {QuantidadePortas}\n");
    }
    }
}