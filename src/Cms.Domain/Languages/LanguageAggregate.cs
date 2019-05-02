using Akkatecture.Aggregates;

namespace Cms.Domain.Languages
{
    public sealed class LanguageAggregate : AggregateRoot<LanguageAggregate,LanguageId, LanguageState>
    {
        public LanguageAggregate(LanguageId id) : base(id)
        {
        }
    }
}