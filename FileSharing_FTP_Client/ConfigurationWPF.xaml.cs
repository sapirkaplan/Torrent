﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FileSharing_FTP_Client.ServiceReference1;
using System.Xml;

namespace FileSharing_FTP_Client
{
    /// <summary>
    /// Interaction logic for ConfigurationWPF.xaml
    /// </summary>
    public partial class ConfigurationWPF : UserControl
    {
        public ConfigurationWPF()
        {
            InitializeComponent();
        }

        public void writeToXmlFile()
        {
            XmlWriter xmlWriter = XmlWriter.Create("MyConfig.xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("connectionDetails");

            xmlWriter.WriteStartElement("ip");
            xmlWriter.WriteString(IPTextBox.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("port");
            xmlWriter.WriteString(PortTextBox.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("username");
            xmlWriter.WriteString(UsernameTextBox.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("password");
            xmlWriter.WriteString(PasswordTextBox.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("publicFolder");
            xmlWriter.WriteString(PublicFolderTextBox.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("downloadFolder");
            xmlWriter.WriteString(DownloadFolderTextBox.Text);
            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }

        public bool checkAuthentication()
        {
            string userName = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            DBServiceClient srv = new DBServiceClient();
            return srv.checkAuthentication(userName, password);

        }

        public void addUserToOnlineUsersTable()
        {
            string userName = UsernameTextBox.Text;
            int port = int.Parse(PortTextBox.Text);
            string ip = IPTextBox.Text;

            DBServiceClient srv = new DBServiceClient();
            srv.addUserToOnlineUsersTable(userName, port, ip);
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (checkAuthentication())
            {
                writeToXmlFile();
                MessageBox.Show("Success");
                addUserToOnlineUsersTable();
            }
            else
                MessageBox.Show("Error");
        }
    }
}
