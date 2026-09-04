using tabuleiro;

namespace projeto
{
    class Tela
    {
        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    System.Console.Write(tab.peca(i,j) == null ? "- " : tab.peca(i,j) + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}