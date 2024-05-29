namespace Task2.Commands
{
    internal class DownloadVideoCommand : IVideoCommand
    {
        private VideoManager _videoManager;

        public DownloadVideoCommand(VideoManager videoManager)
        {
            _videoManager = videoManager;
        }
        public void Execute()
        {
            Console.WriteLine("Начата загрузка видео, пожалуйста ожидайте...");
            Task.WaitAny(_videoManager.DownloadVideo());
            Console.WriteLine("Загрузка завершена!!!\n");
        }
    }
}
