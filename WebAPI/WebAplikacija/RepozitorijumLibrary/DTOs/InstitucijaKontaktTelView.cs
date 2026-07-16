namespace RepozitorijumLibrary.DTOs;

public class InstitucijaKontaktTelView
{
    public int Id { get; set; }
    public string? KontaktTel { get; set; }

    public InstitucijaKontaktTelView() { }

    internal InstitucijaKontaktTelView(InstitucijaKontaktTel? kt)
    {
        if (kt != null)
        {
            Id = kt.Id;
            KontaktTel = kt.KontaktTel;
        }
    }
}
