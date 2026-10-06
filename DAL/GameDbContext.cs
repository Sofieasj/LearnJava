using LearnJava.Models;
using LearnJave.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;

namespace LearnJava.DAL;

public class GameDbContext : DbContext
{
    public GameDbContext(DbContextOptions<GameDbContext> options) : base(options) { }

    // DB entities
    public DbSet<Player> Players { get; set; }
    public DbSet<Quest> Quests { get; set; }
    public DbSet<QuestTask> QuestTasks { get; set; }
    public DbSet<Treasure> Treasures { get; set; }
    public DbSet<PlayerQuest> PlayerQuests { get; set; }
    public DbSet<TaskCompletion> TaskCompletions { get; set; }

}