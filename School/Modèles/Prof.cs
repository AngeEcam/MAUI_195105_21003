namespace Ecole;
public class Prof : Personne
{
    private int salaire;
    public Teacher(string prenom, string nom, int salaire) : base(prenom, nom) {
        this.salaire = salaire;
    }

    public override string ToString()
    {
        return String.Format("{0} ({1})", DisplayName(), salaire);
    }

    public int Salaire {
        get {
            return salaire;
        }
    }
}
