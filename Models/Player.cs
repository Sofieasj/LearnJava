using System;
using LearnJava.Models;

namespace LearnJave.Models;

public class Player
{
    public int PlayerId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    // TBD: Tracking what quest and quest task a player is currently at
    //public int QuestLevel { get; set; }
    //public int QuestTaskLevel { get; set; }

    // navigation properties to other model classes
    public virtual List<PlayerQuest>? PlayerQuest { get; set; }
    public virtual List<TaskCompletion>? TaskCompletion { get; set; }
}