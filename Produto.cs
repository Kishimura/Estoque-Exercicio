using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Curso
{
    internal class Produto{
        public string Nome;
        public double Preco;
        public int Quantidade;
        public Dictionary<string, Produto> estoque = new Dictionary<string, Produto>();


        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
        public void AdiconarProdutos(string nome, double preco, int quantidade)
        {
            if (!estoque.ContainsKey(nome))
            {
                Produto novoProduto = new Produto { Nome = nome, Preco = preco, Quantidade = quantidade };
                estoque[nome] = novoProduto;
                Console.WriteLine($"Produto {nome} adicionado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Produto {nome} já existe no estoque.");
            }
        }
        public void AdicionarQuantidade(int quantidade) {
                Quantidade += quantidade;

         
        }
        public void RemoverQuantidade(int quantidade){
                 Quantidade -= quantidade;

        }
    }
}
