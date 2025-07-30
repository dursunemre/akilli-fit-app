using AkilliFitApp.Application.DTOs.Egzersiz.Program;
using AkilliFitApp.Application.Interfaces.IService;
using AkilliFitApp.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AkilliFitApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EgzersizProgramController : ControllerBase
    {
        protected readonly IEgzersizProgramService _egzersizProgramService;
        protected readonly IMapper _mapper;

        public EgzersizProgramController(IEgzersizProgramService egzersizProgramService, IMapper mapper)
        {
            _egzersizProgramService = egzersizProgramService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EgzersizProgramReadDto>> GetByIdAsync(int id)
        {
            var read = await _egzersizProgramService.GetByIdAsync(id);
            var readDto = _mapper.Map<EgzersizProgramReadDto>(read);
            return Ok(readDto);
        }

        [HttpGet("GetAll/{kullaniciId}")]
        public async Task<ActionResult<IEnumerable<EgzersizProgramReadDto>>> GetAllAsync(int kullaniciId)
        {
            var programs = await _egzersizProgramService.GetAllAsync(kullaniciId);
            var dtoList = _mapper.Map<IEnumerable<EgzersizProgramReadDto>>(programs);
            return Ok(dtoList);
        }

        [HttpPost]
        public async Task<ActionResult<EgzersizProgramReadDto>> CreateAsync([FromBody] EgzersizProgramCreateDto egzersizProgramCreateDto)
        {
            var create = _mapper.Map<EgzersizProgram>(egzersizProgramCreateDto);
            var created = await _egzersizProgramService.AddAsync(create);
            var readDto = _mapper.Map<EgzersizProgramReadDto>(created);
            return Ok(readDto);
        }

        [HttpPut]
        public async Task<ActionResult<EgzersizProgramReadDto>> UpdateAsync([FromBody] EgzersizProgramUpdateDto egzersizProgramUpdateDto)
        {
            var update = _mapper.Map<EgzersizProgram>(egzersizProgramUpdateDto);
            var updated = await _egzersizProgramService.UpdateAsync(update);
            var readDto = _mapper.Map<EgzersizProgramReadDto>(updated);
            return Ok(readDto);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAsync([FromBody] EgzersizProgramReadDto egzersizProgramDeleteDto)
        {
            var delete = _mapper.Map<EgzersizProgram>(egzersizProgramDeleteDto);
            await _egzersizProgramService.DeleteAsync(delete);
            return NoContent();
        }
    }
}
