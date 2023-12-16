using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace ErenyLocalization.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IStringLocalizer<LanguageController> stringLocalizer;

        public LanguageController(IStringLocalizer<LanguageController> stringLocalizer)
        {
            this.stringLocalizer = stringLocalizer;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(stringLocalizer["Welcome"].Value);
        }
    }
}
