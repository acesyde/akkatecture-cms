using Akkatecture.Aggregates;
using Akkatecture.Akka;
using Microsoft.AspNetCore.Mvc;

namespace Cms.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public abstract class BaseController<TManager> : Controller where TManager : IAggregateManager
    {
        public ActorRefProvider<TManager> Manager { get; }

        protected BaseController(ActorRefProvider<TManager> manager)
        {
            Manager = manager;
        }
    }
}
