using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Domain.Values
{
    public sealed class PersonName : Value<PersonName, string>
    {
        private PersonName(string property) : base(property)
        {

        }
        public static PersonName Create(string input) => new PersonName(input);
    }
}
