using Akkatecture.Commands;

namespace Cms.Domain.Languages.Commands
{
    public sealed class EnableLanguageCommand : Command<LanguageAggregate, LanguageId>
    {
        public EnableLanguageCommand(LanguageId aggregateId) : base(aggregateId)
        {
        }
    }
}
