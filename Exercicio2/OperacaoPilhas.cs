namespace Exercicio2
{
    public class OperacaoPilhas
    {
        public static bool VerificarBalanceamento(string expressao)
        {
            int aParanteses = 0;
            int aColchetes = 0;
            int aChaves = 0;
            int fParanteses = 0;
            int fColchetes = 0;
            int fChaves = 0;
            var pilha = new Stack<string>();
            foreach (var item in expressao)
            {
                if (item.Equals('('))
                {
                    aParanteses++;
                } 
                else if (item.Equals(')')) 
                {
                    fParanteses++;
                }
                else if(item.Equals('['))
                {
                    aColchetes++;
                }
                else if (item.Equals(']'))
                {
                    fColchetes++;
                }
                else if(item.Equals('{'))
                {
                    aChaves++;
                }
                else if (item.Equals('}'))
                {
                    fChaves++;
                }
            }

            if (aParanteses == fParanteses && aColchetes == fColchetes && aChaves == fChaves) 
            {
                return true;
            }

            return false;            
        }
    }
}
