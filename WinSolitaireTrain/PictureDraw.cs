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
        private Pen greenPen;
        private Brush greenBrush;
        private Graphics stdGraphics;
        private Graphics backBufferGraphics;
        public Rectangle rectangle { get; set; }

        public List<Card> Cards = new List<Card>();

        private Image backBuffer;
        public readonly object mutex = new object();

        private Font font;
        private string[] types;

        public PictureDraw(PictureBox box, Font font, string[] types)
        {
            backBuffer = new Bitmap(box.Width, box.Height);
            stdGraphics = Graphics.FromHwnd(box.Handle);
            backBufferGraphics = Graphics.FromImage(backBuffer);
            this.font = font;
            this.types = types;

            pen = new Pen(new SolidBrush(Color.Red), 2);
            greenBrush = new SolidBrush(Color.Green);
            greenPen = new Pen(greenBrush, 2);

            Size stdSize = new Size(150, 150);
            rectangle = new Rectangle(new Point(0, 0), stdSize);

            box.Resize += (s, e) => {
                lock (mutex)
                {
                    backBuffer.Dispose();
                    backBuffer = new Bitmap(box.Width, box.Height);
                    backBufferGraphics = Graphics.FromImage(backBuffer);
                    stdGraphics = Graphics.FromHwnd(box.Handle);
                }
            };
        }

        public void Draw(Image image)
        {
            lock (mutex)
            {
                backBufferGraphics.Clear(Color.Black);
                backBufferGraphics.DrawImage(image, new Point(0, 0));
                backBufferGraphics.DrawRectangle(pen, rectangle);

                foreach (var card in Cards)
                {
                    backBufferGraphics.DrawString(types[card.Type], font, greenBrush, new Point(card.Bounds.X, card.Bounds.Y));
                    backBufferGraphics.DrawRectangle(greenPen, card.Bounds);
                }

                stdGraphics.DrawImage(backBuffer, new Point(0, 0));
            }
        }

        public void Dispose()
        {
            backBuffer.Dispose();
        }
    }
}
