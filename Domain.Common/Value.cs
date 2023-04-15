using System.Reflection.Metadata;

namespace Domain.Common
{
    public class Value<T, TObject>
    {
        public TObject Property { get; private set; }

        public Value(TObject property)
        {
            Property = property;
        }
    }
}