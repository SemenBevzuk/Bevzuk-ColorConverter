using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Bevzuk_ColorConverter
{
    public partial class Form1 : Form
    {
        ColorConvert cc = new ColorConvert();
        Stack<ICommand> CommandStack = new Stack<ICommand>();
        private bool HalfMod = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string imagePath;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "image files|*.jpeg;*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = dialog.FileName;
                cc.rgbImage = new Bitmap(imagePath);
                cc.ConvertRGBimagetoHSV();
                cc.ConvertHSVimagetoRGB();
                this.pictureBox1.Image = cc.rgbImage;
            }
        }

        private void buttonHue_Click(object sender, EventArgs e)
        {
            
            this.Cursor = Cursors.WaitCursor;
            if (HalfMod == false)
            {
                HueCommand HC = new HueCommand(trackBarHue.Value);
                HC.Apply(cc);
                pictureBox1.Image = cc.rgbImage;
                CommandStack.Push(HC);
            }
            else
            {
                HalfHueCommand HHC = new HalfHueCommand(trackBarHue.Value);
                HHC.Apply(cc);
                pictureBox1.Image = cc.rgbImage;
                CommandStack.Push(HHC);
            }
            trackBarHue.Value = 0;
            this.Cursor = Cursors.Default;
        }

        private void buttonBrightness_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (HalfMod == false)
            {
                BrightnessCommand BC = new BrightnessCommand(trackBarBrightness.Value);
                BC.Apply(cc);
                pictureBox1.Image = cc.rgbImage;
                CommandStack.Push(BC);
            }
            else
            {
                HalfBrightnessCommand HBC = new HalfBrightnessCommand(trackBarHue.Value);
                HBC.Apply(cc);
                pictureBox1.Image = cc.rgbImage;
                CommandStack.Push(HBC);
            }
            trackBarBrightness.Value = 0;
            this.Cursor = Cursors.Default;
        }

        private void buttonSaturation_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (HalfMod == false)
            {
                SaturationCommand SC = new SaturationCommand(trackBarSaturation.Value);
                SC.Apply(cc);
                pictureBox1.Image = cc.rgbImage;
                CommandStack.Push(SC);
            }
            else
            {
                HalfSaturationCommand HSC = new HalfSaturationCommand(trackBarSaturation.Value);
                HSC.Apply(cc);
                pictureBox1.Image = cc.rgbImage;
                CommandStack.Push(HSC);
            }
            trackBarSaturation.Value = 0;
            this.Cursor = Cursors.Default;
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap saveImage = (Bitmap)pictureBox1.Image;
            SaveFileDialog dialog = new SaveFileDialog();
            //dialog.Filter = "image files|*.jpeg;*.png";
            dialog.DefaultExt = "bmp";
            dialog.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
 
                saveImage.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            try
            {
                ICommand temp = CommandStack.Pop();
                temp.Undo(cc);
                //if (temp is HueCommand)
                //{
                //   trackBarHue.Value = trackBarHue.Value - temp.GetDelta();
                //}
                pictureBox1.Image = cc.rgbImage;
            }
            catch (Exception)
            {
                MessageBox.Show("Стек пуст.");
            }
        }

        private void checkBoxHalfImage_CheckedChanged(object sender, EventArgs e)
        {
            HalfMod = checkBoxHalfImage.Checked;
        }

    }
}
