public class Calculadora
{
    public int SomarNumeros(params IEnumerable<int> numeros)
    {
        int total = 0;
        foreach (var numero in numeros.SelectMany(c => c))
        {
            total += numero;
        }
        return total;
    }
}

// Exemplos de chamada do método
var calc = new Calculadora();

// Passando argumentos separados por vírgula
int resultado1 = calc.SomarNumeros(1, 2, 3); // resultará em 6

// Passando uma lista
var listaDeNumeros = new List<int> { 10, 20, 30 };
int resultado2 = calc.SomarNumeros(listaDeNumeros); // resultará em 60

// Passando um array
int[] arrayDeNumeros = { 5, 15 };
int resultado3 = calc.SomarNumeros(arrayDeNumeros); // resultará em 20