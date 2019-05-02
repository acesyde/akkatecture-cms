using System;

namespace Cms.Api.Controllers.Languages.Models
{
    public class LanguageDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Culture { get; set; }
        public bool IsActive { get; set; }
        public bool IsMaster { get; set; }
    }
}
