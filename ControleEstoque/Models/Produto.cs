using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void Adicionar(int qtd)
        {
            Quantidade += qtd;
        }

        public void Remover(int qtd)
        {
            if (qtd <= Quantidade)
                Quantidade -= qtd;
        }

        public double ValorTotal()
        {
            return Preco * Quantidade;
        }
    }
}
