

int liczbaTur = 0;
bool poprawna = false;
while (!poprawna)
{
    Console.Write("Podaj liczbę tur (1–10): ");
    if (!int.TryParse(Console.ReadLine()!, out liczbaTur))
    {
        Console.WriteLine("Wpisz liczbę całkowitą.");
    }
    else if (liczbaTur < 1 || liczbaTur > 10)
    {
        Console.WriteLine("Liczba tur musi należeć do zakresu 1–10.");
    }
    else
    {
        poprawna = true;
    }
}

int[] zloto = new int[liczbaTur];
for (int i = 0; i < zloto.Length; i++)
{
    bool ok = false;
    while (!ok)
    {
        Console.Write($"Podaj złoto z tury {i + 1}: ");
        int wartosc;
        if (!int.TryParse(Console.ReadLine()!, out wartosc))
        {
            Console.WriteLine("Wpisz liczbę całkowitą.");
        }
        else if (wartosc < 0)
        {
            Console.WriteLine("Wynik nie może być ujemny.");
        }
        else
        {
            zloto[i] = wartosc;
            ok = true;
        }
    }
}

int suma = 0;
int minimum = zloto[0];
int maksimum = zloto[0];
int indeksMaksimum = 0;
int indeksZera = -1;

for (int i = 0; i < zloto.Length; i++)
{
    suma += zloto[i];
    if (zloto[i] < minimum)
    {
        minimum = zloto[i];
    }
    if (zloto[i] > maksimum)
    {
        maksimum = zloto[i];
        indeksMaksimum = i;
    }
    if (zloto[i] == 0 && indeksZera == -1)
    {
        indeksZera = i;
    }
}

int liczbaMaksimow = 0;
foreach (int z in zloto)
{
    if (z == maksimum)
    {
        liczbaMaksimow++;
    }
}

Console.WriteLine($"Suma: {suma}");
Console.WriteLine($"Minimum: {minimum}");
Console.WriteLine($"Maksimum: {maksimum}");
Console.WriteLine($"Pierwszy najlepszy wynik: tura {indeksMaksimum + 1}");
Console.WriteLine($"Liczba tur z maksimum: {liczbaMaksimow}");
if (indeksZera == -1)
{
    Console.WriteLine("Brak tury bez złota.");
}
else
{
    Console.WriteLine($"Pierwsza tura bez złota: {indeksZera + 1}");
}
