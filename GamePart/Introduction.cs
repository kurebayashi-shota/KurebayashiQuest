using System.Xml.Linq;

namespace KurebayashiQuest;

class Introduction
{
    public static string IntroDuction()
    {
        Console.WriteLine(MessageSetting.GameStart);
        Console.WriteLine();
        Console.WriteLine(MessageSetting.DecidOnaName);
        string playerName = Console.ReadLine();
        Console.WriteLine($"{playerName}{MessageSetting.Confirm}");
        Console.WriteLine(MessageSetting.ConfirmationPrompt);
        Console.WriteLine($"{playerName}{MessageSetting.Welcome}");
        Console.WriteLine();
        return playerName;
    }
}