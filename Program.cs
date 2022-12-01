﻿

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