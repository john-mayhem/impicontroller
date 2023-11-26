namespace MFC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_clear_settings = new Button();
            btn_save_settings = new Button();
            lb_ip_addr = new Label();
            lb_username = new Label();
            textbox_ip = new TextBox();
            textbox_username = new TextBox();
            textbox_password = new TextBox();
            lb_password = new Label();
            btn_refresh_start = new Button();
            radiobtn_clear_settings = new RadioButton();
            radiobtn_refresh_start = new RadioButton();
            btn_refresh_stop = new Button();
            btn_manual_ctrl = new Button();
            btn_automatic_ctrl = new Button();
            btn_speed_pct_10 = new Button();
            btn_speed_pct_20 = new Button();
            btn_speed_pct_30 = new Button();
            btn_speed_pct_50 = new Button();
            btn_speed_pct_40 = new Button();
            btn_speed_pct_60 = new Button();
            btn_speed_pct_70 = new Button();
            btn_speed_pct_80 = new Button();
            btn_speed_pct_90 = new Button();
            btn_speed_pct_100 = new Button();
            lb_connection_data = new Label();
            lb_settings = new Label();
            lb_refresh_time = new Label();
            lb_refresh = new Label();
            btn_set_manual_speed = new Button();
            lb_manual_speed = new Label();
            textbox_manual_speed = new TextBox();
            rb_update_speed_5s = new RadioButton();
            lb_fan1 = new Label();
            lb_dyn_speed_fan1 = new Label();
            lb_fan2 = new Label();
            lb_dyn_speed_fan2 = new Label();
            lb_fan3 = new Label();
            lb_dyn_speed_fan3 = new Label();
            lb_fan4 = new Label();
            lb_dyn_speed_fan4 = new Label();
            lb_fan5 = new Label();
            lb_dyn_speed_fan6 = new Label();
            lb_fan6 = new Label();
            lb_dyn_speed_fan5 = new Label();
            lb_cpu_1_temp = new Label();
            lb_cpu_2_temp = new Label();
            lb_power_consumption = new Label();
            settings_panel = new Panel();
            fan_control_panel = new Panel();
            fan_report_data_panel = new Panel();
            lb_dyn_pct_speed_fan6 = new Label();
            lb_dyn_pct_speed_fan5 = new Label();
            lb_dyn_pct_speed_fan4 = new Label();
            lb_dyn_pct_speed_fan3 = new Label();
            lb_dyn_pct_speed_fan2 = new Label();
            lb_dyn_pct_speed_fan1 = new Label();
            lb_pct_fan_speeds = new Label();
            lb_rpm_fan_speeds = new Label();
            cpu_and_pw_cons_panel = new Panel();
            lb_dyn_power_consumption = new Label();
            lb_dyn_cpu_2_temp = new Label();
            lb_dyn_cpu_1_temp = new Label();
            settings_panel.SuspendLayout();
            fan_control_panel.SuspendLayout();
            fan_report_data_panel.SuspendLayout();
            cpu_and_pw_cons_panel.SuspendLayout();
            SuspendLayout();
            // 
            // btn_clear_settings
            // 
            resources.ApplyResources(btn_clear_settings, "btn_clear_settings");
            btn_clear_settings.Name = "btn_clear_settings";
            btn_clear_settings.UseVisualStyleBackColor = true;
            btn_clear_settings.Click += clearButton_Click;
            // 
            // btn_save_settings
            // 
            resources.ApplyResources(btn_save_settings, "btn_save_settings");
            btn_save_settings.Name = "btn_save_settings";
            btn_save_settings.UseVisualStyleBackColor = true;
            btn_save_settings.Click += saveButton_Click;
            // 
            // lb_ip_addr
            // 
            resources.ApplyResources(lb_ip_addr, "lb_ip_addr");
            lb_ip_addr.Name = "lb_ip_addr";
            // 
            // lb_username
            // 
            resources.ApplyResources(lb_username, "lb_username");
            lb_username.Name = "lb_username";
            // 
            // textbox_ip
            // 
            resources.ApplyResources(textbox_ip, "textbox_ip");
            textbox_ip.Name = "textbox_ip";
            // 
            // textbox_username
            // 
            resources.ApplyResources(textbox_username, "textbox_username");
            textbox_username.Name = "textbox_username";
            // 
            // textbox_password
            // 
            resources.ApplyResources(textbox_password, "textbox_password");
            textbox_password.Name = "textbox_password";
            // 
            // lb_password
            // 
            resources.ApplyResources(lb_password, "lb_password");
            lb_password.Name = "lb_password";
            // 
            // btn_refresh_start
            // 
            resources.ApplyResources(btn_refresh_start, "btn_refresh_start");
            btn_refresh_start.Name = "btn_refresh_start";
            btn_refresh_start.UseVisualStyleBackColor = true;
            // 
            // radiobtn_clear_settings
            // 
            resources.ApplyResources(radiobtn_clear_settings, "radiobtn_clear_settings");
            radiobtn_clear_settings.Name = "radiobtn_clear_settings";
            radiobtn_clear_settings.TabStop = true;
            radiobtn_clear_settings.UseVisualStyleBackColor = true;
            // 
            // radiobtn_refresh_start
            // 
            resources.ApplyResources(radiobtn_refresh_start, "radiobtn_refresh_start");
            radiobtn_refresh_start.Name = "radiobtn_refresh_start";
            radiobtn_refresh_start.TabStop = true;
            radiobtn_refresh_start.UseVisualStyleBackColor = true;
            // 
            // btn_refresh_stop
            // 
            resources.ApplyResources(btn_refresh_stop, "btn_refresh_stop");
            btn_refresh_stop.Name = "btn_refresh_stop";
            btn_refresh_stop.UseVisualStyleBackColor = true;
            // 
            // btn_manual_ctrl
            // 
            resources.ApplyResources(btn_manual_ctrl, "btn_manual_ctrl");
            btn_manual_ctrl.Name = "btn_manual_ctrl";
            btn_manual_ctrl.UseVisualStyleBackColor = true;
            // 
            // btn_automatic_ctrl
            // 
            resources.ApplyResources(btn_automatic_ctrl, "btn_automatic_ctrl");
            btn_automatic_ctrl.Name = "btn_automatic_ctrl";
            btn_automatic_ctrl.UseVisualStyleBackColor = true;
            // 
            // btn_speed_pct_10
            // 
            resources.ApplyResources(btn_speed_pct_10, "btn_speed_pct_10");
            btn_speed_pct_10.Name = "btn_speed_pct_10";
            btn_speed_pct_10.UseVisualStyleBackColor = true;
            // 
            // btn_speed_pct_20
            // 
            resources.ApplyResources(btn_speed_pct_20, "btn_speed_pct_20");
            btn_speed_pct_20.Name = "btn_speed_pct_20";
            btn_speed_pct_20.UseVisualStyleBackColor = true;
            // 
            // btn_speed_pct_30
            // 
            resources.ApplyResources(btn_speed_pct_30, "btn_speed_pct_30");
            btn_speed_pct_30.Name = "btn_speed_pct_30";
            btn_speed_pct_30.UseVisualStyleBackColor = true;
            // 
            // btn_speed_pct_50
            // 
            resources.ApplyResources(btn_speed_pct_50, "btn_speed_pct_50");
            btn_speed_pct_50.Name = "btn_speed_pct_50";
            btn_speed_pct_50.UseVisualStyleBackColor = true;
            // 
            // btn_speed_pct_40
            // 
            resources.ApplyResources(btn_speed_pct_40, "btn_speed_pct_40");
            btn_speed_pct_40.Name = "btn_speed_pct_40";
            btn_speed_pct_40.UseVisualStyleBackColor = true;
            // 
            // btn_speed_pct_60
            // 
            resources.ApplyResources(btn_speed_pct_60, "btn_speed_pct_60");
            btn_speed_pct_60.Name = "btn_speed_pct_60";
            btn_speed_pct_60.UseVisualStyleBackColor = true;
            // 
            // btn_speed_pct_70
            // 
            resources.ApplyResources(btn_speed_pct_70, "btn_speed_pct_70");
            btn_speed_pct_70.Name = "btn_speed_pct_70";
            btn_speed_pct_70.UseVisualStyleBackColor = true;
            // 
            // btn_speed_pct_80
            // 
            resources.ApplyResources(btn_speed_pct_80, "btn_speed_pct_80");
            btn_speed_pct_80.Name = "btn_speed_pct_80";
            btn_speed_pct_80.UseVisualStyleBackColor = true;
            // 
            // btn_speed_pct_90
            // 
            resources.ApplyResources(btn_speed_pct_90, "btn_speed_pct_90");
            btn_speed_pct_90.Name = "btn_speed_pct_90";
            btn_speed_pct_90.UseVisualStyleBackColor = true;
            // 
            // btn_speed_pct_100
            // 
            resources.ApplyResources(btn_speed_pct_100, "btn_speed_pct_100");
            btn_speed_pct_100.Name = "btn_speed_pct_100";
            btn_speed_pct_100.UseVisualStyleBackColor = true;
            // 
            // lb_connection_data
            // 
            resources.ApplyResources(lb_connection_data, "lb_connection_data");
            lb_connection_data.Name = "lb_connection_data";
            // 
            // lb_settings
            // 
            resources.ApplyResources(lb_settings, "lb_settings");
            lb_settings.Name = "lb_settings";
            // 
            // lb_refresh_time
            // 
            resources.ApplyResources(lb_refresh_time, "lb_refresh_time");
            lb_refresh_time.Name = "lb_refresh_time";
            // 
            // lb_refresh
            // 
            resources.ApplyResources(lb_refresh, "lb_refresh");
            lb_refresh.Name = "lb_refresh";
            // 
            // btn_set_manual_speed
            // 
            resources.ApplyResources(btn_set_manual_speed, "btn_set_manual_speed");
            btn_set_manual_speed.Name = "btn_set_manual_speed";
            btn_set_manual_speed.UseVisualStyleBackColor = true;
            // 
            // lb_manual_speed
            // 
            resources.ApplyResources(lb_manual_speed, "lb_manual_speed");
            lb_manual_speed.Name = "lb_manual_speed";
            // 
            // textbox_manual_speed
            // 
            resources.ApplyResources(textbox_manual_speed, "textbox_manual_speed");
            textbox_manual_speed.Name = "textbox_manual_speed";
            // 
            // rb_update_speed_5s
            // 
            resources.ApplyResources(rb_update_speed_5s, "rb_update_speed_5s");
            rb_update_speed_5s.Name = "rb_update_speed_5s";
            rb_update_speed_5s.TabStop = true;
            rb_update_speed_5s.UseVisualStyleBackColor = true;
            // 
            // lb_fan1
            // 
            resources.ApplyResources(lb_fan1, "lb_fan1");
            lb_fan1.Name = "lb_fan1";
            // 
            // lb_dyn_speed_fan1
            // 
            resources.ApplyResources(lb_dyn_speed_fan1, "lb_dyn_speed_fan1");
            lb_dyn_speed_fan1.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_speed_fan1.Name = "lb_dyn_speed_fan1";
            // 
            // lb_fan2
            // 
            resources.ApplyResources(lb_fan2, "lb_fan2");
            lb_fan2.Name = "lb_fan2";
            // 
            // lb_dyn_speed_fan2
            // 
            resources.ApplyResources(lb_dyn_speed_fan2, "lb_dyn_speed_fan2");
            lb_dyn_speed_fan2.BackColor = SystemColors.Control;
            lb_dyn_speed_fan2.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_speed_fan2.Name = "lb_dyn_speed_fan2";
            // 
            // lb_fan3
            // 
            resources.ApplyResources(lb_fan3, "lb_fan3");
            lb_fan3.Name = "lb_fan3";
            // 
            // lb_dyn_speed_fan3
            // 
            resources.ApplyResources(lb_dyn_speed_fan3, "lb_dyn_speed_fan3");
            lb_dyn_speed_fan3.BackColor = SystemColors.Control;
            lb_dyn_speed_fan3.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_speed_fan3.Name = "lb_dyn_speed_fan3";
            // 
            // lb_fan4
            // 
            resources.ApplyResources(lb_fan4, "lb_fan4");
            lb_fan4.Name = "lb_fan4";
            // 
            // lb_dyn_speed_fan4
            // 
            resources.ApplyResources(lb_dyn_speed_fan4, "lb_dyn_speed_fan4");
            lb_dyn_speed_fan4.BackColor = SystemColors.Control;
            lb_dyn_speed_fan4.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_speed_fan4.Name = "lb_dyn_speed_fan4";
            // 
            // lb_fan5
            // 
            resources.ApplyResources(lb_fan5, "lb_fan5");
            lb_fan5.Name = "lb_fan5";
            // 
            // lb_dyn_speed_fan6
            // 
            resources.ApplyResources(lb_dyn_speed_fan6, "lb_dyn_speed_fan6");
            lb_dyn_speed_fan6.BackColor = SystemColors.Control;
            lb_dyn_speed_fan6.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_speed_fan6.Name = "lb_dyn_speed_fan6";
            // 
            // lb_fan6
            // 
            resources.ApplyResources(lb_fan6, "lb_fan6");
            lb_fan6.Name = "lb_fan6";
            // 
            // lb_dyn_speed_fan5
            // 
            resources.ApplyResources(lb_dyn_speed_fan5, "lb_dyn_speed_fan5");
            lb_dyn_speed_fan5.BackColor = SystemColors.Control;
            lb_dyn_speed_fan5.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_speed_fan5.Name = "lb_dyn_speed_fan5";
            // 
            // lb_cpu_1_temp
            // 
            resources.ApplyResources(lb_cpu_1_temp, "lb_cpu_1_temp");
            lb_cpu_1_temp.Name = "lb_cpu_1_temp";
            // 
            // lb_cpu_2_temp
            // 
            resources.ApplyResources(lb_cpu_2_temp, "lb_cpu_2_temp");
            lb_cpu_2_temp.Name = "lb_cpu_2_temp";
            // 
            // lb_power_consumption
            // 
            resources.ApplyResources(lb_power_consumption, "lb_power_consumption");
            lb_power_consumption.Name = "lb_power_consumption";
            // 
            // settings_panel
            // 
            resources.ApplyResources(settings_panel, "settings_panel");
            settings_panel.BorderStyle = BorderStyle.FixedSingle;
            settings_panel.Controls.Add(lb_connection_data);
            settings_panel.Controls.Add(btn_clear_settings);
            settings_panel.Controls.Add(btn_save_settings);
            settings_panel.Controls.Add(lb_ip_addr);
            settings_panel.Controls.Add(lb_username);
            settings_panel.Controls.Add(textbox_ip);
            settings_panel.Controls.Add(textbox_username);
            settings_panel.Controls.Add(textbox_password);
            settings_panel.Controls.Add(lb_password);
            settings_panel.Controls.Add(btn_refresh_start);
            settings_panel.Controls.Add(radiobtn_clear_settings);
            settings_panel.Controls.Add(rb_update_speed_5s);
            settings_panel.Controls.Add(radiobtn_refresh_start);
            settings_panel.Controls.Add(btn_refresh_stop);
            settings_panel.Controls.Add(lb_settings);
            settings_panel.Controls.Add(lb_refresh_time);
            settings_panel.Controls.Add(lb_refresh);
            settings_panel.Name = "settings_panel";
            // 
            // fan_control_panel
            // 
            resources.ApplyResources(fan_control_panel, "fan_control_panel");
            fan_control_panel.Controls.Add(btn_set_manual_speed);
            fan_control_panel.Controls.Add(btn_manual_ctrl);
            fan_control_panel.Controls.Add(btn_automatic_ctrl);
            fan_control_panel.Controls.Add(btn_speed_pct_10);
            fan_control_panel.Controls.Add(btn_speed_pct_20);
            fan_control_panel.Controls.Add(btn_speed_pct_30);
            fan_control_panel.Controls.Add(btn_speed_pct_50);
            fan_control_panel.Controls.Add(btn_speed_pct_40);
            fan_control_panel.Controls.Add(btn_speed_pct_60);
            fan_control_panel.Controls.Add(btn_speed_pct_70);
            fan_control_panel.Controls.Add(btn_speed_pct_80);
            fan_control_panel.Controls.Add(btn_speed_pct_90);
            fan_control_panel.Controls.Add(btn_speed_pct_100);
            fan_control_panel.Controls.Add(lb_manual_speed);
            fan_control_panel.Controls.Add(textbox_manual_speed);
            fan_control_panel.Name = "fan_control_panel";
            // 
            // fan_report_data_panel
            // 
            resources.ApplyResources(fan_report_data_panel, "fan_report_data_panel");
            fan_report_data_panel.BorderStyle = BorderStyle.FixedSingle;
            fan_report_data_panel.Controls.Add(lb_dyn_pct_speed_fan6);
            fan_report_data_panel.Controls.Add(lb_dyn_pct_speed_fan5);
            fan_report_data_panel.Controls.Add(lb_dyn_pct_speed_fan4);
            fan_report_data_panel.Controls.Add(lb_dyn_pct_speed_fan3);
            fan_report_data_panel.Controls.Add(lb_dyn_pct_speed_fan2);
            fan_report_data_panel.Controls.Add(lb_dyn_pct_speed_fan1);
            fan_report_data_panel.Controls.Add(lb_pct_fan_speeds);
            fan_report_data_panel.Controls.Add(lb_rpm_fan_speeds);
            fan_report_data_panel.Controls.Add(lb_dyn_speed_fan1);
            fan_report_data_panel.Controls.Add(lb_fan1);
            fan_report_data_panel.Controls.Add(lb_fan2);
            fan_report_data_panel.Controls.Add(lb_dyn_speed_fan2);
            fan_report_data_panel.Controls.Add(lb_fan3);
            fan_report_data_panel.Controls.Add(lb_dyn_speed_fan3);
            fan_report_data_panel.Controls.Add(lb_dyn_speed_fan5);
            fan_report_data_panel.Controls.Add(lb_fan4);
            fan_report_data_panel.Controls.Add(lb_fan6);
            fan_report_data_panel.Controls.Add(lb_dyn_speed_fan4);
            fan_report_data_panel.Controls.Add(lb_dyn_speed_fan6);
            fan_report_data_panel.Controls.Add(lb_fan5);
            fan_report_data_panel.Name = "fan_report_data_panel";
            // 
            // lb_dyn_pct_speed_fan6
            // 
            resources.ApplyResources(lb_dyn_pct_speed_fan6, "lb_dyn_pct_speed_fan6");
            lb_dyn_pct_speed_fan6.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_pct_speed_fan6.Name = "lb_dyn_pct_speed_fan6";
            // 
            // lb_dyn_pct_speed_fan5
            // 
            resources.ApplyResources(lb_dyn_pct_speed_fan5, "lb_dyn_pct_speed_fan5");
            lb_dyn_pct_speed_fan5.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_pct_speed_fan5.Name = "lb_dyn_pct_speed_fan5";
            // 
            // lb_dyn_pct_speed_fan4
            // 
            resources.ApplyResources(lb_dyn_pct_speed_fan4, "lb_dyn_pct_speed_fan4");
            lb_dyn_pct_speed_fan4.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_pct_speed_fan4.Name = "lb_dyn_pct_speed_fan4";
            // 
            // lb_dyn_pct_speed_fan3
            // 
            resources.ApplyResources(lb_dyn_pct_speed_fan3, "lb_dyn_pct_speed_fan3");
            lb_dyn_pct_speed_fan3.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_pct_speed_fan3.Name = "lb_dyn_pct_speed_fan3";
            // 
            // lb_dyn_pct_speed_fan2
            // 
            resources.ApplyResources(lb_dyn_pct_speed_fan2, "lb_dyn_pct_speed_fan2");
            lb_dyn_pct_speed_fan2.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_pct_speed_fan2.Name = "lb_dyn_pct_speed_fan2";
            // 
            // lb_dyn_pct_speed_fan1
            // 
            resources.ApplyResources(lb_dyn_pct_speed_fan1, "lb_dyn_pct_speed_fan1");
            lb_dyn_pct_speed_fan1.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_pct_speed_fan1.Name = "lb_dyn_pct_speed_fan1";
            // 
            // lb_pct_fan_speeds
            // 
            resources.ApplyResources(lb_pct_fan_speeds, "lb_pct_fan_speeds");
            lb_pct_fan_speeds.Name = "lb_pct_fan_speeds";
            // 
            // lb_rpm_fan_speeds
            // 
            resources.ApplyResources(lb_rpm_fan_speeds, "lb_rpm_fan_speeds");
            lb_rpm_fan_speeds.BackColor = SystemColors.Control;
            lb_rpm_fan_speeds.Name = "lb_rpm_fan_speeds";
            // 
            // cpu_and_pw_cons_panel
            // 
            resources.ApplyResources(cpu_and_pw_cons_panel, "cpu_and_pw_cons_panel");
            cpu_and_pw_cons_panel.Controls.Add(lb_dyn_power_consumption);
            cpu_and_pw_cons_panel.Controls.Add(lb_dyn_cpu_2_temp);
            cpu_and_pw_cons_panel.Controls.Add(lb_dyn_cpu_1_temp);
            cpu_and_pw_cons_panel.Controls.Add(lb_cpu_1_temp);
            cpu_and_pw_cons_panel.Controls.Add(lb_cpu_2_temp);
            cpu_and_pw_cons_panel.Controls.Add(lb_power_consumption);
            cpu_and_pw_cons_panel.Name = "cpu_and_pw_cons_panel";
            // 
            // lb_dyn_power_consumption
            // 
            resources.ApplyResources(lb_dyn_power_consumption, "lb_dyn_power_consumption");
            lb_dyn_power_consumption.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_power_consumption.Name = "lb_dyn_power_consumption";
            // 
            // lb_dyn_cpu_2_temp
            // 
            resources.ApplyResources(lb_dyn_cpu_2_temp, "lb_dyn_cpu_2_temp");
            lb_dyn_cpu_2_temp.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_cpu_2_temp.Name = "lb_dyn_cpu_2_temp";
            // 
            // lb_dyn_cpu_1_temp
            // 
            resources.ApplyResources(lb_dyn_cpu_1_temp, "lb_dyn_cpu_1_temp");
            lb_dyn_cpu_1_temp.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_cpu_1_temp.Name = "lb_dyn_cpu_1_temp";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cpu_and_pw_cons_panel);
            Controls.Add(fan_report_data_panel);
            Controls.Add(fan_control_panel);
            Controls.Add(settings_panel);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            settings_panel.ResumeLayout(false);
            settings_panel.PerformLayout();
            fan_control_panel.ResumeLayout(false);
            fan_control_panel.PerformLayout();
            fan_report_data_panel.ResumeLayout(false);
            fan_report_data_panel.PerformLayout();
            cpu_and_pw_cons_panel.ResumeLayout(false);
            cpu_and_pw_cons_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_clear_settings;
        private Button btn_save_settings;
        private Label lb_ip_addr;
        private Label lb_username;
        private TextBox textbox_ip;
        private TextBox textbox_username;
        private TextBox textbox_password;
        private Label lb_password;
        private Button btn_refresh_start;
        private RadioButton radiobtn_clear_settings;
        private RadioButton radiobtn_refresh_start;
        private Button btn_refresh_stop;
        private Button btn_manual_ctrl;
        private Button btn_automatic_ctrl;
        private Button btn_speed_pct_10;
        private Button btn_speed_pct_20;
        private Button btn_speed_pct_30;
        private Button btn_speed_pct_50;
        private Button btn_speed_pct_40;
        private Button btn_speed_pct_60;
        private Button btn_speed_pct_70;
        private Button btn_speed_pct_80;
        private Button btn_speed_pct_90;
        private Button btn_speed_pct_100;
        private Label lb_connection_data;
        private Label lb_settings;
        private Label lb_refresh_time;
        private Label lb_refresh;
        private Button btn_set_manual_speed;
        private Label lb_manual_speed;
        private TextBox textbox_manual_speed;
        private RadioButton rb_update_speed_5s;
        private Label lb_fan1;
        private Label lb_dyn_speed_fan1;
        private Label lb_fan2;
        private Label lb_dyn_speed_fan2;
        private Label lb_fan3;
        private Label lb_dyn_speed_fan3;
        private Label lb_fan4;
        private Label lb_dyn_speed_fan4;
        private Label lb_fan5;
        private Label lb_dyn_speed_fan6;
        private Label lb_fan6;
        private Label lb_dyn_speed_fan5;
        private Label lb_cpu_1_temp;
        private Label lb_cpu_2_temp;
        private Label lb_power_consumption;
        private Panel settings_panel;
        private Panel fan_control_panel;
        private Panel fan_report_data_panel;
        private Label lb_pct_fan_speeds;
        private Label lb_rpm_fan_speeds;
        private Label lb_dyn_pct_speed_fan6;
        private Label lb_dyn_pct_speed_fan5;
        private Label lb_dyn_pct_speed_fan4;
        private Label lb_dyn_pct_speed_fan3;
        private Label lb_dyn_pct_speed_fan2;
        private Label lb_dyn_pct_speed_fan1;
        private Panel cpu_and_pw_cons_panel;
        private Label lb_dyn_power_consumption;
        private Label lb_dyn_cpu_2_temp;
        private Label lb_dyn_cpu_1_temp;
    }
}