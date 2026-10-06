using LearnJava.DAL;
using Microsoft.AspNetCore.Mvc;

namespace LearnJava.Controllers;

public class QuestController : Controller
{
    private readonly GameDbContext _gameDbContext;

    public QuestController(GameDbContext gameDbContext)
    {
        _gameDbContext = gameDbContext;
    }
}