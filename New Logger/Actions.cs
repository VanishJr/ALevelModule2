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

    public Result Info()
    {
        result.TypeMessage = $"Start method: @Info@";
        result.Status = true;
        logger.Add(Logger.TypeLog.Info, result.TypeMessage);
        return result;
    }

    public Result BusinessException()
    {
        result.TypeMessage = $"Skipped logic in method: @BusinessException@";
        result.Status = true;
        logger.Add(Logger.TypeLog.Warning, result.TypeMessage);
        return result;
    }

    public Result Exception()
    {
        result.TypeMessage = "I broke a logic";
        result.Status = false;
        return result;
    }
}
