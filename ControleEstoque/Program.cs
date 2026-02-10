using ControleEstoque.Models;
using ControleEstoque.Services;
using System;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            var estoque = new EstoqueService();

            estoque.AdicionarProduto(new Produto("Mouse", 50, 10));
            estoque.AdicionarProduto(new Produto("Teclado", 120, 5));

            estoque.ListarProdutos();

            Console.ReadLine();
        }
    }
}
