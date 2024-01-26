using System.Xml.Linq;

namespace Ecole;
public class Etudiant : Personne
{
    private List<Evaluation> evaluations;

    public List<Evaluation> Evaluations
    {
        get
        {
            return evaluations;
        }
    }

    public Etudiant(string prenom, string nom) : base(prenom, nom) {
        evaluations = new List<Evaluation>();
    }

    public void Add(Evaluation evaluation) {
        evaluations.Add(evaluation);
    }

    public double Moyenne() {
        int total = 0;
        int ects = 0;
        foreach(var evaluation in evaluations) {
            total += evaluation.Note() * evaluation.Activite.ECTS;
            ects += evaluation.Activite.ECTS;
        }
        return total/ects;
    }

    public string Bulletin {
        get
            {

            var lines = new List<String>
        {
            String.Format("Bulletin de {0}", DisplayName())
        };

            foreach (var evaluation in evaluations)
            {
                lines.Add(evaluation.ToString());
            }

            lines.Add(String.Format("Moyenne: {0:N2}", Moyenne()));

            return String.Join("\n", lines);
        }
    }

    public override string ToString()
    {
        return String.Format("{0} {1}", Firstname, Lastname);
    }
}
