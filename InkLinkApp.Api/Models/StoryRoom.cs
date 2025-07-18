using System;

namespace InkLink.Server.Models;

public class StoryRoom
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string RoomType { get; set; } // e.g. "Prompt Playground", "Lore Lab"
    public DateTime CreatedAt { get; set; }
}

