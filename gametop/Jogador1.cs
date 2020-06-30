namespace gametop
{
    public class Jogador1 : iJogador
    {

        private readonly string _Nome;

        public Jogador1(string nome = "Ronaldo")
        {
            _Nome = nome;
        }

        public string Chuta()
        {
            return $"{_Nome} está chutando!";
        }

        public string Corre()
        {
            return $"{_Nome} está correndo!";
        }

        public string Passa()
        {
            return $"{_Nome} está passando!";
        }
    }
}