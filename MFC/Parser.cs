using System;
using System.Collections.Generic;
using System.Linq;

namespace MFC
{
    public class SensorData
    {
        public string? Name { get; set; }
        public string? Value { get; set; }
    }

    public static class Parser
    {
        public static IEnumerable<string> ParseSensorData(string output, int[] rows, int column)
        {
            var lines = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var rowIndex in rows)
            {
                if (rowIndex < lines.Length)
                {
                    var parts = lines[rowIndex].Split('|').Select(p => p.Trim()).ToArray();
                    if (column < parts.Length)
                    {
                        yield return parts[column].Split(' ')[0]; // Return only the first part of the value
                    }
                }
            }
        }
    }

}
