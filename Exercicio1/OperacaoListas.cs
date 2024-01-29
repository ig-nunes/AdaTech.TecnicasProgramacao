namespace Exercicio1
{
    public static class OperacaoListas
    {
        public static void FiltroLista10ouMais(ref List<string> lista)
        {
            var listaAux = new List<string>();
            foreach (var item in lista)
            {
                if (item.Length >= 10)
                {
                    listaAux.Add(item);
                }
            }

            lista = listaAux;
        }

    }
}
