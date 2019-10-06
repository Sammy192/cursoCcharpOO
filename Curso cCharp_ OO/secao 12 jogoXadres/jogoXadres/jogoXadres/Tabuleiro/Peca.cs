using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro {
    abstract class Peca {

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get;protected set; }

        public Peca(Tabuleiro tab,Cor cor) {
            Posicao = null;
            Cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }

        public void incrementarQteMovimento() {
            qteMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();

    }
}
