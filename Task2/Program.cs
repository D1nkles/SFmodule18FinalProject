using YoutubeExplode;

class Program 
{
    static void Main(string[] args) 
    {
        var a = new VideoManager("https://www.youtube.com/watch?v=kEseOTgX7n4");
        test();
        //a.GetVideoInfo();


    }

    static async void test() 
    {
        var youtube = new YoutubeClient();

        // You can specify either the video URL or its ID
        var videoUrl = "https://youtube.com/watch?v=u_yIGGhubZs";
        var video = await youtube.Videos.GetAsync(videoUrl);

        string title = video.Title; // "Collections - Blender 2.80 Fundamentals"
        string author = video.Author.Title; // "Blender"
        string duration = video.Duration.ToString(); // 00:07:20

        Console.WriteLine(title + " " + author + " " + duration);
    }
}