﻿namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer500 = new System.Windows.Forms.Timer(this.components);
            this.timer50 = new System.Windows.Forms.Timer(this.components);
            this.timer10 = new System.Windows.Forms.Timer(this.components);
            this.connectButton = new System.Windows.Forms.Button();
            this.queueLabel = new System.Windows.Forms.Label();
            this.armButton = new System.Windows.Forms.Button();
            this.portLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer500
            // 
            this.timer500.Interval = 500;
            this.timer500.Tick += new System.EventHandler(this.timer500_Tick);
            // 
            // timer50
            // 
            this.timer50.Interval = 50;
            this.timer50.Tick += new System.EventHandler(this.timer50_Tick);
            // 
            // timer10
            // 
            this.timer10.Interval = 10;
            this.timer10.Tick += new System.EventHandler(this.timer10_Tick);
            // 
            // connectButton
            // 
            this.connectButton.AutoSize = true;
            this.connectButton.Location = new System.Drawing.Point(12, 12);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(156, 42);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Disconnected";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // queueLabel
            // 
            this.queueLabel.AutoSize = true;
            this.queueLabel.Location = new System.Drawing.Point(250, 21);
            this.queueLabel.Name = "queueLabel";
            this.queueLabel.Size = new System.Drawing.Size(153, 25);
            this.queueLabel.TabIndex = 1;
            this.queueLabel.Text = "Queue length: ";
            // 
            // armButton
            // 
            this.armButton.AutoSize = true;
            this.armButton.Location = new System.Drawing.Point(12, 60);
            this.armButton.Name = "armButton";
            this.armButton.Size = new System.Drawing.Size(94, 42);
            this.armButton.TabIndex = 2;
            this.armButton.Text = "Arm";
            this.armButton.UseVisualStyleBackColor = true;
            this.armButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(174, 21);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(0, 25);
            this.portLabel.TabIndex = 3;
            // 
            // resetButton
            // 
            this.resetButton.AutoSize = true;
            this.resetButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetButton.Location = new System.Drawing.Point(113, 61);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(78, 35);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1280, 1024);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.armButton);
            this.Controls.Add(this.queueLabel);
            this.Controls.Add(this.connectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "TJROV - GUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer500;
        private System.Windows.Forms.Timer timer50;
        private System.Windows.Forms.Timer timer10;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label queueLabel;
        private System.Windows.Forms.Button armButton;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button resetButton;
    }
}

