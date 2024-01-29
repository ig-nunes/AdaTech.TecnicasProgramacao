using Exercicio1.Extensions;
using Exercicio1;
using Exercicio2;
using Exercicio3;
using Exercicio4;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Exercicio 1
            //var lista = new List<string>
            //{
            //    "Idiossincrasia",
            //    "Ambivalente",
            //    "Quimérica",
            //    "Perpendicular",
            //    "Efêmero",
            //    "Pletora",
            //    "Obnubilado",
            //    "Xilografia",
            //    "Quixote",
            //    "Inefável"
            //};

            //Console.WriteLine("Lista original:");
            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item);
            //}

            ////OperacaoListas.FiltroLista10ouMais(ref lista);
            //lista.FiltroLista10ouMais();
            //Console.WriteLine();

            //Console.WriteLine("Lista filtrada com 10 ou mais caracteres:");
            //foreach (var item in lista)
            //{
            //    Console.WriteLine(item);
            //}




            // Exercicio 2
            //string expressao1 = "(2 + 1) * 80 / (7 - [√9 + { 4² *0}])";
            //string expressao2 = "([{35 - 2} + 5*3} + 0 / 15) - [3 + 5³] * 11)";

            //var resultado1 = OperacaoPilhas.VerificarBalanceamento(expressao1) ? "Sim" : "Não";
            //var resultado2 = OperacaoPilhas.VerificarBalanceamento(expressao2) ? "Sim" : "Não";

            //Console.WriteLine($"expressao1 1: {expressao1}");
            //Console.WriteLine($"A expressão 1 está balanceada? {resultado1}");

            //Console.WriteLine();

            //Console.WriteLine($"expressao1 2: {expressao2}");
            //Console.WriteLine($"A expressão 2 está balanceada? {resultado2}");



            // Exercicio 3
            //BatataQuente jogo = new BatataQuente();
            //OperacaoFilas operacao = new OperacaoFilas(jogo);

            //operacao.Run();



            // Exercicio 4
            string texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla auctor porta velit a tincidunt. Nam efficitur iaculis placerat. Aenean lectus dui, sollicitudin id rhoncus tristique, aliquet sed quam. Phasellus blandit magna at elementum consequat. Nam vitae nunc vehicula, blandit felis a, placerat augue. Quisque bibendum a ipsum at scelerisque. Duis molestie turpis quis orci vehicula aliquam. Duis non elementum erat. Phasellus et dui odio. Nunc vitae leo sem. Curabitur nec enim id mi aliquet commodo at et sapien. Fusce sit amet nisi elit. Interdum et malesuada fames ac ante ipsum primis in faucibus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Duis vitae dolor at sem ultrices euismod. Morbi aliquet, felis et mattis congue, justo nunc pharetra lectus, a lobortis mauris eros et nulla. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Maecenas sollicitudin posuere nibh malesuada suscipit. Nam a sapien ex. Donec mollis justo est, quis tempus mi pharetra at. Cras fringilla enim eu egestas scelerisque. Praesent tristique imperdiet consectetur. Donec interdum pulvinar nulla vel pharetra. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Aliquam interdum finibus mi, in tempus lorem. Cras diam magna, viverra vitae ante eget, scelerisque sodales velit. Aliquam erat volutpat. Mauris consectetur sapien mi, vel euismod quam consectetur id.";
            //string texto = "A descoberta Seguimos nosso caminho por este mar de longo Até a oitava da Páscoa Topamos aves E houvemos vista de terra os selvagens Mostraram-lhes uma galinha Quase haviam medo dela E não queriam por a mão E depois a tomaram como espantados primeiro chá Depois de dançarem Diogo Dias Fez o salto real as meninas da gare Eram três ou quatro moças bem moças e bem gentis Com cabelos mui pretos pelas espáduas E suas vergonhas tão altas e tão saradinhas Que de nós as muito bem olharmos Não tínhamos nenhuma vergonha.";

            OperacaoDicionario operacao = new OperacaoDicionario();
            operacao.ContarPalavras(texto);

            operacao.ImprimirContador();
        }
    }
}
