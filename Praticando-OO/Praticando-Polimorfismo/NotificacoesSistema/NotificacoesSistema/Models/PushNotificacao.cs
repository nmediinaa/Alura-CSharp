using NotificacoesSistema.Interfaces;

namespace NotificacoesSistema.Models;

public class PushNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando Push: {mensagem}");
    }
}