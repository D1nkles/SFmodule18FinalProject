namespace Task2.Commands
{
    internal class GetVideoDescriptionCommand : IVideoCommand
    {
        private VideoManager _videoManager;

        public GetVideoDescriptionCommand(VideoManager videoManager) 
        {
            _videoManager = videoManager;
        }

        public void Execute()
        {
            Console.WriteLine("Получаем информацию о видео...");
            Task.WaitAny(_videoManager.GetVideoInfo());
            Console.WriteLine("Информация получена!!!\n");
        }
    }
}
