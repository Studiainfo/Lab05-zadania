

Dictionary<string, int> ceny = new Dictionary<string, int>
{
    { "Mikstura", 15 },
    { "Pochodnia", 5 },
    { "Miecz", 40 }
};

Console.WriteLine($"Cennik kupca (liczba pozycji: {ceny.Count}):");
foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: {para.Value} zł");
}

Console.Write("Podaj nazwę przedmiotu: ");
string nazwa = Console.ReadLine()!;

if (ceny.ContainsKey(nazwa))
{
    Console.WriteLine($"Cena: {ceny[nazwa]} zł");
}
else
{
    Console.WriteLine("Kupiec nie sprzedaje takiego przedmiotu.");
}

ceny["Mikstura"] = 12;
Console.WriteLine("Cena mikstury zmieniona na 12 zł.");

Console.WriteLine($"Cennik kupca (liczba pozycji: {ceny.Count}):");
foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: {para.Value} zł");
}
