using System;
using System.Collections.Generic;
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

    internal string GetPath()
    {
        string path = @"C:\Users\forev\source\repos\ALevelModule2\Module2\Lecture 1\LogFolder\log.txt";
        return path;
    }

    internal void WriteToFile()
    {
        File.WriteAllText(GetPath(), string.Join(Environment.NewLine, listLog));
    }

    internal List<string> GetLog()
    {
        return listLog;
    }
}
