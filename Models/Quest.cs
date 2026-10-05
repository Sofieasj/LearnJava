using System;

namespace LearnJave.Models;

public class Quest
{
    public int QuestId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int TotalPoints { get; set; }
}