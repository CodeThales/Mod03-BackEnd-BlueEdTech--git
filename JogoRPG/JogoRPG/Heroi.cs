using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    class Heroi // Definição da classe
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Nivel { get; set; }
        public int Ataque { get; set; }
        public int Xp { get; set; }
        public int AtaqueBase { get; set; }
        
        
        public Heroi(string nome) //Construtor da Classe
        {
            Random aleatorio = new Random();
            this.Nome = nome;
            this.Vida = 10;
            this.Nivel = 1;
            this.Ataque = AtaqueBase + Nivel;
            this.Xp = 0;
            this.AtaqueBase = aleatorio.Next(1, 11);           
        }

        public void GanhaXp(int experiencia)
        {
            Xp += experiencia;
            int novo_nivel = (Xp / 10) + 1;
            if (novo_nivel > Nivel)
            {
                Console.WriteLine("\nVocê aumentou de nível!");
                Vida = novo_nivel * 10;
            }
            Nivel = novo_nivel;
            Ataque = AtaqueBase + Nivel;
        }
    }
}
