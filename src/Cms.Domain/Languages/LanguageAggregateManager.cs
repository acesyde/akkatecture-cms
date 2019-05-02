using Akkatecture.Aggregates;
using Akkatecture.Commands;

namespace Cms.Domain.Languages
{
    public sealed class LanguageAggregateManager : 
        AggregateManager<LanguageAggregate, LanguageId, Command<LanguageAggregate, LanguageId>>
    {
    }
}
