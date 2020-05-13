using System;
using Bible.Proxy.Models;
using Microsoft.AspNetCore.Mvc;
using Bible.Proxy.Services.Interfaces;
using Bible.Proxy.Services;

namespace Bible.Proxy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KingJamesVersionController : ControllerBase
    {
        private readonly IKingJamesVersionService _kingJamesVersionService;

        public KingJamesVersionController(IKingJamesVersionService kingJamesVersionService)
        {
            _kingJamesVersionService = kingJamesVersionService;
        }

        [HttpGet]
        public ActionResult<KJVWrapperResponse> GetKingJamesVersion()
        {
            try
            {
                return new KJVWrapperResponse
                {
                    Code = Constants.General.Code,

                    KingJamesVersion = _kingJamesVersionService.GetKingJamesVersion(),
                    
                    Source = $"{Constants.General.KJVPrefixSourceName}"
                };
            }
            catch
            {
                throw new Exception("The version does not exist");
            }
        }
    }
}
