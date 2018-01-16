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
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.Net;
using System.IO;



namespace Egov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            InitializeComponent();

            var client = new WebClient().DownloadString("http://data.egov.kz/api/v2/valutalar_bagamdary4/v239?pretty");

            List<ego> list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ego>>(client);
            dataG.ItemsSource = list;
        }
        
       
    }
}
