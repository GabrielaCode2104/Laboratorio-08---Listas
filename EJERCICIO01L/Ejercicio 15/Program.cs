// #15 
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese los números separados por comas: ");
        string input = Console.ReadLine();
        List<int> numeros = input.Split(',').Select(x => int.Parse(x.Trim())).ToList();
        List<int> numerosPrimos = EncontrarNumerosPrimos(numeros);
        List<int> numerosPrimosOrdenados = numerosPrimos.OrderBy(n => n).ToList();

        Console.WriteLine("Números primos ordenados: " + string.Join(", ", numerosPrimosOrdenados));
    }

    static List<int> EncontrarNumerosPrimos(List<int> numeros)
    {
        return numeros.Where(n => IsPrime(n)).ToList();
    }

    static bool IsPrime(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;

        for (int i = 3; i * i <= numero; i += 2)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }
}
