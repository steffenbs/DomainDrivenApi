using Domain.Common;
using Domain.Common.Interface;
using Person.Domain.Events;
using Person.Domain.Values;
using Person.Models.Requests;

namespace Person.Domain
{
    public sealed class PersonRegistration : AggregateRoot<PersonId>
    {
        public PersonRegistration() {}
        private PersonRegistration(PersonName personName) 
        {
            PersonName = personName;
        }
        public PersonName PersonName { get; set; }
    
        public void ApplyEventsToDomain(IList<PersonEvents.DomainEvent> @events)
        {
            foreach (var @event in @events)
            {
                Apply(@event);
            }
        }

        protected override void EnsureValidState()
        {
            
        }

        protected override void PreValidation(IDomainEvent @event)
        {
            
        }

        protected override void When(IDomainEvent @event)
        {
           switch (@event)
            {
                case PersonEvents.RegisterNewPerson e:
                    PersonName = PersonName.Create(e.Name);
                break;
            }
        }
        public static PersonRegistration Create(PersonName personName)
            => new PersonRegistration(personName);
    }
}