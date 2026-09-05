using tabuleiro;
using xadrez;

namespace projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Amarela), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Amarela), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Amarela), new Posicao(0, 9));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                System.Console.WriteLine(e.Message);
            }

        }
    }
}