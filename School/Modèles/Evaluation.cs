namespace Ecole;
public abstract class Evaluation
{
    private Activite activite;

    public Evaluation(Activite activite) {
        this.activite = activite;
    }

    public Activite Activite {
        get {
            return activite;
        }
    }

    public abstract int Note();

    public override string ToString()
    {
        return String.Format("{0}: {1}/20", Activite, Note());
    }
    public int NoteValue
    {
        get { return Note(); }
    }
}
