namespace ExerciciosPOO
{
    public class CursoOnline : ProdutoDigital
    {
        public string? CargaHoraria { get; set; }

        public CursoOnline()
        {
            
        }
        public CursoOnline(string nome, decimal preco, string cargaHoraria) : base(nome, preco)
        {
            CargaHoraria = cargaHoraria;
        }

        public override void ExibirInformações() 
        {
            Console.WriteLine($"Curso: \nNome: {Nome} \nPreço: {Preco:C} \nCarga Horária: {CargaHoraria} \n");
        }
    }
}