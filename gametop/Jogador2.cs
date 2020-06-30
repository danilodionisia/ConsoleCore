namespace gametop
{
    public class Jogador2 : iJogador
    {

        private readonly string _Nome;

        public Jogador2(string nome = "Maradona")
        {
            _Nome = nome;
        }

        public string Chuta()
        {
            return $"{_Nome} estás pateando!";
        }

        public string Corre()
        {
            return $"{_Nome} estás corriendo!";
        }

        public string Passa()
        {
            return $"{_Nome} estás pasando!";
        }
    }
}