using System.ComponentModel;

namespace Ecole;
public class Personne
{
    private string prenom;
    private string nom;
    public Person(string prenom, string nom) {
        this.prenom = prenom;
        this.nom = nom;
    }

    public string DisplayName() {
        return String.Format("{0} {1}", prenom, nom);
    }

    public string Prenom {
        get {
            return prenom;
        }
    }

    public string Nom {
        get {
            return nom;
        }
    }
    public string NomComplet {
        get {
            return nom + " " + prenom;
        }
    }
}
