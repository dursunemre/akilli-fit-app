using AkilliFitApp.Application.DTOs;
using AkilliFitApp.Application.Mapping;
using AkilliFitApp.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AkilliFitApp.Application.Interfaces.IService;


namespace AkilliFitApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class GenericCrudController<TEntity, TCreateDto, TReadDto, TUpdateDto> 
        : ControllerBase
        where TEntity : class
    {
        protected readonly IGenericService<TEntity> _service = null!;
        protected readonly IMapper _mapper = null!;

        protected GenericCrudController(IGenericService<TEntity> service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        
        [HttpPost]
        public virtual async Task<ActionResult<TReadDto>> Create([FromBody] TCreateDto createDto)
        {
            var entity = _mapper.Map<TEntity>(createDto);

            var created = await _service.AddAsync(entity);

            var readDto = _mapper.Map<TReadDto>(created);

            var idProp = readDto!.GetType().GetProperty("Id")!.GetValue(readDto);
            
            return CreatedAtAction(
                nameof(GetById),
                new { id = idProp },
                readDto
            );
        }

        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TReadDto>>> GetAll()
        {
            var entities = await _service.GetAllAsync();
            var readDtos = _mapper.Map<IEnumerable<TReadDto>>(entities);
            
            return Ok(readDtos);
        }


        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TReadDto>> GetById( int id )
        {
            var entity = await _service.GetByIdAsync(id);

            if(entity == null)
            {
                return NotFound();
            }

            var readDto = _mapper.Map<TReadDto>(entity);

            return readDto;
        }

        [HttpPut]
        public virtual async Task<ActionResult<TReadDto>> Update([FromBody] TUpdateDto updateDto)
        {
            var entity = _mapper.Map<TEntity>(updateDto);
            var updated = await _service.UpdateAsync(entity);
            var readDto = _mapper.Map<TReadDto>(updated);

            return Ok(readDto);
        }

        [HttpDelete]
        public virtual async Task<ActionResult> Delete([FromBody] TReadDto deleteDto)
        {
            var idProp = typeof(TReadDto).GetProperty("Id");
            if (idProp == null)
            {
                return BadRequest("Id property not found in DTO.");
            }

            var idValue = idProp.GetValue(deleteDto);
            if (idValue == null)
            {
                return BadRequest("Id value is null.");
            }

            var entity = await _service.GetByIdAsync((int)idValue);
            if (entity == null)
            {
                return NotFound();
            }

            await _service.DeleteAsync(entity);

            return NoContent();
        }
    }
}
