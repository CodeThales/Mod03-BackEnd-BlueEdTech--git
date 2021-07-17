using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoRPG
{
    class Jogo
    {
        Heroi heroi;
        public void Iniciar()
        {
            Console.WriteLine("Escreva seu nome: ");
            heroi = new(Console.ReadLine());
            Menu();
        }

        void Menu()
        {
            Console.Clear();
            MostrarInfo();
            Console.WriteLine("Deseja lutar contra qual monstro?");
            Console.WriteLine("1 - ORC");
            Console.WriteLine("2 - TROLL");
            Console.WriteLine("3 - GOBLIN");
            Console.WriteLine("");
            Console.WriteLine("Digite 0 para sair do jogo");

            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "orc":
                    Lutar(new Monstro("Orc", heroi.Nivel * 2, heroi.Nivel));
                    break;
                case "2":
                case "troll":
                    Lutar(new Monstro("Troll", heroi.Nivel * 5, heroi.Nivel * 2));
                    break;
                case "3":
                case "goblin":
                    Lutar(new Monstro("Goblin", heroi.Nivel * 10, heroi.Nivel * 4));
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            if (heroi.Vida <= 0)
            {
                Console.WriteLine("Você faleceu...");
                return;
            }
            else
            {
                Menu();
            }
        }

        void Lutar(Monstro monstro)
        {
            Console.Clear();
            MostrarInfo();
            Console.WriteLine($"MONSTRO ENCONTRADO: {monstro.Nome}\n" +
                $"Ataque: {monstro.Ataque}\n" +
                $"Vida: {monstro.Vida}\n" +
                $"XP: {monstro.Xp}");
            Console.WriteLine("Digite [ 1 ] para ATACAR ou [ 2 ] para FUGIR:");

            switch (Console.ReadLine().ToLower())
            {
                case "1":
                case "atacar":
                    monstro.Vida -= heroi.Ataque;
                    Console.WriteLine($"\nVocê causou {heroi.Ataque} de dano no {monstro.Nome}!");
                    Random rand = new();
                    if (rand.Next(1, 11) % 2 == 0)
                    {
                        heroi.Vida -= monstro.Ataque;
                        Console.WriteLine($"\nVocê recebeu {monstro.Ataque} de dano do ataque do {monstro.Nome}!");
                    }
                    else
                    {
                        Console.WriteLine($"\nO {monstro.Nome} errou o ataque!");
                    }

                    if (heroi.Vida <= 0)
                    {
                        Console.WriteLine("\nVocê faleceu...");
                        return;
                    }
                    if (monstro.Vida <= 0)
                    {
                        Console.WriteLine($"\nVocê derrotou o {monstro.Nome} e ganhou {monstro.Xp} de xp!");
                        heroi.GanhaXp(monstro.Xp);
                        return;
                    }
                    break;
                case "2":
                case "fugir":
                    Console.WriteLine("\nVocê é um covarde e fugiu da batalha!");
                    return;
            }
            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Lutar(monstro);
        }

        void MostrarInfo()
        {
            Console.WriteLine($"Olá {heroi.Nome}");
            Console.WriteLine($"Sua vida é: {heroi.Vida}");
            Console.WriteLine($"Seu nível é: {heroi.Nivel}");
            Console.WriteLine($"Seu ataque é: {heroi.Ataque}");
            Console.WriteLine($"Sua experiência é: {heroi.Xp}");            
            Console.WriteLine($"Seu ataque base é: {heroi.AtaqueBase}");           
            Console.WriteLine("");
        }

    }
}
