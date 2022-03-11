using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakBlock
{
    public partial class MainForm : Form
    {
        Bar _bar;
        Ball _ball;
        List<Block> _blockList;
        int _score;

        public void init()
        {
            LevelEasyRadioButton.Enabled = true;
            LevelNormalRadioButton.Enabled = true;
            LevelHardRadioButton.Enabled = true;
            scoreLabel.Text = 0.ToString();
            _score = 0;
            _bar = new Bar(100, 5, 30);
            _ball = new Ball(3, 3, Vector.Positive, Vector.Positive, 2);
            _blockList = new List<Block>();
            _bar.X = fieldPictureBox.Size.Width / 2;
            _bar.Y = fieldPictureBox.Size.Height / 2 + fieldPictureBox.Size.Height / 3;
            _ball.X = fieldPictureBox.Size.Width / 2;
            _ball.Y = fieldPictureBox.Size.Height / 2;
            BlockSetting.RowNum = 10;
            BlockSetting.ColumnsNum = 10;
            BlockSetting.Gap = 5;
            BlockSetting.FrameSizeWidth = 350;
            BlockSetting.FrameSizeHeight = 350;
            BlockSetting.Width = BlockSetting.FrameSizeWidth / BlockSetting.RowNum - BlockSetting.Gap;
            BlockSetting.Height = BlockSetting.FrameSizeHeight / (BlockSetting.ColumnsNum * 2) - BlockSetting.Gap;
            BlockSetting.StartPointWidth = (fieldPictureBox.Width / 2) - (BlockSetting.FrameSizeWidth / 2);
            BlockSetting.StartPointHeight = (fieldPictureBox.Height / 2) - (BlockSetting.FrameSizeHeight / 2);
            int y = BlockSetting.StartPointHeight;
            int x = BlockSetting.StartPointWidth;
            while (y <= (BlockSetting.Height + BlockSetting.Gap) * BlockSetting.ColumnsNum)
            {
                x = BlockSetting.StartPointWidth;
                while (x <= (BlockSetting.Width + BlockSetting.Gap) * BlockSetting.RowNum)
                {
                    _blockList.Add(new Block(BlockSetting.Width, BlockSetting.Height, x, y, 0));
                    x += BlockSetting.Width + BlockSetting.Gap;
                }
                y += BlockSetting.Height + BlockSetting.Gap;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            init();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Green, new RectangleF(_bar.X, _bar.Y, _bar.Width, _bar.Height));
            e.Graphics.FillRectangle(Brushes.Green, new RectangleF(_ball.X, _ball.Y, _ball.Width, _ball.Height));
            foreach(var block in _blockList)
            {
                if (!block.IsAlaive) continue;
                e.Graphics.FillRectangle(Brushes.Green, new RectangleF(block.X, block.Y, block.Width, block.Height));
            }
        }

        void ballWallHitCheck(Ball ball)
        {
            if (ball.X < 0 || ball.X >= fieldPictureBox.Width - ball.Width) 
                ball.ReverseVectorX();
            if (ball.Y < 0 || ball.Y >= fieldPictureBox.Height - ball.Height)
                ball.ReverseVectorY();
        }

        void ballUpdate(Ball ball)
        {
            ballWallHitCheck(ball);
            ball.X += ball.VectorX * ball.MoveSpeed;
            ball.Y += ball.VectorY * ball.MoveSpeed;
        }

        void barHit(Bar bar, Ball ball)
        {
            int ballX = ball.X + ball.Width / 2;
            int ballY = ball.Y + ball.Height / 2;
            if (bar.X <= ballX && ballX < bar.X + bar.Width 
                && bar.Y <= ballY && ballY < bar.Y + bar.Height)
                ball.ReverseVectorY();
        }

        void blockHit(Ball ball, List<Block> blockList)
        {
            foreach(var block in blockList)
            {
                if (!block.IsAlaive) continue;
                if (block.X <= ball.X && ball.X < block.X + block.Width
                    && block.Y <= ball.Y && ball.Y < block.Y + block.Height)
                {
                    block.IsAlaive = false;
                    ball.ReverseVectorY();
                    _score += 10;
                    scoreLabel.Text = _score.ToString();
                } 
            }
        }

        bool gameOverCheck(Ball ball)
        {
            return ball.Y + ball.Height >= fieldPictureBox.Height;
        }

        void gameInit()
        {
            init();
            updateTimer.Stop();
            fieldPictureBox.Refresh();
        }

        private void reloadTimer_Tick(object sender, EventArgs e)
        {
            if (gameOverCheck(_ball))
            {
                gameInit();
                return;
            }
            barHit(_bar, _ball);
            ballUpdate(_ball);
            blockHit(_ball, _blockList);
            fieldPictureBox.Refresh();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            if (LevelEasyRadioButton.Checked) _ball.MoveSpeed = 1;
            else if (LevelNormalRadioButton.Checked) _ball.MoveSpeed = 2;
            else _ball.MoveSpeed = 3;
            LevelEasyRadioButton.Enabled = false;
            LevelNormalRadioButton.Enabled = false;
            LevelHardRadioButton.Enabled = false;
            fieldPictureBox.Enabled = true;
            updateTimer.Enabled = true;
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            gameInit();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            updateTimer.Stop();
        }

        private void rightButton_MouseDown(object sender, MouseEventArgs e)
        {
            _bar.X += _bar.MoveSpeed;
        }

        private void leftButton_MouseDown(object sender, MouseEventArgs e)
        {
            _bar.X -= _bar.MoveSpeed;
        }
    }
}
