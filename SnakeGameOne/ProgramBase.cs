using SnakeGameOne.Entities;
using System;

namespace SnakeGameOne
{
    internal class ProgramBase
    {
        public static bool Populated { get; private set; }
        public static int FoodCount { get; private set; }
        public static bool Lost { get; private set; }

        private static int snakeLength;
        private static object currentCell;
        static readonly int gridW = 90;
        static readonly int gridH = 25;
        static Cell[,] grid = new Cell[gridH, gridW];
        private static void Main(string[] args)
        {

            if (!Populated)
            {
                FoodCount = 0;
                snakeLength = 5;
                populateGrid();
                currentCell = grid[(int)Math.Ceiling((double)gridH / 2), (int)Math.Ceiling((double)gridW / 2)];
                updatePos();
                addFood();
                Populated = true;
            }

            while (!Lost)
            {
                Restart();
            }
        }

        private static void Restart()
        {
            throw new NotImplementedException();
        }

        private static void addFood()
        {
            throw new NotImplementedException();
        }

        private static void updatePos()
        {
            throw new NotImplementedException();
        }

        private static void populateGrid()
        {
            throw new NotImplementedException();
        }
    }
}