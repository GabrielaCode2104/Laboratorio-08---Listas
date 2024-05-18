// 4.Escriba una función que reciba dos conjuntos de números
// y devuelva un conjunto con los números que están en ambos conjuntos. 
class Program
{
    static void Main()
    {
        int[] conjunto1 = { 11, 3, 54, 20, 24 ,23 ,26 };
        int[] conjunto2 = { 11, 5, 20, 70, 8, 3, 24, 4 };

        var interseccionNumeros = GetCommonNumbers(conjunto1, conjunto2);

        Console.WriteLine("Conjunto 1: " + string.Join(", ", conjunto1));
        Console.WriteLine("Conjunto 2: " + string.Join(", ", conjunto2));
        Console.WriteLine("Intersección: " + string.Join(", ", interseccionNumeros));
    }

    static IEnumerable<int> GetCommonNumbers(IEnumerable<int> conjunto1, IEnumerable<int> conjunto2)
    {
        return conjunto1.Intersect(conjunto2);
    }
}
