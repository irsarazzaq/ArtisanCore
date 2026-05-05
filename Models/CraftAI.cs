namespace ArtistryHub.Models;

public class CraftAI 
{
    public string ItemName { get; set; } = string.Empty;
    public string Difficulty { get; set; } = "Intermediate";
    public string PrimaryMedium { get; set; } = "Mixed Media"; // Medium (Oil, Acrylic, Yarn)
    public string DailyGoal { get; set; } = "1.5 Hours";
    public string ProTip { get; set; } = "Start with a light sketch.";
    public int TotalDays { get; set; } = 5;
}