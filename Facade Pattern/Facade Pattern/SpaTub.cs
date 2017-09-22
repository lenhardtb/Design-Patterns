using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class SpaTub : IFillable
    {
        public readonly double FillLine = 50;
        public readonly double MaxLevel = 60;
        double waterLevel = 0;

        public double WaterLevel
        {
            get { return waterLevel; }
        }

        public readonly WaterSource pipes;
        public readonly WaterSink drains;

        public readonly Jet surfaceFrontJet;
        public readonly Jet surfaceBackJet;
        public readonly Jet bottomFrontJet;
        public readonly Jet bottomBackJet;

        public readonly Lighting internalLights;
        public Lighting roomLights;//only thing provided externally

        public bool IsFull => waterLevel >= FillLine;
        public bool IsEmpty => waterLevel <= 0;

        public SpaTub(WaterSource pipes, WaterSink drains)
        {
            this.pipes = pipes;
            this.drains = drains;
            
            internalLights = new DialLighting();

            //source and output of the jets are the tub
            surfaceFrontJet = new Jet(WaterSource.FromFillable(0.125, this), this, 0.125);
            surfaceBackJet = new Jet(WaterSource.FromFillable(0.125, this), this, 0.125);
            bottomFrontJet = new Jet(WaterSource.FromFillable(0.125, this), this, 0.25);
            bottomBackJet = new Jet(WaterSource.FromFillable(0.125, this), this, 0.25);
        }

        private bool usingAutoFill;
        private double autoFillLimit;

        public void StartFilling()
        {
            StartFilling(FillLine);
        }

        private void StartFilling(double fillLimit)
        {
            StopDraining();
            usingAutoFill = true;
            autoFillLimit = fillLimit;
            pipes.Open(this, pipes.GPS);
        }

        public void StopFilling()
        {
            usingAutoFill = false;
            pipes.Close(this);
        }

        public void StartDraining()
        {
            StopFilling();
            usingAutoFill = true;
            drains.Open(this, drains.GPS);
        }

        public void StopDraining()
        {
            usingAutoFill = false;
            drains.Close(this);
        }

        //this is called by jets too, not just pipes
        public bool Fill(double amount)
        {
            waterLevel += amount;

            //autoFill stops
            if(usingAutoFill && waterLevel > autoFillLimit)
            {
                StopFilling();
            }

            return IsFull;
        }

        //...I'm pretty sure only the drains call this though
        public bool Empty(double amount)
        {
            waterLevel -= amount;
            if (waterLevel < 0) waterLevel = 0;

            //autoFill stops
            if (usingAutoFill && IsEmpty)
            {
                StopFilling();
            }

            return IsFull;
        }
        
        public void StartAllJets()
        {
            bottomBackJet.State = true;
            bottomFrontJet.State = true;
            surfaceBackJet.State = true;
            surfaceFrontJet.State = true;
        }

        public void StopAllJets()
        {
            bottomBackJet.State = false;
            bottomFrontJet.State = false;
            surfaceBackJet.State = false;
            surfaceFrontJet.State = false;
        }

        //this is bad ... I need to figure out | and & operators
        public enum JetPosition { SurfaceFront, SurfaceBack, BottomFront, BottomBack };
        public void FlipJet(JetPosition position)
        {
            if (position == JetPosition.SurfaceFront)
            {
                surfaceFrontJet.State = !surfaceFrontJet.State;
            }
            else if (position == JetPosition.SurfaceBack)
            {
                surfaceBackJet.State = !surfaceBackJet.State;
            }
            else if (position == JetPosition.BottomFront)
            {
                bottomFrontJet.State = !bottomFrontJet.State;
            }
            else if (position == JetPosition.BottomBack)
            {
                bottomBackJet.State = !bottomBackJet.State;
            }
        }

        //yes these have really pretentious names
        public enum Preset { Relaxation, Wakefulness, Night, Full, Basic }
        public void UseSetting(Preset set)
        {
            //most presets don't use most jets. The only one that does turns them all on.
            StopAllJets();

            //lie back and enjoy
            if (set == Preset.Relaxation)
            {
                StartFilling(FillLine * 9 / 10);

                FlipJet(JetPosition.SurfaceFront);
                FlipJet(JetPosition.SurfaceBack);
            }
            //ready for the morning
            else if(set == Preset.Wakefulness)
            {
                StartFilling(FillLine * 9 / 10);

                FlipJet(JetPosition.BottomFront);
                FlipJet(JetPosition.BottomBack);
            }
            //calm, dark and slightly overfilled for a nighttime bath
            else if(set == Preset.Night)
            {
                StartFilling(FillLine * 11 / 10);

                if (roomLights != null)
                    roomLights.Power = Lighting.OFF;

                //about a third
                internalLights.Power = Lighting.MIDPOINT * 3 / 10;
            }
            //activates most features; fills and turns on all jets, all lights on full
            else if(set == Preset.Full)
            {
                StartFilling();

                StartAllJets();

                if (roomLights != null)
                    roomLights.Power = Lighting.ON;
                internalLights.Power = Lighting.ON;
            }
            //no jets, just fills and turns on the lights that keep you from dying
            else if(set == Preset.Basic)
            {
                StartFilling();
                
                internalLights.Power = Lighting.ON;
            }
        }//UseSetting()
    }//class(SpaTub)
}//namespace
