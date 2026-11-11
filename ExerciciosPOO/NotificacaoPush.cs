namespace ExerciciosPOO
{
    public class NotificacaoPush : Notificacao
    {
        public override void Enviar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}