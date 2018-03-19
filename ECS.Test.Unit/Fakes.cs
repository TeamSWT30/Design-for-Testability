using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy;

namespace ECS.Test.Unit
{
    internal class FakeTempSensor : ITempSensor
    {
        public int Temp { get; set; }

        public FakeTempSensor()
        {
            Temp = 0;
        }

        public int GetTemp()
        {
            return Temp;
        }
    }

    internal class FakeHeater : IHeater
    {
        public int TurnOffCalledTimes { get; set; }
        public int TurnOnCalledTimes { get; set; }

        public FakeHeater()
        {
            TurnOffCalledTimes = 0;
            TurnOnCalledTimes = 0;
        }

        public void TurnOn()
        {
            ++TurnOnCalledTimes;
        }



        public void TurnOff()
        {
            ++TurnOffCalledTimes;
        }
    }
}
