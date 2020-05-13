using System.Linq;
using System.Threading.Tasks;
using Bible.Proxy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bible.Proxy.Services.Interfaces;
using Bible.Proxy.Constants;

namespace Bible.Proxy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnglishStandardVersionController : ControllerBase
    {
        private readonly IEnglishStandardVersionServices _englishStandardVersionServices;

        public EnglishStandardVersionController(IEnglishStandardVersionServices englishStandardVersionServices)
        {
            _englishStandardVersionServices = englishStandardVersionServices;
        }

        [HttpGet]
        public ActionResult<ESVWrapperResponse> GetEnglishStandardVersion()
        {
            try
            {
                return new ESVWrapperResponse
                {
                    Code = General.Code,
                    EnglishStandardVersion = _englishStandardVersionServices.GetEnglishStandardVersion(),
                    Source = $"{General.ESVPrefixSourceName}"
                };
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
