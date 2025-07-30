using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using AkilliFitApp.Application.DTOs.Egzersiz;
using AkilliFitApp.Application.Interfaces.IService;

namespace AkilliFitApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EgzersizController : ControllerBase
    {
        private readonly IEgzersizService _egzersizService;
        private readonly IMapper _mapper;

        public EgzersizController(IEgzersizService egzersizService, IMapper mapper)
        {
            _egzersizService = egzersizService;
            _mapper = mapper;
        }

        [HttpGet("GetByTip")]
        public async Task<ActionResult<IEnumerable<EgzersizReadDto>>> GetByTip([FromQuery] string tip)
        {
            var egzersizler = await _egzersizService.GetAllByTipAsync(tip);
            var dtoList = _mapper.Map<IEnumerable<EgzersizReadDto>>(egzersizler);
            return Ok(dtoList);
        }
    }
}
