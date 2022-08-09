namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------");
            Console.WriteLine("Selecione uma opção: ");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1:
                    Soma();
                    break;
                case 2:
                    Subtracao();
                    break;
                case 3:
                    Divisao();
                    break;
                case 4:
                    Multiplicacao();
                    break;
                case 5:
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void Soma()
        {
            do
            {
                Console.Clear();

                Console.WriteLine("Adição");
                Console.WriteLine("");


                Console.WriteLine("Primeiro Valor: ");
                double v1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Segundo valor: ");
                double v2 = double.Parse(Console.ReadLine());

                Console.WriteLine("");

                double resultado = v1 + v2;
                Console.WriteLine($"O resultado da soma é {resultado}");

                Console.WriteLine("\nPrecione Q para voltar para o menu");
                Console.WriteLine("Ou qualquer tecla para continuar.");
            }
            while (Console.ReadKey().Key != ConsoleKey.Q);

            Menu();
        }

        static void Subtracao()
        {
            do
            {
                Console.Clear();

                Console.WriteLine("Subtração");
                Console.WriteLine("");

                Console.WriteLine("Primeiro Valor: ");
                double v1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Primeiro Segundo: ");
                double v2 = double.Parse(Console.ReadLine());

                Console.WriteLine("");

                double resultado = v1 - v2;
                Console.WriteLine($"O resultado da subtração é {resultado}");

                Console.WriteLine("\nPrecione Q para voltar para o menu");
                Console.WriteLine("Ou qualquer tecla para continuar.");
            } while (Console.ReadKey().Key != ConsoleKey.Q);

            Menu();
        }

        static void Divisao()
        {
            do
            {
                Console.Clear();

                Console.WriteLine("Divisão");
                Console.WriteLine("");

                Console.WriteLine("Primeiro Valor: ");
                double v1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Segundo Valor: ");
                double v2 = double.Parse(Console.ReadLine());

                Console.WriteLine("");

                double resultado = v1 / v2;
                Console.WriteLine($"O resultado da divisão é {resultado}");
                Console.WriteLine("\nPrecione Q para voltar para o menu");
                Console.WriteLine("Ou qualquer tecla para continuar.");
            } while (Console.ReadKey().Key != ConsoleKey.Q);

            Menu();
        }

        static void Multiplicacao()
        {
            do
            {
                Console.Clear();

                Console.WriteLine("Mutiplicação");
                Console.WriteLine("");

                Console.WriteLine("Primeiro Valor: ");
                double v1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Segundo Valor: ");
                double v2 = double.Parse(Console.ReadLine());

                Console.WriteLine("");

                double resultado = v1 * v2;
                Console.WriteLine($"O resultado da mutiplicação é {resultado}");

                Console.WriteLine("\nPrecione Q para voltar para o menu");
                Console.WriteLine("Ou qualquer tecla para continuar.");
            } while (Console.ReadKey().Key != ConsoleKey.Q);

            Menu();
        }
    }
}