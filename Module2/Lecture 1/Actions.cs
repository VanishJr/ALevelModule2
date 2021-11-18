using System;


public class Result
{
    public bool Status { get; set; }

    public string? TypeMessage { get; set; }

}

public class Actions
{
    Logger logger = Logger.getIns();
    Result result = new Result();

    public Result InputInfo()
    {
        result.TypeMessage = $"Start method: @Info@";
        result.Status = true;
        logger.Add(Logger.TypeLog.Info, result.TypeMessage);
        return result;
    }

    public Result InputWarning()
    {
        result.TypeMessage = $"Skipped logic: @Warning@";
        result.Status = true;
        logger.Add(Logger.TypeLog.Warning, result.TypeMessage);
        return result;
    }

    public Result InputError()
    {
        result.TypeMessage = "I broke a logic";
        result.Status = false;
        return result;
    }
}

