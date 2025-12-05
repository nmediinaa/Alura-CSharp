using NotificacoesSistema.Interfaces;

namespace NotificacoesSistema.Models;

public class SmsNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando SMS: {mensagem}");
    }
}