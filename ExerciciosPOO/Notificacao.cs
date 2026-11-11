namespace ExerciciosPOO
{
    public class Notificacao
    {
        public virtual void Enviar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}