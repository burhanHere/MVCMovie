using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCMovie.Data;
using MVCMovie.Models;

namespace MVCMovie.Controllers;

public class HomeController(MVCMovieDbContext context) : Controller
{
    private readonly MVCMovieDbContext _context = context;
    public IActionResult Index()
    {
        return View();
    }
    public async Task<IActionResult> MovieList()
    {
        List<Movie> MyMoviesList = await _context.Movies.ToListAsync<Movie>();
        return View(MyMoviesList);
    }
    
    // public async Task<IActionResult> MovieList(string SearchInput)
    // {
    //     List<Movie> MyMoviesList = await _context.Movies.ToListAsync<Movie>();
    //     MyMoviesList = MyMoviesList.Where(x => x.Title == SearchInput || x.Title.Contains(SearchInput)).ToList<Movie>();
    //     return View(MyMoviesList);
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

