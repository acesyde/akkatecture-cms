using Akkatecture.Aggregates;
using Akkatecture.Events;

namespace Cms.Domain.Languages.Events
{
    [EventVersion("LanguageUpdatedEvent", 1)]
    public sealed class LanguageUpdatedEvent : AggregateEvent<LanguageAggregate, LanguageId>
    {
        public string Name { get; }
        public string Culture { get; }

        public LanguageUpdatedEvent(string name, string culture)
        {
            Name = name;
            Culture = culture;
        }
    }
}
