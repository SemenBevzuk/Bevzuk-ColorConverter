using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bevzuk_ColorConverter
{
    public interface ICommand
    {
        void Apply(ColorConvert cc);
        void Undo(ColorConvert cc);
        int GetDelta();
    }

    class HueCommand:ICommand
    {
        private int deltaH;

        public HueCommand(int deltaH)
        {
            this.deltaH = deltaH;
        }

        protected virtual void ShiftH(int delta, ColorConvert cc)
        {
            //cc.ConvertRGBimagetoHSV();
            int width = cc.rgbImage.Width;
            int height = cc.rgbImage.Height;

            for(int i = 0; i<width; ++i)
                for (int j = 0; j < height; ++j)
                {
                    int tmpH = cc.hsvImage[i, j].h + delta;
                    if (tmpH < 0)
                        cc.hsvImage[i, j].h = (ushort) (tmpH + 360);
                    else if(tmpH >= 360)
                         cc.hsvImage[i, j].h = (ushort) (tmpH - 360);
                    else
                         cc.hsvImage[i, j].h = (ushort) (tmpH);
                }
            cc.ConvertHSVimagetoRGB();
        }
        public void Apply(ColorConvert cc)
        {
            ShiftH(deltaH, cc);
        }

         public void Undo(ColorConvert cc)
        {
             ShiftH(-deltaH, cc);
        }

        public int GetDelta()
        {
            return deltaH;
        }
    }
    class HalfHueCommand:HueCommand
    {

        public HalfHueCommand(int deltaH) : base(deltaH){}

        protected  override void ShiftH(int delta, ColorConvert cc)
        {
            //cc.ConvertRGBimagetoHSV();
            int width = cc.rgbImage.Width;
            int height = cc.rgbImage.Height;

            for(int i = (int)(0.5*width); i<width; ++i)
                for (int j = 0; j < height; ++j)
                {
                    int tmpH = cc.hsvImage[i, j].h + delta;
                    if (tmpH < 0)
                        cc.hsvImage[i, j].h = (ushort) (tmpH + 360);
                    else if(tmpH >= 360)
                         cc.hsvImage[i, j].h = (ushort) (tmpH - 360);
                    else
                         cc.hsvImage[i, j].h = (ushort) (tmpH);
                }
            cc.ConvertHSVimagetoRGB();
        }
    }
    class BrightnessCommand : ICommand
    {
        private int deltaB;

        public BrightnessCommand(int deltaB)
        {
            this.deltaB = deltaB;
        }

        protected virtual void ShiftB(int delta, ColorConvert cc)
        {
            int width = cc.rgbImage.Width;
            int height = cc.rgbImage.Height;

            for(int i = 0; i<width; ++i)
                for (int j = 0; j < height; ++j)
                {
                    int tmpV = cc.hsvImage[i, j].v + delta;
                    if (tmpV < 0)
                        cc.hsvImage[i, j].v = 0;
                    else if(tmpV >= 100)
                         cc.hsvImage[i, j].v = 100;
                    else
                         cc.hsvImage[i, j].v = (byte) (tmpV);
                }
            cc.ConvertHSVimagetoRGB();
        }
        public void Apply(ColorConvert cc)
        {
            ShiftB(deltaB, cc);
        }

         public void Undo(ColorConvert cc)
        {
             ShiftB(-deltaB, cc);
        }
        public int GetDelta()
        {
            return deltaB;
        }
    }

    class HalfBrightnessCommand : BrightnessCommand
    {
        public HalfBrightnessCommand(int deltaB): base(deltaB){}

        protected override void ShiftB(int delta, ColorConvert cc)
        {
            int width = cc.rgbImage.Width;
            int height = cc.rgbImage.Height;

            for(int i = (int)(0.5*width); i<width; ++i)
                for (int j = 0; j < height; ++j)
                {
                    int tmpV = cc.hsvImage[i, j].v + delta;
                    if (tmpV < 0)
                        cc.hsvImage[i, j].v = 0;
                    else if(tmpV >= 100)
                         cc.hsvImage[i, j].v = 100;
                    else
                         cc.hsvImage[i, j].v = (byte) (tmpV);
                }
            cc.ConvertHSVimagetoRGB();
        }
    }

     class SaturationCommand : ICommand
    {
        private int deltaS;

        public SaturationCommand(int deltaS)
        {
           this. deltaS = deltaS;
        }

        protected virtual void ShiftS(int delta, ColorConvert cc)
        {
            int width = cc.rgbImage.Width;
            int height = cc.rgbImage.Height;

            for(int i = 0; i<width; ++i)
                for (int j = 0; j < height; ++j)
                {
                    int tmpV = cc.hsvImage[i, j].s + delta;
                    if (tmpV < 0)
                        cc.hsvImage[i, j].s = 0;
                    else if(tmpV >= 100)
                         cc.hsvImage[i, j].s = 100;
                    else
                         cc.hsvImage[i, j].s = (byte) (tmpV);
                }
            cc.ConvertHSVimagetoRGB();
        }
        public void Apply(ColorConvert cc)
        {
            ShiftS(deltaS, cc);
        }

         public void Undo(ColorConvert cc)
        {
             ShiftS(-deltaS, cc);
        }
         public int GetDelta()
        {
            return deltaS;
        }
    }

    class HalfSaturationCommand : SaturationCommand
    {
        public HalfSaturationCommand(int deltaS): base(deltaS){}

        protected override void ShiftS(int delta, ColorConvert cc)
        {
            int width = cc.rgbImage.Width;
            int height = cc.rgbImage.Height;

            for(int i = (int)(0.5*width); i<width; ++i)
                for (int j = 0; j < height; ++j)
                {
                    int tmpV = cc.hsvImage[i, j].s + delta;
                    if (tmpV < 0)
                        cc.hsvImage[i, j].s = 0;
                    else if(tmpV >= 100)
                         cc.hsvImage[i, j].s = 100;
                    else
                         cc.hsvImage[i, j].s = (byte) (tmpV);
                }
            cc.ConvertHSVimagetoRGB();
        }
    }
}
