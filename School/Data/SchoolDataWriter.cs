using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace School
{
    public class SchoolDataWriter
    {

        private static SchoolDataWriter instance = null;

        private SchoolDataWriter() { }

        public static SchoolDataWriter Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SchoolDataWriter();
                }
                return instance;
            }
        }

        public void WriteData(List<Prof> Profs, List<Etudiant> Etudiants)
        {
            // Profs
            File.WriteAllLines(System.IO.Path.Combine(FileSystem.AppDataDirectory, "Prof.txt"), Profs.Select(t => $"{t.Prenom},{t.Nom},{t.Salaire}"));
            var evaluations = Etudiants.SelectMany(t => t.Evaluations);
            
            // Activités
            var activites = evaluations.Select(t => t.Activite);
            File.WriteAllLines(System.IO.Path.Combine(FileSystem.AppDataDirectory, "Activite.txt"), activites.Select(a => $"{a.Nom},{a.Code},{a.ECTS},{a.Prof.Prenom},{a.Prof.Nom}"));

            // Étudiants
            File.WriteAllLines(System.IO.Path.Combine(FileSystem.AppDataDirectory, "Etudiants.txt"), Etudiants.Select(s => $"{s.Prenom},{s.Nom}"));
            // Évaluations
            File.WriteAllLines(System.IO.Path.Combine(FileSystem.AppDataDirectory, "Evaluations.txt"), Etudiants.SelectMany(e => {
                List<string> list = new List<string>();
                foreach (var eval in e.Evaluations)
                {
                    list.Add($"{e.Prenom},{e.Nom},{eval.Activity.Code},{(eval is Cote ? "Cote" : "Appreciation")},{(eval is Cote ? ((Cote)eval).Note() : ((Appreciation)eval).GetAppreciation())}");
                }
                return list;
            }));

        }
        public void WriteDataStudents(List<Etudiant> etudiants)
        {
            // Étudiants
            File.WriteAllLines(System.IO.Path.Combine(FileSystem.AppDataDirectory, "Etudiants.txt"), etudiants.Select(t => $"{t.Prenom},{t.Nom}"));

        }
        public void WriteDataTeachers(List<Prof> profs)
        {
            // Profs
            File.WriteAllLines(System.IO.Path.Combine(FileSystem.AppDataDirectory, "Prof.txt"), profs.Select(t => $"{t.Prenom},{t.Nom},{t.Salaire}"));

        }
        public void WriteDataActivities(List<Activite> activites)
        {
            // Activités
            File.WriteAllLines(System.IO.Path.Combine(FileSystem.AppDataDirectory, "Activite.txt"), activites.Select(a => $"{a.Nom},{a.Code},{a.ECTS},{a.Prof.Prenom},{a.Prof.Nom}"));

        }
        public void WriteDataEvaluation(Etudiant e, Evaluation eval)
        {
            string line  = $"{e.Prenom},{e.Nom},{eval.Activity.Code},{(eval is Cote ? "Cote" : "Appreciation")},{(eval is Cote ? ((Cote)eval).Note() : ((Appreciation)eval).GetAppreciation())}";
            using (StreamWriter sw = File.AppendText(System.IO.Path.Combine(FileSystem.AppDataDirectory, "Evaluations.txt")))
            {
                sw.WriteLine(line);
            }
        }
    }
}
