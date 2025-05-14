using System;
using System.Collections.Generic; // Pour utiliser List<T>

public class Resume
{
    public string _name;               // Le nom de la personne
    public List<Job> _jobs = new List<Job>();  // La liste des emplois (objets Job)

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.Display(); // Appelle la méthode Display() de chaque emploi
        }
    }
}
