namespace RepozitorijumLibrary.DTOs;

public class InstitucijaNaucnaOblastView
{
    public int Id { get; set; }
    public string? NaucnaOblast { get; set; }

    public InstitucijaNaucnaOblastView() { }

    internal InstitucijaNaucnaOblastView(InstitucijaNaucnaOblast? no)
    {
        if (no != null)
        {
            Id = no.Id;
            NaucnaOblast = no.NaucnaOblast;
        }
    }
}
