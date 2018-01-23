using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using ClientApp.ServiceReference1;

namespace ClientApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
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
            srv.addUserToOnlineUsersTable(userName,port,ip);
        }
    }
}
