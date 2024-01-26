namespace )Ecole;
public class Activite
{
    private Prof prof;
    private int ects;
    private string nom;
    private string code;

    public Activite(string nom, string code, int ECTS, Prof prof) {
        this.code = code;
        this.prof = prof;
        this.nom = nom;
        this.ects = ECTS;
    }

    public string Code {
        get {
            return code;
        }
    }

    public string Nom {
        get {
            return nom;
        }
    }

    public int ECTS {
        get {
            return ects;
        }
    }

    public Prof Prof {
        get {
            return teacher;
        }
    }

    public override string ToString()
    {
        return String.Format("[{0}] {1} ({2})", Code, Nom, Prof.DisplayName());
    }
}
