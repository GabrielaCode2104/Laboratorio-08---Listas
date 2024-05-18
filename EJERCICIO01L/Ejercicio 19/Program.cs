// #19
class Aplicacion
{
    static void Main()
    {
        Console.WriteLine("Ingrese los números separados por comas: ");
        string entrada = Console.ReadLine();
        List<int> listaDeNumeros = entrada.Split(',').Select(x => int.Parse(x.Trim())).ToList();

        List<int> numerosOrdenados = EliminarDuplicadosOrdenar(listaDeNumeros);

        Console.WriteLine("Números ordenados de menor a mayor sin duplicados: " + string.Join(", ", numerosOrdenados));
    }
    static List<int> EliminarDuplicadosOrdenar(List<int> listaDeNumeros)
    {
        return listaDeNumeros.Distinct().OrderBy(numero => numero).ToList();
    }
}
