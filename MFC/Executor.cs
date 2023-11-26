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

        public async Task<string> ExecuteCommandAsync(string ipAddress, string username, string password, string command)
        {
            try
            {
                var processStartInfo = new ProcessStartInfo
                {
                    FileName = toolPath,
                    Arguments = $"-I lanplus -H {ipAddress} -U {username} -P {password} {command}",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                };

                using var process = new Process { StartInfo = processStartInfo };
                process.Start();
                var outputTask = process.StandardOutput.ReadToEndAsync();

                if (await Task.WhenAny(outputTask, Task.Delay(4000)) == outputTask)
                {
                    var result = await outputTask;
                    process.WaitForExit();
                    logger.Log($"Executed command: {command}");
                    logger.Log($"Response: {result}");

                    // Update label on successful execution
                    UpdateStatusLabel(true, result);
                    return result;
                }
                else
                {
                    process.Kill();
                    var timeoutError = $"Command timed out: {command}";
                    logger.Log(timeoutError);
                    UpdateStatusLabel(false);
                    return timeoutError;
                }
            }
            catch (Exception ex)
            {
                logger.Log($"Error executing command: {command} - Exception: {ex.Message}");
                UpdateStatusLabel(false);
                return $"Error: {ex.Message}";
            }
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
    }
}