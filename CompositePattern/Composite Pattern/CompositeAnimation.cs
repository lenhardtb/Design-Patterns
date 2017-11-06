using System.Collections.Generic;
using System.Drawing;

namespace Composite_Pattern
{
    public class CompositeAnimation : Animation
    {
        readonly List<Animation> subs;

        public override long Start
        {
            get
            {
                if (subs.Count == 0) return -1;
                else
                {
                    long start = long.MaxValue;
                    foreach(Animation a in subs)
                    {
                        if (a.Start < start)
                            start = a.Start;
                    }
                    return start;
                }
            }
            set { }
        }

        public override long End
        {
            get
            {
                if (subs.Count == 0) return -1;
                else
                {
                    long end = long.MinValue;
                    foreach (Animation a in subs)
                    {
                        if (a.End < end)
                            end = a.End;
                    }
                    return end;
                }
            }
            set { }
        }

        public Point CenterOfRotation;

        public CompositeAnimation() : this(0) { }
        public CompositeAnimation(Animation a1, Animation a2) 
            : this(2)
        {
            subs.Add(a1);
            subs.Add(a2);
        }
        public CompositeAnimation(int initSize)
        {
            subs = new List<Animation>(initSize);
            Rotation = new NonRotate();
            Translation = new Static(new Point(0, 0));
        }

        public override int NumAnimations() => subs.Count;

        public void Add(Animation a)
        {
            subs.Add(a);
            Rotation.Length = End - Start;
            Translation.Length = End - Start;
        }

        public void Remove(Animation a)
        {
            subs.Remove(a);
            Rotation.Length = End - Start;
            Translation.Length = End - Start;
        }

        public override Image Image(long millis)
        {
            double angle = Rotation.Angle(millis - Start);

            int width = 0;
            int height = 0;
            List<Image> subImages = new List<Image>();
            List<Point> translations = new List<Point>();
            for (int i = 0; i < subs.Count; i++)
            {
                Image image = subs[i].Image(millis).Rotate(angle);

                Point translation = subs[i].Translation.PointAt(millis)
                        .Rotate(CenterOfRotation, angle);

                translations.Add(translation);
                subImages.Add(image);

                if (image.Width + translation.X > width)
                    width = image.Width + translation.X;
                if (image.Height + translation.Y > height)
                    height = image.Height + translation.Y;
                int o = 0;
            }

            //I don't know why but I keep getting this error - should only happening with 0 subanimations
            //but because this covers that case I removed the check above
            if (width == 0 || height == 0) return InvisibleImage;

            Bitmap returner = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(returner);

            for(int i = 0; i < subImages.Count; i++)
            {
                g.DrawImage(subImages[i], translations[i]);
            }

            return returner;
        }
    }
}
