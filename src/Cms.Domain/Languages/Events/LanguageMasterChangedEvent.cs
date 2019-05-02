using Akkatecture.Aggregates;
using Akkatecture.Events;

namespace Cms.Domain.Languages.Events
{
    [EventVersion("LanguageMasterChangedEvent", 1)]
    public sealed class LanguageMasterChangedEvent : AggregateEvent<LanguageAggregate, LanguageId>
    {
    }
}
