using Operacao;
using System;
using static Operacao.OperacaoMatematica;
using System.Globalization;


namespace Calculadora
{
    public class Program
    {
        static OperacaoMatematica op = new OperacaoMatematica();
        public static void Main(string[] args)
        {
            bool continuar = true;
            while (continuar)
            {
                
                Console.WriteLine("\nBem vindo a calculadora!");
                Console.WriteLine("Escolha uma operação:");

                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");

                Console.WriteLine("5 - Sair");
  
                try
                {
                    int opcao = Convert.ToInt32(Console.ReadLine());
                    if (opcao == 5)
                    {
                        Console.WriteLine("Saindo da calculadora...");
                        Console.WriteLine("Obrigado por usar a Calculadora do Ícaro");
                        return;
                    }

                    if (opcao < 1 || opcao > 4)
                    {
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        continue;
                    }


                    Console.Write("Digite o Primeiro Numero: ");
                    string entradaA = Console.ReadLine().Replace(',', '.');
                    var a = double.Parse(entradaA, CultureInfo.InvariantCulture);

                    
                    Console.Write("Digite o Segundo Numero: ");
                    string entradaB = Console.ReadLine().Replace(',', '.');
                    var b = double.Parse(entradaB, CultureInfo.InvariantCulture);


                    double resultado = 0;
                    string operacao = "";

                    switch (opcao)
                    {
                        case 1:
                            resultado = Soma.calcular(a, b);
                            operacao = "Soma";
                            break;
                        case 2:
                            resultado = Subtracao.calcular(a, b);
                            operacao = "Subtração";
                            break;
                        case 3:
                            resultado = Multiplicacao.calcular(a, b);
                            operacao = "Multiplicação";
                            break;
                        case 4:
                            resultado = Divisao.calcular(a, b);
                            operacao = "Divisão";
                            break;

                    }

                    Console.WriteLine($"Resultado da {operacao}: {resultado}");
                    Console.WriteLine("Deseja realizar outra operação? (s/n)");

                    string sair = Console.ReadLine().ToLower();

                    if (sair == "sim" || sair == "não" || sair == "nao")
                    {
                        continuar = false;
                        Console.WriteLine("Saindo da calculadora...");
                    }
                    else if (sair != "s" && sair != "sim")
                    {
                        Console.WriteLine("Opção inválida.");
                    }


                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número válido.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                }
                


            }

        }
    }






}
