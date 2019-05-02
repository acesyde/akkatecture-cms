using System;
using Akka.Actor;
using Cms.Services.Languages.Requests;

namespace Cms.Services.MongoDb.Languages
{
    public class LanguageRepository : ReceiveActor
    {
        public LanguageRepository()
        {
            Receive<GetLanguageById>(Handle);
        }

        private bool Handle(GetLanguageById query)
        {
            throw new NotImplementedException();
        }
    }
}
