using Cms.Domain.Languages;

namespace Cms.Services.Languages.Requests
{
    public class GetLanguageById
    {
        public LanguageId Id { get; }

        public GetLanguageById(LanguageId id)
        {
            Id = id;
        }
    }
}
