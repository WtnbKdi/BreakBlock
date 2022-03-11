using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakBlock
{
    class Block : GameObject
    {
        public bool IsAlaive { get; set; } // ブロックが破壊されずに生きているか
        public int Gap { get; }  // ブロックとブロックの隙間
        public Block() { }
        public Block(int width, int height, int x, int y, int gap) : base(width, height, x, y) 
        {
            IsAlaive = true;
            this.Gap = gap;
        }
    }
}
