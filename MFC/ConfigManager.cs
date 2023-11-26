using System;
using System.IO;
using System.Xml.Serialization;

[Serializable] // This attribute is necessary for XML Serialization
public class Settings
{
    public string? IpAddress { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
}

public class ConfigManager
{
    private readonly string configFolderPath;
    private readonly string configFilePath;

    public ConfigManager()
    {
        configFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config");
        configFilePath = Path.Combine(configFolderPath, "config.xml");

        // Check if the config folder exists, if not create it
        if (!Directory.Exists(configFolderPath))
        {
            Directory.CreateDirectory(configFolderPath);
        }

        // Check if the config file exists, if not create it with default settings
        if (!File.Exists(configFilePath))
        {
            SaveSettings(new Settings
            {
                IpAddress = "0.0.0.0",
                Username = "change-me",
                Password = "change-me"
            });
        }
    }

    public Settings LoadSettings()
    {
        try
        {
            using (var stream = new FileStream(configFilePath, FileMode.Open, FileAccess.Read))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                return (Settings)serializer.Deserialize(stream);
            }
        }
        catch
        {
            // If something goes wrong, return default settings
            return new Settings
            {
                IpAddress = "0.0.0.0",
                Username = "change-me",
                Password = "change-me"
            };
        }
    }

    public void SaveSettings(Settings settings)
    {
        try
        {
            using (var stream = new FileStream(configFilePath, FileMode.Create, FileAccess.Write))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                serializer.Serialize(stream, settings);
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions (e.g., log or display an error message)
            // For example, you could show a message box (not recommended for all exceptions as it could be intrusive):
            // MessageBox.Show("Error saving settings: " + ex.Message);
        }
    }
}
