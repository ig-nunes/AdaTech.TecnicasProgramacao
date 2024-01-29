
namespace Exercicio3
{
    public class BatataQuente
    {
        public Queue<Jogador> filaJogadores;

        public BatataQuente() 
        {
             filaJogadores = new Queue<Jogador>();    
        }

        public void CriarFila(List<string> nomes)
        {
            Jogador jogador;
            for (int i = 0; i < nomes.Count; i++)
            {
                jogador = CriarJogador(nomes[i]);
                filaJogadores.Enqueue(jogador);
            }
        }

        private Jogador CriarJogador(string nome)
        {
            return new Jogador(nome);
        }

        public Jogador SimularRodada()
        {
            Random random = new Random();
            int passesAteExplodir = random.Next(1, 101);

            for (int passe = 1; passe <= passesAteExplodir; passe++)
            {
                var jogadorAtual = filaJogadores.Dequeue();
                filaJogadores.Enqueue(jogadorAtual);
            }

            var jogadorEliminado = filaJogadores.Dequeue();
            return jogadorEliminado;
        }

        public Jogador ReceberVencedor()
        {
            if (filaJogadores.Count != 1)
            {
                throw new Exception("Ocorreu algum erro interno!");
            }
            
            var jogador = filaJogadores.Dequeue();
           
            return jogador;
        }
    }
}