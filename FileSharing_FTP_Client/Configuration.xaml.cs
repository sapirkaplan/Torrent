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
using System.Xaml;
using FileSharing_FTP_Client.ServiceReference1;


namespace FileSharing_FTP_Client
{
    /// <summary>
    /// Interaction logic for ConfigurationWPF.xaml
    /// </summary>
    public partial class Configuration : Window
    {
        public Configuration()
        {
          InitializeComponent();
        }

        public void writeToXmlFile()
        {

            XmlWriter xmlWriter = XmlWriter.Create("MyConfig.xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("connectionDetails");

            xmlWriter.WriteAttributeString("ip", IPTextBox.Text);
            xmlWriter.WriteAttributeString("port", PortTextBox.Text);
            xmlWriter.WriteAttributeString("username", UsernameTextBox.Text);
            xmlWriter.WriteAttributeString("password", PasswordTextBox.Text);

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

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (checkAuthentication())
            {
                writeToXmlFile();
                MessageBox.Show("Success");
                this.Close();
            }
            else
                MessageBox.Show("Error");
        }
    }
}
