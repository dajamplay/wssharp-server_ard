
namespace WebSocketsWindowsForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_StartWS = new System.Windows.Forms.Button();
            this.btn_CloseWS = new System.Windows.Forms.Button();
            this.tb_ws_status = new System.Windows.Forms.TextBox();
            this.tb_on_message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_comport = new System.Windows.Forms.ComboBox();
            this.gb_server = new System.Windows.Forms.GroupBox();
            this.gb_arduino = new System.Windows.Forms.GroupBox();
            this.btn_arduino_connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_arduino_status = new System.Windows.Forms.TextBox();
            this.gb_pc_info = new System.Windows.Forms.GroupBox();
            this.CPU = new System.Windows.Forms.Label();
            this.tb_cpu_info = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.performanceCounterCPU = new System.Diagnostics.PerformanceCounter();
            this.gb_server.SuspendLayout();
            this.gb_arduino.SuspendLayout();
            this.gb_pc_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounterCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_StartWS
            // 
            this.btn_StartWS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_StartWS.Location = new System.Drawing.Point(6, 416);
            this.btn_StartWS.Name = "btn_StartWS";
            this.btn_StartWS.Size = new System.Drawing.Size(112, 37);
            this.btn_StartWS.TabIndex = 0;
            this.btn_StartWS.Text = "Старт";
            this.btn_StartWS.UseVisualStyleBackColor = true;
            this.btn_StartWS.Click += new System.EventHandler(this.btn_StartWS_Click);
            // 
            // btn_CloseWS
            // 
            this.btn_CloseWS.Enabled = false;
            this.btn_CloseWS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CloseWS.Location = new System.Drawing.Point(131, 416);
            this.btn_CloseWS.Name = "btn_CloseWS";
            this.btn_CloseWS.Size = new System.Drawing.Size(112, 37);
            this.btn_CloseWS.TabIndex = 1;
            this.btn_CloseWS.Text = "Стоп";
            this.btn_CloseWS.UseVisualStyleBackColor = true;
            this.btn_CloseWS.Click += new System.EventHandler(this.btn_CloseWS_Click);
            // 
            // tb_ws_status
            // 
            this.tb_ws_status.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ws_status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_ws_status.Location = new System.Drawing.Point(6, 19);
            this.tb_ws_status.Name = "tb_ws_status";
            this.tb_ws_status.ReadOnly = true;
            this.tb_ws_status.Size = new System.Drawing.Size(237, 29);
            this.tb_ws_status.TabIndex = 2;
            // 
            // tb_on_message
            // 
            this.tb_on_message.BackColor = System.Drawing.SystemColors.Window;
            this.tb_on_message.Location = new System.Drawing.Point(6, 71);
            this.tb_on_message.Multiline = true;
            this.tb_on_message.Name = "tb_on_message";
            this.tb_on_message.ReadOnly = true;
            this.tb_on_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_on_message.Size = new System.Drawing.Size(237, 339);
            this.tb_on_message.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Подключенные пользователи";
            // 
            // cb_comport
            // 
            this.cb_comport.FormattingEnabled = true;
            this.cb_comport.Location = new System.Drawing.Point(6, 71);
            this.cb_comport.Name = "cb_comport";
            this.cb_comport.Size = new System.Drawing.Size(230, 21);
            this.cb_comport.TabIndex = 6;
            // 
            // gb_server
            // 
            this.gb_server.Controls.Add(this.label1);
            this.gb_server.Controls.Add(this.tb_on_message);
            this.gb_server.Controls.Add(this.tb_ws_status);
            this.gb_server.Controls.Add(this.btn_CloseWS);
            this.gb_server.Controls.Add(this.btn_StartWS);
            this.gb_server.Location = new System.Drawing.Point(12, 12);
            this.gb_server.Name = "gb_server";
            this.gb_server.Size = new System.Drawing.Size(249, 459);
            this.gb_server.TabIndex = 7;
            this.gb_server.TabStop = false;
            this.gb_server.Text = "Сервер";
            // 
            // gb_arduino
            // 
            this.gb_arduino.Controls.Add(this.btn_arduino_connect);
            this.gb_arduino.Controls.Add(this.label2);
            this.gb_arduino.Controls.Add(this.tb_arduino_status);
            this.gb_arduino.Controls.Add(this.cb_comport);
            this.gb_arduino.Location = new System.Drawing.Point(286, 12);
            this.gb_arduino.Name = "gb_arduino";
            this.gb_arduino.Size = new System.Drawing.Size(244, 459);
            this.gb_arduino.TabIndex = 8;
            this.gb_arduino.TabStop = false;
            this.gb_arduino.Text = "Arduino";
            // 
            // btn_arduino_connect
            // 
            this.btn_arduino_connect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_arduino_connect.Location = new System.Drawing.Point(10, 416);
            this.btn_arduino_connect.Name = "btn_arduino_connect";
            this.btn_arduino_connect.Size = new System.Drawing.Size(226, 37);
            this.btn_arduino_connect.TabIndex = 6;
            this.btn_arduino_connect.Text = "Подключиться";
            this.btn_arduino_connect.UseVisualStyleBackColor = true;
            this.btn_arduino_connect.Click += new System.EventHandler(this.btn_arduino_connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выбор COM порта";
            // 
            // tb_arduino_status
            // 
            this.tb_arduino_status.BackColor = System.Drawing.SystemColors.Window;
            this.tb_arduino_status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_arduino_status.Location = new System.Drawing.Point(6, 19);
            this.tb_arduino_status.Name = "tb_arduino_status";
            this.tb_arduino_status.ReadOnly = true;
            this.tb_arduino_status.Size = new System.Drawing.Size(230, 29);
            this.tb_arduino_status.TabIndex = 6;
            // 
            // gb_pc_info
            // 
            this.gb_pc_info.Controls.Add(this.CPU);
            this.gb_pc_info.Controls.Add(this.tb_cpu_info);
            this.gb_pc_info.Location = new System.Drawing.Point(542, 12);
            this.gb_pc_info.Name = "gb_pc_info";
            this.gb_pc_info.Size = new System.Drawing.Size(242, 458);
            this.gb_pc_info.TabIndex = 9;
            this.gb_pc_info.TabStop = false;
            this.gb_pc_info.Text = "Информация о ПК";
            // 
            // CPU
            // 
            this.CPU.AutoSize = true;
            this.CPU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPU.Location = new System.Drawing.Point(8, 43);
            this.CPU.Name = "CPU";
            this.CPU.Size = new System.Drawing.Size(32, 17);
            this.CPU.TabIndex = 7;
            this.CPU.Text = "CPU";
            // 
            // tb_cpu_info
            // 
            this.tb_cpu_info.BackColor = System.Drawing.SystemColors.Window;
            this.tb_cpu_info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_cpu_info.Location = new System.Drawing.Point(11, 63);
            this.tb_cpu_info.Name = "tb_cpu_info";
            this.tb_cpu_info.ReadOnly = true;
            this.tb_cpu_info.Size = new System.Drawing.Size(230, 29);
            this.tb_cpu_info.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.tick_render);
            // 
            // performanceCounterCPU
            // 
            this.performanceCounterCPU.CategoryName = "Processor";
            this.performanceCounterCPU.CounterName = "% Processor Time";
            this.performanceCounterCPU.InstanceName = "_Total";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 491);
            this.Controls.Add(this.gb_pc_info);
            this.Controls.Add(this.gb_arduino);
            this.Controls.Add(this.gb_server);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Умный ПК";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gb_server.ResumeLayout(false);
            this.gb_server.PerformLayout();
            this.gb_arduino.ResumeLayout(false);
            this.gb_arduino.PerformLayout();
            this.gb_pc_info.ResumeLayout(false);
            this.gb_pc_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounterCPU)).EndInit();
        }

        #endregion

        private System.Windows.Forms.Button btn_StartWS;
        private System.Windows.Forms.Button btn_CloseWS;
        private System.Windows.Forms.TextBox tb_ws_status;
        private System.Windows.Forms.TextBox tb_on_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_comport;
        private System.Windows.Forms.GroupBox gb_server;
        private System.Windows.Forms.GroupBox gb_arduino;
        private System.Windows.Forms.Button btn_arduino_connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_arduino_status;
        private System.Windows.Forms.GroupBox gb_pc_info;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label CPU;
        private System.Windows.Forms.TextBox tb_cpu_info;
        private System.Diagnostics.PerformanceCounter performanceCounterCPU;
    }
}

