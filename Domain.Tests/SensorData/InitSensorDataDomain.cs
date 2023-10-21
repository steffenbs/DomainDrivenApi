using SensorData.Domain.MoistureSensors;
using SensorData.Domain.MoistureSensors.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tests.SensorData
{
    internal static class InitSensorDataDomain
    {
        public static MoistureSensorId MOISTUREDATAID = MoistureSensorId.Create(0);
        public static MoistureSensor InitMoistureSensor()
        {
            var SUT = MoistureSensor.Create(MOISTUREDATAID);
            return SUT;
        }
    }
}
