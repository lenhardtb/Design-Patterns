using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade_Pattern
{
    public class WaterSource
    {
        protected const int UpdateTime = 50;//~20 times per second

        //something getting filled and how much it was opened to this source (how much gets added to it)
        protected Dictionary<IFillable, double> filling;
        protected Timer timer = new Timer();

        protected double currentUse;

        //max gallons per second
        public readonly double GPS;
        public bool IsMaxed => currentUse >= GPS;

        public WaterSource(double maxGPS)
        {
            GPS = maxGPS;
            filling = (new Dictionary<IFillable, double>());

            timer.Tick += Timer_tick;
            timer.Interval = UpdateTime;
        }

        
        public virtual void Open(IFillable obj, double gps)
        {
            if (!filling.ContainsKey(obj))
                filling.Add(obj, gps);
            else
            {
                filling[obj] = gps;
            }

            //start timer if it's not running
            if (!timer.Enabled) timer.Start();
        }

        public virtual void Close(IFillable obj)
        {
            filling.Remove(obj);//remove entry

            //stop timer if nothing is being filled
            if (filling.Count == 0) timer.Stop();
        }

        public bool IsFilling(IFillable obj)
        {
            return CurrentFlow(obj) == 0;
        }

        public double CurrentFlow(IFillable obj)
        {
            if (filling.ContainsKey(obj))
                return filling[obj];
            else return 0;
        }

        protected virtual void Timer_tick(object source, EventArgs args)
        {
            //it can only fill so much of its demand past the maximum output
            double factor = 1;
            if (currentUse > GPS)
            {
                factor = GPS / currentUse;
            }

            try
            {
                //add water to the things
                foreach (IFillable filled in filling.Keys)
                {
                    //add water
                    double amount = factor * filling[filled] * UpdateTime / 1000;

                    filled.Fill(amount);
                }
            }
            catch { }
            
        }

        public static WaterSource FromFillable(double gps, IFillable fillable)
        {
            return new FillableSource(gps, fillable);
        }
    }

    public class WaterSink
    {
        int updateTime = 50;//~20 times per second

        //something getting emptied and how much it opened to this sink (how much gets taken)
        Dictionary<IFillable, double> emptying;
        Timer timer = new Timer();


        public WaterSink(double maxGPS)
        {
            GPS = maxGPS;
            emptying = new Dictionary<IFillable, double>();

            timer.Tick += Timer_tick;
            timer.Interval = updateTime;
        }

        private double currentUse;

        //max gallons per second
        public readonly double GPS;
        public bool IsMaxed => currentUse >= GPS;

        public virtual void Open(IFillable obj, double gps)
        {
            if (!emptying.ContainsKey(obj))
                emptying.Add(obj, gps);
            else
            {
                emptying[obj] = gps;
            }
            //start timer if it's not running
            if (!timer.Enabled) timer.Start();
        }

        public virtual void Close(IFillable obj)
        {
            emptying.Remove(obj);//remove entry

            //stop timer if nothing is being filled
            if (emptying.Count == 0) timer.Stop();
        }

        public bool IsEmptying(IFillable obj)
        {
            return CurrentFlow(obj) == 0;
        }

        public double CurrentFlow(IFillable obj)
        {
            if (emptying.ContainsKey(obj))
                return emptying[obj];
            else return 0;
        }

        private void Timer_tick(object source, EventArgs args)
        {
            //it can only take out so much of its demand past the maximum input
            double factor = 1;
            if (currentUse > GPS)
            {
                factor = GPS / currentUse;
            }

            //add water to the things
            foreach (IFillable filled in emptying.Keys)
            {
                //add water
                double amount = factor * emptying[filled] * updateTime / 1000;

                filled.Empty(amount);
            }
        }
    }

    class Infinite_Fillable : IFillable
    {
        public bool IsFull => false;
        public bool IsEmpty => false;
        public bool Fill(double amount) => false;
        public bool Empty(double amount) => false;

        private static Infinite_Fillable instance;
        public static IFillable Instance()
        {
            if (instance == null) instance = new Infinite_Fillable();

            return instance;
        }
    }

    class FillableSource : WaterSource, IFillable
    {
        IFillable source;

        public bool IsFull => source.IsFull;

        public bool IsEmpty => source.IsEmpty;

        public FillableSource(double maxGPS, IFillable source) : base(maxGPS)
        {
            this.source = source;
        }

        public bool Empty(double amount)
        {
            return source.Empty(amount);
        }

        public bool Fill(double amount)
        {
            return source.Fill(amount);
        }

        protected override void Timer_tick(object source, EventArgs args)
        {
            if (this.source.IsEmpty) return;
            
            //it can only fill so much of its demand past the maximum output
            double factor = 1;
            if (currentUse > GPS)
            {
                factor = GPS / currentUse;
            }

            //add water to the things
            foreach (IFillable filled in filling.Keys)
            {
                //add water
                double amount = factor * filling[filled] * WaterSource.UpdateTime / 1000;

                this.source.Empty(amount);
                filled.Fill(amount);
                
            }
        }
    }
}//namespace
