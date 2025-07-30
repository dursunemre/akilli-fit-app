using AkilliFitApp.Application.Interfaces.IService;
using AkilliFitApp.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AkilliFitApp.Application.DTOs.Not;

namespace AkilliFitApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EgzersizNotController : ControllerBase
    {
        protected readonly IEgzersizNotService _egzersizNotService;
        protected readonly IMapper _mapper;

        public EgzersizNotController(IEgzersizNotService egzersizNotService, IMapper mapper)
        {
            _egzersizNotService = egzersizNotService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EgzersizNotReadDto>> GetByIdAsync(int id)
        {
            var read = await _egzersizNotService.GetByIdAsync(id);
            var readDto = _mapper.Map<EgzersizNotReadDto>(read);
            return Ok(readDto);
        }

        [HttpGet("ByEgzersizBilgi/{egzersizBilgiId}")]
        public async Task<ActionResult<EgzersizNotReadDto>> GetByEgzersizBilgiIdAsync(int egzersizBilgiId)
        {
            var read = await _egzersizNotService.GetByEgzersizBilgiIdAsync(egzersizBilgiId);
            var readDto = _mapper.Map<EgzersizNotReadDto>(read);
            return Ok(readDto);
        }

        [HttpPost]
        public async Task<ActionResult<EgzersizNotReadDto>> CreateAsync([FromBody] EgzersizNotCreateDto egzersizNotCreateDto)
        {
            var create = _mapper.Map<EgzersizNot>(egzersizNotCreateDto);
            var created = await _egzersizNotService.AddAsync(create);
            var readDto = _mapper.Map<EgzersizNotReadDto>(created);
            return Ok(readDto);
        }

        [HttpPut]
        public async Task<ActionResult<EgzersizNotReadDto>> UpdateAsync([FromBody] EgzersizNotUpdateDto egzersizNotUpdateDto)
        {
            var update = _mapper.Map<EgzersizNot>(egzersizNotUpdateDto);
            var updated = await _egzersizNotService.UpdateAsync(update);
            var readDto = _mapper.Map<EgzersizNotReadDto>(updated);
            return Ok(readDto);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAsync([FromBody] EgzersizNotReadDto egzersizNotDeleteDto)
        {
            var delete = _mapper.Map<EgzersizNot>(egzersizNotDeleteDto);
            await _egzersizNotService.DeleteAsync(delete);
            return NoContent();
        }
    }
}
