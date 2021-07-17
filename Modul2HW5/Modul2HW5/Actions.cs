using System;

public class Actions
{
    public Result FirstMethod()
    {
        Logger.GetLogger.Write(LogType.Info, "Start method:");
        return new Result(true);
    }

    public Result SecondMethod()
    {
    }

    public void ThirdMethod()
    {
    }
}
