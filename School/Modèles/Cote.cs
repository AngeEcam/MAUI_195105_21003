namespace Ecole;
public class Cote : Evaluation
{
    private int note;

    public Cote(Activite activite, int note) : base(activite) {
        SetNote(note);
    }

    public Cote(Activite activite) : base(activite) {
        SetNote(0);
    }

    public void SetNote(int note) {
        this.note = note;
    }

    public override int Note()
    {
        return note;
    }
}
