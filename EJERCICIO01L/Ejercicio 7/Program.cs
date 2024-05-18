// #7
class Program
{
    static void Main()
    {
        List<string> palabras = new List<string>() { "fresa", "frase", "panel", "nepal", "japonés", "esponja", "Perla", "Pelar" };
        List<List<string>> anagramas = FindAnagramas(palabras);

        foreach (var anagrama in anagramas)
        {
            Console.WriteLine("Anagramas: " + string.Join(", ", anagrama));
        }
    }
    static List<List<string>> FindAnagramas(List<string> palabras)
    {
        Dictionary<string, List<string>> anagramas = new Dictionary<string, List<string>>();

        foreach (string palabra in palabras)
        {
            string palabraOrden = new string(palabra.OrderBy(c => c).ToArray());
            if (!anagramas.ContainsKey(palabraOrden))
            {
                anagramas[palabraOrden] = new List<string>();
            }
            anagramas[palabraOrden].Add(palabra);
        }
        return anagramas.Values.ToList();
    }
}