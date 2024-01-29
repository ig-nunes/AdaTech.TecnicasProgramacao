namespace Exercicio3
{
    public class Jogador
    {
        public string Nome {  get; private set; }

        public Jogador(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return this.Nome;
        }

    }
}