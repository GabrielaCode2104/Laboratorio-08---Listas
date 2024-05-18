//2.Escriba una función que reciba un conjunto de palabras y devuelva un conjunto con las palabras que comienzan con una letra determinada. 

class Program
{
    static void Main()
    {
        string[] palabras = {"manzana","plátano","kiwi","mango","naranja","pera","uva" };
        char letra = 'p';
        Console.WriteLine("Lista original de palabras: " + string.Join(", ", palabras));
        Console.WriteLine("Letra predeterminado con el que comienzan: " + letra);
        var empezarConLetra = GetWordsStartingWithLetter(palabras, letra);

        Console.WriteLine("Palabras que inician con la letra predeterminada: " + string.Join(", ", empezarConLetra));
    }

    static IEnumerable<string> GetWordsStartingWithLetter(IEnumerable<string> palabras, char letra)
    {
        return palabras.Where(w => w[0] == letra);
    }
}
