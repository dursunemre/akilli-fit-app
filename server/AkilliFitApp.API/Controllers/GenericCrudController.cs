using AkilliFitApp.Application.DTOs;
using AkilliFitApp.Application.Mapping;
using AkilliFitApp.Application.Interfaces;
using AkilliFitApp.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;


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
        /*
        [HttpPost]
        public virtual async Task<ActionResult<TReadDto>> Create([FromBody] TCreateDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);

            var created = await _service.AddAsync(entity);

            var readDto = _mapper.Map<TReadDto>(created);

            var idProp = readDto!.GetType().GetProperty("Id")!.GetValue(readDto);
            return CreatedAtAction(
                nameof(GetById),
                new { id = idProp },
                readDto
            );
        }*/

    }
}
