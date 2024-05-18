// #17
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese las palabras separadas por comas: ");
        string input = Console.ReadLine();
        List<string> palabras1 = input.Split(',').Select(x => x.Trim()).ToList();
        Console.WriteLine("Ingrese la longitud deseada: ");
        int longitud1 = int.Parse(Console.ReadLine());
        List<string> palabrasLongitudFija1 = FindPalabrasLongitudFija(palabras1, longitud1);

        Console.WriteLine("Palabras con longitud " + longitud1 + " ordenadas: " + string.Join(", ", palabrasLongitudFija1));
    }

    static List<string> FindPalabrasLongitudFija(List<string> palabras1, int longitud1)
    {
        return palabras1.Where(palabra => palabra.Length == longitud1).OrderBy(palabra => palabra).ToList();
    }
}
