using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ControledeProdutos_Contrutores
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto() //Serve para istanciar mesmo sem passar nenhum parametro
        { }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco) //sobrecarga de construtor
        {
            _nome = nome;
            _preco = preco;
            // Quantidade = 0; Opcional
        }

        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1) //filtro de entrada de dados
            {
                _nome = nome;
            }
        }

        public double Getpreco()
        {
            return _preco;
        }

        public int GetQuantd()
        {
            return _quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
