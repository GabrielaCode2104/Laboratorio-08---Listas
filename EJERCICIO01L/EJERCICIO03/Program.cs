//3. 3.	Escriba una función que reciba un conjunto de números y
//devuelva un conjunto con los números que son divisibles por un número determinado. 

class Program
{
    static void Main()
    {
        int[] numeros1 = { 6,33,8,9,12,15,16,27,29,30,10,34,37,89,46,76,66 };
        int divisor = 3;
        Console.WriteLine("Lista original de números: " + string.Join(" ", numeros1));
        Console.WriteLine("Número predeterminado (divisor): " + divisor);

        var divisibleNumero = GetNumbersDivisibleByNumber(numeros1, divisor);
        Console.WriteLine("Los número divisibles por el número predeterminado son: " + string.Join(" ", divisibleNumero));
    }

    static IEnumerable<int> GetNumbersDivisibleByNumber(IEnumerable<int> numeros1, int divisor)
    {
        return numeros1.Where(n => n % divisor == 0);
    }
}

