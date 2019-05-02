using Akkatecture.Commands;

namespace Cms.Domain.Languages.Commands
{
    public sealed class DisableLanguageCommand : Command<LanguageAggregate, LanguageId>
    {
        public DisableLanguageCommand(LanguageId aggregateId) : base(aggregateId)
        {
        }
    }
}
