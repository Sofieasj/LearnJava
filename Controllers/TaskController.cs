using LearnJava.DAL;
using Microsoft.AspNetCore.Mvc;

namespace LearnJava.Controllers;

public class TaskController : Controller
{
    private readonly GameDbContext _gameDbContext;

    public TaskController(GameDbContext gameDbContext)
    {
        _gameDbContext = gameDbContext;
    }
}