namespace Exercicio3
{
    public class OperacaoFilas
    {
        private BatataQuente _jogo;
        private List<string> _jogadores;


        public OperacaoFilas(BatataQuente jogo)
        {
            _jogo = jogo;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    AdicionarJogadores();

                    IniciarJogo();               
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                var continuar = ContinuarJogo();

                if (continuar)
                {
                    continue;    
                }
                else
                {
                    break;
                }
            }

        }

        private bool ContinuarJogo()
        {
            Console.WriteLine("Deseja Jogar novamente? (s/n)");
            var continuar = Console.ReadLine();

            switch (continuar)
            {
                case "s":
                    return true;
                case "n":
                    Console.WriteLine("Saindo do Jogo...");
                    Thread.Sleep(1000);
                    return false;
                default:
                    Console.WriteLine("Não foi possível identificar a escolha. Saindo do Jogo...");
                    return true;
            }
        }

        private void IniciarJogo()
        {
            int numJogadores = this._jogadores.Count;
            Jogador jogador;
            int rodada = 1;

            while(numJogadores > 1) 
            {
                jogador = this._jogo.SimularRodada();
                Console.WriteLine($"Rodada {rodada}");
                Console.WriteLine($"A batata explodiu! {jogador} está fora do jogo.");
                Console.WriteLine();
                Thread.Sleep(2000);
                numJogadores--;
                rodada++;
            }

            jogador = this._jogo.ReceberVencedor();

            Console.WriteLine($"O jogador {jogador.ToString()} venceu!");

        }

        private void AdicionarJogadores()
        {
            _jogadores = new List<string>();
            Console.WriteLine("Quantos jogadores você deseja adicionar?");
            int numJogador;
            
            if (!int.TryParse(Console.ReadLine(), out numJogador)) 
            {
                throw new ArgumentException("Valor inválido escolhido");
            }

            Console.WriteLine("Digite o nome de cada jogador:");
            for (int i = 1; i <= numJogador; i++)
            {
                Console.WriteLine($"Jogador número {i}: ");
                _jogadores.Add(Console.ReadLine());
            }

            this._jogo.CriarFila(this._jogadores);

        }

    }
}
