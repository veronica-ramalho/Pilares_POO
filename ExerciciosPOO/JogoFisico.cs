namespace ExerciciosPOO
{
    public class JogoFisico : Jogo
    {
        public JogoFisico()
        {
            
        }

        public JogoFisico(string nome, string plataforma) : base (nome, plataforma)
        {
            
        }

        public override void ExibirInformações()
        {
            Console.WriteLine($"Jogo Fisico: \nNome: {Nome} \nPlataforma: {Plataforma} \n");
        }
    }
}