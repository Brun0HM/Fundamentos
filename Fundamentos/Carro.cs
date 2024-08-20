using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Carro
    {
        //Atributos
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }
        // Metodos
        public void Acelerar()
        {
            this.Velocidade += 5;
            Console.WriteLine("A velocidade atual é " + this.Velocidade + " Km/h");
        }
        public void Desacelerar()
        {
            if (this.Velocidade <= 0)
                Console.WriteLine("O carro já está parado");
            else
            {
                this.Velocidade -= 5;
                Console.WriteLine("A velocidade atual é " + this.Velocidade + " Km/h");
            }
        }
    }
}