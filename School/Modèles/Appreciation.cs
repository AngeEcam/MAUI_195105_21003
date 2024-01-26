namespace Ecole;
public class Appreciation : Evaluation
{
    private string appreciation;

    public Appreciation(Activite activite, string appreciation) : base(activite) {
        SetAppreciation(appreciation);
    }

    public Appreciation(Activite activite) : base(activite) {
        SetAppreciation("Not Set");
    }

    public void SetAppreciation(string appreciation) {
        this.appreciation = appreciation;
    }
    public string GetAppreciation() {
        return this.appreciation;
    }

    public override int Note()
    {
        switch(appreciation) {
            case "TB":
                return 20;
            case "B":
                return 16;
            case "S":
                return 12;
            case "F":
                return 8;
            case "I":
                return 4;
            default:
                return 0;
        }
    }
}
