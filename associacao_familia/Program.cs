using System;

namespace associacao_familia
{
    class Program
    {
        static void Main(string[] args)
        {

            Pai pai = new Pai();


            Console.Write("Informe o nome do Pai: ");
            pai.nome = Console.ReadLine();

            Console.Write("Informe a idade do Pai: ");
            pai.idade = Console.ReadLine();

            Console.Write("Quantos filhos o pai tem ");
            int qtdFilhos =Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= qtdFilhos;i++){
                Console.Write("Informe o nome do Filho: ");
                Filhos filhos = new Filhos();
                filhos.nome = Console.ReadLine();
                pai.listaFilhos.Add(filhos);

            }



            Console.Clear();
            Console.WriteLine("{0} tem {1} anos eh pai de: ", pai.nome, pai.idade);
            foreach ( var elemento in pai.listaFilhos){
                Console.WriteLine(elemento.nome);
            }





        }
    }
}
