using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Test.Unit
{
    [TestFixture]
    public class ECSUnitTests
    {
        private FakeTempSensor _fakeTempSensor;
        private FakeHeater _fakeHeater;
        private Legacy.ECS _uut;

        [SetUp]
        public void Setup()
        {
            _fakeTempSensor = new FakeTempSensor();
            _fakeHeater = new FakeHeater();
            _uut = new Legacy.ECS(27, _fakeTempSensor, _fakeHeater);
        }

        [Test]

        public void Regulate_TempIsLower_HeaterIsOn()
        {
            _fakeTempSensor.Temp = 25;
            _uut.Regulate();
            
            Assert.That(_fakeHeater.TurnOnCalledTimes, Is.EqualTo(1));
        }

        [Test]

        public void Regulate_TempIsHigher_HeaterIsOff()
        {
            _fakeTempSensor.Temp = 29;
            _uut.Regulate();

            Assert.That(_fakeHeater.TurnOffCalledTimes, Is.EqualTo(1));
        }
    }
}
