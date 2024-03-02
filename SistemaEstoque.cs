using Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class SistemaEstoque
    {
       
      
        public Dictionary<string, Produto> estoque = new Dictionary<string, Produto> ();

        public void AdiconarProdutos(string nome, double preco, int quantidade)
        {
            if (!estoque.ContainsKey (nome))
            {
                Produto novoProduto = new Produto {Nome = nome, Preco = preco, Quantidade = quantidade};
                estoque[nome] = novoProduto;
                Console.WriteLine($"Produto {nome} adicionado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Produto {nome} já existe no estoque.");
            }
        }
    }
}
