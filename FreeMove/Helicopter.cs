using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using System.Windows.Forms;

namespace FreeMove
{
    class Helicopter
    {
        private System.Windows.Forms.PictureBox picture;

        //コンストラクタ
        public Helicopter(int positionX, int positionY, int speedX, int speedY, int distanceX, int distanceY, System.Windows.Forms.PictureBox picture)
        {
            PositionX = positionX;
            PositionY = positionY;
            SpeedX = speedX;
            SpeedY = speedY;
            DistanceX = distanceX;
            DistanceY = distanceY;
            this.picture = picture;
        }

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public int SpeedX { get; set; }
        public int SpeedY { get; set; }
        public int DistanceX { get; set; }
        public int DistanceY { get; set; }

        // 上へ移動
        public int MoveUp(int y)
        {
            // 上限に達しないように移動
            if (PositionY >= 0)
            {
                return y - SpeedY;
            }
            else
            {
                return 0;
            }
        }

        // 下へ移動
        public int MoveDown(int y)
        {

            // 下限に達しないように移動
            if (PositionY <= DistanceY)
            {
                return y + SpeedY;
            }
            else 
            { 
                return DistanceY;
            }
        }

        // 左へ移動
        public int MoveLeft(int x)
        {
            // 左限に達しないように移動
            if (PositionX >= 0)
            {
                return x - SpeedX;
            }
            else { return 0; }
        }

        // 右へ移動
        public int MoveRight(int x)
        {
            // 右限に達しないように移動
            if (PositionX <= DistanceX)
            {
                return x + SpeedX;
            }
            else { return  DistanceX; }
        }

        // 画像を移動させる
        public void PictureMove(int x, int y)
        {
            picture.Location = new System.Drawing.Point(x, y);
        }
    }
}
