using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;

namespace MFC
{
    public partial class Form1 : Form
    {
        private readonly ConfigManager configManager;
        private readonly Logger logger;
        private readonly IPMIToolWrapper ipmiTool;

        public Form1()
        {
            InitializeComponent();
            DisablePercentageControls();
            logger = new Logger();
            configManager = new ConfigManager();
            string ipmiToolPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ipmitool", "ipmitool.exe");

            // Check if ipmitool.exe exists
            if (File.Exists(ipmiToolPath))
            {
                ipmiTool = new IPMIToolWrapper(ipmiToolPath, logger, lb_operation_status);
                logger.Log("IPMI Tool loaded.");
            }
            else
            {
                logger.Log("Error: ipmitool.exe not found.");
            }

            logger.Log("Initialized.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load settings and populate text fields
            var settings = configManager.LoadSettings();
            textbox_ip.Text = settings.IpAddress;
            textbox_username.Text = settings.Username;
            textbox_password.Text = settings.Password;
            DisablePercentageControls();
            logger.Log("Loaded settings.");
        }

        private void DisablePercentageControls()
        {
            btn_speed_pct_10.Enabled = false;
            btn_speed_pct_20.Enabled = false;
            btn_speed_pct_30.Enabled = false;
            btn_speed_pct_40.Enabled = false;
            btn_speed_pct_50.Enabled = false;
            btn_speed_pct_60.Enabled = false;
            btn_speed_pct_70.Enabled = false;
            btn_speed_pct_80.Enabled = false;
            btn_speed_pct_90.Enabled = false;
            btn_speed_pct_100.Enabled = false;
            btn_set_manual_speed.Enabled = false;
            textbox_manual_speed.Enabled = false;
        }
        private void EnablePercentageControls()
        {
            btn_speed_pct_10.Enabled = true;
            btn_speed_pct_20.Enabled = true;
            btn_speed_pct_30.Enabled = true;
            btn_speed_pct_40.Enabled = true;
            btn_speed_pct_50.Enabled = true;
            btn_speed_pct_60.Enabled = true;
            btn_speed_pct_70.Enabled = true;
            btn_speed_pct_80.Enabled = true;
            btn_speed_pct_90.Enabled = true;
            btn_speed_pct_100.Enabled = true;
            btn_set_manual_speed.Enabled = true;
            textbox_manual_speed.Enabled = true;
        }


        private void SaveButton_Click(object sender, EventArgs e)
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear text fields
            textbox_ip.Clear();
            textbox_username.Clear();
            textbox_password.Clear();
            logger.Log("Cleared settings fields.");
        }

        private CancellationTokenSource cancellationTokenSource;

