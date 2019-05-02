using Akkatecture.Aggregates;
using Akkatecture.Events;

namespace Cms.Domain.Languages.Events
{
    [EventVersion("LanguageCreatedEvent", 1)]
    public sealed class LanguageCreatedEvent : AggregateEvent<LanguageAggregate, LanguageId>
    {
        public string Name { get; }
        public string Culture { get; }
        public bool IsActive { get; }

        public LanguageCreatedEvent(string name, string culture, bool isActive)
        {
            Name = name;
            Culture = culture;
            IsActive = isActive;
        }
    }
}
