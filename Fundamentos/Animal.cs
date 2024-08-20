using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public abstract class Animal
    {
        //declaração de um atributo
        public string Especie { get; set; }
        public string Nome { get; set; }

        //declaração de metedo
        public abstract void emitirSom();
    }
}
