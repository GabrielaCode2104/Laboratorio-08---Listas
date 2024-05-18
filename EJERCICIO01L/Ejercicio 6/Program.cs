// #06
class Program
{
    static void Main()
    {
        List<int> set1 = LeerConjunto("Introduce los elementos del primer conjunto (separados por espacios): ");
        List<int> set2 = LeerConjunto("Introduce los elementos del segundo conjunto (separados por espacios): ");

        IEnumerable<int> resul = DiferenciaConjuntos(set2, set1);

        Console.WriteLine("Los números que están en el segundo conjunto pero no en el primero son:");
        foreach (int num in resul) {Console.WriteLine(num);}
    }
    static List<int> LeerConjunto(string mensaje)
    {
        Console.Write(mensaje);
        string[] elem = Console.ReadLine().Split(" ");
        List<int> set = new List<int>();
        foreach (string elemento in elem)
        {
            if (int.TryParse(elemento, out int num))
            {
                set.Add(num);
            }
        }
        return set;
    }
    static IEnumerable<int> DiferenciaConjuntos(IEnumerable<int> set1, IEnumerable<int> set2)
    {
        return set1.Except(set2);
    }
}
