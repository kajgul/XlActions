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

namespace XlPrinterUserController
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var dbConnectionSet = new GettingData();
            var db = GettingData<ConnectionSet>.GetConnectionData(@"C:\Users\kajtuch\Desktop\DBLoginInfo.json");
            databaseServerTextBox.Text = db.ServerName;
            databaseUserTextBox.Text = db.User;
            passwordUserTextBox.Text = db.Password;
            databaseTextBox.Text = db.DbName;

            var xl = GettingData<ConnectionSet>.GetConnectionData(@"C:\Users\kajtuch\Desktop\XLLoginInfo.json");
            keyServerTextBox.Text = db.ServerName;
            xlUserTextBox.Text = xl.User;
            xlPasswordTextBox.Text = xl.Password;
            xlBaseTextBox.Text = xl.DbName;
            xlVersionTextBox.Text = xl.Version.ToString();
        }

        private void xlVersionTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void testConnectionButton_Click(object sender, RoutedEventArgs e)
        {
           // action.(keyServerTextBox.Text,xlBaseTextBox.Text,
           //     xlVersionTextBox.Text,xlUserTextBox.Text,
           //     xlPasswordTextBox.Text,databaseServerTextBox.Text
           //     ,databaseUserTextBox.Text, passwordUserTextBox.Text
           //     ,databaseTextBox.Text);
        }

        private void saveDataButton_Click(object sender, RoutedEventArgs e)
        {
            var dataToSave = new SaveSerializedData(databaseServerTextBox.Text,
            databaseUserTextBox.Text,
            passwordUserTextBox.Text,
            databaseTextBox.Text,
            keyServerTextBox.Text,
            xlUserTextBox.Text,
            xlPasswordTextBox.Text,
            xlBaseTextBox.Text,
            xlVersionTextBox.Text);

            dataToSave.Save();
        }
    }
}
