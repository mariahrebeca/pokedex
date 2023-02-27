﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;

namespace Pokedex.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Pokemon bulbasur = new();
        bulbasur.Numero = 1;
        bulbasur.Nome = "Bulbasaur";
        bulbasur.Tipo.Add("Planta");
        bulbasur.Tipo.Add("Venenoso");
        bulbasur.Imagem = "\\img\\pokemons\\001.png";

        var ivysaur = new Pokemon()
        {
            Numero = 1,
            Nome = "Ivysaur",
            Tipo = {"Planta", "Venenoso"},
            Imagem = "\\img\\pokemons\\002.png"
        };
        ViewData["Ivysaur"] = ivysaur;
        return View(bulbasur);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
