namespace DigitalniRepozitorijum.Entiteti;

public class AngazovanjeId
{
    public virtual Institucija Institucija { get; set; }
    public virtual Istrazivac Istrazivac { get; set; }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(this, obj)) return true;
        if (obj == null || GetType() != obj.GetType()) return false;
        AngazovanjeId other = (AngazovanjeId)obj;
        return Institucija != null && Istrazivac != null &&
               Institucija.Id == other.Institucija.Id &&
               Istrazivac.Id == other.Istrazivac.Id;
    }

    public override int GetHashCode()
    {
        return (Institucija?.Id ?? 0) * 31 + (Istrazivac?.Id ?? 0);
    }
}
