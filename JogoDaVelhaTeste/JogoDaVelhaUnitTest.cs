﻿using System;
using JogoDaVelha;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JogoDaVelhaTeste
{
    [TestClass]
    public class JogoDaVelhaUnitTest
    {
        [TestMethod]
        public void TesteDeVencedores()
        {
            TabuleiroJogo tabuleiro = new TabuleiroJogo();
            int jogador = tabuleiro.JogadorAtual;
            tabuleiro.Jogar(tabuleiro.JogadorAtual, 0, 0);
            Assert.AreEqual(tabuleiro.Tabuleiro[0][0], jogador);
            try
            {
                tabuleiro.Jogar(tabuleiro.JogadorAtual, 0, 0);
            }
            catch
            {
                //Exceção esperada.
            }
            Assert.AreEqual(tabuleiro.Tabuleiro[0][0], jogador);

            tabuleiro = new TabuleiroJogo(new int [][] {
                new int[]{ 1, 1, 1 },
                new int[] { 0, 0, 0 },
                new int[] { 0, 0, 0 } });

            Assert.AreEqual(tabuleiro.VerificarGanhador(), 1);

            tabuleiro = new TabuleiroJogo(new int[][] {
                new int[]{ 0, 1, 1 },
                new int[] { 0, 0, 0 },
                new int[] { 2, 2, 2 } });

            Assert.AreEqual(2, tabuleiro.VerificarGanhador());

            tabuleiro = new TabuleiroJogo(new int[][] {
                new int[]{ 0, 2, 1 },
                new int[] { 0, 2, 0 },
                new int[] { 1, 2, 2 } });

            Assert.AreEqual(2, tabuleiro.VerificarGanhador());


            tabuleiro = new TabuleiroJogo(new int[][] {
                new int[]{ 1, 2, 1 },
                new int[] { 0, 1, 0 },
                new int[] { 2, 2, 1 } });

            Assert.AreEqual(1, tabuleiro.VerificarGanhador());

            tabuleiro = new TabuleiroJogo(new int[][] {
                new int[] { 2, 2, 1 },
                new int[] { 0, 1, 0 },
                new int[] { 1, 2, 1 } });

            Assert.AreEqual(1, tabuleiro.VerificarGanhador());
        }
    }
}
