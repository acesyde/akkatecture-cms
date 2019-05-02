using Akkatecture.Core;

namespace Cms.Domain.Languages
{
    public sealed class LanguageId : Identity<LanguageId>
    {
        public LanguageId(string value) : base(value)
        {
        }
    }
}
