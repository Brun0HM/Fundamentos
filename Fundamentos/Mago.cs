using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Mago : Personagem
    {
        public override void Apresentarse()
        {
            Console.WriteLine("Eu sou o " + this.Nome + " Sou um " + this.Categoria + " de nível " + this.Nivel);


        }
    }
}