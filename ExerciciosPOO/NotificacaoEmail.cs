namespace ExerciciosPOO
{
    public class NotificacaoEmail : Notificacao
    {
        public override void Enviar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}