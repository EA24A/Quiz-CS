using System;

namespace Quiz
{
    class Programm
    {
        static void Main(string[] args)
        {
            // die Listen, die wir gelernt haben
            string[] fragen = new string[]
            {
                 "Was ist die Hauptstadt von Deutschland?",
                 "Wie viele Bundesländer gibt es in Deutschland?",
                 "Wie lange dauert das Studium zum Informationstechnischen Assistenten?",
                 "Welche Abschlussprüfungen kann man nach dem ITA absolvieren?",
                 "Welche Programmiersprache braucht man für ITA in diesem Kolleg?"
            };

            string[,] antworten = new string[,]
            {
                {"Berlin", "Hamburg", "Paris"},
                {"11", "14", "16" },
                {"2 Jahre", "3 Jahre", "4 Jahre"},
                {"Fachabitur", "Allgemeinabitur", "beide"},
                {"C#", "Java", "Python"}
            };

            string[] richtigeantworten = new string[] { "Berlin", "16", "3 Jahre", "beide", "C#" };

            int punkte = 0;

            // Logik des Codes
            for (int i = 0; i < fragen.Length; i++)
            {
                Console.WriteLine(fragen[i]);

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{j + 1}. {antworten[i, j]}");
                }
                Console.WriteLine("Ihre Antwort (geben Sie die Nummer ein):");

                string benutzerAntworten = Console.ReadLine();

                if (antworten[i, int.Parse(benutzerAntworten) - 1] == richtigeantworten[i])
                {
                    punkte++;
                    Console.WriteLine("Richtige Antwort!\n");
                }
                else
                {
                    Console.WriteLine($"Falsche Antwort! Korrekte Antwort: {richtigeantworten[i]}\n");
                }
            }

            Console.WriteLine($"Sie haben {punkte} von {fragen.Length} Punkten erreicht.");
        }
    }
}
