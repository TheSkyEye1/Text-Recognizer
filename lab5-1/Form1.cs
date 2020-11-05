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
using Emgu.CV.OCR;

namespace lab5_1
{
    public partial class Form1 : Form
    {
        Filter_c fil = new Filter_c();
        Image<Bgr, byte> sourceImage;
        List<Rectangle> rois = new List<Rectangle>();
        Tesseract ocr = new Tesseract();
        public Form1()
        {
            InitializeComponent();
        }

        private void load_Click(object sender, EventArgs e)
        {
            sourceImage = fil.loadfunction(sourceImage);
            if (sourceImage != null)
            {
                IMG1.Image = sourceImage;
                IMG2.Image = sourceImage;
            }
            ocr = new Tesseract("D:\\", "eng", OcrEngineMode.Default);
        }

        private void binarb_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.binarize(sourceImage, trb1.Value, invcheck.Checked);
        }

        private void trb1_ValueChanged(object sender, EventArgs e)
        {
            lb1.Text = Convert.ToString(trb1.Value);
        }

        private void dilb_Click(object sender, EventArgs e)
        {
            IMG2.Image = fil.dilatade(sourceImage, trb1.Value, invcheck.Checked, trb2.Value);
        }

        private void trb2_ValueChanged(object sender, EventArgs e)
        {
            lb2.Text = Convert.ToString(trb2.Value);
        }

        private void contb_Click(object sender, EventArgs e)
        {
            rois.Clear();
            cmbx1.Items.Clear();
            IMG2.Image = fil.roifinder(sourceImage, trb1.Value, invcheck.Checked, trb2.Value, trb3.Value, rois);
            for(int i=0;i<rois.Count;i++)
            {
                sourceImage.ROI = rois[i];
                var roiCopy = sourceImage.Copy();
                sourceImage.ROI = Rectangle.Empty;

                ocr.SetImage(roiCopy);
                ocr.Recognize();
                string text = ocr.GetUTF8Text();
                cmbx1.Items.Add(text);
            }
        }

        private void trb3_ValueChanged(object sender, EventArgs e)
        {
            lb3.Text = Convert.ToString(trb3.Value * 10);
        }

        private void cmbx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sourceImage.ROI = rois[cmbx1.SelectedIndex];
            var roiCopy = sourceImage.Copy();
            sourceImage.ROI = Rectangle.Empty;
            IMG2.Image = roiCopy;
            lb4.Text = Convert.ToString(cmbx1.SelectedItem);
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            ocr = new Tesseract("D:\\", "rus", OcrEngineMode.Default);
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            ocr = new Tesseract("D:\\", "eng", OcrEngineMode.Default);
        }
    }
}
