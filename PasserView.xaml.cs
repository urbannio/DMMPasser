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

namespace DMMPasser
{
    /// <summary>
    /// Interaction logic for PasserView.xaml
    /// </summary>
    public partial class PasserView : UserControl
    {
        private CookieHandler handler = new CookieHandler();
        public PasserView()
        {
            InitializeComponent();
            cookieView.Text = handler.getCookie();
            dayTime.Text = handler.getDefaultDayTime();
        }

        private void setCookie(object sender, RoutedEventArgs e)
        {
            // set cookie from input
            handler.setCookie(dayTime.Text);
            cookieView.Text = handler.getCookie();
        }

        private void resetCookie(object sender, RoutedEventArgs e)
        {
            //set cookie from default, and set input as default
            dayTime.Text = handler.getDefaultDayTime();
            handler.setCookie();
            cookieView.Text = handler.getCookie();
        }

        private void clearCookie(object sender, RoutedEventArgs e)
        {
            
        }

        private void reloadCookie(object sender, RoutedEventArgs e)
        {
            cookieView.Text = handler.getCookie();
        }

    }
}
