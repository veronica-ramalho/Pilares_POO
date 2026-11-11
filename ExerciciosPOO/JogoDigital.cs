namespace ExerciciosPOO
{
    public class JogoDigital : Jogo
    {
        public JogoDigital()
        {
            
        }
        public JogoDigital(string nome, string plataforma) : base (nome, plataforma)
        {
            
        }

        public override void ExibirInformações()
        {
            Console.WriteLine($"Jogo Digital: \nNome: {Nome} \nPlataforma: {Plataforma} \n");
        }  
    }
}