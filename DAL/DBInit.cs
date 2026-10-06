using LearnJave.Models;
using Microsoft.VisualBasic;

namespace LearnJava.Models;

public class DBInit
{
    public static void Seed(IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        var context = serviceScope.ServiceProvider.GetRequiredService<QuestDbContext>();

        // Migration - creates/updates the schema
        context.Database.Migrate();

        // Everything is seeded together, so if Quests exist -> the seed has already run
        if (context.QuestTask.Any()) return;

        new Quest
        {
            Title = "Test",
            Description = "bla bla",
            TotalPoints = 10,
            Tasks =
            {
                new QuestTask { Title = "Test 1", Type = TaskType.Quiz, Order = 1, Points = 5 },
                new QuestTask { Title = "Test 2", Type = TaskType.CodeSubmission, Order = 2, Points = 5 }
            }
        };
    }
}