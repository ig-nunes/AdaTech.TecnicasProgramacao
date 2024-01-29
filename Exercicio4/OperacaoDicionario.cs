using System.Text.RegularExpressions;

namespace Exercicio4
{
    public class OperacaoDicionario
    {
        private Dictionary<string, int> _contador;

        public void ContarPalavras(string texto)
        {
            var contador = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
            var wordPattern = @"\w+";

            MatchCollection matches = Regex.Matches(texto, wordPattern);

            foreach (Match match in matches)
            {
                string palavra = match.Value.ToLower();
                if (contador.ContainsKey(palavra))
                {
                    contador[palavra]++;
                }
                else
                {
                    contador[palavra] = 1;
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
