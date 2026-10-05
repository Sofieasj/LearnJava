using System;

namespace LearnJave.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Name { get; set; } = string.Empty; //  initializes the Name property with an empty string by default ->  never null, preventing potential null reference issues.
        public string? Description { get; set; }
        public int Points { get; set; }
    }
}