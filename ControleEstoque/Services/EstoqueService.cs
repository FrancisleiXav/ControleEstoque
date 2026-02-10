using ControleEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Services
{
    public class EstoqueService
    {
        public List<Produto> Produtos { get; private set; } = new List<Produto>();


        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void ListarProdutos()
        {
            foreach (var p in Produtos)
            {
                Console.WriteLine($"{p.Nome} | {p.Quantidade} | R$ {p.ValorTotal()}");
            }
        }
    }
}

