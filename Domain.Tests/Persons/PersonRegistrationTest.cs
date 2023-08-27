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
        protected override void When()
        {
            SUT.RegisterNewPerson(new NewPerson { Name = "Test"});
        }
        [Test]
        public void Then_should_register_new_person_event()
        {
            SUT.GetChanges().Any(x => x is PersonEvents.RegisterNewPerson).ShouldBeTrue();
        } 
    }
}
