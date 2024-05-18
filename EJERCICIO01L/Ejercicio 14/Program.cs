// #14
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese los números separados por comas: ");
        string input = Console.ReadLine();
        List<int> numer = input.Split(',').Select(x => int.Parse(x.Trim())).ToList();
        List<int> numerosNoDuplicados = FindnumerosNoDuplicados(numer);

        Console.WriteLine("Números no duplicados: " + string.Join(", ", numerosNoDuplicados));
    }

    static List<int> FindnumerosNoDuplicados(List<int> numer)
    {
        return numer.GroupBy(n => n).Where(g => g.Count() == 1).Select(g => g.Key).ToList();
    }
}
