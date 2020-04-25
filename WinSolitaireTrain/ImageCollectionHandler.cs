using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSolitaireTrain
{
    public class ImageCollectionHandler
    {
        protected List<Image> Images = new List<Image>();
        private int Index = 0;

        public void Add(Image image)
        {
            Images.Add(image);
        }

        public Image Get()
        {
            return Images[Index];
        }

        public bool Next()
        {
            if (Index + 1 < Images.Count)
            {
                Index++;
                return true;
            }
            return false;
        }

        public bool HasImages()
        {
            return Images.Count > 0;
        }
    }
}
