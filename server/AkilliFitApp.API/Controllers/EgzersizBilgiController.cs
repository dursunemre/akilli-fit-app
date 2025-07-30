using AkilliFitApp.Application.Interfaces.IService;
using AkilliFitApp.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AkilliFitApp.Application.DTOs.EgzersizBilgi;

namespace AkilliFitApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EgzersizBilgiController : ControllerBase
    {
        protected readonly IEgzersizBilgiService _egzersizBilgiService;
        protected readonly IMapper _mapper;

        public EgzersizBilgiController(IEgzersizBilgiService egzersizBilgiService, IMapper mapper)
        {
            _egzersizBilgiService = egzersizBilgiService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EgzersizBilgiReadDto>> GetByIdAsync(int id)
        {
            var read = await _egzersizBilgiService.GetByIdAsync(id);
            var readDto = _mapper.Map<EgzersizBilgiReadDto>(read);
            return Ok(readDto);
        }

        [HttpGet("GetAll/{egzersizProgramId}")]
        public async Task<ActionResult<IEnumerable<EgzersizBilgiReadDto>>> GetAllAsync(int egzersizProgramId)
        {
            var list = await _egzersizBilgiService.GetAllAsync(egzersizProgramId);
            var dtoList = _mapper.Map<IEnumerable<EgzersizBilgiReadDto>>(list);
            return Ok(dtoList);
        }

        [HttpPost]
        public async Task<ActionResult<EgzersizBilgiReadDto>> CreateAsync([FromBody] EgzersizBilgiCreateDto egzersizBilgiCreateDto)
        {
            var create = _mapper.Map<EgzersizBilgi>(egzersizBilgiCreateDto);
            var created = await _egzersizBilgiService.AddAsync(create);
            var readDto = _mapper.Map<EgzersizBilgiReadDto>(created);
            return Ok(readDto);
        }

        [HttpPut]
        public async Task<ActionResult<EgzersizBilgiReadDto>> UpdateAsync([FromBody] EgzersizBilgiUpdateDto egzersizBilgiUpdateDto)
        {
            var update = _mapper.Map<EgzersizBilgi>(egzersizBilgiUpdateDto);
            var updated = await _egzersizBilgiService.UpdateAsync(update);
            var readDto = _mapper.Map<EgzersizBilgiReadDto>(updated);
            return Ok(readDto);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAsync([FromBody] EgzersizBilgiReadDto egzersizBilgiDeleteDto)
        {
            var delete = _mapper.Map<EgzersizBilgi>(egzersizBilgiDeleteDto);
            await _egzersizBilgiService.DeleteAsync(delete);
            return NoContent();
        }
    }
}
