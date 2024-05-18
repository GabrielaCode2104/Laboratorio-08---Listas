// #20
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese las palabras separadas por comas: ");
        string input = Console.ReadLine();
        List<string> palabras = input.Split(',').Select(x => x.Trim()).ToList();
        Console.WriteLine("Ingrese la longitud deseada: ");
        int longitud = Convert.ToInt32(Console.ReadLine());
        List<string> palabrasFiltradas = FindPalindromosLongitud(palabras, longitud);

        Console.WriteLine("Palabras palíndromos de longitud " + longitud + " ordenadas de menor a mayor: " + 
            string.Join(", ", palabrasFiltradas));
    }

    static List<string> FindPalindromosLongitud(List<string> palabras, int longitud)
    {
        return palabras.Where(palabra => palabra.Length == longitud && palabra == 
        new string(palabra.Reverse().ToArray())).OrderBy(palabra => palabra).ToList();
    }
}
