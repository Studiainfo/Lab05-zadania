

List<string> plecak = new List<string> { "Miecz", "Mikstura", "Pochodnia" };

Console.WriteLine($"Plecak ({plecak.Count}/6):");
for (int i = 0; i < plecak.Count; i++)
{
    Console.WriteLine($"{i + 1}. {plecak[i]}");
}

plecak.Add("Klucz");
Console.WriteLine("Dodano: Klucz");

if (plecak.Contains("Mikstura"))
{
    Console.WriteLine("W plecaku jest Mikstura.");
}
else
{
    Console.WriteLine("W plecaku nie ma Mikstury.");
}

bool usunieto = plecak.Remove("Mikstura");
if (usunieto)
{
    Console.WriteLine("Użyto mikstury.");
}
else
{
    Console.WriteLine("Nie udało się użyć mikstury – nie ma jej w plecaku.");
}

Console.WriteLine($"Plecak ({plecak.Count}/6):");
for (int i = 0; i < plecak.Count; i++)
{
    Console.WriteLine($"{i + 1}. {plecak[i]}");
}
