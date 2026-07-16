namespace RepozitorijumLibrary.DTOs;

public class IstrazivacEmailView
{
    public int Id { get; set; }
    public string? Email { get; set; }

    public IstrazivacEmailView() { }

    internal IstrazivacEmailView(IstrazivacEmail? e)
    {
        if (e != null)
        {
            Id = e.Id;
            Email = e.Email;
        }
    }
}
