using System;
using System.IO;
					
public class Program
{
	public static void Main()
	{
		    Console.Write("Unesite putanju direktorija: ");
            string putanja = Console.ReadLine();
            // Provjeravamo postoji li uneseni direktorij
            if (Directory.Exists(putanja))
            {
                // Ispisujemo sve datoteke u direktoriju
                Console.WriteLine("Datoteke:");
                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }
                // Provjeravamo postoji li poddirektorij TEST
                string putanjaPoddirektorija = putanja + "\\TEST";
                if (!Directory.Exists(putanjaPoddirektorija))
                {
                    // Ako ne postoji, kreiramo ga
                    Directory.CreateDirectory(putanjaPoddirektorija);
                }
                // Ispisujemo sve poddirektorije
                Console.WriteLine("Poddirektoriji:");
                foreach (string poddirektorij in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(poddirektorij);
                }
                
                

                // Brišemo poddirektorij TEST
                Directory.Delete(putanjaPoddirektorija);
                // Ponovno ispisujemo sve poddirektorije
                Console.WriteLine("Nakon brisanja direktorija TEST:");
                foreach (string poddirektorij
                in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(poddirektorij);
                }
            }
            else
            {
                Console.WriteLine("Putanja ne postoji na računalu!");
            }
            
        }
    }
