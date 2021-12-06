using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

class Logger
{
    List<string> listLog = new List<string>();

    private static Logger? instance;

    private Logger()
    { }

    public enum TypeLog
    {
        Error,
        Info,
        Warning
    }

    public static Logger getIns()
    {
        if (instance == null)
            instance = new Logger();
        return instance;
    }

    internal void Add(TypeLog typeLog, string message)
    {
        var logText = $"{DateTime.Now} : {typeLog} : {message}";
        Console.WriteLine(logText);
        listLog.Add(logText);

    }

    internal List<string> GetLog()
    {
        return listLog;
    }
}
