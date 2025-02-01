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
                "Was für eine Hauptstadt von Deutschland?",
                 "Wie viele Bundesländer sind in Deutschland?",

            };

            string[,] antworten = new string[,]
            {
                {"Berlin", "Hamburg", "Paris"},
                {"11", "14", "16" }


            };
            string[] richtigeantworten = new string[] { "Berlin", "16" };

            int punkte = 0;

            // Logik des Codes
            for (int i = 0; i < fragen.Length; i++)
            {
                Console.WriteLine(fragen[i]);

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{j + 1}. {antworten[i, j]}");
                }
                Console.WriteLine("Ihre Antwort(geben Sie die Nummer):");

                string benutzerAntworten = Console.ReadLine();

                if (antworten[i, int.Parse(benutzerAntworten) - 1] == richtigeantworten[i])
                {
                    punkte++;
                    Console.WriteLine("Richtige Antwort!\n");
                }
                else
                {
                    Console.WriteLine($"Falsche Antwort! Korekte Antwort:{richtigeantworten[i]}\n ");
                }
                Console.WriteLine($"Sie haben {punkte} von {fragen.Length}");
            }
        }
    }
}