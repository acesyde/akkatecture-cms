using Akkatecture.Aggregates;
using Akkatecture.Events;

namespace Cms.Domain.Languages.Events
{
    [EventVersion("LanguageDisabledEvent", 1)]
    public sealed class LanguageDisabledEvent : AggregateEvent<LanguageAggregate, LanguageId>
    {
    }
}
