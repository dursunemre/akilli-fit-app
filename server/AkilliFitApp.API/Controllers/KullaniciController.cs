using AkilliFitApp.Application.Interfaces.IService;
using AkilliFitApp.Application.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using AkilliFitApp.Application.DTOs.Kullanici;
using AkilliFitApp.Domain.Entities;

namespace AkilliFitApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KullaniciController : ControllerBase
    {
        protected readonly IKullaniciService _kullaniciService;
        protected readonly IMapper _mapper; 

        public KullaniciController(IKullaniciService kullaniciService, IMapper mapper)
        {
            _kullaniciService = kullaniciService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<KullaniciReadDto>> GetbyIdAsync(int id)
        {
            var read = await _kullaniciService.GetByIdAsync(id);
            var readDto = _mapper.Map<KullaniciReadDto>(read);
            return Ok(readDto);
        }
        
        [HttpPost]
        public async Task<ActionResult<KullaniciReadDto>> CreateAsync([FromBody] KullaniciCreateDto kullaniciCreateDto)
        {
            var create = _mapper.Map<Kullanici>(kullaniciCreateDto);
            var created = await _kullaniciService.AddAsync(create);
            var readDto = _mapper.Map<KullaniciReadDto>(created);
            return Ok(readDto);
        }

        [HttpPut]
        public async Task<ActionResult<KullaniciReadDto>> UpdateAsync([FromBody] KullaniciUpdateDto kullaniciUpdateDto)
        {
            var update = _mapper.Map<Kullanici>(kullaniciUpdateDto);
            var updated = await _kullaniciService.UpdateAsync(update);
            var readDto = _mapper.Map<KullaniciReadDto>(updated);
            return Ok(readDto);
        }

        [HttpDelete]
        public async Task<ActionResult> UpdateAsync([FromBody] KullaniciReadDto kullaniciDeleteDto)
        {
            var delete = _mapper.Map<Kullanici>(kullaniciDeleteDto);
            await _kullaniciService.DeleteAsync(delete);
            return NoContent();
        }
    }
}
