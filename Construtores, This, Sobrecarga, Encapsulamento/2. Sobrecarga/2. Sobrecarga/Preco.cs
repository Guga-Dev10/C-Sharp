﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace _2._Sobrecarga {
    class Preco {

        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Nome;
        public double Valor;
        public int Quantidade;

        // Sobrecarga Padrão - Sem parâmetros
        public Preco() {
        }

        // Construtor Sobrecarga com dois parâmetros
        public Preco(string nome, double valor) {
            Nome = nome;
            Valor = valor;
            Quantidade = 5;
        }
        // Construtor sobrecarga com Três parâmetros
        public Preco(string nome, double valor, int quantidade) {
            Nome = nome;
            Valor = valor;
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque() {
            double total = Valor * Quantidade;
            return total;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome
                + ", Quantidade = "
                + Quantidade
                + ", Valor = $"
                + ValorTotalEmEstoque().ToString("F2", CI);
        }
    }
}

