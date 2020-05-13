using Bible.Proxy.Models;
using Microsoft.AspNetCore.Mvc;
using Bible.Proxy.Services.Interfaces;
using Bible.Proxy.Constants;

namespace Bible.Proxy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmericanStandardVersionController : ControllerBase
    {
        private readonly IAmericanStandardVersionService _americanStandardVersionService;

        public AmericanStandardVersionController(IAmericanStandardVersionService americanStandardVersionService)
        {
            _americanStandardVersionService = americanStandardVersionService;
        }

        [HttpGet]
        public ActionResult<ASVWrapperResponse> GetAmericanStandardVersion()
        {
            try
            {
                return new ASVWrapperResponse
                {
                    Code = General.Code,

                    AmericanStandardVersion = _americanStandardVersionService.GetAmericanStandardVersion(),

                    Source = $"{General.ASVPrefixSourceName}"
                };
            }
            catch
            {
                throw new System.Exception();
            }
        }
    }
}
