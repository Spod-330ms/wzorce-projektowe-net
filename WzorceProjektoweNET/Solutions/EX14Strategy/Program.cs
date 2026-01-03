using EX14Strategy;
using EX14Strategy.PictureBrowser;

RedactionBrowser redactionBrowser = new RedactionBrowser();

Console.WriteLine("Set strategy for PictureBrowsing [Pexels/Pixabay]");
string strategy = Console.ReadLine();

strategy = strategy?.Trim().ToLower();

switch (strategy)
{
    case "pixabay":
        // Set the strategy to Pixabay
        redactionBrowser.SetBrowsingStrategy(new PixabayBrowserStrategy());
        break;
    case "pexels":
        // Set the strategy to Pexels
        redactionBrowser.SetBrowsingStrategy(new PexelsBrowserStrategy());
        break;
    default:
        Console.WriteLine("Unsupported strategy");
        return;
}

//Get input for search
Console.WriteLine("Enter search text:");
string searchText = Console.ReadLine();
searchText = searchText?.Trim();

var pictures = redactionBrowser.FindPictures(searchText);
foreach (var pic in pictures)
{
    Console.WriteLine(pic);
}
