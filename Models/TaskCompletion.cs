namespace LearnJava.Models;

public class TaskCompletion
{
    public int PlayerId { get; set; }
    public int TaskId { get; set; }
    public string Status { get; set; } = string.Empty;
    public int Score { get; set; }
    public DateTime SubmittedAt { get; set; }

    // TODO: add answer data
}