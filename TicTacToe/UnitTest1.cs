using System;
using Xunit;
using Lab04_TicTacToe.Classes;
using Lab04_TicTacToe;

namespace TicTacToe
{
    public class UnitTest1
    {

        [Fact]
        public void ReturnWinner()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            game.Board.GameBoard = new string[,]

          {
                {"X", "O", "X"},
                {"O", "X", "X"},
                {"O", "O", "X"},
          };

            Assert.True(game.CheckForWinner(game.Board));

        }
        [Fact]

        public void SwitchPlayers()

        {

            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            p1.IsTurn = true;
            game.SwitchPlayer();
            Assert.Equal(game.PlayerTwo, game.NextPlayer());

        }
        [Fact]

        public void KnowPostion()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            p1.IsTurn = true;
            int position = 2;
            Position position2 = Player.PositionForNumber(position);
            Position newpo = new Position(0, 1);

            Assert.Equal(newpo.Column, position2.Column);
            Assert.Equal(newpo.Row, position2.Row);
        }


 } 
    }
