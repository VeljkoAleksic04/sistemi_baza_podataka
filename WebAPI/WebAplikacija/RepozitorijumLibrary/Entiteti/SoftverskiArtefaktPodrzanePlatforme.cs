namespace RepozitorijumLibrary.Entiteti;

internal class SoftverskiArtefaktPodrzanePlatforme
{
    internal protected virtual int Id { get; set; }
    internal protected virtual int IdPublikacije { get; set; }
    internal protected virtual required string PodrzanaPlatforma { get; set; }
    internal protected virtual SoftverskiArtefakt? SoftverskiArtefakt { get; set; }
}