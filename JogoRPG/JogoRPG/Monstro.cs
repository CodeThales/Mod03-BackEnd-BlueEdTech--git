using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    class Monstro
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Xp { get; set; }

        public Monstro(string nome, int vida, int ataque)
        {
            this.Nome = nome;
            this.Vida = vida;
            this.Ataque = ataque;
            this.Xp = Vida + Ataque;
        }
    }
}
