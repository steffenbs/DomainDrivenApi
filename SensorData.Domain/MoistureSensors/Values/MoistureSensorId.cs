using Domain.Common;

namespace SensorData.Domain.MoistureSensors.Values
{
    public class MoistureSensorId : Value<MoistureSensorId, int>
    {
        private MoistureSensorId(int property) : base(property)
        {
        }

        public static MoistureSensorId Create(int id)
            => new MoistureSensorId(id);
    }
}
