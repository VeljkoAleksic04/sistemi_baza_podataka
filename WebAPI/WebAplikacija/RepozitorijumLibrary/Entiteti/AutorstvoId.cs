namespace RepozitorijumLibrary.Entiteti;

internal class AutorstvoId
{
    internal protected virtual Publikacija Publikacija { get; set; }
    internal protected virtual Istrazivac Autor { get; set; }

    public override bool Equals(object? obj)
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
