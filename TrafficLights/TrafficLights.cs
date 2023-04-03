using System;
using System.Drawing;

namespace TrafficLights
{
    class TrafficLights
    {
        private const int countOfLamps = 4;
        private Lamp[] lamps;
        private uint activeLamp;
        private Graphics graphics;

        public bool IsNight { get; set; }

        public TrafficLights(Graphics gr, uint activeNo = 0)
        {
            graphics = gr;
            activeLamp = activeNo;
            lamps = new Lamp[countOfLamps]
            {
                new Lamp(30, 30, Color.Red, 5000),
                new Lamp(30, 160, Color.Yellow, 1000),
                new Lamp(30, 290, Color.Green, 5000),
                null
            };
            lamps[3] = lamps[1];
            lamps[activeLamp].SwitchOn();
            IsNight = false;
        }

        public void ChangeLamp()
        {
            if (IsNight)
            {
                lamps[activeLamp].SwitchOff().Draw(graphics);
                activeLamp = ++activeLamp % countOfLamps;
                if (activeLamp == 1 || activeLamp == 3) lamps[activeLamp].SwitchOn().Draw(graphics);
            }
            else
            {
                lamps[activeLamp].SwitchOff().Draw(graphics);
                activeLamp = ++activeLamp % countOfLamps;
                lamps[activeLamp].SwitchOn().Draw(graphics);
            }        
        }

        public void Draw()
        {
            for(uint i = 0; i < countOfLamps - 1; ++i)
                lamps[i].Draw(graphics);
        }

        public int GetInterval()
        {
            return (int)lamps[activeLamp].Period;
        }

        public void SetInterval(int k, uint p)
        {
            lamps[k].Period = p;
        }


    }
}
