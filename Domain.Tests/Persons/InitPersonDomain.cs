using Moq;
using Person.Domain;
using Person.Domain.Events;
using Person.Domain.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tests.Persons
{
    internal static class InitPersonDomain
    {
        public static PersonRegistration CreateSUT()
        {

            var sut = PersonRegistration.Create(It.IsAny<PersonName>());

            return sut;
        }
        public static IList<PersonEvents.DomainEvent> DomainEvents = new List<PersonEvents.DomainEvent>();
    }
}
