using System;
using System.Linq;

namespace ProjetoSalaDeAula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome da turma: ");
            string NomeTurma = Console.ReadLine();
            Console.WriteLine("Quantos alunos tem na turma? ");
            int QuantAlunos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Turma {NomeTurma}, máximo de {QuantAlunos} alunos, foi criada com sucesso.".ToUpper());
            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            

            Console.WriteLine($"***CADASTRO DOS ALUNOS DA TURMA {NomeTurma.ToUpper()}***");
            Console.WriteLine("");
            string[] ArrayAlunos = new string[QuantAlunos];
            double[] notas = new double[QuantAlunos];
            int[] faltas = new int[QuantAlunos];
            


            for (int i = 0; i < QuantAlunos; i++)
            {
                Console.WriteLine($"Digite o nome do {i + 1}º aluno: ");
                ArrayAlunos[i] = Console.ReadLine();

                //NÃO DEU CERTO A TENTATIVA DE COLOCAR AS FALTAS :´(
                //Console.WriteLine($"Digite a quantidade de faltas de {ArrayAlunos[i]}");
                //faltas[i] = Convert.ToInt32(Console.ReadLine());

                while (notas[i] < QuantAlunos)
                {
                    Console.WriteLine($"Digite a nota de {ArrayAlunos[i]}: ");
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

            Console.WriteLine("");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

            Menu();

            void Menu()
            {
                Console.WriteLine("ESCOLHA UMA OPÇÃO:\n\n" +
                    "[1] EXCLUIR ALUNO\n" +
                    "[2] LISTAR PELA NOTA\n" +
                    "[3] LISTAR EM ORDEM ALFABÉTICA\n" +
                    "[0] SAIR DO PROGRAMA");
                Console.WriteLine("");

                string opc = Console.ReadLine();
                switch (opc)
                {
                    case "1":
                        Array.Sort(ArrayAlunos);
                        Console.WriteLine("QUAL ALUNO VOCÊ DESEJA EXCLUIR? ");
                        for(int i = 0; i < QuantAlunos; i++)
                        {
                            Console.WriteLine($"[{i}] - {ArrayAlunos[i].ToUpper()}");
                        }
                        int Remove = Convert.ToInt32(Console.ReadLine());
                        ArrayAlunos = ArrayAlunos.Where((source, index) => index != Remove).ToArray();
                        notas = notas.Where((source, index) => index != Remove).ToArray();

                        Console.WriteLine($"Aluno excluído com sucesso!");
                        Console.WriteLine("");

                        Console.WriteLine("***LISTA ATUALIZADA***");
                        Console.WriteLine("");
                        foreach (string value in ArrayAlunos)
                        {
                            Console.WriteLine(value);
                        }

                        Console.WriteLine("");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("***CADASTRE UM NOVO ALUNO***");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o nome do novo aluno: ");
                        ArrayAlunos[QuantAlunos+1]= Console.ReadLine();

                        //AINDA NÃO CONSEGUI FAZER A INCLUSÃO DE UM NOVO REGISTRO DEPOIS QUE OUTRO É EXCLUÍDO :´(
                        Console.WriteLine($"Digite a nota do novo aluno");
                        double testenota = Convert.ToDouble(Console.ReadLine());
                        if (testenota < 0 || testenota > 10)
                        {
                            Console.WriteLine("Valor inválido! Tente novamente.");
                        }
                        else
                        {
                            notas[QuantAlunos+1] = testenota;
                        }

                        Console.WriteLine("");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "2":
                        Console.WriteLine("LISTANDO ALUNOS PELA NOTA:");
                        Console.WriteLine("");
                        Array.Sort(notas, ArrayAlunos);
                        for (int i = 0; i < QuantAlunos; i++)
                        {
                            if (notas[i] > 7 && faltas[i] < 4)
                            {
                                Console.WriteLine($"Alun@ {ArrayAlunos[i]}. Nota: {notas[i]}: APROVAD@!");
                            }
                            else
                            {
                                Console.WriteLine($"Alun@ {ArrayAlunos[i]}. Nota: {notas[i]}: REPROVAD@!");
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("LISTANDO ALUNOS EM ORDEM ALFABÉTICA");
                        Console.WriteLine("");
                        Array.Sort(ArrayAlunos, notas);
                        for (int i = 0; i < QuantAlunos; i++)
                        {
                            if (notas[i] > 7)
                            {
                                Console.WriteLine($"Alun@ {ArrayAlunos[i]}. Nota: {notas[i]}: APROVAD@!");
                            }
                            else
                            {
                                Console.WriteLine($"Alun@ {ArrayAlunos[i]}. Nota: {notas[i]}: REPROVAD@!");
                            }
                        }
                        break;

                    case "0":
                        Console.WriteLine("Saido do programa...");
                        return;

                    default:
                        Console.WriteLine("OPÇÃO INVÁLIDA!");
                        Console.WriteLine("");
                        break;
                }
                
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
        }
    }
}
