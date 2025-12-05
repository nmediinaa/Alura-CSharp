using NotificacoesSistema.Interfaces;
using NotificacoesSistema.Models;

List<INotificacao> sistemaNotificacao = new List<INotificacao>
{
    new EmailNotificacao(),
    new SmsNotificacao(),
    new PushNotificacao()
};


foreach (var notificacao in sistemaNotificacao)
{
    notificacao.EnviarMensagem("Sistema Fora do AR");
}
