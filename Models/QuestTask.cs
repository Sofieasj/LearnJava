using System;

namespace LearnJave.Models;

// A quest is a larger goal, which might consist of sub-tasks QuestTask
public class QuestTask
{
    public int Id { get; set; }
    public int QuestId { get; set; }

    public string Title { get; set; } = string.Empty; //  initializes the Name property with an empty string by default ->  never null, preventing potential null reference issues.
    public TaskType Type { get; set; }
    public int Order { get; set; }
    public string? Description { get; set; }

    // TODO: Legg inn obj med solution
    public int Points { get; set; }

    // Navigation property
    public virtual Quest Quest { get; set; } = null!;
}

public enum TaskType
{
    Quiz,
    CodeSubmission,
    Upload,
    CodeReview
}