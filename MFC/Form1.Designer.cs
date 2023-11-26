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
            lb_operation_status = new Label();
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
            btn_clear_settings.Location = new Point(430, 68);
            btn_clear_settings.Name = "btn_clear_settings";
            btn_clear_settings.Size = new Size(90, 40);
            btn_clear_settings.TabIndex = 0;
            btn_clear_settings.Text = "Clear";
            btn_clear_settings.UseVisualStyleBackColor = true;
            btn_clear_settings.Click += ClearButton_Click;
            // 
            // btn_save_settings
            // 
            btn_save_settings.Location = new Point(430, 25);
            btn_save_settings.Name = "btn_save_settings";
            btn_save_settings.Size = new Size(90, 40);
            btn_save_settings.TabIndex = 1;
            btn_save_settings.Text = "Save";
            btn_save_settings.UseVisualStyleBackColor = true;
            btn_save_settings.Click += SaveButton_Click;
            // 
            // lb_ip_addr
            // 
            lb_ip_addr.AutoSize = true;
            lb_ip_addr.Location = new Point(5, 30);
            lb_ip_addr.Name = "lb_ip_addr";
            lb_ip_addr.Size = new Size(62, 15);
            lb_ip_addr.TabIndex = 2;
            lb_ip_addr.Text = "IP Address";
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Location = new Point(5, 60);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(60, 15);
            lb_username.TabIndex = 3;
            lb_username.Text = "Username";
            // 
            // textbox_ip
            // 
            textbox_ip.Location = new Point(70, 25);
            textbox_ip.Name = "textbox_ip";
            textbox_ip.Size = new Size(350, 23);
            textbox_ip.TabIndex = 4;
            // 
            // textbox_username
            // 
            textbox_username.Location = new Point(70, 55);
            textbox_username.Name = "textbox_username";
            textbox_username.Size = new Size(350, 23);
            textbox_username.TabIndex = 5;
            // 
            // textbox_password
            // 
            textbox_password.Location = new Point(70, 85);
            textbox_password.Name = "textbox_password";
            textbox_password.PasswordChar = '*';
            textbox_password.Size = new Size(350, 23);
            textbox_password.TabIndex = 6;
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Location = new Point(5, 90);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(57, 15);
            lb_password.TabIndex = 7;
            lb_password.Text = "Password";
            // 
            // btn_refresh_start
            // 
            btn_refresh_start.Location = new Point(600, 25);
            btn_refresh_start.Name = "btn_refresh_start";
            btn_refresh_start.Size = new Size(90, 40);
            btn_refresh_start.TabIndex = 8;
            btn_refresh_start.Text = "Start";
            btn_refresh_start.UseVisualStyleBackColor = true;
            // 
            // radiobtn_clear_settings
            // 
            radiobtn_clear_settings.AutoSize = true;
            radiobtn_clear_settings.Location = new Point(535, 30);
            radiobtn_clear_settings.Name = "radiobtn_clear_settings";
            radiobtn_clear_settings.Size = new Size(51, 19);
            radiobtn_clear_settings.TabIndex = 9;
            radiobtn_clear_settings.TabStop = true;
            radiobtn_clear_settings.Text = "3 sec";
            radiobtn_clear_settings.UseVisualStyleBackColor = true;
            // 
            // radiobtn_refresh_start
            // 
            radiobtn_refresh_start.AutoSize = true;
            radiobtn_refresh_start.Location = new Point(535, 78);
            radiobtn_refresh_start.Name = "radiobtn_refresh_start";
            radiobtn_refresh_start.Size = new Size(51, 19);
            radiobtn_refresh_start.TabIndex = 11;
            radiobtn_refresh_start.TabStop = true;
            radiobtn_refresh_start.Text = "7 sec";
            radiobtn_refresh_start.UseVisualStyleBackColor = true;
            // 
            // btn_refresh_stop
            // 
            btn_refresh_stop.Location = new Point(600, 68);
            btn_refresh_stop.Name = "btn_refresh_stop";
            btn_refresh_stop.Size = new Size(90, 40);
            btn_refresh_stop.TabIndex = 12;
            btn_refresh_stop.Text = "Stop";
            btn_refresh_stop.UseVisualStyleBackColor = true;
            // 
            // btn_manual_ctrl
            // 
            btn_manual_ctrl.Location = new Point(5, 7);
            btn_manual_ctrl.Name = "btn_manual_ctrl";
            btn_manual_ctrl.Size = new Size(200, 40);
            btn_manual_ctrl.TabIndex = 13;
            btn_manual_ctrl.Text = "Manual Control";
            btn_manual_ctrl.UseVisualStyleBackColor = true;
            btn_manual_ctrl.Click += ManualControlButton_Click;
            // 
            // btn_automatic_ctrl
            // 
            btn_automatic_ctrl.Location = new Point(215, 9);
            btn_automatic_ctrl.Name = "btn_automatic_ctrl";
            btn_automatic_ctrl.Size = new Size(200, 40);
            btn_automatic_ctrl.TabIndex = 14;
            btn_automatic_ctrl.Text = "Automatic Control";
            btn_automatic_ctrl.UseVisualStyleBackColor = true;
            btn_automatic_ctrl.Click += AutoControlButton_Click;
            // 
            // btn_speed_pct_10
            // 
            btn_speed_pct_10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_speed_pct_10.Location = new Point(5, 55);
            btn_speed_pct_10.Name = "btn_speed_pct_10";
            btn_speed_pct_10.Size = new Size(60, 40);
            btn_speed_pct_10.TabIndex = 16;
            btn_speed_pct_10.Text = "10%";
            btn_speed_pct_10.UseVisualStyleBackColor = true;
            btn_speed_pct_10.Click += btn_speed_pct_10_Click;
            // 
            // btn_speed_pct_20
            // 
            btn_speed_pct_20.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_speed_pct_20.Location = new Point(75, 55);
            btn_speed_pct_20.Name = "btn_speed_pct_20";
            btn_speed_pct_20.Size = new Size(60, 40);
            btn_speed_pct_20.TabIndex = 17;
            btn_speed_pct_20.Text = "20%";
            btn_speed_pct_20.UseVisualStyleBackColor = true;
            btn_speed_pct_20.Click += btn_speed_pct_20_Click;
            // 
            // btn_speed_pct_30
            // 
            btn_speed_pct_30.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_speed_pct_30.Location = new Point(145, 55);
            btn_speed_pct_30.Name = "btn_speed_pct_30";
            btn_speed_pct_30.Size = new Size(60, 40);
            btn_speed_pct_30.TabIndex = 18;
            btn_speed_pct_30.Text = "30%";
            btn_speed_pct_30.UseVisualStyleBackColor = true;
            btn_speed_pct_30.Click += btn_speed_pct_30_Click;
            // 
            // btn_speed_pct_50
            // 
            btn_speed_pct_50.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_speed_pct_50.Location = new Point(285, 55);
            btn_speed_pct_50.Name = "btn_speed_pct_50";
            btn_speed_pct_50.Size = new Size(60, 40);
            btn_speed_pct_50.TabIndex = 19;
            btn_speed_pct_50.Text = "50%";
            btn_speed_pct_50.UseVisualStyleBackColor = true;
            btn_speed_pct_50.Click += btn_speed_pct_50_Click;
            // 
            // btn_speed_pct_40
            // 
            btn_speed_pct_40.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_speed_pct_40.Location = new Point(215, 55);
            btn_speed_pct_40.Name = "btn_speed_pct_40";
            btn_speed_pct_40.Size = new Size(60, 40);
            btn_speed_pct_40.TabIndex = 20;
            btn_speed_pct_40.Text = "40%";
            btn_speed_pct_40.UseVisualStyleBackColor = true;
            btn_speed_pct_40.Click += btn_speed_pct_40_Click;
            // 
            // btn_speed_pct_60
            // 
            btn_speed_pct_60.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_speed_pct_60.Location = new Point(355, 55);
            btn_speed_pct_60.Name = "btn_speed_pct_60";
            btn_speed_pct_60.Size = new Size(60, 40);
            btn_speed_pct_60.TabIndex = 21;
            btn_speed_pct_60.Text = "60%";
            btn_speed_pct_60.UseVisualStyleBackColor = true;
            btn_speed_pct_60.Click += btn_speed_pct_60_Click;
            // 
            // btn_speed_pct_70
            // 
            btn_speed_pct_70.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_speed_pct_70.Location = new Point(425, 55);
            btn_speed_pct_70.Name = "btn_speed_pct_70";
            btn_speed_pct_70.Size = new Size(60, 40);
            btn_speed_pct_70.TabIndex = 22;
            btn_speed_pct_70.Text = "70%";
            btn_speed_pct_70.UseVisualStyleBackColor = true;
            btn_speed_pct_70.Click += btn_speed_pct_70_Click;
            // 
            // btn_speed_pct_80
            // 
            btn_speed_pct_80.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_speed_pct_80.Location = new Point(495, 55);
            btn_speed_pct_80.Name = "btn_speed_pct_80";
            btn_speed_pct_80.Size = new Size(60, 40);
            btn_speed_pct_80.TabIndex = 23;
            btn_speed_pct_80.Text = "80%";
            btn_speed_pct_80.UseVisualStyleBackColor = true;
            btn_speed_pct_80.Click += btn_speed_pct_80_Click;
            // 
            // btn_speed_pct_90
            // 
            btn_speed_pct_90.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_speed_pct_90.Location = new Point(565, 55);
            btn_speed_pct_90.Name = "btn_speed_pct_90";
            btn_speed_pct_90.Size = new Size(60, 40);
            btn_speed_pct_90.TabIndex = 24;
            btn_speed_pct_90.Text = "90%";
            btn_speed_pct_90.UseVisualStyleBackColor = true;
            btn_speed_pct_90.Click += btn_speed_pct_90_Click;
            // 
            // btn_speed_pct_100
            // 
            btn_speed_pct_100.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_speed_pct_100.Location = new Point(635, 55);
            btn_speed_pct_100.Name = "btn_speed_pct_100";
            btn_speed_pct_100.Size = new Size(60, 40);
            btn_speed_pct_100.TabIndex = 25;
            btn_speed_pct_100.Text = "100%";
            btn_speed_pct_100.UseVisualStyleBackColor = true;
            btn_speed_pct_100.Click += btn_speed_pct_100_Click;
            // 
            // lb_connection_data
            // 
            lb_connection_data.AutoSize = true;
            lb_connection_data.Location = new Point(197, 5);
            lb_connection_data.Name = "lb_connection_data";
            lb_connection_data.Size = new Size(95, 15);
            lb_connection_data.TabIndex = 26;
            lb_connection_data.Text = "Connection data";
            // 
            // lb_settings
            // 
            lb_settings.AutoSize = true;
            lb_settings.Location = new Point(450, 5);
            lb_settings.Name = "lb_settings";
            lb_settings.Size = new Size(49, 15);
            lb_settings.TabIndex = 27;
            lb_settings.Text = "Settings";
            // 
            // lb_refresh_time
            // 
            lb_refresh_time.AutoSize = true;
            lb_refresh_time.Location = new Point(525, 5);
            lb_refresh_time.Name = "lb_refresh_time";
            lb_refresh_time.Size = new Size(73, 15);
            lb_refresh_time.TabIndex = 28;
            lb_refresh_time.Text = "Refresh time";
            // 
            // lb_refresh
            // 
            lb_refresh.AutoSize = true;
            lb_refresh.Location = new Point(622, 5);
            lb_refresh.Name = "lb_refresh";
            lb_refresh.Size = new Size(46, 15);
            lb_refresh.TabIndex = 29;
            lb_refresh.Text = "Refresh";
            // 
            // btn_set_manual_speed
            // 
            btn_set_manual_speed.Location = new Point(592, 25);
            btn_set_manual_speed.Name = "btn_set_manual_speed";
            btn_set_manual_speed.Size = new Size(103, 24);
            btn_set_manual_speed.TabIndex = 30;
            btn_set_manual_speed.Text = "Set";
            btn_set_manual_speed.UseVisualStyleBackColor = true;
            btn_set_manual_speed.Click += btnSetCustomSpeed_Click;
            // 
            // lb_manual_speed
            // 
            lb_manual_speed.AutoSize = true;
            lb_manual_speed.Location = new Point(551, 7);
            lb_manual_speed.Name = "lb_manual_speed";
            lb_manual_speed.Size = new Size(144, 15);
            lb_manual_speed.TabIndex = 31;
            lb_manual_speed.Text = "Custom Speed (0%-100%)";
            // 
            // textbox_manual_speed
            // 
            textbox_manual_speed.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textbox_manual_speed.Location = new Point(551, 25);
            textbox_manual_speed.Name = "textbox_manual_speed";
            textbox_manual_speed.Size = new Size(35, 25);
            textbox_manual_speed.TabIndex = 32;
            // 
            // rb_update_speed_5s
            // 
            rb_update_speed_5s.AutoSize = true;
            rb_update_speed_5s.Location = new Point(535, 54);
            rb_update_speed_5s.Name = "rb_update_speed_5s";
            rb_update_speed_5s.Size = new Size(51, 19);
            rb_update_speed_5s.TabIndex = 10;
            rb_update_speed_5s.TabStop = true;
            rb_update_speed_5s.Text = "5 sec";
            rb_update_speed_5s.UseVisualStyleBackColor = true;
            // 
            // lb_fan1
            // 
            lb_fan1.AutoSize = true;
            lb_fan1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_fan1.Location = new Point(55, 10);
            lb_fan1.Name = "lb_fan1";
            lb_fan1.Size = new Size(54, 25);
            lb_fan1.TabIndex = 33;
            lb_fan1.Text = "Fan 1";
            // 
            // lb_dyn_speed_fan1
            // 
            lb_dyn_speed_fan1.AutoSize = true;
            lb_dyn_speed_fan1.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_speed_fan1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dyn_speed_fan1.Location = new Point(55, 50);
            lb_dyn_speed_fan1.Name = "lb_dyn_speed_fan1";
            lb_dyn_speed_fan1.Size = new Size(64, 27);
            lb_dyn_speed_fan1.TabIndex = 34;
            lb_dyn_speed_fan1.Text = "99999";
            lb_dyn_speed_fan1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_fan2
            // 
            lb_fan2.AutoSize = true;
            lb_fan2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_fan2.Location = new Point(162, 10);
            lb_fan2.Name = "lb_fan2";
            lb_fan2.Size = new Size(54, 25);
            lb_fan2.TabIndex = 35;
            lb_fan2.Text = "Fan 2";
            // 
            // lb_dyn_speed_fan2
            // 
            lb_dyn_speed_fan2.AutoSize = true;
            lb_dyn_speed_fan2.BackColor = SystemColors.Control;
            lb_dyn_speed_fan2.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_speed_fan2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dyn_speed_fan2.Location = new Point(162, 50);
            lb_dyn_speed_fan2.Name = "lb_dyn_speed_fan2";
            lb_dyn_speed_fan2.Size = new Size(64, 27);
            lb_dyn_speed_fan2.TabIndex = 36;
            lb_dyn_speed_fan2.Text = "99999";
            lb_dyn_speed_fan2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_fan3
            // 
            lb_fan3.AutoSize = true;
            lb_fan3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_fan3.Location = new Point(269, 10);
            lb_fan3.Name = "lb_fan3";
            lb_fan3.Size = new Size(54, 25);
            lb_fan3.TabIndex = 37;
            lb_fan3.Text = "Fan 3";
            // 
            // lb_dyn_speed_fan3
            // 
            lb_dyn_speed_fan3.AutoSize = true;
            lb_dyn_speed_fan3.BackColor = SystemColors.Control;
            lb_dyn_speed_fan3.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_speed_fan3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dyn_speed_fan3.Location = new Point(269, 50);
            lb_dyn_speed_fan3.Name = "lb_dyn_speed_fan3";
            lb_dyn_speed_fan3.Size = new Size(64, 27);
            lb_dyn_speed_fan3.TabIndex = 38;
            lb_dyn_speed_fan3.Text = "99999";
            lb_dyn_speed_fan3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_fan4
            // 
            lb_fan4.AutoSize = true;
            lb_fan4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_fan4.Location = new Point(376, 10);
            lb_fan4.Name = "lb_fan4";
            lb_fan4.Size = new Size(54, 25);
            lb_fan4.TabIndex = 39;
            lb_fan4.Text = "Fan 4";
            // 
            // lb_dyn_speed_fan4
            // 
            lb_dyn_speed_fan4.AutoSize = true;
            lb_dyn_speed_fan4.BackColor = SystemColors.Control;
            lb_dyn_speed_fan4.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_speed_fan4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dyn_speed_fan4.Location = new Point(376, 50);
            lb_dyn_speed_fan4.Name = "lb_dyn_speed_fan4";
            lb_dyn_speed_fan4.Size = new Size(64, 27);
            lb_dyn_speed_fan4.TabIndex = 40;
            lb_dyn_speed_fan4.Text = "99999";
            lb_dyn_speed_fan4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_fan5
            // 
            lb_fan5.AutoSize = true;
            lb_fan5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_fan5.Location = new Point(483, 10);
            lb_fan5.Name = "lb_fan5";
            lb_fan5.Size = new Size(54, 25);
            lb_fan5.TabIndex = 41;
            lb_fan5.Text = "Fan 5";
            // 
            // lb_dyn_speed_fan6
            // 
            lb_dyn_speed_fan6.AutoSize = true;
            lb_dyn_speed_fan6.BackColor = SystemColors.Control;
            lb_dyn_speed_fan6.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_speed_fan6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dyn_speed_fan6.Location = new Point(590, 50);
            lb_dyn_speed_fan6.Name = "lb_dyn_speed_fan6";
            lb_dyn_speed_fan6.Size = new Size(64, 27);
            lb_dyn_speed_fan6.TabIndex = 42;
            lb_dyn_speed_fan6.Text = "99999";
            lb_dyn_speed_fan6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_fan6
            // 
            lb_fan6.AutoSize = true;
            lb_fan6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_fan6.Location = new Point(590, 10);
            lb_fan6.Name = "lb_fan6";
            lb_fan6.Size = new Size(54, 25);
            lb_fan6.TabIndex = 43;
            lb_fan6.Text = "Fan 6";
            // 
            // lb_dyn_speed_fan5
            // 
            lb_dyn_speed_fan5.AutoSize = true;
            lb_dyn_speed_fan5.BackColor = SystemColors.Control;
            lb_dyn_speed_fan5.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_speed_fan5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dyn_speed_fan5.Location = new Point(483, 50);
            lb_dyn_speed_fan5.Name = "lb_dyn_speed_fan5";
            lb_dyn_speed_fan5.Size = new Size(64, 27);
            lb_dyn_speed_fan5.TabIndex = 44;
            lb_dyn_speed_fan5.Text = "99999";
            lb_dyn_speed_fan5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_cpu_1_temp
            // 
            lb_cpu_1_temp.AutoSize = true;
            lb_cpu_1_temp.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_cpu_1_temp.Location = new Point(53, 10);
            lb_cpu_1_temp.Name = "lb_cpu_1_temp";
            lb_cpu_1_temp.Size = new Size(163, 25);
            lb_cpu_1_temp.TabIndex = 45;
            lb_cpu_1_temp.Text = "CPU 1 Temperature";
            // 
            // lb_cpu_2_temp
            // 
            lb_cpu_2_temp.AutoSize = true;
            lb_cpu_2_temp.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_cpu_2_temp.Location = new Point(269, 10);
            lb_cpu_2_temp.Name = "lb_cpu_2_temp";
            lb_cpu_2_temp.Size = new Size(163, 25);
            lb_cpu_2_temp.TabIndex = 46;
            lb_cpu_2_temp.Text = "CPU 2 Temperature";
            // 
            // lb_power_consumption
            // 
            lb_power_consumption.AutoSize = true;
            lb_power_consumption.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_power_consumption.Location = new Point(485, 10);
            lb_power_consumption.Name = "lb_power_consumption";
            lb_power_consumption.Size = new Size(162, 25);
            lb_power_consumption.TabIndex = 47;
            lb_power_consumption.Text = "Power Consumtion";
            // 
            // settings_panel
            // 
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
            settings_panel.Location = new Point(15, 10);
            settings_panel.Name = "settings_panel";
            settings_panel.Size = new Size(700, 115);
            settings_panel.TabIndex = 48;
            // 
            // fan_control_panel
            // 
            fan_control_panel.Controls.Add(lb_operation_status);
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
            fan_control_panel.Location = new Point(15, 150);
            fan_control_panel.Name = "fan_control_panel";
            fan_control_panel.Size = new Size(700, 100);
            fan_control_panel.TabIndex = 49;
            // 
            // lb_operation_status
            // 
            lb_operation_status.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_operation_status.Location = new Point(421, 9);
            lb_operation_status.Name = "lb_operation_status";
            lb_operation_status.Size = new Size(122, 38);
            lb_operation_status.TabIndex = 51;
            lb_operation_status.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fan_report_data_panel
            // 
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
            fan_report_data_panel.Location = new Point(15, 275);
            fan_report_data_panel.Name = "fan_report_data_panel";
            fan_report_data_panel.Size = new Size(700, 140);
            fan_report_data_panel.TabIndex = 50;
            // 
            // lb_dyn_pct_speed_fan6
            // 
            lb_dyn_pct_speed_fan6.AutoSize = true;
            lb_dyn_pct_speed_fan6.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_pct_speed_fan6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dyn_pct_speed_fan6.Location = new Point(590, 90);
            lb_dyn_pct_speed_fan6.Name = "lb_dyn_pct_speed_fan6";
            lb_dyn_pct_speed_fan6.Size = new Size(59, 27);
            lb_dyn_pct_speed_fan6.TabIndex = 55;
            lb_dyn_pct_speed_fan6.Text = "100%";
            lb_dyn_pct_speed_fan6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_dyn_pct_speed_fan5
            // 
            lb_dyn_pct_speed_fan5.AutoSize = true;
            lb_dyn_pct_speed_fan5.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_pct_speed_fan5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dyn_pct_speed_fan5.Location = new Point(483, 90);
            lb_dyn_pct_speed_fan5.Name = "lb_dyn_pct_speed_fan5";
            lb_dyn_pct_speed_fan5.Size = new Size(59, 27);
            lb_dyn_pct_speed_fan5.TabIndex = 54;
            lb_dyn_pct_speed_fan5.Text = "100%";
            lb_dyn_pct_speed_fan5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_dyn_pct_speed_fan4
            // 
            lb_dyn_pct_speed_fan4.AutoSize = true;
            lb_dyn_pct_speed_fan4.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_pct_speed_fan4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dyn_pct_speed_fan4.Location = new Point(376, 90);
            lb_dyn_pct_speed_fan4.Name = "lb_dyn_pct_speed_fan4";
            lb_dyn_pct_speed_fan4.Size = new Size(59, 27);
            lb_dyn_pct_speed_fan4.TabIndex = 53;
            lb_dyn_pct_speed_fan4.Text = "100%";
            lb_dyn_pct_speed_fan4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_dyn_pct_speed_fan3
            // 
            lb_dyn_pct_speed_fan3.AutoSize = true;
            lb_dyn_pct_speed_fan3.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_pct_speed_fan3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dyn_pct_speed_fan3.Location = new Point(269, 90);
            lb_dyn_pct_speed_fan3.Name = "lb_dyn_pct_speed_fan3";
            lb_dyn_pct_speed_fan3.Size = new Size(59, 27);
            lb_dyn_pct_speed_fan3.TabIndex = 52;
            lb_dyn_pct_speed_fan3.Text = "100%";
            lb_dyn_pct_speed_fan3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_dyn_pct_speed_fan2
            // 
            lb_dyn_pct_speed_fan2.AutoSize = true;
            lb_dyn_pct_speed_fan2.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_pct_speed_fan2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dyn_pct_speed_fan2.Location = new Point(162, 90);
            lb_dyn_pct_speed_fan2.Name = "lb_dyn_pct_speed_fan2";
            lb_dyn_pct_speed_fan2.Size = new Size(59, 27);
            lb_dyn_pct_speed_fan2.TabIndex = 51;
            lb_dyn_pct_speed_fan2.Text = "100%";
            lb_dyn_pct_speed_fan2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_dyn_pct_speed_fan1
            // 
            lb_dyn_pct_speed_fan1.AutoSize = true;
            lb_dyn_pct_speed_fan1.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_pct_speed_fan1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dyn_pct_speed_fan1.Location = new Point(55, 90);
            lb_dyn_pct_speed_fan1.Name = "lb_dyn_pct_speed_fan1";
            lb_dyn_pct_speed_fan1.Size = new Size(59, 27);
            lb_dyn_pct_speed_fan1.TabIndex = 50;
            lb_dyn_pct_speed_fan1.Text = "100%";
            lb_dyn_pct_speed_fan1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_pct_fan_speeds
            // 
            lb_pct_fan_speeds.AutoSize = true;
            lb_pct_fan_speeds.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_pct_fan_speeds.Location = new Point(5, 95);
            lb_pct_fan_speeds.Name = "lb_pct_fan_speeds";
            lb_pct_fan_speeds.Size = new Size(33, 19);
            lb_pct_fan_speeds.TabIndex = 49;
            lb_pct_fan_speeds.Text = "PCT";
            // 
            // lb_rpm_fan_speeds
            // 
            lb_rpm_fan_speeds.AutoSize = true;
            lb_rpm_fan_speeds.BackColor = SystemColors.Control;
            lb_rpm_fan_speeds.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_rpm_fan_speeds.Location = new Point(5, 53);
            lb_rpm_fan_speeds.Name = "lb_rpm_fan_speeds";
            lb_rpm_fan_speeds.Size = new Size(38, 19);
            lb_rpm_fan_speeds.TabIndex = 48;
            lb_rpm_fan_speeds.Text = "RPM";
            // 
            // cpu_and_pw_cons_panel
            // 
            cpu_and_pw_cons_panel.Controls.Add(lb_dyn_power_consumption);
            cpu_and_pw_cons_panel.Controls.Add(lb_dyn_cpu_2_temp);
            cpu_and_pw_cons_panel.Controls.Add(lb_dyn_cpu_1_temp);
            cpu_and_pw_cons_panel.Controls.Add(lb_cpu_1_temp);
            cpu_and_pw_cons_panel.Controls.Add(lb_cpu_2_temp);
            cpu_and_pw_cons_panel.Controls.Add(lb_power_consumption);
            cpu_and_pw_cons_panel.Location = new Point(15, 440);
            cpu_and_pw_cons_panel.Name = "cpu_and_pw_cons_panel";
            cpu_and_pw_cons_panel.Size = new Size(700, 100);
            cpu_and_pw_cons_panel.TabIndex = 51;
            // 
            // lb_dyn_power_consumption
            // 
            lb_dyn_power_consumption.AutoSize = true;
            lb_dyn_power_consumption.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_power_consumption.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dyn_power_consumption.Location = new Point(542, 57);
            lb_dyn_power_consumption.Name = "lb_dyn_power_consumption";
            lb_dyn_power_consumption.Size = new Size(44, 27);
            lb_dyn_power_consumption.TabIndex = 50;
            lb_dyn_power_consumption.Text = "100";
            // 
            // lb_dyn_cpu_2_temp
            // 
            lb_dyn_cpu_2_temp.AutoSize = true;
            lb_dyn_cpu_2_temp.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_cpu_2_temp.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dyn_cpu_2_temp.Location = new Point(331, 57);
            lb_dyn_cpu_2_temp.Name = "lb_dyn_cpu_2_temp";
            lb_dyn_cpu_2_temp.Size = new Size(44, 27);
            lb_dyn_cpu_2_temp.TabIndex = 49;
            lb_dyn_cpu_2_temp.Text = "100";
            // 
            // lb_dyn_cpu_1_temp
            // 
            lb_dyn_cpu_1_temp.AutoSize = true;
            lb_dyn_cpu_1_temp.BorderStyle = BorderStyle.Fixed3D;
            lb_dyn_cpu_1_temp.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lb_dyn_cpu_1_temp.Location = new Point(112, 57);
            lb_dyn_cpu_1_temp.Name = "lb_dyn_cpu_1_temp";
            lb_dyn_cpu_1_temp.Size = new Size(44, 27);
            lb_dyn_cpu_1_temp.TabIndex = 48;
            lb_dyn_cpu_1_temp.Text = "100";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 548);
            Controls.Add(cpu_and_pw_cons_panel);
            Controls.Add(fan_report_data_panel);
            Controls.Add(fan_control_panel);
            Controls.Add(settings_panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(740, 587);
            Name = "Form1";
            Text = "IPMI Multi Fan Controller";
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
        private Label lb_operation_status;
    }
}