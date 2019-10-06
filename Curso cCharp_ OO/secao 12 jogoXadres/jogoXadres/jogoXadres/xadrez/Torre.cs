using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez {
    class Torre : Peca {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor) {
        }

        public override string ToString() {
            return "T";
        }

        private bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.Cor != this.Cor;
        }


        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).Cor != Cor){
                    break;
                }
                pos.Linha = pos.Linha - 1;
            }

            //abaixo
            pos.definirValores(Posicao.Linha +1, Posicao.Coluna);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).Cor != Cor){
                    break;
                }
                pos.Linha = pos.Linha + 1;
            }

            //a direita
            pos.definirValores(Posicao.Linha, Posicao.Coluna +1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).Cor != Cor){
                    break;
                }
                pos.Coluna = pos.Coluna +1;
            }

            //a esquerda
            pos.definirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).Cor != Cor){
                    break;
                }
                pos.Coluna = pos.Coluna - 1;
            }


            return mat;
        }



    }
}
