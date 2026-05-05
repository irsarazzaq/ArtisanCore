using Microsoft.AspNetCore.Mvc;
using ArtistryHub.Models;

namespace ArtistryHub.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(new CraftAI());
    }

    [HttpPost]
    public IActionResult Analyze(string itemName)
    {
        var result = new CraftAI { ItemName = itemName };
        string lowerItem = itemName.ToLower();

        // Universal Logic for different Art types
        if (lowerItem.Contains("painting") || lowerItem.Contains("sketch"))
        {
            result.PrimaryMedium = "Canvas & Acrylics/Oils";
            result.Difficulty = "High (Requires focus)";
            result.DailyGoal = "2 Hours (Layering)";
            result.ProTip = "Focus on the perspective before adding colors.";
            result.TotalDays = 7;
        }
        else if (lowerItem.Contains("crochet") || lowerItem.Contains("wool"))
        {
            result.PrimaryMedium = "Yarn & Hook";
            result.Difficulty = "Moderate";
            result.DailyGoal = "1 Hour";
            result.ProTip = "Keep your tension consistent for a clean finish.";
            result.TotalDays = 4;
        }
        else 
        {
            result.PrimaryMedium = "Mixed Media / Digital";
            result.Difficulty = "Varies";
            result.DailyGoal = "1.5 Hours";
            result.ProTip = "Experiment with textures to make it unique.";
            result.TotalDays = 5;
        }
        
        return View("Index", result);
    }
}