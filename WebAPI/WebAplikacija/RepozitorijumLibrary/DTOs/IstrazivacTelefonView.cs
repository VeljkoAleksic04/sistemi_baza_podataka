namespace RepozitorijumLibrary.DTOs;

public class IstrazivacTelefonView
{
    public int Id { get; set; }
    public string? Telefon { get; set; }

    public IstrazivacTelefonView() { }

    internal IstrazivacTelefonView(IstrazivacTelefon? t)
    {
        if (t != null)
        {
            Id = t.Id;
            Telefon = t.Telefon;
        }
    }
}
