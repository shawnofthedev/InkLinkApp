using Microsoft.AspNetCore.Mvc;
using InkLink.Shared.Dtos;
using InkLink.Api.Data;
using InkLink.Api.Models;

namespace InkLink.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoryRoomController : ControllerBase
    {
        private readonly InkLinkDbContext _context;

        public StoryRoomController(InkLinkDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllRooms()
        {
            var rooms = _context.StoryRooms.ToList();
            return Ok(rooms);
        }

        [HttpGet("{id}")]
        public IActionResult GetRoomById(Guid id)
        {
            var room = _context.StoryRooms.Find(id);
            if (room == null) return NotFound();
            return Ok(room);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom([FromBody] StoryRoomCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var room = new StoryRoom
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Description = dto.Description,
                RoomType = dto.RoomType,
                CreatedAt = DateTime.UtcNow
            };

            _context.StoryRooms.Add(room);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRoomById), new { id = room.Id }, room);
        }
    }
}
