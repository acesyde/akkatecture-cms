using Akkatecture.Commands;

namespace Cms.Domain.Languages.Commands
{
    public class ChangeMasterLanguageCommand : Command<LanguageAggregate, LanguageId>
    {
        public ChangeMasterLanguageCommand(LanguageId aggregateId) : base(aggregateId)
        {
        }
    }
}
