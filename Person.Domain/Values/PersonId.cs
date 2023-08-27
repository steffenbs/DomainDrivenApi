using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Domain.Values
{
    public sealed class PersonId : Value<PersonId, int>
    {
        private PersonId(int property) : base(property)
        {
        }
        public PersonId Create(int value) => new PersonId(value);
    }
}
