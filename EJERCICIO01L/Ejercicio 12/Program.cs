// #12
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese los números separados por comas: ");
        string input = Console.ReadLine();
        List<int> numeros = input.Split(',').Select(x => int.Parse(x.Trim())).ToList();
        List<int> ordenNumeros = FindOrdenNumeros(numeros);

        Console.WriteLine("Números ordenados: " + string.Join(", ", ordenNumeros));
    }

    static List<int> FindOrdenNumeros(List<int> numeros)
    {
        return numeros.OrderByDescending(n => n).ToList();
    }
}
