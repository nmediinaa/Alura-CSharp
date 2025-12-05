using NotificacoesSistema.Interfaces;

namespace NotificacoesSistema.Models;

public class EmailNotificacao : INotificacao
{
    public void EnviarMensagem(string mensagem)
    {
        Console.WriteLine($"Enviando EMAIL: {mensagem}");
    }
}