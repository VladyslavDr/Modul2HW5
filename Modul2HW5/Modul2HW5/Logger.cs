using System;

public class Logger
{
    private static Logger _logger = new Logger();
    private string _log = string.Empty;

    private Logger()
    {
    }

    public static Logger GetLogger => _logger;

    public void Write(LogType type, string messege)
    {
        _log = $"{DateTime.UtcNow} : {type} : {messege}";
        Console.WriteLine(_log);
    }
}
