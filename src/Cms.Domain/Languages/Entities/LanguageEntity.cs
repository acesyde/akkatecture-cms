using Akkatecture.Entities;

namespace Cms.Domain.Languages.Entities
{
    public sealed class LanguageEntity : Entity<LanguageId>
    {
        public string Name { get; set; }
        public string Culture { get; set; }
        public bool IsActive { get; set; }
        public bool IsMaster { get; set; }

        public LanguageEntity(LanguageId id) : base(id)
        {
        }
    }
}
