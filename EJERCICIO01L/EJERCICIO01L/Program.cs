// 1.Escriba una función que reciba un conjunto de números y devuelva un conjunto con los números primos. 
class Program
{
    static void Main()
    {
        int[] numeros = { 1, 5, 4, 3, 23, 21, 20, 19, 18, 17, 16, 8, 0, 31, 6 };
        var numeroPrimo = GetPrimeNumbers(numeros);
        Console.WriteLine("Números primos: " + string.Join(" ", numeroPrimo));
    }
    static IEnumerable<int> GetPrimeNumbers(IEnumerable<int> numeros)
    {
        return numeros.Where(n => IsPrime(n));
    }
    static bool IsPrime(int numero)
    {
        if (numero <= 1) return false;
        if (numero == 2) return true;
        if (numero % 2 == 0) return false;
        var limite = (int)Math.Sqrt(numero);
        for (int i = 3; i <= limite; i += 2)
        {
            if (numero % i == 0)
                return false;
        }
        return true;
    } 
}

