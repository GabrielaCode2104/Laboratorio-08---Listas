// #13
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese los números separados por comas: ");
        string input = Console.ReadLine();
        List<int> num = input.Split(',').Select(x => int.Parse(x.Trim())).ToList();
        List<int> numerosDuplicados = FindnumerosDuplicados(num);

        Console.WriteLine("Números duplicados: " + string.Join(", ", numerosDuplicados));
    }

    static List<int> FindnumerosDuplicados(List<int> num)
    {
        return num.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
    }
}
