using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakBlock
{
    class Bar : GameObject
    {
        public int MoveSpeed { get; }
        public Bar() { }
        public Bar(int width, int height, int moveSpeed) : base(width, height)
        {
            this.MoveSpeed = moveSpeed;
        }
    }
}
