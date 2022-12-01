

using Genericos.Clases;

Console.WriteLine("GENÉRICOS Y COLECCIONES\n");

/* Genéricos y sus restricciones */
int[] numeros = { 1, 2, 3 };
string[] nombres = { "Fernando", "María", "Marisol", "Luis" };
DateTime[] fechas = { DateTime.Today, DateTime.Today.AddDays(1) };

var utilidades = new Utilidades<string>();

Console.WriteLine($"Longitud de arreglo de numeros: { longitudArreglo(numeros) }");
Console.WriteLine($"Longitud de arreglo de nombres: { longitudArreglo(nombres) }");
Console.WriteLine($"Longitud de arreglo de fechas: { longitudArreglo(fechas) } \n");

Console.WriteLine($"Primer elemento de numeros: { primerElementoOPorDefecto(numeros) }");
Console.WriteLine($"Primer elemento de nombres: { primerElementoOPorDefecto(nombres) }");
Console.WriteLine($"Primer elemento de fechas: { primerElementoOPorDefecto(fechas) } \n");

int longitudArreglo<T>(T[] arreglo) where T: notnull {
    return arreglo.Length;
}

T? primerElementoOPorDefecto<T>(T[] arreglo) {
    if (arreglo.Length == 0) {
        return default;
    }

    return arreglo[0];
}

/* Colecciones - Listado */
List<int> enterosList = new List<int>();
enterosList.Add(0);
enterosList.Add(4);
enterosList.Add(8);

var enterosList2 = new List<int> { 3, 2, 5, -6 };
enterosList2.Add(-1);

enterosList2.Sort();
enterosList2.RemoveAt(1);

foreach (var value in enterosList2) {
    Console.WriteLine($"Valor: { value }");
}

Console.WriteLine();

/* Diccionarios */
var diccionario = new Dictionary<string, List<int>>();
diccionario.Add("Par", new List<int>());    
diccionario.Add("Impar", new List<int>());

for (int i = 0; i <= 10; i++) {
    var key = i % 2 == 0 ? "Par" : "Impar";
    diccionario[key].Add(i);
}

foreach (var items in diccionario){
    Console.WriteLine($"Key: { items.Key }");
    foreach (var value in items.Value){
        Console.WriteLine($"Value: { value }");
    }
}

/* IEnumerable */
var num = new List<int> { 3, 4, 5 };
string[] nombresCompletos = { "Fer Santi", "María Dae" };

Console.WriteLine();
imprimirConsola(num);
imprimirConsola(nombresCompletos);

void imprimirConsola<T>(IEnumerable<T> valores) {
    foreach (var valor in valores) {
        Console.WriteLine(valor);
    }
}

/* Yield y Ejecución Diferida */
var enumerableNumeros = primerosTresNumeros();
var todosNumeros = enumerableNumeros.ToList();

foreach (var valor in todosNumeros) {
    Console.WriteLine(valor);
}

IEnumerable<int> primerosTresNumeros() {
    yield return 1;
    yield return 2;
    yield return 3;
}

