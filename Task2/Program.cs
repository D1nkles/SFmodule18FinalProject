using Task2.Commands;
using Task2.Invoker;
using YoutubeExplode;

class Program 
{
    static int? CheckCommandInput(string checkNum) 
    {
        int result = 0;

        if (int.TryParse(checkNum, out result))
            if (result == 1 || result == 2)
                return result;

        Console.WriteLine("Вы ввели не целочисленное значение или значение, не соответсвующее ни одной команде...");
        return null;
    }

    static void Main(string[] args) 
    {
        var invoker = new CommandInvoker();

        while (true)
        {
            Console.WriteLine("Введите ссылку на Youtube видео: ");
            string videoUrl = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(videoUrl))
            {
                Console.WriteLine("\nВыберите какую операцию вы хотите провести:\n" +
                                  "1 - Получить название и описание видео.\n" +
                                  "2 - Скачать видео.\n\n" +
                                  "Введите цифру, соответсвующую желаемой команде: ");
                string checkNum = Console.ReadLine();
                int? commandNum = CheckCommandInput(checkNum);

                if (commandNum != null)
                {
                    switch (commandNum)
                    {
                        case 1:
                            var getVideoDescriptionCommand = new GetVideoDescriptionCommand(new VideoManager(videoUrl));
                            invoker.SetCommand(getVideoDescriptionCommand);
                            break;
                        case 2:
                            var downloadVideoCommand = new DownloadVideoCommand(new VideoManager(videoUrl));
                            invoker.SetCommand(downloadVideoCommand);
                            break;
                    }

                    invoker.ExecuteCommand();
                    Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...\n");
                    Console.ReadKey();
                }
            }
        }
    }
}