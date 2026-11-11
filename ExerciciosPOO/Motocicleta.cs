namespace PilaresPOO
{
    public class Motocicleta : Veiculo
    {
        public int Cilindradas { get; set; }

    public override void ExibirInformações()
    {
        Console.WriteLine($"Marca do veiculo: {Marca} \nModelo do veiculo: {Modelo} \nCilindradas: {Cilindradas}\n");
    }
    }

}