// 5.Escriba una función que reciba dos conjuntos de números y devuelva un conjunto con los números que están en el primer conjunto pero no en el segundo. 
class Program
{
    static void Main()
    {
        List<int> conj1 = LeerConjunto("Introduce los elementos del conjunto 01 (separados por espacios): ");
        List<int> conj2 = LeerConjunto("Introduce los elementos del conjunto 02 (separados por espacios): ");

        IEnumerable<int> resultado = DiferenciaConjuntos(conj1, conj2);

        Console.WriteLine("Los números que están en el primer conjunto pero no estan en el segundo son:");
        foreach (int numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }
    static List<int> LeerConjunto(string mensaje)
    {
        Console.Write(mensaje);
        string[] elementos = Console.ReadLine().Split(' ');
        List<int> conjunto = new List<int>();

        foreach (string elemento in elementos)
        {
            if (int.TryParse(elemento, out int numero))
            {
                conjunto.Add(numero);
            }
        }
        return conjunto;
    }
    static IEnumerable<int> DiferenciaConjuntos(IEnumerable<int> conj1, IEnumerable<int> conj2)
    {
        return conj1.Except(conj2);
    }
}