// #8
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese las palabras separadas por comas:");
        string input = Console.ReadLine();
        List<string> palabras = input.Split(',').Select(x => x.Trim()).ToList();
        List<string> palindromos = FindPalindromos(palabras);

        Console.WriteLine("Palíndromos: " + string.Join(", ", palindromos));
    }

    static List<string> FindPalindromos(List<string> palabras)
    {
        return palabras.Where(IsPalindromo).ToList();
    }

    static bool IsPalindromo(string palabra)
    {
        string palabraInvertida = new string(palabra.Reverse().ToArray());
        return palabra.Equals(palabraInvertida, StringComparison.OrdinalIgnoreCase);
    }
}