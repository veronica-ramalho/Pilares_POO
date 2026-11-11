namespace ExerciciosPOO
{
    public class Ebook : ProdutoDigital
    {
        public int QuantidadePaginas { get; set; }
    

        public Ebook()
        {
            
        }
        public Ebook(string nome, decimal preco, int totalPaginas) : base(nome, preco)
        {
            QuantidadePaginas = totalPaginas;
        }

        public override void ExibirInformações() 
        {
            Console.WriteLine($"Ebook: \nNome: {Nome} \nPreço: {Preco:C} \nQuantidade de páginas: {QuantidadePaginas} \n");
        }
    }
}