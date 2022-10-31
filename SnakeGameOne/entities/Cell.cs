using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGameOne.entities
{
    public class Cell
    {
        public string val
        {
            get;
            set;
        }
        public int x
        {
            get;
            set;
        }
        public int y
        {
            get;
            set;
        }
        public bool visited
        {
            get;
            set;
        }
        public int decay
        {
            get;
            set;
        }

        public void decaySnake()
        {
            decay -= 1;
            if (decay == 0)
            {
                visited = false;
                val = " ";
            }
        }

        public void Clear()
        {
            val = " ";
        }

        public void Set(string newVal)
        {
            val = newVal;
        }
    }
}
