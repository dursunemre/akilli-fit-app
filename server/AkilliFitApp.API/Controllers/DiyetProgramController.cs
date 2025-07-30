using AkilliFitApp.Application.Interfaces.IService;
using AkilliFitApp.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AkilliFitApp.Application.DTOs.Diyet.Program;

namespace AkilliFitApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiyetProgramController : ControllerBase
    {
        private readonly IDiyetProgramService _diyetProgramService;
        private readonly IMapper _mapper;

        public DiyetProgramController(IDiyetProgramService diyetProgramService, IMapper mapper)
        {
            _diyetProgramService = diyetProgramService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DiyetProgramReadDto>> GetByIdAsync(int id)
        {
            var program = await _diyetProgramService.GetByIdAsync(id);
            if (program == null)
                return NotFound();

            var readDto = _mapper.Map<DiyetProgramReadDto>(program);
            return Ok(readDto);
        }

        [HttpGet("GetAll/{kullaniciId}")]
        public async Task<ActionResult<IEnumerable<DiyetProgramReadDto>>> GetAllAsync(int kullaniciId)
        {
            var list = await _diyetProgramService.GetAllAsync(kullaniciId);
            var dtoList = _mapper.Map<IEnumerable<DiyetProgramReadDto>>(list);
            return Ok(dtoList);
        }

        [HttpPost]
        public async Task<ActionResult<DiyetProgramReadDto>> CreateAsync([FromBody] DiyetProgramCreateDto createDto)
        {
            var program = _mapper.Map<DiyetProgram>(createDto);
            var created = await _diyetProgramService.AddAsync(program);
            var readDto = _mapper.Map<DiyetProgramReadDto>(created);
            return Ok(readDto);
        }

        [HttpPut]
        public async Task<ActionResult<DiyetProgramReadDto>> UpdateAsync([FromBody] DiyetProgramUpdateDto updateDto)
        {
            var program = _mapper.Map<DiyetProgram>(updateDto);
            var updated = await _diyetProgramService.UpdateAsync(program);
            var readDto = _mapper.Map<DiyetProgramReadDto>(updated);
            return Ok(readDto);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAsync([FromBody] DiyetProgramReadDto deleteDto)
        {
            var program = _mapper.Map<DiyetProgram>(deleteDto);
            await _diyetProgramService.DeleteAsync(program);
            return NoContent();
        }
    }
}

