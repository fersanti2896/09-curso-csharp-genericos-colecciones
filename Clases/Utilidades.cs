using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos.Clases {
    internal class Utilidades<T> {
        internal int longitudArreglo(T[] arreglo) {
            return arreglo.Length;
        }

        internal T? primerElementoOPorDefecto(T[] arreglo) {
            if (arreglo.Length == 0) {
                return default;
            }

            return arreglo[0];
        }
    }
}
