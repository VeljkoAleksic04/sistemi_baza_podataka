namespace DigitalniRepozitorijum.Entiteti;

public class AutorstvoId
{
    public virtual Publikacija Publikacija { get; set; }
    public virtual Istrazivac Autor { get; set; }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(this, obj)) return true;
        if (obj == null || GetType() != obj.GetType()) return false;
        AutorstvoId other = (AutorstvoId)obj;
        return Publikacija != null && Autor != null &&
               Publikacija.Id == other.Publikacija.Id &&
               Autor.Id == other.Autor.Id;
    }

    public override int GetHashCode()
    {
        return (Publikacija?.Id ?? 0) * 31 + (Autor?.Id ?? 0);
    }
}
