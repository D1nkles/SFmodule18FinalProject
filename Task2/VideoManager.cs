using YoutubeExplode;
using YoutubeExplode.Converter;

class VideoManager
{
    YoutubeClient youtubeClient;
    string _videoURL;

    public VideoManager(string videoURL)
    {
        _videoURL = videoURL;
        youtubeClient = new YoutubeClient();
    }

    public async void GetVideoInfo() 
    {
        var videoDescription = await youtubeClient.Videos.GetAsync(_videoURL);
        string title = videoDescription.Title;
        Console.WriteLine(title);
    }

    public void DownloadVideo() 
    {
        youtubeClient.Videos.DownloadAsync(_videoURL, Environment.CurrentDirectory, builder => builder.SetPreset(ConversionPreset.UltraFast));
    }
}

