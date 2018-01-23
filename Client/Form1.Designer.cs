﻿namespace Client
{
    partial class Form1
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
            this.ServerStatus = new System.Windows.Forms.StatusStrip();
            this.ServerProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ClientStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.ServerFileListView = new System.Windows.Forms.ListView();
            this.Row = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComputerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ServerPortValue = new System.Windows.Forms.TextBox();
            this.ServerPort = new System.Windows.Forms.Label();
            this.Separate = new System.Windows.Forms.Label();
            this.ServerIP = new System.Windows.Forms.Label();
            this.ShareFolder = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.StartClient = new System.Windows.Forms.Button();
            this.ServerIPValue = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ServerStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerStatus
            // 
            this.ServerStatus.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ServerStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ServerProgressBar,
            this.ClientStatusMessage});
            this.ServerStatus.Location = new System.Drawing.Point(0, 634);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.ServerStatus.Size = new System.Drawing.Size(1030, 31);
            this.ServerStatus.SizingGrip = false;
            this.ServerStatus.TabIndex = 19;
            // 
            // ServerProgressBar
            // 
            this.ServerProgressBar.Name = "ServerProgressBar";
            this.ServerProgressBar.Size = new System.Drawing.Size(150, 25);
            // 
            // ClientStatusMessage
            // 
            this.ClientStatusMessage.Name = "ClientStatusMessage";
            this.ClientStatusMessage.Size = new System.Drawing.Size(70, 26);
            this.ClientStatusMessage.Text = "[Status]";
            // 
            // ServerFileListView
            // 
            this.ServerFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Row,
            this.ComputerName,
            this.Filename,
            this.Size});
            this.ServerFileListView.FullRowSelect = true;
            this.ServerFileListView.GridLines = true;
            this.ServerFileListView.Location = new System.Drawing.Point(12, 75);
            this.ServerFileListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ServerFileListView.MultiSelect = false;
            this.ServerFileListView.Name = "ServerFileListView";
            this.ServerFileListView.Size = new System.Drawing.Size(1000, 539);
            this.ServerFileListView.TabIndex = 18;
            this.ServerFileListView.UseCompatibleStateImageBehavior = false;
            this.ServerFileListView.View = System.Windows.Forms.View.Details;
            this.ServerFileListView.DoubleClick += new System.EventHandler(this.ServerFileListView_DockChanged);
            // 
            // Row
            // 
            this.Row.Text = "Row";
            // 
            // ComputerName
            // 
            this.ComputerName.Text = "Computer name";
            this.ComputerName.Width = 209;
            // 
            // Filename
            // 
            this.Filename.Text = "Filename";
            this.Filename.Width = 248;
            // 
            // Size
            // 
            this.Size.Text = "Size (KB)";
            this.Size.Width = 124;
            // 
            // ServerPortValue
            // 
            this.ServerPortValue.Location = new System.Drawing.Point(477, 12);
            this.ServerPortValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ServerPortValue.MaxLength = 5;
            this.ServerPortValue.Name = "ServerPortValue";
            this.ServerPortValue.Size = new System.Drawing.Size(109, 26);
            this.ServerPortValue.TabIndex = 17;
            this.ServerPortValue.Text = "8081";
            this.ServerPortValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServerPortValue_KeyPress);
            // 
            // ServerPort
            // 
            this.ServerPort.AutoSize = true;
            this.ServerPort.Location = new System.Drawing.Point(374, 20);
            this.ServerPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(92, 20);
            this.ServerPort.TabIndex = 16;
            this.ServerPort.Text = "Server Port:";
            // 
            // Separate
            // 
            this.Separate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Separate.Location = new System.Drawing.Point(18, 52);
            this.Separate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Separate.Name = "Separate";
            this.Separate.Size = new System.Drawing.Size(998, 3);
            this.Separate.TabIndex = 15;
            // 
            // ServerIP
            // 
            this.ServerIP.AutoSize = true;
            this.ServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerIP.Location = new System.Drawing.Point(18, 14);
            this.ServerIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(118, 29);
            this.ServerIP.TabIndex = 13;
            this.ServerIP.Text = "Server IP:";
            // 
            // ShareFolder
            // 
            this.ShareFolder.Enabled = false;
            this.ShareFolder.Location = new System.Drawing.Point(657, 9);
            this.ShareFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShareFolder.Name = "ShareFolder";
            this.ShareFolder.Size = new System.Drawing.Size(112, 35);
            this.ShareFolder.TabIndex = 12;
            this.ShareFolder.Text = "Upload";
            this.ShareFolder.UseVisualStyleBackColor = true;
            this.ShareFolder.Click += new System.EventHandler(this.ShareFolder_Click);
            // 
            // Refresh
            // 
            this.Refresh.Enabled = false;
            this.Refresh.Location = new System.Drawing.Point(778, 9);
            this.Refresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(112, 35);
            this.Refresh.TabIndex = 11;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // StartClient
            // 
            this.StartClient.Location = new System.Drawing.Point(903, 9);
            this.StartClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartClient.Name = "StartClient";
            this.StartClient.Size = new System.Drawing.Size(112, 35);
            this.StartClient.TabIndex = 10;
            this.StartClient.Text = "Start Client";
            this.StartClient.UseVisualStyleBackColor = true;
            this.StartClient.Click += new System.EventHandler(this.StartClient_Click);
            // 
            // ServerIPValue
            // 
            this.ServerIPValue.Location = new System.Drawing.Point(122, 14);
            this.ServerIPValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ServerIPValue.Name = "ServerIPValue";
            this.ServerIPValue.Size = new System.Drawing.Size(228, 26);
            this.ServerIPValue.TabIndex = 20;
            this.ServerIPValue.Text = "192.168.1.2";
            this.ServerIPValue.TextChanged += new System.EventHandler(this.ServerIPValue_TextChanged);
            this.ServerIPValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ServerIPValue_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 665);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ServerIPValue);
            this.Controls.Add(this.ServerStatus);
            this.Controls.Add(this.ServerFileListView);
            this.Controls.Add(this.ServerPortValue);
            this.Controls.Add(this.ServerPort);
            this.Controls.Add(this.Separate);
            this.Controls.Add(this.ServerIP);
            this.Controls.Add(this.ShareFolder);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.StartClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Server_FormClosing);
            this.ServerStatus.ResumeLayout(false);
            this.ServerStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ServerStatus;
        private System.Windows.Forms.ToolStripProgressBar ServerProgressBar;
        private System.Windows.Forms.ListView ServerFileListView;
        private System.Windows.Forms.ColumnHeader Row;
        private System.Windows.Forms.ColumnHeader ComputerName;
        private System.Windows.Forms.ColumnHeader Filename;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.TextBox ServerPortValue;
        private System.Windows.Forms.Label ServerPort;
        private System.Windows.Forms.Label Separate;
        private System.Windows.Forms.Label ServerIP;
        private System.Windows.Forms.Button ShareFolder;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button StartClient;
        private System.Windows.Forms.TextBox ServerIPValue;
        private System.Windows.Forms.ToolStripStatusLabel ClientStatusMessage;
        private System.Windows.Forms.Button button1;
    }
}