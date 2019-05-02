using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Akka.Actor;
using Cms.Domain.Languages;
using Cms.Domain.Languages.Entities;
using Cms.Services.Languages.Requests;

namespace Cms.Services.Languages
{
    public sealed class LanguageService : ILanguageService
    {
        private readonly IActorRef _repository;

        public LanguageService(IActorRef repository)
        {
            _repository = repository;
        }

        public async Task<LanguageEntity> GetByIdAsync(Guid id)
        {
            return await _repository.Ask<LanguageEntity>(new GetLanguageById(LanguageId.With(id)));
        }

        public Task<IReadOnlyList<LanguageEntity>> GetAllAsync(int skip = 0, int take = 25, IQueryable<LanguageEntity> query = null)
        {
            throw new NotImplementedException();
        }
    }
}
