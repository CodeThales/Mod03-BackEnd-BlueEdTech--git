/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSalaDeAula
{
    public class Turma
    {
        public string Nome;
        public int Quant;


        public Turma(string Nome = "", int Quant = 0)
        {
            this.Nome = Nome;
            this.Quant = Quant;
        }

        
        //CADASTRO DA TURMA
        public void NovaTurma()
        {
            Console.WriteLine("Digite o nome da turma: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de alunos da turma: ");
            Quant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"CADASTRO EFETUADO COM SUCESSO! \nNome da Turma: {Nome}\n" +
                $"Número de alunos: {Quant}");
            Console.WriteLine("");                
        }

        //CADASTRO DOS ALUNOS
        public string[] alunos = new string[Quant];
        public double[] notas = new double[Quant];
        public void Cadastrar()
        {
            for (int i = 0; i < Quant; i++)
            {
                Console.WriteLine($"Digite o nome do {i + 1}º aluno: ");
                alunos[i] = Console.ReadLine();

                while (notas[i] < Quant)
                {
                    Console.WriteLine($"Digite a nota de {alunos[i]}: ");
                    double testenota = Convert.ToDouble(Console.ReadLine());
                    if (testenota < 0 || testenota > 10)
                    {
                        Console.WriteLine("Valor inválido! Tente novamente.");
                    }
                    else
                    {
                        notas[i] = testenota;
                    }
                }
            }
        }


        public static void Menu()
        {
            Console.WriteLine("Escolha uma opção:\n" +
            "[1] EXCLUIR ALUNO\n" +
            "[2] LISTAR PELA MAIOR NOTA\n" +
            "[3] LISTAR EM ORDEM ALFABÉTICA\n" +
            "[0] SAIR DO PROGRAMA");

        }

    }         
    
}*/
