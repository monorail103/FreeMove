using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FreeMove
{
    public partial class Form1 : Form
    {
        private Helicopter helicopter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int formSizeW = this.ClientSize.Width;
            int formSizeH = this.ClientSize.Height;
            const int HelicopterSpeedX = 30; // ヘリコプターのスピードX
            const int HelicopterSpeedY = 30; // ヘリコプターのスピードY

            // ヘリコプターのインスタンス
            int x = pictureBoxHeli.Location.X;
            int y = pictureBoxHeli.Location.Y;
            int distanceW = formSizeW - pictureBoxHeli.Size.Width;
            int distanceH = formSizeH - pictureBoxHeli.Size.Height;
            helicopter = new Helicopter(x, y, HelicopterSpeedX, HelicopterSpeedY, distanceW, distanceH, pictureBoxHeli);
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            int x = pictureBoxHeli.Location.X;
            int y = pictureBoxHeli.Location.Y;
            switch (e.KeyCode)
            {
                case Keys.Down:
                    y = helicopter.MoveDown(y);
                    break;
                case Keys.Up:
                    y = helicopter.MoveUp(y);
                    break;
                case Keys.Left:
                    x = helicopter.MoveLeft(x);
                    break;
                case Keys.Right:
                    x = helicopter.MoveRight(x);
                    break;
            }
            Console.WriteLine("{0} {1}", x,y);
            helicopter.PictureMove(x, y);
        }
    }
}
