// #18
class Programa
{
    static void Main()
    {
        Console.WriteLine("Ingrese las palabras separadas por comas: ");
        string entrada = Console.ReadLine();
        List<string> listaDePalabras = entrada.Split(',').Select(x => x.Trim()).ToList();
        Console.WriteLine("Ingrese la letra deseada: ");
        char caracter = Convert.ToChar(Console.ReadLine());

        List<string> palabrasFiltradas = EncontrarPalabrasConLetra(listaDePalabras, caracter);

        Console.WriteLine("Palabras con la letra " + caracter + " ordenadas de mayor a menor: " 
        + string.Join(", ", palabrasFiltradas));
    }
    static List<string> EncontrarPalabrasConLetra(List<string> listaDePalabras, char caracter)
    {
        return listaDePalabras.Where(palabra => palabra.Contains(caracter)).OrderByDescending(palabra => palabra.Length).ToList();
    }
}
