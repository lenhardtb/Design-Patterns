using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public abstract class Animation
    {
        public Point from, to;

        private long start = 0;
        private long end = 0;

        public virtual long Start
        {
            get
            {
                return start;
            }
            set
            {
                if (value <= End)
                {
                    start = value;
                    Rotation.Length = End - Start;
                    Translation.Length = End - Start;
                }
            }
        }
        public virtual long End
        {
            get
            {
                return end;
            }
            set
            {
                if (value >= Start)
                {
                    end = value;
                    Rotation.Length = End - Start;
                    Translation.Length = End - Start;
                }
            }
        }

        #region UI helper members
        public Animation Parent;
        
        /// <summary>
        /// Determines whether this animation and its children are visible
        /// </summary>
        public bool Visible = true;
        
        /// <summary>
        /// Determines whether this animation would appear; 
        /// if this animation's parent isn't visible this returns false, even if this animation is
        /// </summary>
        public bool IsVisible
        {
            get
            {
                //in order to show up, parent must be visible and this must be visible
                return (Parent == null || Parent.IsVisible) && Visible;
            }
        }
        public string Name;
        #endregion

        public RotationFormula Rotation;
        public TranslationFormula Translation;

        public abstract int NumAnimations();

        public abstract Image Image(long millis);
        
        //this should be static probably, but how to make it make sense internally?
        //it's just a utility for inherited classes anyway
        protected Bitmap InvisibleImage => new Bitmap(4, 4);
        
        public Animation()
        {
            start = 0;
            end = 0;
            Rotation = new NonRotate();
            Translation = new Static(new Point(0, 0));
        }
        
        public static Animation operator +(Animation a1, Animation a2)
        {
            return new CompositeAnimation(a1, a2);
        }
    }
}
