namespace Cms.Api.Controllers.Languages.Models
{
    public class CreateDto
    {
        public string Name { get; set; }
        public string Culture { get; set; }
        public bool IsActive { get; set; }
    }
}
