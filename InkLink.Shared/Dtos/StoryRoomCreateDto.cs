using System.ComponentModel.DataAnnotations;

namespace InkLink.Shared.Dtos;

public class StoryRoomCreateDto
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [MaxLength(500)]
    public string Description { get; set; }

    [Required]
    public string RoomType { get; set; } // Could be an enum later
}

