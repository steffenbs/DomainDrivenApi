using NUnit.Framework;
using Person.Domain;
using Person.Models.Requests;
using SpecsFor.Core;
using SpecsFor.StructureMap;
using System;
using Should;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Person.Domain.Events;

namespace Domain.Tests.Persons
{
    public class PersonRegistrationTest : SpecsFor<PersonRegistration>
    {
        protected override void InitializeClassUnderTest()
        {
            SUT = InitPersonDomain.CreateSUT();
        }
        protected override void When()
        {
            const string PersonName = "Test";
            var events = InitPersonDomain.DomainEvents;
            events.Add(new PersonEvents.RegisterNewPerson{ Name = PersonName });
            
            SUT.ApplyEventsToDomain(events);
        }
        [Test]
        public void Then_should_register_new_person_event()
        {
            SUT.GetChanges().Any(x => x is PersonEvents.RegisterNewPerson).ShouldBeTrue();
        }
        [Test]
        public void Then_name_should_be_applied_to_domain_object()
        {
            SUT.PersonName.Property.ShouldEqual("Test");
        }
    }
}
