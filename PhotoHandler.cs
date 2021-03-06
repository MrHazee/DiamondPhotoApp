﻿using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MonitorPhotoApp
{
    class PhotosHandler
    {
        public ImageList ImageList { get; private set; }
        private List<Bitmap> BitMapList { get; set; }
        public PhotosHandler()
        {
            this.ImageList = new ImageList();
            this.ImageList.ImageSize = new Size(56, 56);
            this.ImageList.ColorDepth = ColorDepth.Depth32Bit;

            this.BitMapList = new List<Bitmap>();
        }
        public ImageList GetImageListFromURLs(List<PhotoInfo> photoInfoList)
        {
            this.ImageList.Images.Clear();
            this.BitMapList.Clear();

            for (int i = 0; i < photoInfoList.Count; i++)  
            {

                WebClient w = new WebClient();
                byte[] imageByte = w.DownloadData(photoInfoList[i].URL);
                MemoryStream stream = new MemoryStream(imageByte);
                
                this.ImageList.Images.Add(Image.FromStream(stream));
                this.BitMapList.Add(new Bitmap(Image.FromStream(stream)));

            }
            return this.ImageList;
        }

        public Color GetPicturesAvrColor(int picIndex)
        {
            return GetMostUsedColor(this.BitMapList[picIndex]);
        }

        private Color GetMostUsedColor(Bitmap bmp)
        {

            int r = 0;
            int g = 0;
            int b = 0;

            int total = 0;

            // Iterate through every pixel and store the total value of R,G and B
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color clr = bmp.GetPixel(x, y);

                    r += clr.R;
                    g += clr.G;
                    b += clr.B;

                    total++;
                }
            }
            //Calculate average
            r /= total;
            g /= total;
            b /= total;

            return Color.FromArgb(r, g, b);
        }
    }
}
