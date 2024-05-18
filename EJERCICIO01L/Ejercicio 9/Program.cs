// #9
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese las palabras separadas por comas: ");
        string input = Console.ReadLine();
        List<string> palabras = input.Split(',').Select(x => x.Trim()).ToList();
        Console.WriteLine("Ingrese la longitud deseada: ");
        int longitud = Convert.ToInt32(Console.ReadLine());
        List<string> longitudPalabras = FindlongitudPalabras(palabras, longitud);

        Console.WriteLine("Palabras de longitud " + longitud + ": " + string.Join(", ", longitudPalabras));
    }

    static List<string> FindlongitudPalabras(List<string> palabras, int longitud)
    {
        return palabras.Where(palabra => palabra.Length == longitud).ToList();
    }
}
