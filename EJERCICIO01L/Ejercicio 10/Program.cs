// #10
class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese las palabras separadas por comas: ");
        string input = Console.ReadLine();
        List<string> palabras = input.Split(',').Select(x => x.Trim()).ToList();
        Console.WriteLine("Ingrese la letra deseada: ");
        char letra = Convert.ToChar(Console.ReadLine());
        List<string> palabrasConLetra = FindpalabrasConLetra(palabras, letra);

        Console.WriteLine("Palabras que contienen la letra " + letra + ": " + string.Join(", ", palabrasConLetra));
    }

    static List<string> FindpalabrasConLetra(List<string> palabras, char letra)
    {
        return palabras.Where(word => word.Contains(letra)).ToList();
    }
}
