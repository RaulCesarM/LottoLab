using LotoCharts.Domain.Entities.Models;
using LotoCharts.Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LotoCharts.API.Controllers
{
    [ApiController]
    [Route("API/Consumo")]
    public class BuscarController : ControllerBase
    {
        private readonly ILotoFacilService _lotoService;
        public BuscarController(ILotoFacilService lotoService)
        {
            _lotoService = lotoService;
        }
    }
}