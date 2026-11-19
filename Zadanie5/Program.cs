

List<string> przedmioty = new List<string> { "Miecz", "Tarcza", "Mikstura", "Klucz" };

if (przedmioty.Count == 0)
{
    Console.WriteLine("Lista jest pusta – nie ma czego usuwać.");
}
else
{
    for (int i = 0; i < przedmioty.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {przedmioty[i]}");
    }

    bool poprawny = false;
    while (!poprawny)
    {
        Console.Write("Wybierz przedmiot do usunięcia: ");
        int numer;
        if (!int.TryParse(Console.ReadLine()!, out numer))
        {
            Console.WriteLine("Wpisz liczbę całkowitą.");
        }
        else if (numer < 1 || numer > przedmioty.Count)
        {
            Console.WriteLine($"Numer musi należeć do zakresu 1–{przedmioty.Count}.");
        }
        else
        {
            int indeks = numer - 1;
            string nazwa = przedmioty[indeks];
            przedmioty.RemoveAt(indeks);
            Console.WriteLine($"Usunięto: {nazwa}");
            poprawny = true;
        }
    }

    if (przedmioty.Count == 0)
    {
        Console.WriteLine("Lista jest pusta.");
    }
    else
    {
        Console.WriteLine("Aktualna lista:");
        for (int i = 0; i < przedmioty.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {przedmioty[i]}");
        }
    }
}
