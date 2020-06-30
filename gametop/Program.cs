using System;

namespace gametop
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Jogo(new Jogador1(), new Jogador2());
            jogo.IniciarJogo();
        }
    }
}
