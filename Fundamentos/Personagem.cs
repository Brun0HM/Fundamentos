using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentos
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Nivel { get; set; }
        public int Forca { get; set; }
        public int Agilidade { get; set; }
        public int Inteligencia { get; set; }
        public int Vida { get; set; }

        public virtual void Apresentarse() { }
        public void Evolui()
        {
            Console.WriteLine("Você subiu" + (this.Nivel += 1) + " Níveis. Você tem pontos para evoluir seu" + this.Categoria);
        }

        public virtual int GetVida()
        {
            return Vida;
        }

        public int Defender()
        {
            int Defesa = 0;
            int def = (this.Forca + this.Agilidade + this.Inteligencia) / 4;
            return Defesa;
        }

        public int Atacar()
        {
            {
                int Dano = 0;
                Dano = (this.Forca + this.Agilidade + this.Inteligencia) / 2;
                return Dano;

            }
        }

        public virtual void batalhar(Personagem p)
        {
            bool vencedor = false;
            while (vencedor == false)
            {
                int valorAtaque = this.Atacar();
                int valorDefesaInimigo = p.Defender();
                int danoDeVida = valorAtaque - valorDefesaInimigo;
                if (danoDeVida <= 0)
                {
                    danoDeVida = 1;
                }
                p.Vida = p.Vida - danoDeVida;
                Console.WriteLine("Dano na Vida do Inimigo em " + danoDeVida);
                Console.WriteLine("O nível de vida do Inimigo agora é " + p.Vida);

                int valorAtaqueInimigo = p.Atacar();
                int valorDefesa = this.Defender();
                int danoDeVida2 = valorAtaqueInimigo - valorDefesa;
                if (danoDeVida2 <= 0)
                {
                    danoDeVida2 = 1;
                }
                this.Vida = this.Vida - danoDeVida2;
                Console.WriteLine("Dano na Vida do Atacante em " + danoDeVida2);
                Console.WriteLine("O nível de vida do Atacante agora é " + this.Vida);

                Console.WriteLine("==================================");

                if (this.Vida <= 0)
                {
                    Console.WriteLine("O perssonagem " + p.Nome + " Venceu!");
                    vencedor = true;
                    p.Nivel += 1;
                    Console.WriteLine(p.Nome + " Subiu para o nível " + p.Nivel);

                }

                if (p.Vida <= 0)
                {
                    Console.WriteLine("O perssonagem" + this.Nome + " Venceu!");
                    vencedor = true;
                    this.Nivel += 1;
                    Console.WriteLine(this.Nome + " Subiu para o nível " + this.Nivel);
                }
            }
        }
    }
}
