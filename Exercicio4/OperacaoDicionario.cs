namespace Exercicio4
{
    public class OperacaoDicionario
    {
        private Dictionary<string, int> _contador;

        public void ContarPalavras(string texto)
        {
            Dictionary<string, int> contador = new Dictionary<string, int>();

            string[] palavras = texto.Split(new char[] { ' ', '.', ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string palavra in palavras)
            {
                string palavraFormatada = palavra.ToLower();
                if (contador.ContainsKey(palavraFormatada))
                {
                    contador[palavraFormatada]++;
                }
                else
                {
                    contador[palavraFormatada] = 1;
                }
            }

            _contador = contador;
        }

        public void ImprimirContador()
        {
            Console.WriteLine("Contagem de palavras:");

            foreach (var entrada in _contador)
            {
                Console.WriteLine($"{entrada.Key}: {entrada.Value}");
            }
        }
    }
}
