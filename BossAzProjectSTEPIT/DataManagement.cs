using System;
using System.IO;
using Newtonsoft.Json;

public static class DataManagement
{
    public static void SaveToJson(object data, string filePath)
    {
        string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
        File.WriteAllText(filePath, jsonData);
    }

    public static void LogToFile(string logMessage, string logFilePath)
    {
        using (StreamWriter streamWriter = File.AppendText(logFilePath))
        {
            streamWriter.WriteLine($"{DateTime.Now}: {logMessage}");
        }
    }
}
