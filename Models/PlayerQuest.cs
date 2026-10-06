using LearnJave.Models;

namespace LearnJava.Models;

// som koblingstabell mellom Player og Quest
public class PlayerQuest
{
    public int Id { get; set; }
    public int PlayerId { get; set; }
    public int QuestId { get; set; }
    public string Status { get; set; } = string.Empty;

    // TBD: Not yet certain if start and end times are relevant, but in case:
    // public DateTime StartedAt { get; set; }
    // public DateTime EndedAt { get; set; }

    // navigation property
    public virtual Player Player { get; set; } = default!;
    public virtual Quest Quest { get; set; } = default!;
}