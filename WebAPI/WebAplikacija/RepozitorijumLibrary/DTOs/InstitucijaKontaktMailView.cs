namespace RepozitorijumLibrary.DTOs;

public class InstitucijaKontaktMailView
{
    public int Id { get; set; }
    public string? KontaktMail { get; set; }

    public InstitucijaKontaktMailView() { }

    internal InstitucijaKontaktMailView(InstitucijaKontaktMail? km)
    {
        if (km != null)
        {
            Id = km.Id;
            KontaktMail = km.KontaktMail;
        }
    }
}
