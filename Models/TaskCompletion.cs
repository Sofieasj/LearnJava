namespace LearnJava.Models;

// TBD: Do i actually need this model? I might in some cases need to 
// store what a player has done during a task, but perhaps not always?
public class TaskCompletion
{
    public int Id { get; set; }
    public int PlayerId { get; set; }
    public int TaskId { get; set; }
    public string Status { get; set; } = string.Empty;
    public int Score { get; set; }
    public DateTime SubmittedAt { get; set; }

    // TODO: add answer data
}