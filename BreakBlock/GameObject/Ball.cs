using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakBlock
{
    class Ball : GameObject
    {
        public int MoveSpeed { get; set; }
        public int VectorX { get; private set; }
        public int VectorY { get; private set; }
        public Ball(int width, int height, Vector x, Vector y, int moveSpeed)
            : base(width, height)
        {
            this.VectorX = (int)x;
            this.VectorY = (int)y;
            this.MoveSpeed = moveSpeed;
        }

        public void ReverseVectorX()
        {
            VectorX *= -1;
        }

        public void ReverseVectorY()
        {
            VectorY *= -1;
        }
    }
}
