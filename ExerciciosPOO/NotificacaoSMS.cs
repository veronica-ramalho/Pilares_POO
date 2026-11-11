namespace ExerciciosPOO
{
    public class NotificacaoSMS : Notificacao
    {
        public override void Enviar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}