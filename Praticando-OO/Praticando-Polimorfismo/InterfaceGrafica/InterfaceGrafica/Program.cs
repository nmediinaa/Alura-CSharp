using InterfaceGrafica.Interfaces;
using InterfaceGrafica.Models;

List<IAcaoBotao> acaoBotaos = new ()
{
    new SalvarAcao(),
    new EditarAcao(),
    new ExcluirAcao()
};

foreach (var acao in acaoBotaos)
{
    acao.ExecutaAcao();
}