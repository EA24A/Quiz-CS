using System;
using System.Collections.Generic;

namespace Quiz
{
    class Programm
    {
        static void Main(string[] args)
        {
            // Fragen und Antworten
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

            List<int> frageIndexListe = new List<int>();
            for (int i = 0; i < fragen.Length; i++)
            {
                frageIndexListe.Add(i);
            }

            // Fragen zufällig mischen
            Random random = new Random();
            for (int i = frageIndexListe.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int temp = frageIndexListe[i];
                frageIndexListe[i] = frageIndexListe[j];
                frageIndexListe[j] = temp;
            }

            // Quiz durchführen
            foreach (var frageIndex in frageIndexListe)
            {
                Console.WriteLine(fragen[frageIndex]);

                for (int j = 0; j < antworten.GetLength(1); j++)
                {
                    Console.WriteLine($"{j + 1}. {antworten[frageIndex, j]}");
                }

                int benutzerAntwortIndex = -1;
                // Solange der Benutzer keine gültige Antwort gibt, wiederhole die Frage
                while (benutzerAntwortIndex < 0 || benutzerAntwortIndex >= antworten.GetLength(1))
                {
                    Console.WriteLine("Ihre Antwort (geben Sie die Nummer ein):");

                    string benutzerAntworten = Console.ReadLine();
                    if (int.TryParse(benutzerAntworten, out benutzerAntwortIndex))
                    {
                        benutzerAntwortIndex--; // Um von 1-basierter auf 0-basierte Indizierung zu konvertieren
                    }

                    if (benutzerAntwortIndex < 0 || benutzerAntwortIndex >= antworten.GetLength(1))
                    {
                        Console.WriteLine("Ungültige Antwort! Bitte geben Sie eine Zahl zwischen 1 und 3 ein.");
                    }
                }

                // Überprüfen, ob die Antwort richtig ist
                if (antworten[frageIndex, benutzerAntwortIndex] == richtigeantworten[frageIndex])
                {
                    punkte++;
                    Console.WriteLine("Richtige Antwort!\n");
                }
                else
                {
                    Console.WriteLine($"Falsche Antwort! Korrekte Antwort: {richtigeantworten[frageIndex]}\n");
                }
            }

            Console.WriteLine($"Sie haben {punkte} von {fragen.Length} Punkten erreicht.");
        }
    }
}


