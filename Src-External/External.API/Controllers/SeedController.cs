

using System.Threading;
using External.Domain.Entities.Models;
using External.Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace External.API.Controllers
{
    [ApiController]
    [Route("API/Seed")]
    public class SeedController : ControllerBase
    {
        private readonly ILotoFacilService _lotoService;
        private readonly ILotoFacilFeedService _FeedService;
        public SeedController(ILotoFacilService lotoService, ILotoFacilFeedService FeedService)
        {
            _lotoService = lotoService;
            _FeedService = FeedService;
        }

        [HttpPost]
        public async Task<int> Consumption()
        {
            try
            {
                var cancellationTokenSource = new CancellationTokenSource();
                cancellationTokenSource.Cancel(false);
                var final = await _FeedService.CheckLast();
                return final;

            }
            catch (Exception e)
            {
                throw new Exception("erro", e);
            }
        }

    }
}