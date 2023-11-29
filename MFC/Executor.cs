using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MFC
{
    public class IPMIToolWrapper
    {
        private readonly string toolPath;
        private readonly Logger logger;
        private readonly Label statusLabel;

        public IPMIToolWrapper(string ipmitoolPath, Logger logger, Label statusLabel)
        {
            this.toolPath = ipmitoolPath;
            this.logger = logger;
            this.statusLabel = statusLabel;
        }

        public async Task<string> GetSensorListAsync(string ipAddress, string username, string password)
        {
            string command = "sensor list";
            return await ExecuteCommandAsync(ipAddress, username, password, command);
        }

        public async Task<string> ExecuteCommandAsync(string ipAddress, string username, string password, string command)
        {
            string result = string.Empty;
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = toolPath,
                    Arguments = $"-I lanplus -H {ipAddress} -U {username} -P {password} {command}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };

                using (var process = Process.Start(startInfo))
                {
                    using (var reader = process.StandardOutput)
                    {
                        result = await reader.ReadToEndAsync(); // Wait for the entire output
                        process.WaitForExit(); // Ensure the process has completed
                    }
                }
                logger.Log($"Executed command: {command}\nResponse: {result}");
            }
            catch (Exception ex)
            {
                logger.Log($"Error executing command: {command} - Exception: {ex.Message}");
            }
            return result;
        }



        private void UpdateStatusLabel(bool isSuccess, string response = " ")
        {
            statusLabel.Invoke((MethodInvoker)delegate
            {
                if (isSuccess)
                {
                    statusLabel.Text = "OK";
                    statusLabel.BackColor = Color.Green;
                }
                else
                {
                    statusLabel.Text = "ERROR";
                    statusLabel.BackColor = Color.Red;
                }
            });
        }


        public async Task<string> GetCPUTemperaturesAsync(string ipAddress, string username, string password)
        {
            string command = "sdr type 0x01";
            return await ExecuteCommandAsync(ipAddress, username, password, command);
        }

        public async Task<string> GetPowerConsumptionAsync(string ipAddress, string username, string password)
        {
            string command = "sdr type 0x03";
            return await ExecuteCommandAsync(ipAddress, username, password, command);
        }

        public async Task<string> GetFanSpeedsAsync(string ipAddress, string username, string password)
        {
            string command = "sdr type 0x04";
            return await ExecuteCommandAsync(ipAddress, username, password, command);
        }

    }
}