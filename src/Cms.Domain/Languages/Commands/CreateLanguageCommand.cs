using Akkatecture.Commands;

namespace Cms.Domain.Languages.Commands
{
    public sealed class CreateLanguageCommand : Command<LanguageAggregate, LanguageId>
    {
        public string Name { get; }
        public string Culture { get; }
        public bool IsActive { get; }

        public CreateLanguageCommand(LanguageId aggregateId, string name, string culture, bool isActive) : base(aggregateId)
        {
            Name = name;
            Culture = culture;
            IsActive = isActive;
        }
    }
}
