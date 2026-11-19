Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Dictionary<string, int> magazyn = new Dictionary<string, int>
{
    { "Mikstura", 3 },
    { "Pochodnia", 2 },
    { "Klucz", 1 }
};

bool dziala = true;
while (dziala)
{
    Console.WriteLine();
    Console.WriteLine("=== MAGAZYN ===");
    Console.WriteLine("1 - Pokaż magazyn");
    Console.WriteLine("2 - Przyjmij dostawę");
    Console.WriteLine("3 - Wydaj przedmiot");
    Console.WriteLine("4 - Usuń pustą pozycję");
    Console.WriteLine("5 - Zakończ");
    Console.Write("Wybór: ");
    string wybor = Console.ReadLine()!;

    switch (wybor)
    {
        case "1":
        {
            if (magazyn.Count == 0)
            {
                Console.WriteLine("Magazyn jest pusty.");
            }
            else
            {
                Console.WriteLine($"Magazyn (liczba pozycji: {magazyn.Count}):");
                foreach (KeyValuePair<string, int> para in magazyn)
                {
                    Console.WriteLine($"{para.Key}: {para.Value} szt.");
                }
            }
            break;
        }
        case "2":
        {
            Console.Write("Nazwa przedmiotu: ");
            string nazwa = Console.ReadLine()!;
            Console.Write("Ilość sztuk: ");
            string tekstIlosci = Console.ReadLine()!;
            int ilosc;
            if (nazwa == "")
            {
                Console.WriteLine("Nazwa nie może być pusta.");
            }
            else if (!int.TryParse(tekstIlosci, out ilosc))
            {
                Console.WriteLine("Wpisz liczbę całkowitą.");
            }
            else if (ilosc <= 0)
            {
                Console.WriteLine("Ilość musi być dodatnia.");
            }
            else if (magazyn.ContainsKey(nazwa))
            {
                magazyn[nazwa] += ilosc;
                Console.WriteLine($"Przyjęto dostawę: {nazwa} +{ilosc} (stan: {magazyn[nazwa]}).");
            }
            else
            {
                magazyn.Add(nazwa, ilosc);
                Console.WriteLine($"Dodano nową pozycję: {nazwa} (stan: {ilosc}).");
            }
            break;
        }
        case "3":
        {
            Console.Write("Nazwa przedmiotu: ");
            string nazwa = Console.ReadLine()!;
            if (!magazyn.ContainsKey(nazwa))
            {
                Console.WriteLine($"Nie ma takiego przedmiotu w magazynie: {nazwa}");
            }
            else
            {
                Console.Write("Ilość sztuk do wydania: ");
                int ilosc;
                if (!int.TryParse(Console.ReadLine()!, out ilosc))
                {
                    Console.WriteLine("Wpisz liczbę całkowitą.");
                }
                else if (ilosc <= 0)
                {
                    Console.WriteLine("Ilość musi być dodatnia.");
                }
                else if (ilosc > magazyn[nazwa])
                {
                    Console.WriteLine($"Za mało sztuk – dostępne: {magazyn[nazwa]}.");
                }
                else
                {
                    magazyn[nazwa] -= ilosc;
                    Console.WriteLine($"Wydano: {nazwa} x{ilosc} (stan: {magazyn[nazwa]}).");
                }
            }
            break;
        }
        case "4":
        {
            Console.Write("Nazwa przedmiotu: ");
            string nazwa = Console.ReadLine()!;
            if (!magazyn.ContainsKey(nazwa))
            {
                Console.WriteLine($"Nie ma takiego przedmiotu w magazynie: {nazwa}");
            }
            else if (magazyn[nazwa] != 0)
            {
                Console.WriteLine($"Nie można usunąć – stan wynosi {magazyn[nazwa]}.");
            }
            else
            {
                magazyn.Remove(nazwa);
                Console.WriteLine($"Usunięto pustą pozycję: {nazwa}");
            }
            break;
        }
        case "5":
        {
            dziala = false;
            Console.WriteLine("Koniec programu.");
            break;
        }
        default:
        {
            Console.WriteLine("Nieznana opcja.");
            break;
        }
    }
}
