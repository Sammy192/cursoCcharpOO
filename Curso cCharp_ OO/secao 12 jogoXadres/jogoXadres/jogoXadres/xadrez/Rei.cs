﻿using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez {
    class Rei : Peca {
        public Rei(Tabuleiro tab, Cor cor) :base(tab, cor) {
        }

        public override string ToString() {
            return "R";
        }

        private bool podeMover(Posicao pos) {
            Peca p = tab.peca(pos);
            return p == null || p.Cor != this.Cor;
        }


        public override bool[,] movimentosPossiveis() {
            bool[,] mat = new bool[tab.Linhas, tab.Colunas];

            Posicao pos = new Posicao(0, 0);

            //acima
            pos.definirValores(Posicao.Linha -1, Posicao.Coluna);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //nordeste
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna +1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //direito
            pos.definirValores(Posicao.Linha, Posicao.Coluna +1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //sudeste
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna +1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //abaixo
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //sudoeste
            pos.definirValores(Posicao.Linha + 1, Posicao.Coluna -1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //esquerda
            pos.definirValores(Posicao.Linha, Posicao.Coluna -1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }

            //noroeste
            pos.definirValores(Posicao.Linha - 1, Posicao.Coluna -1);
            if (tab.posicaoValida(pos) && podeMover(pos)) {
                mat[pos.Linha, pos.Coluna] = true;
            }
            return mat;
        }


    }
}
