using YoutubeExplode;

class Program 
{
    static void Main(string[] args) 
    {
        var a = new VideoManager("https://www.youtube.com/watch?v=kEseOTgX7n4");
        
        a.GetVideoInfo();
        a.DownloadVideo();

        Console.ReadKey();
    }

    
}