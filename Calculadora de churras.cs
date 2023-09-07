namespace Calculadora_de_churrasco
{
    internal class Program
    {
        static decimal totalc;
        static decimal totalb;
        static int quantidadep;
        static int quantidadec;
        static int quantidadeb;
        static decimal[] precoc = new decimal[10];
        static string[] nomec = new string[10];
        static decimal[] precob = new decimal[10];
        static string[] nomeb = new string[10];
        static void Main(string[] args)
        {

            int opcao = 0;

            while (opcao != 3)
            {
                Console.Clear();
                Console.WriteLine("Bem-Vindo, o que deseja fazer?");
                Console.WriteLine("1 - Cadastrar carnes");
                Console.WriteLine("2 - Cadastrar bebidas");
                Console.WriteLine("3 - Calcular valor por pessoa");
                Console.WriteLine("4 - Sair");
                opcao = Convert.ToInt32(Console.ReadLine()!);
                Console.Clear();

                switch (opcao)
                {
                    case 1:

                        Cadastrarc();

                        break;

                    case 2:

                        Cadastrarb();

                        break;

                    case 3:

                        CalculoPessoas();

                        break;

                    case 4:

                        Sair();

                        break;
                }
            }


        }

        public static void Cadastrarc()
        {
            Console.Clear();
            Console.WriteLine("Quantas carnes você deseja cadastrar? (MÁX 10)");
            quantidadec = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < quantidadec; i++)
            {
                Console.WriteLine($"Escreva o nome da {i + 1}° carne");
                nomec[i] = Console.ReadLine()!;
                Console.WriteLine($"Escreva o preço do(a) {nomec[i]}:");
                precoc[i] = Convert.ToDecimal(Console.ReadLine())!;
                totalc = precoc[0] + precoc[1] + precoc[2] + precoc[3] + precoc[4] + precoc[5] + precoc[6] + precoc[7] + precoc[8] + precoc[9];
            }
            Console.WriteLine($"Valor total armazenado!: R$:{totalc}");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções:");
            Console.ReadKey();

        }

        public static void Cadastrarb()
        {
            Console.Clear();
            Console.WriteLine("Quantas bebidas você deseja cadastrar? (MÁX 10)");
            quantidadeb = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < quantidadeb; i++)
            {
                Console.WriteLine($"Escreva o nome da {i + 1}° bebida");
                nomeb[i] = Console.ReadLine()!;
                Console.WriteLine($"Escreva o preço do(a) {nomeb[i]}:");
                precob[i] = Convert.ToDecimal(Console.ReadLine())!;
                totalb = precob[0] + precob[1] + precob[2] + precob[3] + precob[4] + precob[5] + precob[6] + precob[7] + precob[8] + precob[9];
            }
            Console.WriteLine($"Valor total armazenado!: R$:{totalb}");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções:");
            Console.ReadKey();

        }
        public static void CalculoPessoas()
        {
            Console.Clear();
            Console.WriteLine("Quantas pessoas irão ao churrasco?");
            quantidadep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O valor total para {quantidadep} pessoas é:");
            Console.WriteLine($"R$:{totalb + totalc / quantidadep}");

        }

        public static void Sair() 
        {
            Console.Clear();
            Console.WriteLine("Obrigado por usar á calculadora! Até mais!");
        
        }
    }
}