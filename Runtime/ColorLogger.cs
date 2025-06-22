using UnityEngine;

public static class ColorLogger
{
    public static void LogRed(string message)
    {
        Debug.Log($"<color=red>{message}</color>");
    }
    
    public static void LogGreen(string message)
    {
        Debug.Log($"<color=green>{message}</color>");
    }
    
    public static void LogColor(string message, string color)
    {
        Debug.Log($"<color={color}>{message}</color>");
    }
}

// 使用示例
// ColorLogger.LogRed("这是红色警告信息");
// ColorLogger.LogColor("自定义颜色", "#FFA500"); // 橙色