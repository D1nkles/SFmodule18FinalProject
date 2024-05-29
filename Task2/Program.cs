using Task2.Commands;
using Task2.Invoker;
using YoutubeExplode;

class Program 
{
    static void Main(string[] args) 
    {

        var command1 = new GetVideoDescriptionCommand(new VideoManager("https://www.youtube.com/watch?v=-CUhd8wQ-aU&ab_channel=jampgoog"));
        var command2 = new DownloadVideoCommand(new VideoManager("https://www.youtube.com/watch?v=-CUhd8wQ-aU&ab_channel=jampgoog"));

        var invoker = new CommandInvoker();

        invoker.SetCommand(command1);
        invoker.ExecuteCommand();

        //invoker.SetCommand(command2);
        //invoker.ExecuteCommand();
        
    }
}