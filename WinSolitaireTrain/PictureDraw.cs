using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSolitaireTrain
{
    public class PictureDraw : IDisposable
    {
        private Pen pen;
        private Graphics stdGraphics;
        private Graphics backBufferGraphics;
        public Rectangle rectangle { get; set; }

        private Image backBuffer;

        public PictureDraw(PictureBox box)
        {
            backBuffer = new Bitmap(box.Width, box.Height);
            stdGraphics = Graphics.FromHwnd(box.Handle);
            backBufferGraphics = Graphics.FromImage(backBuffer);

            pen = new Pen(new SolidBrush(Color.Red), 2);
            

            Size stdSize = new Size(150, 150);
            rectangle = new Rectangle(new Point(0, 0), stdSize);
        }

        public void Draw(Image image)
        {
            backBufferGraphics.Clear(Color.Black);
            backBufferGraphics.DrawImage(image, new Point(0, 0));
            backBufferGraphics.DrawRectangle(pen, rectangle);
            stdGraphics.DrawImage(backBuffer, new Point(0, 0));
        }

        public void Dispose()
        {
            backBuffer.Dispose();
        }
    }
}
