

int[] zlotoWTurach = { 5, 12, 0, 8, 15 };

int suma = 0;
for (int i = 0; i < zlotoWTurach.Length; i++)
{
    Console.WriteLine($"Tura {i + 1}: {zlotoWTurach[i]} sztuk złota");
    suma += zlotoWTurach[i];
}

int liczbaDobrychTur = 0;
foreach (int zloto in zlotoWTurach)
{
    if (zloto >= 10)
    {
        liczbaDobrychTur++;
    }
}

Console.WriteLine($"Łącznie: {suma}");

if (zlotoWTurach.Length > 0)
{
    double srednia = (double)suma / zlotoWTurach.Length;
    Console.WriteLine($"Średnio na turę: {srednia:F2}");
}
else
{
    Console.WriteLine("Średnio na turę: brak danych");
}

Console.WriteLine($"Tury z wynikiem co najmniej 10: {liczbaDobrychTur}");

Console.Write("Od końca: ");
for (int i = zlotoWTurach.Length - 1; i >= 0; i--)
{
    Console.Write(zlotoWTurach[i]);
    if (i > 0)
    {
        Console.Write(" ");
    }
}
Console.WriteLine();
