using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos.Clases {
    internal class Persona : IComparable<Persona> {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public int CompareTo(Persona? other) {
            if (other is null) { 
                throw new ArgumentNullException(nameof(other)); 
            }

            return this.Edad - other.Edad;
        }
    }
}
