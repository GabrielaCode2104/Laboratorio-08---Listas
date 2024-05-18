// #11
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese los números separados por comas: ");
        string input = Console.ReadLine();
        List<int> num = input.Split(',').Select(x => int.Parse(x.Trim())).ToList();
        List<int> ordenNum = FindOrdenNum(num);

        Console.WriteLine("Números ordenados: " + string.Join(", ", ordenNum));
    }

    static List<int> FindOrdenNum(List<int> num)
    {
        return num.OrderBy(n => n).ToList();
    }
}