        private void StartButton_Click(object sender, EventArgs e)
        {
            // This will prevent starting multiple tasks if the button is clicked more than once.
            if (cancellationTokenSource == null || cancellationTokenSource.IsCancellationRequested)
            {
                cancellationTokenSource = new CancellationTokenSource();
                Task.Run(() => StartIPMIRequests(cancellationTokenSource.Token));
                logger.Log("Start button pressed. Started making IPMI requests.");
            }
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            cancellationTokenSource?.Cancel();
            logger.Log("Stop button pressed. Refreshing stopped.");
        }
        private async Task StartIPMIRequests(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                    var sensorList = await ipmiTool.GetSensorListAsync(textbox_ip.Text, textbox_username.Text, textbox_password.Text);

                    string firstValue = ExtractValue(sensorList, 143, 147);
                    string secondValue = ExtractValue(sensorList, 267, 271);
                    string thirdValue = ExtractValue(sensorList, 391, 395);
                    string fourthValue = ExtractValue(sensorList, 515, 519);
                    string fifthValue = ExtractValue(sensorList, 639, 643);
                    string sixthValue = ExtractValue(sensorList, 763, 767);
                    string seventhValue = ExtractValue(sensorList, 15767, 15769);
                    string eighthValue = ExtractValue(sensorList, 15891, 15893);
                    string ninthValue = ExtractValue(sensorList, 7583, 7586);

                    // Use Invoke to update UI controls from a different thread
                    Invoke(new Action(() =>
                    {
                        lb_dyn_speed_fan1.Text = firstValue;
                        lb_dyn_speed_fan2.Text = secondValue;
                        lb_dyn_speed_fan3.Text = thirdValue;
                        lb_dyn_speed_fan4.Text = fourthValue;
                        lb_dyn_speed_fan5.Text = fifthValue;
                        lb_dyn_speed_fan6.Text = sixthValue;
                        lb_dyn_cpu_1_temp.Text = seventhValue;
                        lb_dyn_cpu_2_temp.Text = eighthValue;
                        lb_dyn_power_consumption.Text = ninthValue;
                    }));

                    // Ensure cancellation is still not requested
                    if (token.IsCancellationRequested) break;
                }
                catch (OperationCanceledException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    logger.Log("Error: " + ex.Message);
                }
            }
        }

        private string ExtractValue(string data, int startIndex, int endIndex)
        {
            // Ensure the indices are within the bounds of the string
            if (startIndex < data.Length && endIndex <= data.Length && startIndex < endIndex)
            {
                return data.Substring(startIndex, endIndex - startIndex).Trim();
            }
            return "Value out of range";
        }


        private async void ManualControlButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textbox_ip.Text) &&
                !string.IsNullOrWhiteSpace(textbox_username.Text) &&
                !string.IsNullOrWhiteSpace(textbox_password.Text))
            {
                string command = "raw 0x30 0x30 0x01 0x00";
                // Execute the command and the label will be updated within the IPMIToolWrapper
                await ipmiTool.ExecuteCommandAsync(textbox_ip.Text, textbox_username.Text, textbox_password.Text, command);
            }
            else
            {
                logger.Log("Error: IP address, username, or password is empty.");
                // If fields are empty, update the label directly here
                lb_operation_status.Text = "ERROR";
                lb_operation_status.BackColor = Color.Red;
            }
            EnablePercentageControls();
            logger.Log("Manual control engaged.");
        }

        private async void AutoControlButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textbox_ip.Text) &&
                !string.IsNullOrWhiteSpace(textbox_username.Text) &&
                !string.IsNullOrWhiteSpace(textbox_password.Text))
            {
                string command = "raw 0x30 0x30 0x01 0x01";
                // Execute the command and the label will be updated within the IPMIToolWrapper
                await ipmiTool.ExecuteCommandAsync(textbox_ip.Text, textbox_username.Text, textbox_password.Text, command);
            }
            else
            {
                logger.Log("Error: IP address, username, or password is empty.");
                // If fields are empty, update the label directly here
                lb_operation_status.Text = "ERROR";
                lb_operation_status.BackColor = Color.Red;
            }
            DisablePercentageControls();
            logger.Log("Automatic control engaged.");
        }

        private async void btn_speed_pct_10_Click(object sender, EventArgs e)
        {
            await SendFanSpeedCommand(0x0A); // 10% speed
        }

        private async void btn_speed_pct_20_Click(object sender, EventArgs e)
        {
            await SendFanSpeedCommand(0x14); // 20% speed
        }

        private async void btn_speed_pct_30_Click(object sender, EventArgs e)
        {
            await SendFanSpeedCommand(0x1E); // 30% speed
        }

        private async void btn_speed_pct_40_Click(object sender, EventArgs e)
        {
            await SendFanSpeedCommand(0x28); // 40% speed
        }
        private async void btn_speed_pct_50_Click(object sender, EventArgs e)
        {
            await SendFanSpeedCommand(0x32); // 50% speed
        }

        private async void btn_speed_pct_60_Click(object sender, EventArgs e)
        {
            await SendFanSpeedCommand(0x3C); // 60% speed
        }
        private async void btn_speed_pct_70_Click(object sender, EventArgs e)
        {
            await SendFanSpeedCommand(0x46); // 70% speed
        }

        private async void btn_speed_pct_80_Click(object sender, EventArgs e)
        {
            await SendFanSpeedCommand(0x50); // 80% speed
        }
        private async void btn_speed_pct_90_Click(object sender, EventArgs e)
        {
            await SendFanSpeedCommand(0x5A); // 90% speed
        }

        private async void btn_speed_pct_100_Click(object sender, EventArgs e)
        {
            await SendFanSpeedCommand(0x64); // 100% speed
        }

        private async Task SendFanSpeedCommand(int hexPercentageValue)
        {
            if (!string.IsNullOrWhiteSpace(textbox_ip.Text) &&
                !string.IsNullOrWhiteSpace(textbox_username.Text) &&
                !string.IsNullOrWhiteSpace(textbox_password.Text))
            {
                // Convert the integer hex value to a string in hexadecimal format and prepend with '0x'
                string hexValue = "0x" + hexPercentageValue.ToString("X2");
                string command = $"raw 0x30 0x30 0x02 0xff {hexValue}";
                await ipmiTool.ExecuteCommandAsync(textbox_ip.Text, textbox_username.Text, textbox_password.Text, command);
            }
            else
            {
                logger.Log("Error: IP address, username, or password is empty.");
                lb_operation_status.Text = "ERROR";
                lb_operation_status.BackColor = Color.Red;
            }
        }

        private async void btnSetCustomSpeed_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textbox_manual_speed.Text, out int customPercentage) &&
                customPercentage >= 0 && customPercentage <= 100)
            {
                await SendFanSpeedCommand(customPercentage);
            }
            else
            {
                logger.Log("Invalid custom speed percentage.");
                lb_operation_status.Text = "ERROR";
                lb_operation_status.BackColor = Color.Red;
            }
        }

    }
}