using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

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
        string description = videoDescription.Description;

        Console.WriteLine($"Название видео: {title} \n \n" +
                          $"Описание видео: {description}");
    }

    public async void DownloadVideo() 
    {
        var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(_videoURL);
        var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

        await youtubeClient.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
    }
}

