﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro {
    class Peca {

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get;protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab) {
            Posicao = posicao;
            Cor = cor;
            this.tab = tab;
            this.qteMovimentos = 0;
        }


    }
}