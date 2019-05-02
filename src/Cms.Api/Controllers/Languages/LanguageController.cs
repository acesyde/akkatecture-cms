using Akkatecture.Akka;
using Cms.Domain.Languages;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Api.Controllers.Languages
{
    [Route("api/languages")]
    [ApiExplorerSettings(GroupName = nameof(Languages))]
    public class LanguageController : BaseController<LanguageAggregateManager>
    {
        public LanguageController(ActorRefProvider<LanguageAggregateManager> manager)
            : base(manager)
        {
        }
    }
}
