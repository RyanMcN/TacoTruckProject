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
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace TacoTruckProject
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            string connStr = "Server=192.168.0.25;Database=tacoTruckInventory;User ID=USER;Password=PASSWORD;";


            MySqlConnection mySqlConnection = new MySqlConnection(connStr);
            
                try
                {
                    mySqlConnection.Open();
                }
                catch
                {
                    MessageBox.Show("could not connect dude");
                }
            
            mySqlConnection.Close();
            MessageBox.Show("it worked!");

        }
    }
}
