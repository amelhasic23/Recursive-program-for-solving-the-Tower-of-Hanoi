using System;

class Program
{
    static void Hanoj(int n, char izvor, char cilj, char pomocni)
    {
        if (n == 1)
        {
            Console.WriteLine($"Premesti disk 1 sa {izvor} na {cilj}");
            return;
        }

        Hanoj(n - 1, izvor, pomocni, cilj); // Premesti n-1 diskova na pomoćni stub
        Console.WriteLine($"Premesti disk {n} sa {izvor} na {cilj}");
        Hanoj(n - 1, pomocni, cilj, izvor); // Premesti n-1 diskova na cilj
    }

    static void Main()
    {
        Console.Write("Unesite broj diskova: ");
        int brojDiskova = int.Parse(Console.ReadLine());
        Hanoj(brojDiskova, 'A', 'C', 'B'); // Stubovi su A (izvor), C (cilj), B (pomoćni)
    }
}

