
namespace gametop
{
    class Jogo
    {

        private readonly iJogador _JogadorA;
        private readonly iJogador _JogadorB;
        public Jogo(iJogador jogadorA, iJogador jogadorB)
        {
            _JogadorA = jogadorA;
            _JogadorB = jogadorB;
        }
        public void IniciarJogo()
        {
            System.Console.WriteLine(_JogadorA.Corre());
            System.Console.WriteLine(_JogadorA.Passa());
            System.Console.WriteLine(_JogadorA.Chuta());

            System.Console.WriteLine("\n -------------------------------------- \n");

            System.Console.WriteLine(_JogadorB.Corre());
            System.Console.WriteLine(_JogadorB.Passa());
            System.Console.WriteLine(_JogadorB.Chuta());
        }

    }

}