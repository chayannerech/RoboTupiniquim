namespace Robô_Tupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Olá. Eu sou Chayanne, sua assistente de navegação.\nVocê está controlando a versão 2.0 do Robô Tupiniquim :)\n\nPor favor, informe os limites de movimentação em coordenadas, as posições iniciais e os comandos de movimento");
                string[] limites = Console.ReadLine().Split(' ');
                int xLim = int.Parse(limites[0]), yLim = int.Parse(limites[1]), x = 0, y = 0, Dir = 0, x2 = 0, y2 = 0, Dir2 = 0;
                string N = "", N2 = "";

                EntradaDeDados(xLim, yLim, ref x, ref y, ref Dir, ref N);
                EntradaDeDados(xLim, yLim, ref x2, ref y2, ref Dir2, ref N2);

                Console.WriteLine($"\nAs novas posições do robô são: \n{x} {y} {N}\n{x2} {y2} {N2}");
                if (DeveContinuar()) break;
            }
        }
        static void Instrucoes(ref int Dir, ref int x, ref int y, int xLim, int yLim, ref string N)
        {
            string repetir = "não";

            do
            {
                char[] instrucoes = Console.ReadLine().ToCharArray();
                repetir = "não";

                for (int i = 0; i < instrucoes.Length; i++)
                {
                    if (instrucoes[i] == 'D') Dir++;
                    if (instrucoes[i] == 'E') Dir--;
                    if (instrucoes[i] == 'M') Mover(ref Dir, ref x, ref y, xLim, yLim, ref repetir);
                }

                if (Dir % 4 == 0) N = "N";
                if (Dir % 4 == 1 || Dir % 4 == -3) N = "L";
                if (Dir % 4 == 2 || Dir % 4 == -2) N = "S";
                if (Dir % 4 == 3 || Dir % 4 == -1) N = "O";
            }
            while (repetir == "sim");
        }
        static void Mover(ref int Dir, ref int x, ref int y, int xLim, int yLim, ref string repetir)
        {
            int A = x, B = y;

            if (Dir % 4 == 0) B++;
            if (Dir % 4 == 1 || Dir % 4 == -3) A++;
            if (Dir % 4 == 2 || Dir % 4 == -2) B--;
            if (Dir % 4 == 3 || Dir % 4 == -1) A--;
            if (B > yLim || A > xLim)
            {
                repetir = "sim";
                Console.WriteLine("Ultrapassa os limites. Tente novamente:\n");
            }
            else
            {
                x = A;
                y = B;
            }
        }
        static int Direcao(string N)
        {
            int Dir = 0;

            if (N == "N") Dir = 0;
            if (N == "S") Dir = 2;
            if (N == "L") Dir = 1;
            if (N == "O") Dir = 3;

            return Dir;
        }
        static bool DeveContinuar()
        {
            Console.WriteLine("\nDeseja continuar? [S/N]");
            string continuar = Console.ReadLine();
            return continuar == "N" || continuar == "n";
        }
        static void EntradaDeDados(int xLim, int yLim, ref int x, ref int y, ref int Dir, ref string N)
        {
            string[] posicao = Console.ReadLine().Split(' ');
            N = (posicao[2]);
            x = int.Parse(posicao[0]);
            y = int.Parse(posicao[1]);
            Dir = Direcao(N);
            Instrucoes(ref Dir, ref x, ref y, xLim, yLim, ref N);
        }
    }
}
