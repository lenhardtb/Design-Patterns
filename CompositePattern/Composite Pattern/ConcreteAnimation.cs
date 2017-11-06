using System;
using System.Drawing;
using System.Windows.Forms;

namespace Composite_Pattern
{
    public class ConcreteAnimation : Animation
    {
        public Image BaseImage;
        
        public ConcreteAnimation()
        {
            BaseImage = new Bitmap(1, 1);
        }
        public ConcreteAnimation(Image img, long start, long length, RotationFormula rotation, TranslationFormula translation)
        {
            if (length < 0) throw new ArgumentOutOfRangeException("length (" +  length + " given) must be at least 0 milliseconds.");

            this.BaseImage = img;
            this.Start = start;
            this.End = start + length;
            this.Rotation = rotation;
            this.Translation = translation;
        }

        public override Image Image(long millis)
        {
            if(!IsVisible || millis <= Start || millis >= End)
            {
                return InvisibleImage;
            }

            double angle = Rotation.Angle(millis - Start);
            return BaseImage.Rotate(angle);
        }

        public override int NumAnimations() => 1;

        
    }
}
