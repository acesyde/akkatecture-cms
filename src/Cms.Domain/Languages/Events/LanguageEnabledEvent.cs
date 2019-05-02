using Akkatecture.Aggregates;
using Akkatecture.Events;

namespace Cms.Domain.Languages.Events
{
    [EventVersion("LanguageEnabledEvent", 1)]
    public sealed class LanguageEnabledEvent : AggregateEvent<LanguageAggregate, LanguageId>
    {

    }
}
