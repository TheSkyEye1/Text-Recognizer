using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using Emgu.CV.Structure;
using Emgu.CV.ImgHash;

namespace lab5_1
{
    class Filter_c
    {
        public Image<Bgr, byte> loadfunction(Image<Bgr, byte> image)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;*.png";
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                image = new Image<Bgr, byte>(fileName);
            }
            return image;
        }

        public Image<Gray,byte> binarize(Image<Bgr,byte> image, int k1, bool k2)
        {
            var grayImage = image.Convert<Gray, byte>();
            Image<Gray, byte> binarizedImage;
            if (k2 == true)
            {
                binarizedImage = grayImage.ThresholdBinaryInv(new Gray(k1), new Gray(255));
            }
            else
            {
                binarizedImage = grayImage.ThresholdBinary(new Gray(k1), new Gray(255));
            }

            return binarizedImage;
        }

        public Image<Gray, byte> dilatade(Image<Bgr, byte> image, int k1, bool k2, int k3)
        {
            var binarizedImage = binarize(image, k1, k2);

            var dilatedImage = binarizedImage.Dilate(k3);

            return dilatedImage;
        }

        public Image<Bgr, byte> roifinder(Image<Bgr, byte> image, int k1, bool k2, int k3, int k4, List<Rectangle> rois)
        {
            var dilatedImage = dilatade(image, k1, k2, k3);

            var contours = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(dilatedImage, contours, null, RetrType.List, ChainApproxMethod.ChainApproxSimple);
            var copy = image.Copy();
            for (int i = 0; i < contours.Size; i++)
            {
                if (CvInvoke.ContourArea(contours[i], false) > (k4 * 10))
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                    rois.Add(rect);

                    copy.Draw(rect, new Bgr(Color.Blue), 1);
                }
            }

            return copy;
        }
    }
}
