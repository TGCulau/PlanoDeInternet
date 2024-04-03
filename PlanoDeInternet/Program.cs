namespace PlanoDeInternet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int meses, int mb) = Input();
            int sobramb = Equacao(meses, mb);
            Resultado(sobramb);
        }
        static int LerInt()
        {
            while (true)
            {
                var digitouNumero = int.TryParse(Console.ReadLine(), out var numero);

                if (digitouNumero)
                {
                    return numero;
                }

                Console.Write("\nPor favor digite um numero.\n\nPrecione qualquer tecla para continuar.");
                Console.ReadLine();
            }
        }
        static (int, int) Input()
        {
            int mb = 0, meses = 0;
            while (true)
            {
                mb = LerInt();
                if (mb <= 0 || mb > 100)
                {
                    Console.WriteLine("Comando invalido. Tente novamente. Precione qualquer tecla para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                meses = LerInt();
                if (meses <= 0 || meses > 100)
                {
                    Console.WriteLine("Comando invalido. Tente novamente. Precione qualquer tecla para continuar");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }
                break;
            }
            return (meses, mb);
        }
        static int Equacao(int meses, int mb)
        {
            int proximomes = mb, sobramb = 0;
            
            while (meses > 0)
            {
                meses--;
                int consumo = LerInt();
                sobramb = (proximomes - consumo);
                proximomes = mb + sobramb;
            }

            return proximomes;
        }
        static void Resultado(int proximomes)
        {
            Console.Clear();
            Console.Write(proximomes);
            Console.ReadLine();
        }
    }
}
