using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; } // Associação a classe Posicao
        public Cor cor { get; protected set; } // Associação a classe do tipo Enum Cor
        public int qteMovimentos { get; protected set; } 
        public Tabuleiro tab { get; protected set; } // Associação a classe Tabuleiro

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0; // Inicia com 0 movimentos no jogo
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }
    }
}
