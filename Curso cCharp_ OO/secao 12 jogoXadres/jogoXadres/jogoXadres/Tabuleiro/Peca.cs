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

        public void decrementarQteMovimento() {
            qteMovimentos--;
        }

        public bool existeMovimentosPossiveis() {
            bool[,] mat = movimentosPossiveis();
            for(int i=0; i<tab.Linhas; i++) {
                for(int j=0; j < tab.Colunas; j++) {
                    if (mat[i,j]) {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool podeMoverPara(Posicao pos) {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }


        public abstract bool[,] movimentosPossiveis();

    }
}
