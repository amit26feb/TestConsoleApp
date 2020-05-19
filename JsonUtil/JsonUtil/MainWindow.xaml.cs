using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows;
using System.Xml.Linq;

namespace JsonUtil
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

        private void BtnBeautify_Click(object sender, RoutedEventArgs e)
        {
            txtDestination.Text = JToken.Parse(txtSource.Text).ToString(Formatting.Indented);
        }

        private void BtnSwap_Click(object sender, RoutedEventArgs e)
        {
            string tempText = txtSource.Text;
            txtSource.Text = txtDestination.Text;
            txtDestination.Text = tempText;
        }

        private void BtnXML_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSource.Text))
            {
                txtDestination.Text = txtSource.Text;
            }
            XNode node = JsonConvert.DeserializeXNode(txtSource.Text);
            txtDestination.Text = node.ToString();
        }

        private void TxtSource_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSource.Text))
            {
                btnBeautify.IsEnabled = false;
                btnDeEscape.IsEnabled = false;
                btnEscape.IsEnabled = false;
                btnvalidate.IsEnabled = false;
                btnXML.IsEnabled = false;
            }
            else
            {
                btnBeautify.IsEnabled = true;
                btnDeEscape.IsEnabled = true;
                btnEscape.IsEnabled = true;
                btnvalidate.IsEnabled = true;
                btnXML.IsEnabled = true;
                btnHtmlDecode.IsEnabled = true;
            }

            if (string.IsNullOrEmpty(txtSource.Text) && string.IsNullOrEmpty(txtDestination.Text))
            {
                btnSwap.IsEnabled = false;
            }
            else
            {
                btnSwap.IsEnabled = true;
            }
        }

        private void BtnUnEscape_Click(object sender, RoutedEventArgs e)
        {
            txtDestination.Text = Regex.Unescape(txtSource.Text);
        }

        private void BtnEscape_Click(object sender, RoutedEventArgs e)
        {
            txtDestination.Text = Regex.Escape(txtSource.Text);
        }

        private void BtnHtmlDecode_Click(object sender, RoutedEventArgs e)
        {
            txtDestination.Text = HttpUtility.UrlDecode(txtSource.Text);
            txtDestination.Text = txtDestination.Text.Replace("&amp;", "&");
            txtDestination.Text = txtDestination.Text.Replace("&lt;", "<");
            txtDestination.Text = txtDestination.Text.Replace("&gt;", ">");
        }
    }
}