using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakBlock
{
    class GameObject
    {
        public virtual int X { get; set; }
        public virtual int Y { get; set; }
        public int Width { get; }
        public int Height { get; }

        public GameObject() { throw new Exception("引数を指定してください"); }

        public GameObject(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public GameObject(int width, int height, int x, int y)
        {
            this.Width = width;
            this.Height = height;
            this.X = x;
            this.Y = y;
        }
    }
}
