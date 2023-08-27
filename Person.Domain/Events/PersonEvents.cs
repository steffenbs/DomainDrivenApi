using Domain.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person.Domain.Events
{
    public static class PersonEvents
    { 
        public abstract class DomainEvent : IDomainEvent
        {
            public int Priority => 0;
        }
        public class RegisterNewPerson : DomainEvent
        {
            public string Name { get; set; }
        }
    }
}
