using Akkatecture.Commands;

namespace Cms.Domain.Languages.Commands
{
    public sealed class UpdateLanguageCommand : Command<LanguageAggregate, LanguageId>
    {
        public string Name { get; }
        public string Culture { get; }

        public UpdateLanguageCommand(LanguageId aggregateId, string name, string culture) : base(aggregateId)
        {
            Name = name;
            Culture = culture;
        }
    }
}
