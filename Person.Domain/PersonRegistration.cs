using Domain.Common;
using Domain.Common.Interface;
using Person.Domain.Events;
using Person.Domain.Values;
using Person.Models.Requests;

namespace Person.Domain
{
    public sealed class PersonRegistration : AggregateRoot<PersonId>
    {
        public PersonName PersonName { get; set; }
        public void RegisterNewPerson(NewPerson p)
        {
            Apply(new PersonEvents.RegisterNewPerson
            {
                Name = p.Name
            });
        }

        protected override void EnsureValidState()
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
    }
}