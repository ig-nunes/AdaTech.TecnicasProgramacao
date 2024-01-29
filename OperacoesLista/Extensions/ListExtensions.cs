namespace Exercicio1.Extensions
{
    public static class ListExtensions
    {
        public static void FiltroLista10ouMais(this List<string> lista)
        {
            var listaAux = new List<string>();
            foreach (var item in lista)
            {
                if (item.Length >= 10)
                {
                    listaAux.Add(item);
                }
            }

            lista.Clear();
            lista.AddRange(listaAux);
        }
    }
}
