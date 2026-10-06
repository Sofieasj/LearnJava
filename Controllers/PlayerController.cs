using LearnJava.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LearnJava.Controllers;

// A class to handle browser requests, retireve/modify data 
// (by invoking model logic), call view templates and return responses
public class PlayerController : Controller
{
    private readonly GameDbContext _gameDbContext;

    public PlayerController(GameDbContext gameDbContext)
    {
        _gameDbContext = gameDbContext;
    }

    // TODO: Return Profil view

    // TODO: Player creation form

    // TODO: Get player by ID

    // TODO: Get a list of all players
}