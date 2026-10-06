using System;

namespace LearnJave.Models;

public class Quest
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Status { get; set; } = string.Empty;

    // TBD: Should the player connect points through solving tasks?
    // public int TotalPoints { get; set; }

    // navigation property
    public virtual List<QuestTask>? Tasks { get; set; }
}