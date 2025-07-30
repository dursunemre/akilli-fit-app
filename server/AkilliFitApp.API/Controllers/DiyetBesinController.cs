using AkilliFitApp.Application.Interfaces.IService;
using AkilliFitApp.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AkilliFitApp.Application.DTOs.Diyet.Besin;

namespace AkilliFitApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiyetBesinController : ControllerBase
    {
        private readonly IDiyetBesinService _diyetBesinService;
        private readonly IMapper _mapper;

        public DiyetBesinController(IDiyetBesinService diyetBesinService, IMapper mapper)
        {
            _diyetBesinService = diyetBesinService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DiyetBesinReadDto>> GetByIdAsync(int id)
        {
            var besin = await _diyetBesinService.GetByIdAsync(id);
            if (besin == null)
                return NotFound();

            var readDto = _mapper.Map<DiyetBesinReadDto>(besin);
            return Ok(readDto);
        }

        [HttpGet("GetAll/{diyetProgramId}")]
        public async Task<ActionResult<IEnumerable<DiyetBesinReadDto>>> GetAllAsync(int diyetProgramId)
        {
            var list = await _diyetBesinService.GetAllAsync(diyetProgramId);
            var dtoList = _mapper.Map<IEnumerable<DiyetBesinReadDto>>(list);
            return Ok(dtoList);
        }

        [HttpPost]
        public async Task<ActionResult<DiyetBesinReadDto>> CreateAsync([FromBody] DiyetBesinCreateDto createDto)
        {
            var entity = _mapper.Map<DiyetBesin>(createDto);
            var created = await _diyetBesinService.AddAsync(entity);
            var readDto = _mapper.Map<DiyetBesinReadDto>(created);
            return Ok(readDto);
        }

        [HttpPut]
        public async Task<ActionResult<DiyetBesinReadDto>> UpdateAsync([FromBody] DiyetBesinUpdateDto updateDto)
        {
            var entity = _mapper.Map<DiyetBesin>(updateDto);
            var updated = await _diyetBesinService.UpdateAsync(entity);
            var readDto = _mapper.Map<DiyetBesinReadDto>(updated);
            return Ok(readDto);
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAsync([FromBody] DiyetBesinReadDto deleteDto)
        {
            var entity = _mapper.Map<DiyetBesin>(deleteDto);
            await _diyetBesinService.DeleteAsync(entity);
            return NoContent();
        }
    }
}
