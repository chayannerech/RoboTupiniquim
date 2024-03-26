namespace Robô_Tupiniquim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Olá. Eu sou Chayanne, sua assistente de navegação.\nVocê está controlando a versão 1.0 do Robô Tupiniquim :)\n\nPor favor, informe a posição inicial do robô => utilize este formato: (x,y)N");
                string[] posicao = Console.ReadLine().Split('(' , ',' , ')');
                
                int x = int.Parse(posicao[1]), y = int.Parse(posicao[2]);
                string N = (posicao[3]);
                int Dir = Direcao(N);

                Instrucoes(ref Dir, ref x, ref y, ref N);

                Console.WriteLine($"\nA nova posição do robô é ({x},{y}){N}");
                if (DeveContinuar()) break;
            }
        }
        static void Instrucoes(ref int Dir,ref int x,ref int y, ref string N)
        {
            Console.WriteLine("\nÓtimo! Agora, por favor, informe a sequência de instruções para a movimentação do robô (separadas por espaços):");
            string[] instrucoes = Console.ReadLine().Split(' ');

            for (int i = 0; i < instrucoes.Length; i++)
            {
                if (instrucoes[i] == "D") Dir++;
                if (instrucoes[i] == "E") Dir--;
                if (instrucoes[i] == "M") Mover(ref Dir, ref x, ref y);
            }

            if (Dir % 4 == 0) N = "N";
            if (Dir % 4 == 1 || Dir % 4 == -3) N = "L";
            if (Dir % 4 == 2 || Dir % 4 == -2) N = "S";
            if (Dir % 4 == 3 || Dir % 4 == -1) N = "O";
        }        
        static void Mover(ref int Dir, ref int x, ref int y)
        {
            if (Dir % 4 == 0) y++;
            if (Dir % 4 == 1 || Dir % 4 == -3) x++;
            if (Dir % 4 == 2 || Dir % 4 == -2) y--;
            if (Dir % 4 == 3 || Dir % 4 == -1) x--;
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
    }
}
