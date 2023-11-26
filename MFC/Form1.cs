namespace MFC
{
    public partial class Form1 : Form
    {
        private readonly ConfigManager configManager;
        private readonly Logger logger;

        public Form1()
        {
            InitializeComponent();
            logger = new Logger(); // Make sure to instantiate the Logger first
            configManager = new ConfigManager();
            logger.Log("Initializing.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load settings and populate text fields
            var settings = configManager.LoadSettings();
            textbox_ip.Text = settings.IpAddress;
            textbox_username.Text = settings.Username;
            textbox_password.Text = settings.Password;
            logger.Log("Loaded settings.");
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Save settings from text fields to config.xml
            var settings = new Settings
            {
                IpAddress = textbox_ip.Text,
                Username = textbox_username.Text,
                Password = textbox_password.Text
            };

            if (!string.IsNullOrWhiteSpace(settings.IpAddress) &&
                !string.IsNullOrWhiteSpace(settings.Username) &&
                !string.IsNullOrWhiteSpace(settings.Password))
            {
                configManager.SaveSettings(settings);
                logger.Log("Saved settings.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear text fields
            textbox_ip.Clear();
            textbox_username.Clear();
            textbox_password.Clear();
            logger.Log("Cleared settings fields.");
        }
    }

}