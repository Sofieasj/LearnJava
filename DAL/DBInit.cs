using LearnJave.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnJava.DAL;

public class DBInit
{
    public static void Seed(IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        var context = serviceScope.ServiceProvider.GetRequiredService<GameDbContext>();

        // Migration - creates/updates the schema
        context.Database.Migrate();

        // Everything is seeded together, so if Quests exist -> the seed has already run
        if (context.QuestTasks.Any()) return;

        var quest = new Quest
        {
            Title = "Test",
            Description = "bla bla",
            Tasks = new List<QuestTask>
            {
                new QuestTask { }
            }
        };

        context.Add(quest);
        context.SaveChanges();
    }
}