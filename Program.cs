using Estoque;
using System;
using System.Globalization;

namespace Curso { 
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();
            SistemaEstoque s = new SistemaEstoque();
            

            //Entrar com os dados do produto no console
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            //adiciona a quantidade de produtos que o usuário desejar  estoque e mostra os dados atualizados
            Console.WriteLine("Digite a quantidade de produtos a serem adicionadas ao estoque: ");
            int quantidadeAdicionada = int.Parse(Console.ReadLine());
            p.AdicionarQuantidade(quantidadeAdicionada);
            
            Console.WriteLine();    
            Console.WriteLine("Dados atualizados: " + p);

            //Remove a quantidade de produtos desejados e mostra os dados atualizados
            Console.WriteLine("Digite o quantidade de produtos a serem removidas do estoque: ");
            int quantidadeRemovida = int.Parse(Console.ReadLine());
            p.RemoverQuantidade(quantidadeRemovida);
           
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            

             
            

        }
    }
}