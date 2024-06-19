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
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.Dnn;

namespace ForEric02
{
  public partial class ForEric : Form
  {
    Mat mSource = new Mat();
    Mat mThresholded = new Mat();
    Mat mThresholdedInv = new Mat();
    Mat mSourceHSV = new Mat();
    bool mLoaded = false;

    public ForEric()
    {
      InitializeComponent();
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog Openfile = new OpenFileDialog();
      if (Openfile.ShowDialog() == DialogResult.OK)
      {
        mLoaded = true; 
        mSource = CvInvoke.Imread(Openfile.FileName, ImreadModes.AnyColor);
        process();
      }
    }

    private void process()
    {
      if(true == mLoaded)
      {
        ibOriginal.Image = mSource.ToImage<Bgr, byte>();

        CvInvoke.CvtColor(mSource, mSourceHSV, ColorConversion.Bgr2Hsv);

        MCvScalar lowScalar = new MCvScalar(sbMin.Value, 0, 0);
        MCvScalar highScalar = new MCvScalar(sbMax.Value, 255, 255);
        ScalarArray ialower = new ScalarArray(lowScalar);
        ScalarArray iaupper = new ScalarArray(highScalar);

        CvInvoke.InRange(mSourceHSV, ialower, iaupper, mThresholded);

        CvInvoke.BitwiseNot(mThresholded, mThresholdedInv);
        ibMask.Image = mThresholded.ToImage<Bgr, byte>();
//        ibMask.Image = mThresholdedInv.ToImage<Bgr, byte>();
      }
    }


    private void sbMin_Scroll(object sender, ScrollEventArgs e)
    {
      process();
      tbMin.Text = sbMin.Value.ToString();
    }

    private void sbMax_Scroll(object sender, ScrollEventArgs e)
    {
      process();
      tbMax.Text = sbMax.Value.ToString();
    }

    private void tbMin_Leave(object sender, EventArgs e)
    {
      int value = 0;
      int.TryParse(tbMin.Text, out value);
      sbMin.Value = value;
      process();
    }

    private void tbMax_Leave(object sender, EventArgs e)
    {
      int value = 0;
      int.TryParse(tbMax.Text, out value);
      sbMax.Value = value;
      process();
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (true == mLoaded)
      {
        Mat saveImg = new Mat();
        Mat maskImg = new Mat();

        CvInvoke.CvtColor(mThresholded, maskImg, ColorConversion.Gray2Bgr);
        CvInvoke.BitwiseAnd(mSource, maskImg, saveImg);

        SaveFileDialog Savefile = new SaveFileDialog();
        if (Savefile.ShowDialog() == DialogResult.OK)
        {
          CvInvoke.Imwrite(Savefile.FileName,saveImg);
        }
      }
    }
    private void saveInverseToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (true == mLoaded)
      {
        Mat saveImg = new Mat();
        Mat maskImg = new Mat();

        CvInvoke.CvtColor(mThresholdedInv, maskImg, ColorConversion.Gray2Bgr);
        CvInvoke.BitwiseAnd(mSource, maskImg, saveImg);

        SaveFileDialog Savefile = new SaveFileDialog();
        if (Savefile.ShowDialog() == DialogResult.OK)
        {
          CvInvoke.Imwrite(Savefile.FileName, saveImg);
        }
      }
    }
  }
}
